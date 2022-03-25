namespace LibrarySystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pbusername = new System.Windows.Forms.PictureBox();
            this.pbpassword = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblguest = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbusername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pblogo
            // 
            this.pblogo.Location = new System.Drawing.Point(-1, -1);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(172, 168);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 0;
            this.pblogo.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(248, 37);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(122, 23);
            this.txtusername.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(248, 76);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(122, 23);
            this.txtpassword.TabIndex = 2;
            // 
            // pbusername
            // 
            this.pbusername.Location = new System.Drawing.Point(215, 37);
            this.pbusername.Name = "pbusername";
            this.pbusername.Size = new System.Drawing.Size(32, 27);
            this.pbusername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbusername.TabIndex = 3;
            this.pbusername.TabStop = false;
            // 
            // pbpassword
            // 
            this.pbpassword.Location = new System.Drawing.Point(215, 74);
            this.pbpassword.Name = "pbpassword";
            this.pbpassword.Size = new System.Drawing.Size(32, 27);
            this.pbpassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbpassword.TabIndex = 4;
            this.pbpassword.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(314, 131);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblguest
            // 
            this.lblguest.AutoSize = true;
            this.lblguest.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblguest.Location = new System.Drawing.Point(177, 145);
            this.lblguest.Name = "lblguest";
            this.lblguest.Size = new System.Drawing.Size(50, 12);
            this.lblguest.TabIndex = 6;
            this.lblguest.TabStop = true;
            this.lblguest.Text = "Guest Login";
            this.lblguest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblguest_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 166);
            this.Controls.Add(this.lblguest);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.pbpassword);
            this.Controls.Add(this.pbusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pblogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbusername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbpassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pblogo;
        private TextBox txtusername;
        private TextBox txtpassword;
        private PictureBox pbusername;
        private PictureBox pbpassword;
        private Button btnlogin;
        private LinkLabel lblguest;
    }
}