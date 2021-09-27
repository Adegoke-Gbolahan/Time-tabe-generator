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
    public partial class frmtime : Form
    {
        int pid;
        public frmtime()
        {
            InitializeComponent();
        }

        private void frmtime_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (timestart.Text == timeend.Text)
            {
                MessageBox.Show("Invalid Lecture Time!");
                timestart.Focus();
                return;
            }
            try
            {
                connection connect = new connection();
                string sql1 = "select * from time  where start='" + timestart.Text.Trim() + "' or end = '" + timeend.Text.Trim() + "'";
                MySqlDataAdapter cmd1 = new MySqlDataAdapter(sql1, connect.con);
                DataTable tb = new DataTable();
                cmd1.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Lecture Time Already Exist!");
                }

                else
                {
                    string sql = "insert into time (start,end) values(@start,@end)";
                    MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                    cmd.Parameters.AddWithValue("@start", timestart.Text.Trim());
                    cmd.Parameters.AddWithValue("@end", timeend.Text.Trim());
                    connect.opencon();
                    int i = cmd.ExecuteNonQuery();
                    connect.closecon();
                    if (i > 0)
                    {
                        MessageBox.Show("Lecture Time added succesfully!");
                        Display_Data();
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
                string sql = "SELECT * FROM time";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                lstview.Columns.Add("S/N", 50);
                lstview.Columns.Add("End Time", 100);
                lstview.Columns.Add("Start Time", 100);
                while (myReader.Read())
                {
                    ListViewItem LV1 = lstview.Items.Add(myReader["id"].ToString());
                    LV1.SubItems.Add(myReader["start"].ToString());
                    LV1.SubItems.Add(myReader["end"].ToString());
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
                MessageBox.Show("Select Time to delete");
                return;
            }
            pid = int.Parse(lstview.SelectedItems[0].Text);
            try
            {
                MySqlDataReader myReader;
                connection connect = new connection();
                string sql = "delete from time where id='" + pid + "'";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                connect.opencon();
                myReader = cmd.ExecuteReader();
                connect.closecon();
                MessageBox.Show("Time deleted succesfully!");
                Display_Data();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
