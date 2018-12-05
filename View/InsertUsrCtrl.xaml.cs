using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using Visitors.DAO;
using Visitors.DAOImpl;
using Visitors.entity;

namespace Visitors.View
{
    /// <summary>
    /// Interaction logic for InsertUsrCtrl.xaml
    /// </summary>
    public partial class InsertUsrCtrl : UserControl
    {
        public InsertUsrCtrl()
        {
            StyleManager.ApplicationTheme = new VistaTheme();
            InitializeComponent();
        }
        string imglocation = null;
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            UserMasterDAO usrMasterDAOREf = new UserMasterDAOImpl();
            UserMaster usrMasterref = new UserMaster();

            //if (pwdtxt.Text == cpwd.Text)
            //    usrMasterref.pwd = pwdtxt.Text;
            if (pwdtxt.Password != cpwd.Password)
                MessageBox.Show("confirm password doesnt match with password!!");
            else if(pwdtxt.Password=="")
                MessageBox.Show("pls enter password!!");
            else if(cpwd.Password=="")
                MessageBox.Show("pls enter confirm password!!");
            else
            {
                usrMasterref.pwd = pwdtxt.Password;
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
                clearFields();
            }
        
        }
        private void clearFields()
        {
            userNameTxt.Text = "";
            mobileNoTxt.Text = "";
            adressTxt.Text = "";
            pwdtxt.Password = "";
            cpwd.Password = "";
            imagepath.Text = "";
            emailidTxt.Text = "";
        }

        private void BrowseBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".jpg"; // Required file extension 
            fileDialog.Filter = "JPG File (.jpg)|*.jpg|png files(.png)|*.png"; // Optional file extensions
            fileDialog.ShowDialog();
            imglocation = fileDialog.FileName.ToString();
            imagepath.Text = imglocation;
            System.IO.StreamReader sr = new System.IO.StreamReader(fileDialog.FileName);
           // MessageBox.Show(imglocation);
            sr.Close();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new InsertUsrCtrlVM();

            UserMasterDAO usrMasterDAOREf = new UserMasterDAOImpl();
            List<string> rolenamelist = usrMasterDAOREf.getRoleName();
            foreach (var item in rolenamelist)
            {
                DesgcomboBox.Items.Add(item);
            }
        }
    }
}
