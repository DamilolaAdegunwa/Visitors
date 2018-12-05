using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for DeleteVisitorUserControl.xaml
    /// </summary>
    public partial class DeleteVisitorUserControl : UserControl
    {
        public DeleteVisitorUserControl()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

            UserMaster usrMasterRef = new UserMaster();
            UserMasterDAO usrMasterDAORef = new UserMasterDAOImpl();
            DataRowView row = (DataRowView)dataGridUser.SelectedItems[0];
            usrMasterRef.userid = Convert.ToInt32(row["user Id"]);
            usrMasterDAORef.deleteUser(usrMasterRef);
        }

        private void searchUserNameBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(UserNameTxt.Text.Trim()=="")
            {
                MessageBox.Show("Please enter user name !");

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

                DataTable dt = CreateDataTable(listNm, usrList);
                dataGridUser.ItemsSource = dt.DefaultView;
                deleteBtn.Visibility = Visibility.Visible;
                UserNameTxt.Text = "";
            }
         
            
        }
        private System.Data.DataTable CreateDataTable(List<string> columnDefinitions, List<ArrayList> rows)
        {
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

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FindAll_Click(object sender, RoutedEventArgs e)
        {
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
            deleteBtn.Visibility = Visibility.Visible;
           
            UserNameTxt.Text = "";
           
        }
    }
}
