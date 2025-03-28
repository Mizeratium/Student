using StudentAPK.Database;
using StudentAPK.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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

namespace StudentAPK
{
    /// <summary>
    /// Логика взаимодействия для WindowEdit.xaml
    /// </summary>
    public partial class WindowEdit : Window
    {
        Student _SelectUser { get; set; }
        public WindowEdit(Student student)
        {
            InitializeComponent();
            _SelectUser = student;
            txbSurname.DataContext = _SelectUser;
            txbName.DataContext = _SelectUser;
            txbPat.DataContext = _SelectUser;
            txbLogin.DataContext = _SelectUser;
            txbPas.DataContext = _SelectUser;
            var collect = ClassDB.connection.Groups.ToList();
            cmbGroup.ItemsSource = collect;
            cmbGroup.DisplayMemberPath = "title";
            cmbGroup.SelectedIndex = _SelectUser.group_id;
          //  cmbGroup.SelectedItem = ClassDB.connection.Groups.Where(x => x.ID == _SelectUser.group_id).FirstOrDefault().title;
        }

        private void ClEventSave(object sender, RoutedEventArgs e)
        {
            var selCombo = cmbGroup.SelectedItem as Groups;
            _SelectUser.isDelete = true; //удаляем старый эземпляр
            StudentClass studentClass = new StudentClass();
            studentClass.NewStudent(txbName.Text, txbSurname.Text, txbPat.Text, txbLogin.Text, txbPas.Text, selCombo.ID); //добавляем обновленный экземпляр
            ClassDB.connection.SaveChanges(); //сохранение изменений
            this.Close();
        }

        private void ClEventGoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
