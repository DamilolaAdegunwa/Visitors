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
using Visitors.View;

namespace Visitors
{
    /// <summary>
    /// Interaction logic for radCarouse1.xaml
    /// </summary>
    public partial class radCarouse1 : Window
    {
        public radCarouse1()
        {
            InitializeComponent();
        }

        private void mouseDoubleClickOnAddVisitor(object sender, MouseButtonEventArgs e)
        {
            addvisitorUserControl1.Visibility = Visibility.Visible;
            editvisitorUserControl1.Visibility = Visibility.Hidden;
            viewVisitorUserCtrl1.Visibility = Visibility.Hidden;
            deleteVisitorCtrl1.Visibility = Visibility.Hidden;
        }

        private void mouseDoubleClickEditVisitor(object sender, MouseButtonEventArgs e)
        {
            editvisitorUserControl1.Visibility = Visibility.Visible;
            viewVisitorUserCtrl1.Visibility = Visibility.Hidden;
            addvisitorUserControl1.Visibility = Visibility.Hidden;
            deleteVisitorCtrl1.Visibility = Visibility.Hidden;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            editvisitorUserControl1.Visibility = Visibility.Hidden;
           addvisitorUserControl1.Visibility = Visibility.Hidden;
            viewVisitorUserCtrl1.Visibility = Visibility.Hidden;
            deleteVisitorCtrl1.Visibility = Visibility.Hidden;
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void mouseDoubleClickLogOut(object sender, MouseButtonEventArgs e)
        {
            LoginPage l = new LoginPage();
            l.Show();
            Hide();
        }

        private void mouseDoubleClickViewVisitor(object sender, MouseButtonEventArgs e)
        {
            viewVisitorUserCtrl1.Visibility = Visibility.Visible;
            editvisitorUserControl1.Visibility = Visibility.Hidden;
            addvisitorUserControl1.Visibility = Visibility.Hidden;
            deleteVisitorCtrl1.Visibility = Visibility.Hidden;
        }

        private void mouseDoubleClickDeletVisitor(object sender, MouseButtonEventArgs e)
        {

        }

        private void ListBox_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void mouseDoubleClickDeleteVisitor(object sender, MouseButtonEventArgs e)
        {
            deleteVisitorCtrl1.Visibility = Visibility.Visible;
            editvisitorUserControl1.Visibility = Visibility.Hidden;
            addvisitorUserControl1.Visibility = Visibility.Hidden;
            viewVisitorUserCtrl1.Visibility = Visibility.Hidden;
        }

        private void dropdown_Expanded(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
           
        }
    }
}
