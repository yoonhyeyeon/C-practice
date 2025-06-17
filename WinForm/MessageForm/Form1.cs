using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("간단한 메세지 박스");
            MessageBox.Show("타이틀을 갖는 메시지 박스", "Title. Messge");
            MessageBox.Show("느낌표와 알람 메시지 박스", "느낌표와 알람소리",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            DialogResult result1 = MessageBox.Show("두개의 버튼을 갖는 메시지 박스", "Question", MessageBoxButtons.YesNo);
            DialogResult result2 = MessageBox.Show("세 개의 버튼과 물음표 아이콘을 보여주는 메시지박스", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            DialogResult result3 = MessageBox.Show("디폴트 버튼을 두번째 버튼으로\n지정한 메시지박스", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            string msg = string.Format($"당신의 선택 : {result1.ToString()}, {result2.ToString()}, {result3.ToString()}");
            MessageBox.Show(msg , "Your Selections");       // 선택 결과를 보여주는 메시지박스
        }
    }
}
