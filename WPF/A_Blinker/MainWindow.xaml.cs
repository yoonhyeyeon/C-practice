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
using System.Windows.Threading;

namespace A_Blinker
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer t = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            t.Interval = new TimeSpan(5000000);     // 0.5초
            t.Tick += T_Tick;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            var GreenBrush = new SolidColorBrush(Color.FromRgb(0, 243, 255));
            var RedBrush = new SolidColorBrush(Color.FromRgb(255, 92, 92));

            if ( btnRed.Background is SolidColorBrush currentRedBrush && currentRedBrush.Color == RedBrush.Color)
            {
                btnRed.ClearValue(Button.BackgroundProperty);
                btnGreen.Background = GreenBrush;
            }
            else
            {
                btnGreen.ClearValue(Button.BackgroundProperty);
                btnRed.Background = RedBrush;
            }
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            t.Start();
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            t.Stop();
        }
    }
}
