using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Visitors;
using Visitors.DAO;
using Visitors.entity;

namespace Visitors.DAOImpl
{

    public class UserMasterDAOImpl :UserMasterDAO
    {

        public void deleteUser(UserMaster userMasterRef)
        {

            DataBaseConnection DbCon = new DataBaseConnection();
            string qry = "delete from dbo.visitor_user where userid= '" + userMasterRef.userid + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("delete successfull !!");
            cnn.Dispose();
            cnn.Close();
            //MessageBox.Show("Connectiom closed !!");
        }

        public UserMaster findbyprimaryKey(int userId)
        {

            DataBaseConnection DbCon = new DataBaseConnection();
            string qry = "select * from dbo.visitor_user where userid= '" + userId + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            //  da.InsertCommand = new SqlCommand(qry, cnn);
            // da.InsertCommand.ExecuteReader();

            SqlDataReader reader = cmd.ExecuteReader();
            UserMaster userMasterref = new UserMaster();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n inserted  values \n");
                    //Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                    //    reader.GetString(1));
                    userMasterref.userid = reader.GetInt32(0);
                    userMasterref.username = reader.GetString(1);
                    userMasterref.mobileNo = reader.GetString(2);
                    userMasterref.address = reader.GetString(4);
                    userMasterref.gender = reader.GetString(5);
                    userMasterref.emailId = reader.GetString(6);
                    userMasterref.dob = reader.GetDateTime(7);
                    userMasterref.pwd = reader.GetString(8);
                    RoleMaster roleMasterRef = new RoleMaster();
                    roleMasterRef.roleName = reader.GetString(9);

                    userMasterref.designationRef = roleMasterRef;

                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }


            reader.Close();
            //  MessageBox.Show("display successfull !!");




            cnn.Dispose();
            cnn.Close();
            //  MessageBox.Show("Connectiom closed !!");

            return userMasterref;
        }


        public DataTable selectAll()
        {
            DataBaseConnection DbCon = new DataBaseConnection();
            string qry = "select * from dbo.visitor_user;";

            SqlConnection cnn = DbCon.ObtainConnection();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("dbo.visitor_user");
            sda.Fill(dt);

            cnn.Dispose();
            cnn.Close();
            return dt;


        }
        public void insertUser(UserMaster userMasterRef)
        {
            DataBaseConnection DbCon = new DataBaseConnection();
            // string qry = "insert into dbo.visitor_user(userid,name,mobileNo,address,gender,emailid,dob,pwd,designation) values('" + userMasterRef.userid + "','" + userMasterRef.username + "','" + userMasterRef.mobileNo + "','" + userMasterRef.address + "','" + userMasterRef.gender + "','" + userMasterRef.emailId + "','" + userMasterRef.dob + "','" + userMasterRef.pwd + "','" + userMasterRef.designationRef.roleName + "')";
            string qry = "insert into dbo.visitor_user(name,Image,mobileNo,address,gender,emailid,dob,pwd,designation) values('" + userMasterRef.username + "','" + userMasterRef.picture + "','" + userMasterRef.mobileNo + "','" + userMasterRef.address + "','" + userMasterRef.gender + "','" + userMasterRef.emailId + "','" + userMasterRef.dob + "','" + userMasterRef.pwd + "','" + userMasterRef.designationRef.roleName + "')";
            SqlConnection cnn = DbCon.ObtainConnection();
            //MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("User Added !!");
            cnn.Dispose();
            cnn.Close();
            //    MessageBox.Show("Connectiom closed !!");
        }

        public void updateUser(UserMaster userMasterRef)
        { 
           DataBaseConnection DbCon = new DataBaseConnection();
            string qry = "update dbo.visitor_user set name = '" + userMasterRef.username + "',  mobileNo= '" + userMasterRef.mobileNo + "',  address= '" + userMasterRef.address + "',  gender= '" + userMasterRef.gender + "',  emailid= '" + userMasterRef.emailId + "', dob= '" + userMasterRef.dob + "', pwd= '" + userMasterRef.pwd + "' where userid= '" + userMasterRef.userid + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            //   MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            //  SqlCommand cmd = new SqlCommand(qry, cnn);
            da.InsertCommand = new SqlCommand(qry, cnn);
            da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show("update successfull !!");
            cnn.Dispose();
            cnn.Close();
            //  MessageBox.Show("Connectiom closed !!");

        }


        public List<string> getRoleName()
        {
            DataBaseConnection DbCon = new DataBaseConnection();
            string qry = "select * from dbo.vistor_role";
            SqlConnection cnn = DbCon.ObtainConnection();
            // MessageBox.Show("Connectiom established !!");
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(qry, cnn);


            SqlDataReader reader = cmd.ExecuteReader();
            RoleMaster roleRef = new RoleMaster();
            List<string> roleNames = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("\n inside Get Role names\n \n");
                    Console.WriteLine("\n inserted  values \n");
                    Console.WriteLine("{0}\t\n", reader.GetString(0));
                    roleNames.Add(reader.GetString(0));


                }
            }
            else
            {
                Console.WriteLine("couldn't display");
            }


            reader.Close();
            //  MessageBox.Show("display successfull !!");

            cnn.Dispose();
            cnn.Close();
            //  MessageBox.Show("Connectiom closed !!");

            return roleNames;
        }

        public List<ArrayList> getUsrList(UserMaster usermasterRef)
        {
            UserMaster usrmasterRef = new UserMaster();
            List<ArrayList> listOfUsers = new List<ArrayList>();
            DataBaseConnection DbCon = new DataBaseConnection();
            List<ArrayList> usrList = new List<ArrayList>();
            SqlConnection cnn = DbCon.ObtainConnection();
            UserMaster usrMasterRef = new UserMaster();
            string qry = null;
            if (usermasterRef == null)
            {
                qry = "select * from dbo.visitor_user";
            }
            else
            {
                if (usermasterRef.username != "")
                {
                    Console.WriteLine("\n ^^^^^^^^^^^^inside if User name\n");
                    Console.WriteLine("user Name:{0}\n", usermasterRef.username);
                    qry = "select * from dbo.visitor_user where name='" + usermasterRef.username + "'";

                }

                if (usermasterRef.designationRef.roleName != null)
                {
                    Console.WriteLine("inside else if \nRole Name:{0}", usermasterRef.designationRef.roleName);
                    qry = "select * from dbo.visitor_user where designation='" + usermasterRef.designationRef.roleName + "'";
                }

            }
            Console.WriteLine("\n ^^^^^^^^^^^^outside if User name\n");
            //   Console.WriteLine("user Name:{0}\n", usermasterRef.username);

            // Console.WriteLine("outside else if \nRole Name:{0}", usermasterRef.designationRef.roleName);
            SqlCommand cmd = new SqlCommand(qry, cnn);




            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    Console.WriteLine("");
                    // (0 int  id,1 string usename, 2 string mobileNo,3 string address,  4 string g, 5 string mailid, 6 DateTime d,7  string pwd,8  string RoleMaster)
                    usrList.Add(usrmasterRef.getUserList(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetDateTime(7), reader.GetString(8), reader.GetString(9)));
                    Console.WriteLine("USER ID:{0}\n ID:{1}\n mobile no:{2}\n address:{3}\n gender:{4}\n mailid:{5}\tdob:{6}\npwd:{7}\nrole:[8]", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetDateTime(7), reader.GetString(8), reader.GetString(9));

                }
            }
            else
                Console.WriteLine("No row found!!\n");

            return usrList;


        }

        public int login(UserMaster usermasterRef)
        {

            DataBaseConnection DbCon = new DataBaseConnection();
            //string qry = "select * from dbo.visitor_user where mobileNo= '" + usermasterRef.mobileNo + "';";
            string qry = "select * from dbo.visitor_user where mobileNo= '" + usermasterRef.mobileNo + "' and pwd='" + usermasterRef.pwd + "';";
            SqlConnection cnn = DbCon.ObtainConnection();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                return 1;
            else return 0;

        }

     
    }

}
