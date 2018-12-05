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
using System.Windows.Shapes;

namespace Visitors.View
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddUserBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void addUsrCtrl1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            insertUsrCtrl1.Visibility = Visibility.Visible;
            editroleCtrl1.Visibility = Visibility.Hidden;
        }

        private void MainMenu_load(object sender, RoutedEventArgs e)
        {
            insertUsrCtrl1.Visibility = Visibility.Hidden;
            editroleCtrl1.Visibility = Visibility.Hidden;
        }

        private void EditUserBtn_Click(object sender, RoutedEventArgs e)
        {
            editroleCtrl1.Visibility = Visibility.Visible;
            insertUsrCtrl1.Visibility = Visibility.Hidden;
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            //LoginPage l = new LoginPage();
            //l.Show();
            //Hide();
        }

        private void LogOutBtn_Click_1(object sender, RoutedEventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
            Hide();
        }

        private void EditRoleUserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void ViewUserBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
