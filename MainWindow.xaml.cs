using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ProjectOffice.Desktop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GlobalData.ActiveFrame = frmMain;
            GlobalData.ActiveFrame.Navigate(new TaskPage());
            //GlobalData.SelectedProject = 

            tbVersion.Text = "Версия: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();


        }

        private void btnDashboard_Click(object sender, RoutedEventArgs e)
        {
            GlobalData.ActiveFrame.Navigate(new DashboardPage());
        }

        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            GlobalData.ActiveFrame.Navigate(new TaskPage());
        }

        private void btnGang_Click(object sender, RoutedEventArgs e)
        {
            GlobalData.ActiveFrame.Navigate(new GantPage());
        }
    }
}
