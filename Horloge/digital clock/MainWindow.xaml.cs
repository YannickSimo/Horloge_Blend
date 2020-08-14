using System;
using System.Windows;
using System.Windows.Threading;

namespace digital_clock
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Content = DateTime.Now.ToString("HH:mm");
            lblSecond.Content = DateTime.Now.ToString("ss");
            lblDays.Content = DateTime.Now.ToString("dddd");
            lblYear.Content = DateTime.Now.ToString("MMM dd yyyy");
        }

       
    }
}
