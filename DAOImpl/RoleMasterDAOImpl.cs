using System;
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
    public class RoleMasterDAOImpl : RoleMasterDAO
    {
         public void deleteRole(RoleMaster roleMasterRef)
            {


                DataBaseConnection DbCon = new DataBaseConnection();
                string qry = "delete from dbo.vistor_role where roleName='" + roleMasterRef.roleName + "';";
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

            public void insertRole(RoleMaster roleMasterRef)
            {
            DataBaseConnection DbCon = new DataBaseConnection();
                string qry = "insert into dbo.vistor_role(roleName,roleDescription) values('" + roleMasterRef.roleName + "','" + roleMasterRef.roleDesc + "')";
                SqlConnection cnn = DbCon.ObtainConnection();
                //MessageBox.Show("Connectiom established !!");
                SqlDataAdapter da = new SqlDataAdapter();
                //  SqlCommand cmd = new SqlCommand(qry, cnn);
                da.InsertCommand = new SqlCommand(qry, cnn);
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("insert successfull !!");
                cnn.Dispose();
                cnn.Close();
                //    MessageBox.Show("Connectiom closed !!");

            }



            public void updaterole(RoleMaster roleMasterRef)
            {
            DataBaseConnection DbCon = new DataBaseConnection();
                string qry = "update dbo.vistor_role set roleDescription = '" + roleMasterRef.roleDesc + "' where roleName= '" + roleMasterRef.roleName + "';";
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
           
            RoleMaster RoleMasterDAO.findbyprimaryKey(string roleName)
            {

            DataBaseConnection DbCon = new DataBaseConnection();

                string qry = "select * from dbo.vistor_role where roleName='" + roleName + "';";

                Console.WriteLine("role name:{0}", roleName);
                SqlConnection cnn = DbCon.ObtainConnection();
                // MessageBox.Show("Connectiom established !!");
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(qry, cnn);
                //  da.InsertCommand = new SqlCommand(qry, cnn);
                // da.InsertCommand.ExecuteReader();

                SqlDataReader reader = cmd.ExecuteReader();
                RoleMaster roleMasterref = new RoleMaster();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("\n inserted  values \n");
                        Console.WriteLine("{0}\t{1}\n", reader.GetString(0),
                            reader.GetString(1));
                        roleMasterref.roleName = reader.GetString(0);
                        roleMasterref.roleDesc = reader.GetString(1);
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                Console.WriteLine("name:{0}\ndesc{1}\n", roleMasterref.roleName,
                                roleMasterref.roleDesc);
                reader.Close();
                //  MessageBox.Show("display successfull !!");
                cnn.Dispose();
                cnn.Close();
                //  MessageBox.Show("Connectiom closed !!");

                return roleMasterref;


            }

        DataTable RoleMasterDAO.selectAll()
        {
            DataBaseConnection DbCon = new DataBaseConnection();
            string qry = "select * from dbo.vistor_role;";

            SqlConnection cnn = DbCon.ObtainConnection();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("dbo.vistor_role");
            sda.Fill(dt);

            cnn.Dispose();
            cnn.Close();
            return dt;
        }

      
    
    }
}
