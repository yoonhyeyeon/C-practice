using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_BMICalc
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // BMI = 몸무게 / (키 * 키)

        private void btnBMI_Click(object sender, RoutedEventArgs e)
        {
            if ( txtHeight.Text == "" || txtWeight.Text == "")
            {
                MessageBox.Show("키와 체중을 입력하세요", "Error");
                return;
            }
            double h = Convert.ToDouble(txtHeight.Text) / 100.0;
            double w = Double.Parse(txtWeight.Text);
            double bmi = w / (h * h);

            // Form 에서는 Label.Text 인데 , WPF 에서는 label.Content
            lblResult.Content = string.Format($"당신의 BMI는 {bmi:F2} 입니다.");       // 소수점 둘째자리까지 (F2)

        }
    }
}
