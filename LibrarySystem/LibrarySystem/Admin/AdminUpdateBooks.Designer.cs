namespace LibrarySystem.Admin
{
    partial class AdminUpdateBooks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnchoose = new System.Windows.Forms.Button();
            this.lblfilename = new System.Windows.Forms.Label();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblupdate = new System.Windows.Forms.Label();
            this.lbladd = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnupdateoradd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btnchoose);
            this.panel1.Controls.Add(this.lblfilename);
            this.panel1.Controls.Add(this.pbimage);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblupdate);
            this.panel1.Controls.Add(this.lbladd);
            this.panel1.Location = new System.Drawing.Point(160, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 281);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(273, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(93, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Title";
            // 
            // btnupdate
            // 
            this.btnupdate.Enabled = false;
            this.btnupdate.Location = new System.Drawing.Point(283, 244);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(55, 23);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(355, 244);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(55, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnchoose
            // 
            this.btnchoose.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnchoose.Location = new System.Drawing.Point(165, 190);
            this.btnchoose.Name = "btnchoose";
            this.btnchoose.Size = new System.Drawing.Size(75, 23);
            this.btnchoose.TabIndex = 7;
            this.btnchoose.Text = "Choose File:";
            this.btnchoose.UseVisualStyleBackColor = true;
            this.btnchoose.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfilename.Location = new System.Drawing.Point(59, 222);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(85, 13);
            this.lblfilename.TabIndex = 6;
            this.lblfilename.Text = "No File Chosen";
            // 
            // pbimage
            // 
            this.pbimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbimage.Location = new System.Drawing.Point(59, 134);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(100, 79);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 5;
            this.pbimage.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 23);
            this.textBox1.TabIndex = 3;
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblupdate.Location = new System.Drawing.Point(185, 9);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(72, 21);
            this.lblupdate.TabIndex = 2;
            this.lblupdate.Text = "UPDATE";
            this.lblupdate.Visible = false;
            // 
            // lbladd
            // 
            this.lbladd.AutoSize = true;
            this.lbladd.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbladd.Location = new System.Drawing.Point(199, 9);
            this.lbladd.Name = "lbladd";
            this.lbladd.Size = new System.Drawing.Size(45, 21);
            this.lbladd.TabIndex = 1;
            this.lbladd.Text = "ADD";
            // 
            // pblogo
            // 
            this.pblogo.Location = new System.Drawing.Point(5, 5);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(28, 26);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 1;
            this.pblogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Library System";
            // 
            // pbprofile
            // 
            this.pbprofile.Location = new System.Drawing.Point(22, 63);
            this.pbprofile.Name = "pbprofile";
            this.pbprofile.Size = new System.Drawing.Size(114, 81);
            this.pbprofile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbprofile.TabIndex = 3;
            this.pbprofile.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlogout.Location = new System.Drawing.Point(114, 293);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(40, 23);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin";
            // 
            // btnbooks
            // 
            this.btnbooks.FlatAppearance.BorderSize = 0;
            this.btnbooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbooks.Location = new System.Drawing.Point(0, 196);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(161, 35);
            this.btnbooks.TabIndex = 8;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // btnupdateoradd
            // 
            this.btnupdateoradd.FlatAppearance.BorderSize = 0;
            this.btnupdateoradd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateoradd.Location = new System.Drawing.Point(0, 229);
            this.btnupdateoradd.Name = "btnupdateoradd";
            this.btnupdateoradd.Size = new System.Drawing.Size(161, 35);
            this.btnupdateoradd.TabIndex = 9;
            this.btnupdateoradd.Text = "Update / Add";
            this.btnupdateoradd.UseVisualStyleBackColor = true;
            this.btnupdateoradd.Click += new System.EventHandler(this.btnupdateoradd_Click);
            // 
            // AdminUpdateBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 339);
            this.Controls.Add(this.btnupdateoradd);
            this.Controls.Add(this.btnbooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.pbprofile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminUpdateBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminUpdateBooks";
            this.Load += new System.EventHandler(this.AdminUpdateBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox pblogo;
        private Label label1;
        private PictureBox pbprofile;
        private Button btnlogout;
        private Label label2;
        private Button btnbooks;
        private Button btnupdateoradd;
        private Label lblupdate;
        private Label lbladd;
        private Button btnupdate;
        private Button btnadd;
        private Button btnchoose;
        private Label lblfilename;
        private PictureBox pbimage;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
    }
}