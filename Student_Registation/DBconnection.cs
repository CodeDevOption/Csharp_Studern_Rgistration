using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Student_Registation
{
    public class DBconnection
    {
        public MySqlConnection cn;
        public void connect()
        {
            cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=school"); 
        }
    }
}
