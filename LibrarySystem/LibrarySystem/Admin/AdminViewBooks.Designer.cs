namespace LibrarySystem.Admin
{
    partial class AdminViewBooks
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
            this.flowLayoutPanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbprofile = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnupdateoradd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbprofile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanelBooks);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(160, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 281);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanelBooks
            // 
            this.flowLayoutPanelBooks.AutoScroll = true;
            this.flowLayoutPanelBooks.Location = new System.Drawing.Point(0, 99);
            this.flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            this.flowLayoutPanelBooks.Size = new System.Drawing.Size(423, 182);
            this.flowLayoutPanelBooks.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(183, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOOKS";
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
            this.btnbooks.TabIndex = 9;
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
            this.btnupdateoradd.TabIndex = 10;
            this.btnupdateoradd.Text = "Update / Add";
            this.btnupdateoradd.UseVisualStyleBackColor = true;
            this.btnupdateoradd.Click += new System.EventHandler(this.btnupdateoradd_Click);
            // 
            // AdminViewBooks
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
            this.Name = "AdminViewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminViewBooks";
            this.Load += new System.EventHandler(this.AdminViewBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Label label3;
        private FlowLayoutPanel flowLayoutPanelBooks;
    }
}