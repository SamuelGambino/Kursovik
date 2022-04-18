using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Kursovik1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            _NavigationFrame.Content = new MainPage();
            new Thread(() =>
            {
                Thread.Sleep(3000);
                
                Dispatcher.Invoke(() =>
                {
                    _NavigationFrame.Content = new SignInPage();
                });
            }).Start();

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) ;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.NavigationService.Navigate(new Uri("Page1.xaml", UriKind.Relative));
            
            
        }
    }
}
