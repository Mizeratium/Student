using StudentAPK.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
    /// Логика взаимодействия для PageStudentList.xaml
    /// </summary>
    public partial class PageStudentList : Page
    {
        Student stud = new Student();
        public PageStudentList()
        {
            InitializeComponent();
            StudList.ItemsSource = ClassDB.connection.Student.Where(z => z.isDelete == false).ToList();
            var collect = ClassDB.connection.Groups.ToList();
            cmbGroup.ItemsSource = collect;
            cmbGroup.DisplayMemberPath = "title";
            this.DataContext = this;
        }

        //поисковая строка
        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbSearch.Text != null)
            {
                StudList.ItemsSource = ClassDB.connection.Student.Where(z => z.surname.Contains(txbSearch.Text) || z.name.Contains(txbSearch.Text) || z.patronymic.Contains(txbSearch.Text)).ToList();
            }
        }

        private void cmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbGroup.SelectedIndex != 0)
            {
                StudList.ItemsSource = ClassDB.connection.Student.Where(z => z.group_id == ClassDB.connection.Groups.Where(x => x.title == cmbGroup.Text).FirstOrDefault().ID).ToList(); //не работает
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var SelectUser = (sender as Button).DataContext as Student;
            WindowEdit win = new WindowEdit(SelectUser);
            win.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var scr = (sender as Button).DataContext as Student;
            scr.isDelete = true;
            ClassDB.connection.SaveChanges();
            StudList.ItemsSource = ClassDB.connection.Student.Where(z => z.isDelete == false).ToList();
        }
    }
}
