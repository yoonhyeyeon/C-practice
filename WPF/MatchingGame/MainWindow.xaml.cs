using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchingGame
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        Button first;
        Button second;
        DispatcherTimer myTimer = new DispatcherTimer();
        int matched = 0;
        int[] rnd = new int[16];        // 랜덤숫자가 중복되는지 체크용
        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
            BoardSet();
            myTimer.Interval = new TimeSpan(0, 0, 0, 0, 750);   //0.75초
            myTimer.Tick += myTimer_Tick;
        }
        private void BoardSet()        // 16개버튼 초기화   
        {
            board.Children.Clear();     // 기존 버튼들 제거
            for (int i = 0; i < 16; i++)
            {
                Button c = new Button();
                c.Background = Brushes.White;
                c.Margin = new Thickness(10);
                c.Content = "✔";
                c.FontSize = 30;
                c.Tag = TagSet();
                c.Click += C_Click;
                board.Children.Add(c);
            }
        }
        private int TagSet()        // 중복되지 않는 i = 0~15 생성, i % 8 리턴
        {
            int i;
            while (true)
            {
                i = r.Next(16);
                if (rnd[i] == 0)
                {
                    rnd[i] = 1;
                    break;
                }
            }
            return i % 8;   // 태그는 0~7까지, 8개의 그림을 표시
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (myTimer.IsEnabled || btn == first || !btn.IsEnabled)
            {
                return;
            }

            // 이미지 대신 텍스트 사용
            string[] icon = { "🍓", "🍋", "🍐", "🍎", "🍉", "🍍", "🍇", "🍊" };
            btn.Content = icon[(int)btn.Tag];
            btn.FontSize = 50; // 크기 조정

            if (first == null)
            {
                first = btn;
                return;
            }

            second = btn;

            if ((int)first.Tag == (int)second.Tag)
            {
                first.IsEnabled = false;
                second.IsEnabled = false;
                first = null;
                second = null;
                matched += 2;

                if (matched >= 16)
                {
                    MessageBoxResult res = MessageBox.Show("성공 ! 다시하겠습니까?", "Success", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                        NewGame();
                    else
                        Close();
                }
            }
            else
            {
                myTimer.Start();
            }
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            first.Content = "✔";
            first.FontSize = 30;
            second.Content = "✔";
            second.FontSize = 30;
            first = null;
            second = null;
        }
        private void NewGame()
        {
            for (int i = 0; i < 16; i++)
                rnd[i] = 0;
            matched = 0;
            first = null;
            second = null;
            myTimer.Stop();
            BoardSet();
        }
    }
}
