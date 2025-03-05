using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WIPR

{
    
    class MY_DB
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private SqlConnection con;

        public MY_DB()
        {
            con = new SqlConnection(connectionString);
        }

        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }

        }


        // close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }

        }

        internal object GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}
