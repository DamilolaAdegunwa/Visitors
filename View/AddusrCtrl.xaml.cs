using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
using Visitors.DAO;
using Visitors.DAOImpl;
using Visitors.entity;

namespace Visitors.View
{
    /// <summary>
    /// Interaction logic for AddusrCtrl.xaml
    /// </summary>
    public partial class AddusrCtrl : UserControl
    {
        public AddusrCtrl()
        {
            InitializeComponent();
        }
        string imglocation = "";
        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
             fileDialog.DefaultExt = ".jpg"; // Required file extension 
            fileDialog.Filter = "JPG File (.jpg)|*.jpg|png files(.png)|*.png"; // Optional file extensions
            fileDialog.ShowDialog();
           imglocation = fileDialog.FileName.ToString();
            imagepath.Text = imglocation;
            System.IO.StreamReader sr = new System.IO.StreamReader(fileDialog.FileName);
            MessageBox.Show(imglocation);
            sr.Close();


          

        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {

            UserMasterDAO usrMasterDAOREf = new UserMasterDAOImpl();
            UserMaster usrMasterref = new UserMaster();
            usrMasterref.username = userNameTxt.Text;
            usrMasterref.mobileNo = mobileNoTxt.Text;
            usrMasterref.address = adressTxt.Text;
            if (maleRbtn.IsChecked == true)
                usrMasterref.gender = "M";
            else if (femaleRbtn.IsChecked == true)
                usrMasterref.gender = "F";
            usrMasterref.emailId = emailidTxt.Text;
            if (dobCalender.SelectedDate.HasValue)
            {

                usrMasterref.dob = dobCalender.SelectedDate.Value;
                Console.WriteLine("DOB:{0}\n", usrMasterref.dob);

            }
            if (pwdtxt.Password == cpwd.Password)
                usrMasterref.pwd = pwdtxt.Password;
            RoleMaster r = new RoleMaster();
            r.roleName = DesgcomboBox.Text;
            usrMasterref.designationRef = r;

            byte[] images = null;
            FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            if (images == null)
                MessageBox.Show("Upload image!");
            usrMasterref.picture = images;
            usrMasterDAOREf.insertUser(usrMasterref);

        }
        private void ClearFields()
        {

        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        
            //  DataContext = new AddusrCtrlVM();
            UserMasterDAO usrMasterDAOREf = new UserMasterDAOImpl();
            List<string> rolenamelist = usrMasterDAOREf.getRoleName();
            foreach (var item in rolenamelist)
            {
                DesgcomboBox.Items.Add(item);
            }
        }
    }
}
