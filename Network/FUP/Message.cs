using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUP
{
    public class CONSTANTS
    {
        public const uint REQ_FILE_SEND = 0x01;
        public const uint REP_FILE_SEND = 0x02;
        public const uint FILE_SEND_DATA = 0x03;
        public const uint FILE_SEND_RES = 0x04;

        public const byte NOT_FRAGMENTED = 0x00;
        public const byte FRAGMENTED = 0x01;

        public const byte NOT_LASTMSG = 0x00;
        public const byte LASTMSG = 0x01;

        public const byte ACCEPTED = 0x01;
        public const byte DENIED = 0x00;

        public const byte FAIL = 0x00;
        public const byte SUCCESS = 0x01;
    }
    // 메시지, 헤더, 바디는 모두 이 인터페이스를 상속함
    public interface ISerializable
    {
        byte[] GetBytes();
        int GetSize();
    }
    public class Message : ISerializable
    {
        public Header Header { get; set; }
        public ISerializable Body { get; set; }
        public byte[] GetBytes()
        {
            byte[] bytes = new byte[GetSize()];

            Header.GetBytes().CopyTo(bytes, 0);
            Body.GetBytes().CopyTo(bytes, Header.GetSize());

            return bytes;
        }
        public int GetSize()
        {
            return Header.GetSize() + Body.GetSize();
        }
    }
}
