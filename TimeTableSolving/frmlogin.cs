using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableSolving
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection connect = new connection();
            try
            {
                string sql = "select * from admin where username='" + txtusername.Text.Trim() + "' and password ='" + txtpassword.Text.Trim() + "'";
                MySqlDataAdapter adapt = new MySqlDataAdapter(sql, connect.con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    frmdashboard hab = new frmdashboard();
                    hab.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login parameter!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
