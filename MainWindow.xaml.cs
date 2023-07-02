using ProjectOffice.Desktop.Classes;
using ProjectOffice.Desktop.Models;
using ProjectOffice.Desktop.Pages;
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
            lbProject.ItemsSource = GlobalData.BaseConnect.Project.ToList();
            lbProject.SelectedIndex = 0;
            GlobalData.ActiveFrame.Navigate(new TaskPage());
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
            GlobalData.ActiveFrame.Navigate(new GangPage());
        }

        private void lbProject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListItem listItem = lbProject.SelectedItem as ListItem;
            Project project = lbProject.SelectedValue as Project;
            //bool b = 1 == a;
            if (lbProject.SelectedValue != null)
            {
                GlobalData.SelectedProject = GlobalData.BaseConnect.Project.FirstOrDefault(x => x.Id == project.Id);
            }
            //GlobalData.ActiveFrame.Refresh();
            GlobalData.ActiveFrame.Navigate(new TaskPage());
        }
    }
}
