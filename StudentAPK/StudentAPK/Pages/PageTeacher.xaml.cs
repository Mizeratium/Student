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

namespace StudentAPK.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTeacher.xaml
    /// </summary>
    public partial class PageTeacher : Page
    {
        public PageTeacher()
        {
            InitializeComponent();
        }
        private void btnStudents_Click(object sender, RoutedEventArgs e)
        {
            Button a = sender as Button;
            if (a.Name == "btnStudents")
            {
                NavFrame.NavigationService.Navigate(new Pages.PageStudentList());
            }
            else if (a.Name == "btnAddNewStudent")
            {
                NavFrame.NavigationService.Navigate(new Pages.PageNewStudent());
            }
        }
    }
}
