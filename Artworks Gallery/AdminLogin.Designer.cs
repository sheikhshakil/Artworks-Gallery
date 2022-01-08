
namespace Artworks_Gallery
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.adminBox = new System.Windows.Forms.GroupBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.adminLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adminBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // adminBox
            // 
            this.adminBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminBox.Controls.Add(this.loginBtn);
            this.adminBox.Controls.Add(this.groupBox2);
            this.adminBox.Controls.Add(this.groupBox1);
            this.adminBox.Controls.Add(this.adminLogo);
            this.adminBox.Font = new System.Drawing.Font("Arial", 9F);
            this.adminBox.Location = new System.Drawing.Point(76, 84);
            this.adminBox.Name = "adminBox";
            this.adminBox.Size = new System.Drawing.Size(475, 291);
            this.adminBox.TabIndex = 4;
            this.adminBox.TabStop = false;
            this.adminBox.Text = "ADMIN PANEL";
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginBtn.BackColor = System.Drawing.Color.Tomato;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(163, 233);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(171, 40);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login to Admin Panel";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.passwordInput);
            this.groupBox2.Location = new System.Drawing.Point(25, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 45);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PASSWORD";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.SeaShell;
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Location = new System.Drawing.Point(6, 21);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(414, 14);
            this.passwordInput.TabIndex = 0;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.usernameInput);
            this.groupBox1.Location = new System.Drawing.Point(25, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USERNAME";
            // 
            // usernameInput
            // 
            this.usernameInput.BackColor = System.Drawing.Color.SeaShell;
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameInput.Location = new System.Drawing.Point(6, 21);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(414, 14);
            this.usernameInput.TabIndex = 0;
            // 
            // adminLogo
            // 
            this.adminLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adminLogo.Image = global::Artworks_Gallery.Properties.Resources.admin;
            this.adminLogo.Location = new System.Drawing.Point(211, 31);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(80, 80);
            this.adminLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminLogo.TabIndex = 3;
            this.adminLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 26);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(163, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Panel Login";
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(630, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Admin Panel";
            this.adminBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox adminBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.PictureBox adminLogo;
        private System.Windows.Forms.Label label1;
    }
}