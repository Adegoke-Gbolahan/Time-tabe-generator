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
    public partial class frmfaculty : Form
    {
        int pid;
        public frmfaculty()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtfaculty.Text.Trim(), out validator) || txtfaculty.Text == "")
            {
                MessageBox.Show("Invalid Faculty Name!");
                txtfaculty.Focus();
                return;
            }
            try
            {
                connection connect = new connection();
                string sql1 = "select * from faculty  where name='" + txtfaculty.Text.Trim() + "'";
                MySqlDataAdapter cmd1 = new MySqlDataAdapter(sql1, connect.con);
                DataTable tb = new DataTable();
                cmd1.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Faculty Name Already Exist!");
                }

                else
                {
                    string sql = "insert into faculty (name) values(@name)";
                    MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                    cmd.Parameters.AddWithValue("@name", txtfaculty.Text.Trim());
                    connect.opencon();
                    int i = cmd.ExecuteNonQuery();
                    connect.closecon();
                    if (i > 0)
                    {
                        MessageBox.Show("Faculty added succesfully!");
                        Display_Data();
                        txtfaculty.Text = "";
                        txtfaculty.Focus();
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
                string sql = "SELECT * FROM faculty";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                lstview.Columns.Add("S/N", 50);
                lstview.Columns.Add("Faculty Name", 200);
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

        double validator;

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
                string sql = "delete from faculty where id='" + pid + "'";
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

        private void frmfaculty_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
