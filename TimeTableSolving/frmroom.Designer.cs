namespace TimeTableSolving
{
    partial class frmroom
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtroom = new System.Windows.Forms.TextBox();
            this.lstview = new System.Windows.Forms.ListView();
            this.btnadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(176, 119);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 33);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtroom);
            this.panel5.Location = new System.Drawing.Point(51, 83);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2, 8, 2, 0);
            this.panel5.Size = new System.Drawing.Size(225, 35);
            this.panel5.TabIndex = 15;
            // 
            // txtroom
            // 
            this.txtroom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtroom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroom.ForeColor = System.Drawing.Color.Gray;
            this.txtroom.Location = new System.Drawing.Point(2, 8);
            this.txtroom.Name = "txtroom";
            this.txtroom.Size = new System.Drawing.Size(219, 19);
            this.txtroom.TabIndex = 0;
            // 
            // lstview
            // 
            this.lstview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstview.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstview.FullRowSelect = true;
            this.lstview.GridLines = true;
            this.lstview.HoverSelection = true;
            this.lstview.Location = new System.Drawing.Point(282, 83);
            this.lstview.Name = "lstview";
            this.lstview.Size = new System.Drawing.Size(312, 224);
            this.lstview.TabIndex = 19;
            this.lstview.UseCompatibleStateImageBehavior = false;
            this.lstview.View = System.Windows.Forms.View.Details;
            // 
            // btnadd
            // 
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(162)))), ((int)(((byte)(64)))));
            this.btnadd.Location = new System.Drawing.Point(51, 119);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 33);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(162)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(449, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lecture Room List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(162)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(47, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Add New Lecture Room";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pic1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 48);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "You will asign facult here";
            // 
            // pic1
            // 
            this.pic1.Image = global::TimeTableSolving.Properties.Resources.images__1_;
            this.pic1.Location = new System.Drawing.Point(665, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(52, 43);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic1.TabIndex = 6;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 359);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lstview);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmroom_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtroom;
        public System.Windows.Forms.ListView lstview;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic1;
    }
}