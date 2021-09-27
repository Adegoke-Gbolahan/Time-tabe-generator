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
    public partial class frmroom : Form
    {
        int pid;
        double validator;
        public frmroom()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtroom.Text.Trim(), out validator) || txtroom.Text == "")
            {
                MessageBox.Show("Invalid Lecture Room Name!");
                txtroom.Focus();
                return;
            }
            try
            {
                connection connect = new connection();
                string sql1 = "select * from faculty  where name='" + txtroom.Text.Trim() + "'";
                MySqlDataAdapter cmd1 = new MySqlDataAdapter(sql1, connect.con);
                DataTable tb = new DataTable();
                cmd1.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Faculty Name Already Exist!");
                }

                else
                {
                    string sql = "insert into room (name) values(@name)";
                    MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                    cmd.Parameters.AddWithValue("@name", txtroom.Text.Trim());
                    connect.opencon();
                    int i = cmd.ExecuteNonQuery();
                    connect.closecon();
                    if (i > 0)
                    {
                        MessageBox.Show("Lecture Room added succesfully!");
                        Display_Data();
                        txtroom.Text = "";
                        txtroom.Focus();
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
                string sql = "SELECT * FROM room";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                lstview.Columns.Add("S/N", 50);
                lstview.Columns.Add("Lecture Room Name", 200);
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
                MessageBox.Show("Select Lecture Room to delete");
                return;
            }
            pid = int.Parse(lstview.SelectedItems[0].Text);
            try
            {
                MySqlDataReader myReader;
                connection connect = new connection();
                string sql = "delete from room where id='" + pid + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                connect.opencon();
                myReader = cmd.ExecuteReader();
                connect.closecon();
                MessageBox.Show("Lecture Room deleted succesfully!");
                Display_Data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void frmroom_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
