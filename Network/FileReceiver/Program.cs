using System;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUP;

namespace FileReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine($"사용법 : {Process.GetCurrentProcess().ProcessName} <Directory>");
                return;
            }
            uint msgId = 0;

            string dir = args[0];
            if (Directory.Exists(dir) == false)
            {
                Directory.CreateDirectory(dir);
            }
            const int bindPort = 5425;          // 서버 포트 5425
            TcpListener server = null;
            try
            {
                IPEndPoint localAddress = new IPEndPoint(0, bindPort);      // IP주소를 0으로 입력하면 OS에 할당되어 있는 어떤 주소로도 서버에 접속할 수 있음

                server = new TcpListener(localAddress);
                server.Start();

                Console.WriteLine("파일 업로드 서버 시작");

                while (true)
                {
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine($"클라이언트 접속 : {((IPEndPoint)client.Client.RemoteEndPoint).ToString()}");

                    NetworkStream stream = client.GetStream();

                    Message reqMsg = MessageUtil.Receive(stream);
                    if (reqMsg.Header.MSGTYPE != CONSTANTS.REQ_FILE_SEND)
                    {
                        stream.Close();
                        client.Close();
                        continue;
                    }
                    BodyRequest reqBody = (BodyRequest)reqMsg.Body;
                    Console.WriteLine("파일 업로드 요청이 왔습니다. 수락하시겠습니까?  Y / N");
                    string answer = Console.ReadLine();

                    Message rspMsg = new Message();
                    rspMsg.Body = new BodyResponse()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESPONSE = CONSTANTS.ACCEPTED
                    };
                    rspMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.REP_FILE_SEND,
                        BODYLEN = (uint)rspMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG = CONSTANTS.LASTMSG,
                        SEQ = 0
                    };

                    // Y 가 아닌 다른 값을 입력하면 클라이언트에게 거부 응답 보냄 
                    if (answer != "Y")
                    {
                        rspMsg.Body = new BodyResponse()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESPONSE = CONSTANTS.DENIED
                        };
                        MessageUtil.Send(stream, rspMsg);
                        stream.Close();
                        client.Close();

                        continue;
                    }
                    else
                        MessageUtil.Send(stream, rspMsg);       // Y 를 입력하면 클라이언트에게 승낙 응답 보냄

                    Console.WriteLine("파일 전송을 시작합니다");

                    long fileSize = reqBody.FILESIZE;

                    string fileName = Encoding.Default.GetString(reqBody.FILENAME);
                    FileStream file = new FileStream(dir + "\\" + fileName, FileMode.Create);       // 업로그 파일 스트림 생성

                    uint? dataMsgId = null;
                    ushort prevSeq = 0;
                    while ((reqMsg = MessageUtil.Receive(stream)) != null)
                    {
                        Console.Write("#");
                        if (reqMsg.Header.MSGTYPE != CONSTANTS.FILE_SEND_DATA)
                            break;
                        if (dataMsgId == null)
                            dataMsgId = reqMsg.Header.MSGID;
                        else
                        {
                            if (dataMsgId != reqMsg.Header.MSGID)
                                break;
                        }
                        if (prevSeq++ != reqMsg.Header.SEQ)         // 메시지 순서가 어긋나면 전송을 중단
                        {
                            Console.WriteLine($"{prevSeq}, {reqMsg.Header.SEQ}");
                            break;
                        }
                        file.Write(reqMsg.Body.GetBytes(), 0, reqMsg.Body.GetSize());  // 전송받은 스트림을 서버에서 생성한 파일에 기록함

                        if (reqMsg.Header.FRAGMENTED == CONSTANTS.NOT_FRAGMENTED)   // 분할 메시지가 아니라면 반복을 한 번만 하고 빠져나온다
                            break;
                        if (reqMsg.Header.LASTMSG == CONSTANTS.LASTMSG)     // 마지막 메시지면 반복문을 빠져나온다
                            break;
                    }
                    long recvFileSize = file.Length;
                    file.Close();

                    Console.WriteLine();
                    Console.WriteLine($"수신 파일 크기 : {recvFileSize} bytes");

                    Message rstMsg = new Message();
                    rstMsg.Body = new BodyResult()
                    {
                        MSGID = reqMsg.Header.MSGID,
                        RESULT = CONSTANTS.SUCCESS
                    };
                    rstMsg.Header = new Header()
                    {
                        MSGID = msgId++,
                        MSGTYPE = CONSTANTS.FILE_SEND_RES,
                        BODYLEN = (uint)rstMsg.Body.GetSize(),
                        FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
                        LASTMSG = CONSTANTS.LASTMSG,
                        SEQ = 0
                    };

                    // 파일 전송 요청에 담겨온 파일 크기와 실제로 받은 파일의 크기를 비교하여 같으면 성공 메세지 보냄
                    if (fileSize == recvFileSize)
                        MessageUtil.Send(stream, rstMsg);
                    else
                    {
                        rstMsg.Body = new BodyResult()
                        {
                            MSGID = reqMsg.Header.MSGID,
                            RESULT = CONSTANTS.FAIL
                        };

                        MessageUtil.Send(stream, rstMsg);
                    }
                    Console.WriteLine("파일 전송을 마쳤습니다.");

                    stream.Close();
                    client.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                server.Stop();
            }
            Console.WriteLine("서버를 종료합니다.");
        }
    }
}
