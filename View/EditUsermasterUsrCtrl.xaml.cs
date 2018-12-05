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
using Visitors.View;

namespace Visitors.View
{
    /// <summary>
    /// Interaction logic for EditRoleUserControl.xaml
    /// </summary>
    public partial class EditRoleUserControl : UserControl
    {
        public EditRoleUserControl()
        {
            InitializeComponent();
        }

        private void searchUserNameBtn_Click(object sender, RoutedEventArgs e)
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

            dataGridUser.Columns[0].IsReadOnly = true;
            dataGridUser.Columns[1].IsReadOnly = false;
            dataGridUser.Columns[2].IsReadOnly = false;
            dataGridUser.Columns[3].IsReadOnly = false;
            dataGridUser.Columns[4].IsReadOnly = false;
            dataGridUser.Columns[5].IsReadOnly = false;
            dataGridUser.Columns[6].IsReadOnly = false;
            dataGridUser.Columns[7].IsReadOnly = false;
            dataGridUser.Columns[8].IsReadOnly = true;
           
            roleNameTxt.Text = "";
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

        private void searchRoleNameBtn_Click(object sender, RoutedEventArgs e)
        {
            UserMaster usrmasterRef = new UserMaster();
            usrmasterRef.username = null;
            RoleMaster rolemasterRef = new RoleMaster();
            rolemasterRef.roleName = roleNameTxt.Text.Trim();
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

            dataGridUser.Columns[0].IsReadOnly = true;
            dataGridUser.Columns[1].IsReadOnly = false;
            dataGridUser.Columns[2].IsReadOnly = false;
            dataGridUser.Columns[3].IsReadOnly = false;
            dataGridUser.Columns[4].IsReadOnly = false;
            dataGridUser.Columns[5].IsReadOnly = false;
            dataGridUser.Columns[6].IsReadOnly = false;
            dataGridUser.Columns[7].IsReadOnly = false;
            dataGridUser.Columns[8].IsReadOnly = true;
            
            UserNameTxt.Text = "";
        }

        private void FindAllBtn_Click(object sender, RoutedEventArgs e)
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
           
            roleNameTxt.Text = "";
            UserNameTxt.Text = "";
            
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            UserMaster usrMasterRef = new UserMaster();
            UserMasterDAO usrMasterDAORef = new UserMasterDAOImpl();
            DataRowView row = (DataRowView)dataGridUser.SelectedItems[0];
            usrMasterRef.userid = Convert.ToInt32(row["user Id"]);
            usrMasterDAORef.deleteUser(usrMasterRef);
        }

        private void dataGridUser_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dataGridUser_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int rowIndex = e.Row.GetIndex();
            UserMaster usrMasterRef = new UserMaster();
            UserMasterDAO usrMasterDAORef = new UserMasterDAOImpl();
                         
            var col = dataGridUser.CurrentColumn.DisplayIndex;

                var changedValue = dataGridUser.Columns[col].GetCellContent(e.Row);
                Console.WriteLine("\n\n\nvalue changed:{0}", changedValue);
                FrameworkElement element_1 = (dataGridUser.Columns[0].GetCellContent(e.Row));
                var userId = ((TextBlock)element_1).Text;
                usrMasterRef.userid = Convert.ToInt32(userId);


                Console.WriteLine("\n+\nUser Id={0}", usrMasterRef.userid);
                //usrMasterRef.userid = Convert.ToInt32(dataGridUser.Columns[0].GetCellContent(e.Row));
                RoleMaster roleMasteRef = new RoleMaster();


                FrameworkElement element_username = (dataGridUser.Columns[1].GetCellContent(e.Row));
                Console.WriteLine("****************************************************");
                var username = "";
                if (col == 1)
                    username = ((TextBox)element_username).Text;
                else
                    username = ((TextBlock)element_username).Text;

                usrMasterRef.username = Convert.ToString(username);
                Console.WriteLine("\n\n\nuserName:{0}", usrMasterRef.username);


                FrameworkElement element_mobile = dataGridUser.Columns[2].GetCellContent(e.Row);
                var mobile_no = "";
                if (col == 2)
                    mobile_no = ((TextBox)element_mobile).Text;
                else
                    mobile_no = ((TextBlock)element_mobile).Text;
                usrMasterRef.mobileNo = mobile_no;
                Console.WriteLine("mobile  No:{0}", usrMasterRef.mobileNo);


                FrameworkElement element_adress = dataGridUser.Columns[3].GetCellContent(e.Row);
                var address = "";
                if (col == 3)
                    address = ((TextBox)element_adress).Text;
                else
                    address = ((TextBlock)element_adress).Text;
                usrMasterRef.address = Convert.ToString(address);
                Console.WriteLine("address  :{0}", usrMasterRef.address);



                FrameworkElement element_gender = dataGridUser.Columns[4].GetCellContent(e.Row);
                var gender = "";
                if (col == 4)
                    gender = ((TextBox)element_gender).Text;
                else
                    gender = ((TextBlock)element_gender).Text;
                usrMasterRef.gender = Convert.ToString(gender);
                Console.WriteLine("gender  :{0}", usrMasterRef.gender);



                FrameworkElement element_emailId = dataGridUser.Columns[5].GetCellContent(e.Row);
                var emailId = "";
                if (col == 5)
                    emailId = ((TextBox)element_emailId).Text;
                else
                    emailId = ((TextBlock)element_emailId).Text;
                usrMasterRef.emailId = Convert.ToString(emailId);
                Console.WriteLine("email ID  :{0}", usrMasterRef.emailId);


                FrameworkElement element2 = dataGridUser.Columns[6].GetCellContent(e.Row);
                var dob = "";
                if (col == 6)
                    dob = ((TextBox)element2).Text;
                else
                    dob = ((TextBlock)element2).Text;

                usrMasterRef.dob = Convert.ToDateTime(dob);
                Console.WriteLine("dob  :{0}", usrMasterRef.dob);



                FrameworkElement element_pwd = dataGridUser.Columns[7].GetCellContent(e.Row);
                var pwd = "";
                if (col == 7)
                    pwd = ((TextBox)element_pwd).Text;
                else
                    pwd = ((TextBlock)element_pwd).Text;
                usrMasterRef.pwd = Convert.ToString(pwd);
                Console.WriteLine("pwd  :{0}", usrMasterRef.pwd);



                FrameworkElement element_role = dataGridUser.Columns[8].GetCellContent(e.Row);
                var role = "";
                if (col == 8)
                    role = ((TextBox)element_role).Text;
                else
                    role = ((TextBlock)element_role).Text;
                roleMasteRef.roleName = Convert.ToString(role);
                usrMasterRef.designationRef = roleMasteRef;
                Console.WriteLine("role name  :{0}", usrMasterRef.designationRef.roleName);

                usrMasterDAORef.updateUser(usrMasterRef);

            
          
        }

        private void searchUserNameBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(UserNameTxt.Text.Trim()=="")
            {
                MessageBox.Show("Please enter User Name !");
            }
            else
            {
                roleNameTxt.Text = "";
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

                dataGridUser.Columns[0].IsReadOnly = true;
                dataGridUser.Columns[1].IsReadOnly = false;
                dataGridUser.Columns[2].IsReadOnly = false;
                dataGridUser.Columns[3].IsReadOnly = false;
                dataGridUser.Columns[4].IsReadOnly = false;
                dataGridUser.Columns[5].IsReadOnly = false;
                dataGridUser.Columns[6].IsReadOnly = false;
                dataGridUser.Columns[7].IsReadOnly = false;
                dataGridUser.Columns[8].IsReadOnly = true;

                roleNameTxt.Text = "";
            }
          
   
        }

        private void searchRoleNameBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (roleNameTxt.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Role name !");
            }
            UserNameTxt.Text = "";
            UserMaster usrmasterRef = new UserMaster();
            usrmasterRef.username = null;
            RoleMaster rolemasterRef = new RoleMaster();
            rolemasterRef.roleName = roleNameTxt.Text.Trim();
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

            dataGridUser.Columns[0].IsReadOnly = true;
            dataGridUser.Columns[1].IsReadOnly = false;
            dataGridUser.Columns[2].IsReadOnly = false;
            dataGridUser.Columns[3].IsReadOnly = false;
            dataGridUser.Columns[4].IsReadOnly = false;
            dataGridUser.Columns[5].IsReadOnly = false;
            dataGridUser.Columns[6].IsReadOnly = false;
            dataGridUser.Columns[7].IsReadOnly = false;
            dataGridUser.Columns[8].IsReadOnly = true;
           UserNameTxt.Text = "";
         
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
         

        }

        private void dataGridUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
