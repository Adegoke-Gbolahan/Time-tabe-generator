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
    public partial class frmcourse : Form
    {
        int pid;
//        double validator;
        public frmcourse()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtcoursecode.Text.Trim() == "" || txtcoursetitle.Text.Trim() == "")
            {
                MessageBox.Show("Course can not be empty!");
                return;
            }
            try
            {
                connection connect = new connection();
                string sql1 = "select * from course  where code='" + txtcoursecode.Text.Trim() + "' or title = '" + txtcoursetitle.Text.Trim() + "'";
                MySqlDataAdapter cmd1 = new MySqlDataAdapter(sql1, connect.con);
                DataTable tb = new DataTable();
                cmd1.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Course Already Exist!");
                }

                else
                {
                    string sql = "insert into course (code,title) values(@code,@title)";
                    MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                    cmd.Parameters.AddWithValue("@code", txtcoursecode.Text.Trim());
                    cmd.Parameters.AddWithValue("@title", txtcoursetitle.Text.Trim());
                    connect.opencon();
                    int i = cmd.ExecuteNonQuery();
                    connect.closecon();
                    if (i > 0)
                    {
                        MessageBox.Show("Course added succesfully!");
                        Display_Data();
                        txtcoursecode.Text = "";
                        txtcoursetitle.Text = "";
                        txtcoursecode.Focus();
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
                string sql = "SELECT * FROM course";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                lstview.Columns.Add("S/N", 50);
                lstview.Columns.Add("Code", 100);
                lstview.Columns.Add("Cours Title", 250);
                while (myReader.Read())
                {
                    ListViewItem LV1 = lstview.Items.Add(myReader["id"].ToString());
                    LV1.SubItems.Add(myReader["code"].ToString());
                    LV1.SubItems.Add(myReader["title"].ToString());
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
                string sql = "delete from course where id='" + pid + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                connect.opencon();
                myReader = cmd.ExecuteReader();
                connect.closecon();
                MessageBox.Show("Course deleted succesfully!");
                Display_Data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmcourse_Load(object sender, EventArgs e)
        {
            Display_Data();
        }
    }
}
