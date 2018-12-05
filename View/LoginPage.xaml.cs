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
using Visitors.DAO;
using Visitors.DAOImpl;
using Visitors.entity;

namespace Visitors.View
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            UserMaster usrmasterRef = new UserMaster();
            usrmasterRef.mobileNo = mobileNotxt.Text.Trim();

            if (passwordBoxsample.Password.Trim() == "")
                MessageBox.Show("Please enter password !");
            else
            {

                usrmasterRef.pwd = passwordBoxsample.Password.Trim();
                UserMasterDAO usrmasterDAORef = new UserMasterDAOImpl();
                int i = usrmasterDAORef.login(usrmasterRef);
                if (i == 1)
                {
                    
                    radCarouse1 r = new radCarouse1();
                    r.Show();
                    Hide();
                }
                else if (i == 0)
                {
                    mobileNotxt.Text = "";
                    passwordBoxsample.Password = "";
                    MessageBox.Show("invalid credential!");
                }
            }
          


        }
    }
}
