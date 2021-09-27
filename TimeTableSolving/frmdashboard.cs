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
    public partial class frmdashboard : Form
    {
        public frmdashboard()
        {
            InitializeComponent();
        }

        private void btnfacult_Click(object sender, EventArgs e)
        {
            frmfaculty ad = new frmfaculty();
            //ad.StartPosition = FormStartPosition.Manual;
            //ad.Location = new Point(350, 100);
            ad.Show();
        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            frmcourse ad = new frmcourse();
            //ad.StartPosition = FormStartPosition.Manual;
            //ad.Location = new Point(350, 100);
            ad.Show();
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            frmroom ad = new frmroom();
            //ad.StartPosition = FormStartPosition.Manual;
            //ad.Location = new Point(350, 100);
            ad.Show();
        }

        private void btntime_Click(object sender, EventArgs e)
        {
            frmtime ad = new frmtime();
            //ad.StartPosition = FormStartPosition.Manual;
            //ad.Location = new Point(350, 100);
            ad.Show();
        }

        private void btntimetable_Click(object sender, EventArgs e)
        {
            frmtimetable ad = new frmtimetable();
            ad.StartPosition = FormStartPosition.Manual;
            ad.Location = new Point(227, 100);
            ad.Show();
        }

        private void frmdashboard_Load(object sender, EventArgs e)
        {
            //pan.Top = 150;
            //pan.Left = 350;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmdepartment ad = new frmdepartment();
            //ad.StartPosition = FormStartPosition.Manual;
            //ad.Location = new Point(227, 100);
            ad.Show();
        }
    }
}
