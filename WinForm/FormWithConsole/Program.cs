using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FormWithConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMyForm();
        }
        private static void CreateMyForm()
        {
            Form form1 = new Form();

            Button button1 = new Button();
            Button button2 = new Button();

            button1.Text = "OK";
            button1.Location = new Point(10, 10);   // 버튼의 위치, 좌상단 좌표 (10, 10)
            button2.Text = "Cancel";
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 10);      // button1의 아래 10만큼 떨어진 곳으로

            form1.Text = "My Dialog Box";

            button1.Click += Button1_Click;

            form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.StartPosition = FormStartPosition.CenterScreen;

            form1.Controls.Add(button1);
            form1.Controls.Add(button2);

            form1.ShowDialog();
        }
        private static void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK Button Clicked!");
        }
    }
}
