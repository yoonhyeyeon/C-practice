using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Media;
using System.Text;

namespace RandomSplash
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Border> borderList;

        DispatcherTimer t = new DispatcherTimer();
        Random r = new Random();

        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            "AttachDbFilename = C:\\Users\\yhy\\source\\repos\\RandomSplash\\Colors.mdf;Integrated Security=True\\Color.mdf;" +
            "Integrated Security=True";
        SqlConnection conn;

        public MainWindow()
        {
            InitializeComponent();

            borderList = new List<Border>
                { border1, border2, border3, border4, border5, 
                border6, border7, border8, border9, border10, 
                border11, border12, border13, border14, border15,
                border16, border17, border18, border19, border20 };

            t.Interval = new TimeSpan(0, 0, 1); //1초에 한번
            t.Tick += T_Tick;
        }
        private void T_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            lblDate.Text = "날짜 : " + date;
            string time = DateTime.Now.ToString("HH:mm:ss");
            lblTme.Text = "시간 : " + time;

            byte[] colors = new byte[20];
            for (int i = 0; i < 20; i++)
            {
                colors[i] = (byte)(r.Next(255));
                borderList[i].Background = new SolidColorBrush(Color.FromRgb((byte)0, (byte)0, colors[i]));
            }

            StringBuilder sqlBuilder = new StringBuilder("INSERT INTO ColorTable VALUES(@date, @time");
            for (int i = 0; i < 20; i++)
            {
                sqlBuilder.AppendFormat(", {0}", colors[i]);
            }
            sqlBuilder.Append(")");

            string sql = sqlBuilder.ToString();

            using (conn = new SqlConnection(connString))
            using (SqlCommand comm = new SqlCommand(sql, conn))
            {
                conn.Open();
                comm.Parameters.AddWithValue("@date" , date);
                comm.Parameters.AddWithValue("@time", time);
                comm.ExecuteNonQuery();
            }
            string lstItem = "";
            lstItem += string.Format($"{date} {time} ");
            for (int i = 0;i < 20; i++)
            {
                lstItem += string.Format("{0,3} ", colors[i]);
            }
            lstDB.Items.Add(lstItem);
        }

        bool flag = false;
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                btnRandom.Content = "정지";
                t.Start();
                flag = true;
            }
            else
            {
                btnRandom.Content = "Random 색깔 표시";
                t.Stop();
                flag = false;

            }
        }

        private void btnDB_Click(object sender, RoutedEventArgs e)
        {
            lstDB.Items.Clear();

            string sql = "SELECT * FROM ColorTable";
            int[] colors = new int[20];

            using (conn = new SqlConnection(connString))
            using (SqlCommand command= new SqlCommand(sql, conn))
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                int index = 0;
                while (reader.Read())
                {
                    lblDate.Text = reader[1].ToString();        // Date, [0]는 id
                    lblTme.Text = reader[2].ToString();         // Time
                    for (int i = 0; i < 20; i++)
                    {
                        colors[i] = int.Parse(reader[i + 3].ToString());
                    }

                    string record = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                        record += String.Format("{0, 3}", reader[i].ToString()) + " ";

                    lstDB.Items.Add(record);
                    lstDB.SelectedIndex = index++;

                    for (int i = 0; i < 20; i++)
                    {
                        borderList[i].Background = new SolidColorBrush(Color.FromRgb((byte)0, (byte)0, (byte)colors[i]));
                    }

                    // delay 주기
                    this.Dispatcher.Invoke((ThreadStart)(() => { }),
                        DispatcherPriority.ApplicationIdle);
                    Thread.Sleep(20);
                }
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            lstDB.Items.Clear();
            string sql = "DELETE FROM ColorTable";

            using (conn = new SqlConnection(connString))
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
