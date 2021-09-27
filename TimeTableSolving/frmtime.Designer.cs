namespace TimeTableSolving
{
    partial class frmtime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeend = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timestart = new System.Windows.Forms.DateTimePicker();
            this.lstview = new System.Windows.Forms.ListView();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(163, 175);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 33);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 48);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "You will asign Time here";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.timeend);
            this.panel2.Location = new System.Drawing.Point(41, 134);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.panel2.Size = new System.Drawing.Size(225, 35);
            this.panel2.TabIndex = 16;
            // 
            // timeend
            // 
            this.timeend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeend.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeend.Location = new System.Drawing.Point(2, 8);
            this.timeend.Name = "timeend";
            this.timeend.ShowUpDown = true;
            this.timeend.Size = new System.Drawing.Size(219, 23);
            this.timeend.TabIndex = 15;
            this.timeend.Value = new System.DateTime(2019, 6, 10, 4, 48, 0, 0);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.timestart);
            this.panel5.Location = new System.Drawing.Point(41, 93);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.panel5.Size = new System.Drawing.Size(225, 35);
            this.panel5.TabIndex = 17;
            // 
            // timestart
            // 
            this.timestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timestart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timestart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timestart.Location = new System.Drawing.Point(2, 8);
            this.timestart.Name = "timestart";
            this.timestart.ShowUpDown = true;
            this.timestart.Size = new System.Drawing.Size(219, 23);
            this.timestart.TabIndex = 14;
            this.timestart.Value = new System.DateTime(2019, 6, 10, 4, 48, 0, 0);
            // 
            // lstview
            // 
            this.lstview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstview.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstview.FullRowSelect = true;
            this.lstview.GridLines = true;
            this.lstview.HoverSelection = true;
            this.lstview.Location = new System.Drawing.Point(272, 93);
            this.lstview.Name = "lstview";
            this.lstview.Size = new System.Drawing.Size(312, 224);
            this.lstview.TabIndex = 21;
            this.lstview.UseCompatibleStateImageBehavior = false;
            this.lstview.View = System.Windows.Forms.View.Details;
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(162)))), ((int)(((byte)(64)))));
            this.btnadd.Location = new System.Drawing.Point(41, 175);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 33);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(162)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(445, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Lecture Time List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(162)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(37, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Add New Time";
            // 
            // pic1
            // 
            this.pic1.Image = global::TimeTableSolving.Properties.Resources.images__1_;
            this.pic1.Location = new System.Drawing.Point(654, 2);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(52, 43);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 23;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // frmtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 385);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lstview);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmtime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmtime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker timeend;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DateTimePicker timestart;
        public System.Windows.Forms.ListView lstview;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic1;
    }
}