namespace LibrarySystem
{
    partial class BookGuestViewUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbbooks = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblauthor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbbooks)).BeginInit();
            this.SuspendLayout();
            // 
            // pbbooks
            // 
            this.pbbooks.Location = new System.Drawing.Point(3, 3);
            this.pbbooks.Name = "pbbooks";
            this.pbbooks.Size = new System.Drawing.Size(106, 116);
            this.pbbooks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbooks.TabIndex = 0;
            this.pbbooks.TabStop = false;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.Location = new System.Drawing.Point(115, 16);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(42, 20);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Title:";
            // 
            // lblauthor
            // 
            this.lblauthor.AutoSize = true;
            this.lblauthor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblauthor.Location = new System.Drawing.Point(115, 45);
            this.lblauthor.Name = "lblauthor";
            this.lblauthor.Size = new System.Drawing.Size(46, 13);
            this.lblauthor.TabIndex = 2;
            this.lblauthor.Text = "Author:";
            // 
            // BookGuestViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblauthor);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.pbbooks);
            this.Name = "BookGuestViewUserControl";
            this.Size = new System.Drawing.Size(400, 122);
            this.Load += new System.EventHandler(this.BookGuestViewUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbbooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbbooks;
        private Label lbltitle;
        private Label lblauthor;
    }
}
