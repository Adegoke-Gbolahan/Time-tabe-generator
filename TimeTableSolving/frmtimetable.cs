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
using System.IO;
using System.Drawing.Printing;
using Microsoft.Office.Interop.Excel;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace TimeTableSolving
{
    public partial class frmtimetable : Form
    {
       // MySqlDataAdapter adpt;
       // DataTable dt;
         
        public frmtimetable()
        {
            InitializeComponent();
            Display_Data();
            showData();
            //printDocument1;

            this.lstview.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lstview_ColumnWidthChanging);
        }
        void lstview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            Console.Write("Column Resizing");
            e.NewWidth = this.lstview.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        


        private void Display_department()
        {
           
            connection connect = new connection();
            try
            {
                cmbfaculty.Items.Add("Department");
                lstview.Clear();
                connect.opencon();
                MySqlDataReader myReader;
                string sql = "SELECT * FROM department";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    cmddept.Items.Add(myReader["name"].ToString());
                }
                connect.closecon();
            }

            catch (Exception hab)
            {
                connect.closecon();
                MessageBox.Show(hab.Message);
            }
        }
        public void Display_faculty()
        {
            connection connect = new connection();
            try
            {
                cmbfaculty.Items.Add("Select...");
                lstview.Clear();
                connect.opencon();
                MySqlDataReader myReader;
                string sql = "SELECT * FROM faculty";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    cmbfaculty.Items.Add(myReader["name"].ToString());
                }
                connect.closecon();
            }
            catch (Exception hab)
            {
                connect.closecon();
                MessageBox.Show(hab.Message);
            }
        }

        public void Display_room()
        {
            connection connect = new connection();
            try
            {
                cmbroom.Items.Add("Select...");
                lstview.Clear();
                connect.opencon();
                MySqlDataReader myReader;
                string sql = "SELECT * FROM room";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    cmbroom.Items.Add(myReader["name"].ToString());
                }
                connect.closecon();
            }
            catch (Exception hab)
            {
                connect.closecon();
                MessageBox.Show(hab.Message);
            }
        }

        public void Display_course()
        {
            connection connect = new connection();
            try
            {
                cmbcourse.Items.Add("Select...");
                lstview.Clear();
                connect.opencon();
                MySqlDataReader myReader;
                string sql = "SELECT * FROM course";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    cmbcourse.Items.Add(myReader["code"].ToString() + " (" + myReader["title"].ToString() + ")");
                }
                connect.closecon();
            }
            catch (Exception hab)
            {
                connect.closecon();
                MessageBox.Show(hab.Message);
            }
        }
            
        public void Display_start()
        {
            connection connect = new connection();
            try
            {
                cmbstart.Items.Add("Select...");
                lstview.Clear();
                connect.opencon();
                MySqlDataReader myReader;
                string sql = "SELECT start FROM time";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    cmbstart.Items.Add(myReader["start"].ToString());
                }
                connect.closecon();
            }
            catch (Exception hab)
            {
                connect.closecon();
                MessageBox.Show(hab.Message);
            }
        }

        public void Display_end()
        {
            connection connect = new connection();
            try
            {
                cmbend.Items.Add("Select...");
                lstview.Clear();
                connect.opencon();
                MySqlDataReader myReader;
                string sql = "SELECT end FROM time";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    cmbend.Items.Add(myReader["end"].ToString());
                }
                connect.closecon();
            }
            catch (Exception hab)
            {
                connect.closecon();
                MessageBox.Show(hab.Message);
            }
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            try
            {
                connection connect = new connection();
                connect.opencon();
                MySqlDataReader myreader;
                string sql1 = "select * from table_generated  where  room = '" + cmbroom.Text + "'AND start ='" + cmbstart.Text + "'AND end = '" + cmbend.Text + "'AND day = '" + cmdday.Text +"'";
                MySqlCommand cmd1 = new MySqlCommand(sql1, connect.con);
                myreader = cmd1.ExecuteReader();
                int ii = 0;
                while(myreader.Read())
                {
                    ii++;
                    if (ii > 0)
                    {
                        MessageBox.Show("Venue is used up");
                    }
                        string sql = "insert into table_generated (faculty,course, department,day,prog,room,start,end) values(@faculty,@course,@department,@day,@prog,@room,@start,@end)";
                        MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                        cmd.Parameters.AddWithValue("@faculty", cmbfaculty.Text.Trim());
                        cmd.Parameters.AddWithValue("@course", cmbcourse.Text.Trim());
                        cmd.Parameters.AddWithValue("@department", cmddept.Text.Trim());
                        cmd.Parameters.AddWithValue("@day", cmdday.Text.Trim());
                        cmd.Parameters.AddWithValue("@prog", cmdprog.Text.Trim());
                        cmd.Parameters.AddWithValue("@room", cmbroom.Text.Trim());
                        cmd.Parameters.AddWithValue("@start", cmbstart.Text.Trim());
                        cmd.Parameters.AddWithValue("@end", cmbend.Text.Trim());
                        //`connect.opencon();
                        int i = cmd.ExecuteNonQuery();
                        connect.closecon();
                        if (i > 0)
                        {
                            MessageBox.Show("Course added succesfully!");
                            Display_Data();
                            cmbfaculty.Focus();
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
                string sql = "SELECT * FROM table_generated";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                myReader = cmd.ExecuteReader();
                lstview.Columns.Add("Day", 50);
                lstview.Columns.Add("Department", 300);
                lstview.Columns.Add("Class", 200);
                lstview.Columns.Add("Course", 200);
               // lstview.Columns.Add("Day", 50);
                lstview.Columns.Add("Venue", 200);
                lstview.Columns.Add("Start Time", 100);
                lstview.Columns.Add("End Time", 100);
                while (myReader.Read())
                {
                    ListViewItem LV1 = lstview.Items.Add(myReader["day"].ToString());
                    LV1.SubItems.Add(myReader["department"].ToString());
                    LV1.SubItems.Add(myReader["prog"].ToString());
                    LV1.SubItems.Add(myReader["course"].ToString());
                  //  LV1.SubItems.Add(myReader["day"].ToString());
                    LV1.SubItems.Add(myReader["room"].ToString());
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
        private void btnexp_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sdf = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
            {
                if (sdf.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Day";
                    ws.Cells[1, 2] = "Department";
                    ws.Cells[1, 3] = "Class";
                    ws.Cells[1, 4] = "Room";
                    ws.Cells[1, 5] = "Venue";
                    ws.Cells[1, 6] = "Start Time";
                    ws.Cells[1, 7] = "End Time";
                    int i = 2;
                    foreach (ListViewItem item in lstview.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 6] = item.SubItems[5].Text;
                        ws.Cells[i, 7] = item.SubItems[6].Text;
                        i++;
                    }
                    wb.SaveAs(sdf.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Data exported successfully");
                }
            }
        }
        private void Display_day()
        {
            cmdday.Items.Add("Monday");
            cmdday.Items.Add("Tuesday");
            cmdday.Items.Add("Wednesday");
            cmdday.Items.Add("Thursday");
            cmdday.Items.Add("Friday");
            cmdday.Items.Add("Saturday");
        }
         private void Diplay_prog()
         {
         cmdprog.Items.Add("ND1 PT");
         cmdprog.Items.Add("ND2 PT");
         cmdprog.Items.Add("ND1 FT");
         cmdprog.Items.Add("ND2 FT");
         cmdprog.Items.Add("HND 1");
         cmdprog.Items.Add("HND 2");
         }

        private void frmtimetable_Load(object sender, EventArgs e)
        {
            Display_faculty();
            Display_course();
            Display_room();
            Display_start();
            Display_end();
            Display_day();
            Display_department();
            Diplay_prog();
            Display_Data();

            cmbfaculty.SelectedIndex = 0;
            cmbcourse.SelectedIndex = 0;
            cmbroom.SelectedIndex = 0;
            cmbstart.SelectedIndex = 0;
            cmbend.SelectedIndex = 0;
            cmdday.SelectedIndex = 0;
            cmddept.SelectedIndex = 0;
            cmdprog.SelectedIndex = 0;
        }

        private void lstview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void btnexport_Click(object sender, EventArgs e)
        {

            try
            {

                MySqlDataReader myReader;
                connection connect = new connection();
                string sql = "DELETE FROM table_generated Where faculty =  'School of Applied Science'";
                MySqlCommand cmd = new MySqlCommand(sql, connect.con);
                connect.opencon();
                myReader = cmd.ExecuteReader();
                connect.closecon();
                MessageBox.Show("Faculty deleted succesfully!");
                Display_Data();
                showData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void showData()
        {
            //connection connect = new connection();
            //connect.opencon();
            //string sql = "SELECT * FROM table_generated";
            //adpt = new MySqlDataAdapter(sql, connect.con);
            //dt = new DataTable();
            //adpt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //connect.closecon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ppdListView.ShowDialog();
           // printDocument1.Print();

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Bitmap bm = new Bitmap(this.lstview.Width, this.lstview.Height);
            lstview.DrawToBitmap (bm, new System.Drawing.Rectangle(0, 0, this.lstview.Width, this.lstview.Height));
            e.Graphics.DrawImage(bm, 0, 0);
             //Print the ListView.
            //lstview.PrintData(e.MarginBounds.Location,
            //    e.Graphics, Brushes.Blue,
            //    Brushes.Black, Pens.Blue);
        }
        // Print the ListView's data at the indicated location
        // assuming everything will fit within the column widths.
        //public  void PrintData(this ListView lvw, System.Drawing.Point location,
        //    Graphics gr, Brush header_brush, Brush data_brush, Pen grid_pen)
        //{
        //    const int x_margin = 5;
        //    const int y_margin = 3;
        //    float x = location.X;
        //    float y = location.Y;

        //    // See how tall rows should be.
        //    SizeF row_size = gr.MeasureString(lvw.Columns[0].Text, lvw.Font);
        //    int row_height = (int)row_size.Height + 2 * y_margin;

        //    // Get the screen's horizontal resolution.
        //    float screen_res_x;
        //    using (Graphics screen_gr = lvw.CreateGraphics())
        //    {
        //        screen_res_x = screen_gr.DpiX;
        //    }

        //    // Scale factor to convert from screen pixels
        //    // to printer units (100ths of inches).
        //    float screen_to_printer = 100 / screen_res_x;

        //    // Get the column widths in printer dots.
        //    float[] col_wids = new float[lvw.Columns.Count];
        //    for (int i = 0; i < lvw.Columns.Count; i++)
        //        col_wids[i] = (lvw.Columns[i].Width + 4 * x_margin) *
        //            screen_to_printer;

        //    int num_columns = lvw.Columns.Count;
        //    using (StringFormat string_format = new StringFormat())
        //    {
        //        // Draw the column headers.
        //        string_format.Alignment = StringAlignment.Center;
        //        string_format.LineAlignment = StringAlignment.Center;
        //        for (int i = 0; i < num_columns; i++)
        //        {
        //            RectangleF rect = new RectangleF(
        //                x + x_margin,
        //                y + y_margin,
        //                col_wids[i] - x_margin,
        //                row_height - y_margin);
        //            gr.DrawString(lvw.Columns[i].Text,
        //                lvw.Font, header_brush, rect, string_format);
        //            rect = new RectangleF(x, y, col_wids[i], row_height);
        //            gr.DrawRectangle(grid_pen, x, y, col_wids[i], row_height);
        //            x += col_wids[i];
        //        }
        //        y += row_height;

        //        // Draw the data.
        //        foreach (ListViewItem item in lvw.Items)
        //        {
        //            x = location.X;
        //            for (int i = 0; i < num_columns; i++)
        //            {
        //                RectangleF rect = new RectangleF(
        //                    x + x_margin, y,
        //                    col_wids[i] - x_margin, row_height);

        //                switch (lvw.Columns[i].TextAlign)
        //                {
        //                    case HorizontalAlignment.Left:
        //                        string_format.Alignment = StringAlignment.Near;
        //                        break;
        //                    case HorizontalAlignment.Center:
        //                        string_format.Alignment = StringAlignment.Center;
        //                        break;
        //                    case HorizontalAlignment.Right:
        //                        string_format.Alignment = StringAlignment.Far;
        //                        break;
        //                }

        //                gr.DrawString(item.SubItems[i].Text,
        //                    lvw.Font, header_brush, rect, string_format);
        //                rect = new RectangleF(x, y, col_wids[i], row_height);
        //                gr.DrawRectangle(grid_pen, x, y, col_wids[i], row_height);
        //                x += col_wids[i];
        //            }
        //            y += row_height;
        //        }
        //    }
        //}

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //// Start maximized.
            //Form frm = ppdListView as Form;
            //frm.WindowState = FormWindowState.Maximized;

            //// Start at 100% scale.
            //ppdListView.PrintPreviewControl.Zoom = 1.0;

            //// Display.
            //ppdListView.ShowDialog();
        }

        
       

            
        
    }
        
}
