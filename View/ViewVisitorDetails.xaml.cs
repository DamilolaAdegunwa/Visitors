using Spire.Barcode;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
    /// Interaction logic for ViewVisitorDetails.xaml
    /// </summary>
    public partial class ViewVisitorDetails : UserControl
    {
        public ViewVisitorDetails()
        {
            InitializeComponent();
        }

        private void dataGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void searchUserNameBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(UserNameTxt.Text.Trim()=="")
            {
                MessageBox.Show("Please enter user name!");

            }
            else
            {
                UserMaster usrmasterRef = new UserMaster();
                usrmasterRef.username = UserNameTxt.Text.Trim();

                RoleMaster rolemasterRef = new RoleMaster();
                rolemasterRef.roleName = null;
                usrmasterRef.designationRef = rolemasterRef;
                UserMasterDAO userMasterDaoRef = new UserMasterDAOImpl();
                List<string> listNm = new List<string>();
                listNm.Add("user Id");
                listNm.Add("User Name");
                listNm.Add("Mobile No");
                listNm.Add("Address");
                listNm.Add("gender");
                listNm.Add("Email Id");
                listNm.Add("DOB");
                listNm.Add("password");
                listNm.Add("designation");
                List<List<string>> itemList = new List<List<string>>();
                List<ArrayList> usrList = new List<ArrayList>();
                usrList = userMasterDaoRef.getUsrList(usrmasterRef);
                if (usrList.Count == 0)
                {
                    Console.WriteLine("inside if null");
                    QRCodeBtn.Visibility = Visibility.Hidden;
                    dataGridUser.ItemsSource = null;
                    image1.Visibility = Visibility.Hidden;
                }
                    
                else
                {
                    Console.WriteLine("inside else null");
                    DataTable dt = CreateDataTable(listNm, usrList);
                    dataGridUser.ItemsSource = dt.DefaultView;
                }
              
            }
               


        }
        private System.Data.DataTable CreateDataTable(List<string> columnDefinitions, List<ArrayList> rows)
        {
            QRCodeBtn.Visibility = Visibility.Visible;
            DataTable table = new DataTable();
            foreach (string colDef in columnDefinitions)
            {
                DataColumn column;
                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = colDef;
                table.Columns.Add(column);
            }


            // Create DataRow and Add it to table
            foreach (ArrayList rowData in rows)
            {
                DataRow row = table.NewRow();
                // rowData is in same order as columnDefinitions
                for (int i = 0; i < rowData.Count; i++)
                {
                    row[i] = rowData[i];
                }
                table.Rows.Add(row);
            }


            return table;
        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            UserNameTxt.Text = "";
            UserMasterDAO userMasterDaoRef = new UserMasterDAOImpl();
            List<string> listNm = new List<string>();
            listNm.Add("user Id");
            listNm.Add("User Name");
            listNm.Add("Mobile No");
            listNm.Add("Address");
            listNm.Add("gender");
            listNm.Add("Email Id");
            listNm.Add("DOB");
            listNm.Add("password");
            listNm.Add("designation");
            // List<List<string>> itemList = new List<List<string>>();
            List<ArrayList> usrList = new List<ArrayList>();
            usrList = userMasterDaoRef.getUsrList(null);

            DataTable dt = CreateDataTable(listNm, usrList);
            dataGridUser.ItemsSource = dt.DefaultView;

            dataGridUser.Columns[0].IsReadOnly = true;
            dataGridUser.Columns[1].IsReadOnly = false;
            dataGridUser.Columns[2].IsReadOnly = false;
            dataGridUser.Columns[3].IsReadOnly = false;
            dataGridUser.Columns[4].IsReadOnly = false;
            dataGridUser.Columns[5].IsReadOnly = false;
            dataGridUser.Columns[6].IsReadOnly = false;
            dataGridUser.Columns[7].IsReadOnly = false;
            dataGridUser.Columns[8].IsReadOnly = true;
        

        }

        private void QRCodeBtn_Click(object sender, RoutedEventArgs e)
        {
        //    if (dataGridUser.ItemsSource == "")
        //    {
        //        MessageBox.Show("No Data!");
        //    }
        //    else
            {
               
                UserMaster usrMasterRef = new UserMaster();
                UserMasterDAO usrMasterDAORef = new UserMasterDAOImpl();
                DataRowView row = (DataRowView)dataGridUser.SelectedItems[0];
                int id = Convert.ToInt32(row["user Id"]);
                usrMasterRef = usrMasterDAORef.findbyprimaryKey(id);
                QrCodegenerator(usrMasterRef);
                 image1.Visibility = Visibility.Visible;
            }
        }

        private void QrCodegenerator(UserMaster usrMasterRef)
        {
            BarcodeSettings.ApplyKey("your key");//you need a key from e-iceblue, otherwise the watermark 'E-iceblue' will be shown in barcode
            BarcodeSettings settings = new BarcodeSettings();
            settings.Type = BarCodeType.QRCode;
            settings.Unit = GraphicsUnit.Pixel;
            settings.ShowText = false;
            settings.ResolutionType = ResolutionType.UseDpi;
           string data = "UserName :" + usrMasterRef.username + "\nMobileNo : " + usrMasterRef.mobileNo + "\ngender : " + usrMasterRef.gender+"\nAddress : "+usrMasterRef.address+"\nEmail Id : "+usrMasterRef.emailId;
        // Console.WriteLine("Usren mae:{0} password:{1} Mobile No={2} gender={3}", u.username, u.pwd, u.mobileNo, u.gender);
            settings.Data = data;
            string foreColor = "Black";
            string backColor = "White";
            settings.ForeColor = System.Drawing.Color.FromName(foreColor);
            settings.BackColor = System.Drawing.Color.FromName(backColor);
            settings.X = Convert.ToInt16(30);
            short leftMargin = 1;
            settings.LeftMargin = leftMargin;
            short rightMargin = 1;
            settings.RightMargin = rightMargin;
            short topMargin = 1;
            settings.TopMargin = topMargin;
            short bottomMargin = 1;
            settings.BottomMargin = bottomMargin;
            settings.QRCodeECL = QRCodeECL.L;

            BarCodeGenerator generator = new BarCodeGenerator(settings);
            System.Drawing.Image QRbarcode = generator.GenerateImage();

            image1.Source = BitmapToImageSource(QRbarcode);
        }

     

        private ImageSource BitmapToImageSource(System.Drawing.Image bitmap)
        {
            //throw new NotImplementedException();
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();
       return bitmapimage;
            }
        }
    }
}

