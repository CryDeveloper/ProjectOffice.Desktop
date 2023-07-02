using ProjectOffice.Desktop.Classes;
using ProjectOffice.Desktop.Models;
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

namespace ProjectOffice.Desktop.Pages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        public TaskPage()
        {
            InitializeComponent();
            GridMain.DataContext = GlobalData.SelectedProject;
            tbNameProect.Text = GlobalData.SelectedProject.FullTitle;
            lbTasks_StandartItemSource();
        }

        private void lbTasks_StandartItemSource()
        {
            List<Models.Task> tasks = new List<Models.Task>();
            //var a = GlobalData.BaseConnect.Task.Where(x => x.TaskStatus.Name == "в работе").ToList();
            tasks.AddRange(GlobalData.SelectedProject.Task.Where(x => x.TaskStatus.Name == "в работе" && x.Deadline >= DateTime.Now).ToList());
            tasks.AddRange(GlobalData.SelectedProject.Task.Where(x => x.TaskStatus.Name == "открыта" && x.Deadline >= DateTime.Now).ToList());
            tasks.AddRange(GlobalData.SelectedProject.Task.Where(x => x.TaskStatus.Name == "в работе" && x.Deadline < DateTime.Now).ToList());
            tasks.AddRange(GlobalData.SelectedProject.Task.Where(x => x.TaskStatus.Name == "открыта" && x.Deadline < DateTime.Now).ToList());
            tasks.AddRange(GlobalData.SelectedProject.Task.ToList().Except(tasks));
            lbTasks.ItemsSource = tasks;
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Search.Text == null || Search.Text == "")
            {
                lbTasks_StandartItemSource();
            }
            else
            {
                List<Models.Task> tasks = new List<Models.Task>();
                tasks.AddRange(GlobalData.SelectedProject.Task.Where(x => x.FullTitle.Contains(Search.Text)).ToList());
                tasks.AddRange(GlobalData.SelectedProject.Task.Where(x => x.Description.Contains(Search.Text)).ToList());
                lbTasks.ItemsSource = tasks;
            }
        }

        private void SourceForViewRask()
        {
            grListTasks.SetValue(Grid.ColumnSpanProperty, 1);
            grViewTask.Visibility = Visibility.Visible;

            cbProject.ItemsSource = GlobalData.BaseConnect.Project.ToList();
            cbStatus.ItemsSource = GlobalData.BaseConnect.TaskStatus.ToList();
            cbExEmployee.ItemsSource = GlobalData.BaseConnect.Emploeyy.ToList();
        }

        private void OpenViewTask()
        {
            CloseViewTask.Content = "Отмена";
            
            grViewTask.DataContext = new Models.Task();
            SourceForViewRask();
        }
        private void OpenViewTask(Models.Task task)
        {
            CloseViewTask.Content = "Закрыть";
            
            grViewTask.DataContext = task;
            SourceForViewRask();
        }

        private void lbTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nameWiewTask.Text = "Просмотр задачи";
            OpenViewTask(lbTasks.SelectedValue as Models.Task);
        }

        private void CloseViewTask_Click(object sender, RoutedEventArgs e)
        {
            grViewTask.Visibility = Visibility.Collapsed;
            grListTasks.SetValue(Grid.ColumnSpanProperty, 2);
        }

        private void CreateTask_Click(object sender, RoutedEventArgs e)
        {
            nameWiewTask.Text = "Создание задачи";
            OpenViewTask();
        }
    }
}
