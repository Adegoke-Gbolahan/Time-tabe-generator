using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableSolving
{
    class connection
    {
        public MySqlConnection con = new MySqlConnection("database=softwaresuite; server=localhost; username=root; password=;");
        public void opencon()
        {
            con.Open();
        }
        public void closecon()
        {
            con.Close();
        }
    }
}
