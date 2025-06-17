using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox2.Items.Add("오스트리아, 비엔나");
            listBox2.Items.Add("덴마크, 코펜하겐");
            listBox2.Items.Add("스위스, 취리히");
            listBox2.Items.Add("캐나다, 벤쿠버");
            listBox2.Items.Add("독일, 뮌헨");
            listBox2.Items.Add("스위스, 제네바");
            listBox2.Items.Add("노르웨이, 오슬로");
            listBox2.Items.Add("네덜란드, 암스테르담");
            listBox2.Items.Add("호주, 멜버른");
            listBox2.Items.Add("한국, 서울");

            List<String> FirstGDP = new List<String> { "미국", "러시아", "중국", "영국", "독일", "프랑스", "이스라엘", "사우디아라비아", "UAE" };
            listBox3.DataSource = FirstGDP;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox first = sender as ListBox;
            txtSIndex1.Text = first.SelectedIndex.ToString();
            txtSItem1.Text = first.SelectedItem.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox first = sender as ListBox;
            txtSIndex2.Text = first.SelectedIndex.ToString();
            txtSItem2.Text = first.SelectedItem.ToString();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox first = sender as ListBox;
            txtSIndex3.Text = first.SelectedIndex.ToString();
            txtSItem3.Text = first.SelectedItem.ToString();
        }
    }
}
