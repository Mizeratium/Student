using StudentAPK.Database;
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
    /// Логика взаимодействия для PageNewStudent.xaml
    /// </summary>
    public partial class PageNewStudent : Page
    {
        Student stud = new Student();
        public PageNewStudent()
        {
            InitializeComponent();
            var collect = ClassDB.connection.Groups.ToList();
            cmbGroup.ItemsSource = collect;
            cmbGroup.DisplayMemberPath = "title";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txbSurname.Text != "" && txbName.Text != null && txbPat.Text != "" && txbLogin.Text != "" && txbPas.Text != "" && cmbGroup.SelectedItem != null)
            {

                var selCombo = cmbGroup.SelectedItem as Groups;
                StudentClass a = new StudentClass();
                a.NewStudent(txbName.Text, txbSurname.Text, txbPat.Text, txbLogin.Text, txbPas.Text, selCombo.ID);
                MessageBox.Show("Студент добавлен");
            }
            else
            {
                MessageBox.Show("Студент не добавлен");
            }
        }

        
    }
}
