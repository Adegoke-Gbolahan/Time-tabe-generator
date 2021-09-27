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
    public partial class frmdepartment : Form
    {
        int pid;
        public frmdepartment()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if ( txtdept.Text == "")
            {
                MessageBox.Show("Invalid Department Name!");
                txtdept.Focus();
                return;
            }
            try
            {
                connection connect = new connection();
                string sql1 = "select * from department  where name='" + txtdept.Text.Trim() + "'";
                MySqlDataAdapter cmd1 = new MySqlDataAdapter(sql1, connect.con);
                DataTable tb = new DataTable();
                cmd1.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Department Name Already Exist!");
                }

                else
                {
                    string sql = "insert into department (name) values(@name)";
                    MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                    cmd.Parameters.AddWithValue("@name", txtdept.Text.Trim());
                    connect.opencon();
                    int i = cmd.ExecuteNonQuery();
                    connect.closecon();
                    if (i > 0)
                    {
                        MessageBox.Show("Department added succesfully!");
                       Display_Data();
                        txtdept.Text = "";
                        txtdept.Focus();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Display_Data()
        {
            connection connect = new connection();
            try
            {
                lstview.Clear();
                connect.opencon();
                MySqlDataReader myReader;
                string sql = "SELECT * FROM department";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                lstview.Columns.Add("S/N", 50);
                lstview.Columns.Add("Deparment Name", 200);
                while (myReader.Read())
                {
                    ListViewItem LV1 = lstview.Items.Add(myReader["id"].ToString());
                    LV1.SubItems.Add(myReader["name"].ToString());
                }
                connect.closecon();
            }
            catch (Exception hab)
            {
                connect.closecon();
                MessageBox.Show(hab.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (pid.ToString() == "0")
            {
                MessageBox.Show("Select course to delete");
                return;
            }
            pid = int.Parse(lstview.SelectedItems[0].Text);
            try
            {

                MySqlDataReader myReader;
                connection connect = new connection();
                string sql = "delete from department where id='" + pid + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                connect.opencon();
                myReader = cmd.ExecuteReader();
                connect.closecon();
                MessageBox.Show("Faculty deleted succesfully!");
                Display_Data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmdepartment_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       // double validator;
    }
}
