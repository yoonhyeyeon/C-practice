using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            TreeNode root = new TreeNode("짱구는 못말려");

            TreeNode gu = new TreeNode("짱구 가족");
            TreeNode su = new TreeNode("철수 가족");
            TreeNode ri = new TreeNode("유리 가족");

            gu.Nodes.Add("짱구");
            gu.Nodes.Add("봉미선");
            gu.Nodes.Add("신형만");
            gu.Nodes.Add("짱아");
            gu.Nodes.Add("흰둥이");

            su.Nodes.Add("철수");
            su.Nodes.Add("철수 엄마");

            ri.Nodes.Add("유리");
            ri.Nodes.Add("유리 엄마");

            root.Nodes.Add(gu);
            root.Nodes.Add(su);
            root.Nodes.Add(ri);

            treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "짱구")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/신짱구.png"));
                txtMemo.Text = "5살 유치원생으로, 동생 신짱아와 4살 차이가 난다. 삭발에 가까운 헤어스타일이 특징이며 눈썹은 비교적 두껍다. 생일은 5월 5일이며, 혈액형은 B형 MBTI는 ENTP이다. 일본 현지에서의 명칭은 노하라 신노스케이다.";
            }else if (e.Node.Text == "봉미선")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/봉미선.png"));
                txtMemo.Text = "신형만의 부인이자 신짱구와 신짱아의 어머니이며 주부이다.";
            }else if (e.Node.Text == "신형만")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/신형만.png"));
                txtMemo.Text = "주인공 신짱구와 신짱아의 아버지다. 출생일 1955년 5월 5일이며, 출생지는 일본판 아키타현 다이센시 가미오카 정 / 한국에서는 강원도 양양군 (3기, 5기 한정 대전광역시)이다.";
            }else if (e.Node.Text == "짱아")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/짱아.png"));
                txtMemo.Text = "아빠 신형만과 엄마 봉미선의 딸이자 신짱구의 여동생이다. 해바라기라는 뜻";
            }else if (e.Node.Text == "흰둥이")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/흰둥이.png"));
                txtMemo.Text = "신짱구가 주워온 유기견이었다. 과거 떡잎마을 방범대의 대원 중 하나였다. 지금은 짱구보다도 인기가 많으며 항상 흰둥이가 짱구가 사고친 걸 수습한다.";
            }else if (e.Node.Text == "철수")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/철수.png"));
                txtMemo.Text = "남들보다 우수해야 한다는 의지가 강하기 때문에 항상 떡잎마을 방범대의 리더를 자처한다. 물론 리더 하고 싶은 건 다른 멤버들도 마찬가지라서 자칭이다. 다만 구호 선창 정도는 자주 하는 편이고 받아들여지든 않든 뭘 어떻게 하자는 의견 제시는 적극적으로 한다. 상식이 많은 편이고 집이 부유해서 이것저것 경험이 많은데 이를 바탕으로 자신이 리더가 되어야 한다고 주장하면 다른 친구들이 태클 걸며 투닥거리는 패턴이 상당히 자주 나온다. 단, 뭔가 사고 쳤을 때는 짱구가 곧잘 철수에게 대장이니 책임지라며 대장 자리를 떠민다.";
            }else if (e.Node.Text == "철수 엄마")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/철수엄마.png"));
                txtMemo.Text = "철수 엄마다.";
            }else if (e.Node.Text == "유리")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/유리.png"));
                txtMemo.Text = "항상 토끼인형을 들고 다니는 귀여운 여자아이지만, 일단 화가 나면 가지고 다니는 토끼인형을 향해 엄청난 주먹을 날린다. 사실 이런 버릇이 처음부터 있는 건 아니었다. 크레용 신짱 초기에는 아주 순진했는데(평소의 엄마같지가 않으면 평소에 우리엄마가 아니야라고 외친다), 두 얼굴을 가진 엄마 때문에 이런 성격을 가지게 된 것이다. 혼자서 다른 친구들을 제압할 정도이다. ";
            }else if (e.Node.Text == "유리 엄마")
            {
                pictureBox1.Image = Bitmap.FromFile(Path.Combine(Application.StartupPath, @"Image/유리엄마.png"));
                txtMemo.Text = "유리 엄마다.";
            }
        }
    }
}
