using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitors
{
    class DataBaseConnection
    {


        public SqlConnection ObtainConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["WpfApplication1.Properties.Settings.TrainingConnectionString"].ConnectionString;
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;
        }

    }
}
