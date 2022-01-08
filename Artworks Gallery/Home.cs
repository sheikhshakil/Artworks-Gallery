using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Artworks_Gallery
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.visitorBox = new System.Windows.Forms.GroupBox();
            this.visitorLogo = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.visitorIntro = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.intro = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.visitorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // visitorBox
            // 
            this.visitorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitorBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.visitorBox.Controls.Add(this.visitorLogo);
            this.visitorBox.Controls.Add(this.browseBtn);
            this.visitorBox.Controls.Add(this.visitorIntro);
            this.visitorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.visitorBox.Location = new System.Drawing.Point(355, 247);
            this.visitorBox.Name = "visitorBox";
            this.visitorBox.Size = new System.Drawing.Size(521, 291);
            this.visitorBox.TabIndex = 2;
            this.visitorBox.TabStop = false;
            this.visitorBox.Text = "VISITOR SECTION";
            // 
            // visitorLogo
            // 
            this.visitorLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.visitorLogo.Image = global::Artworks_Gallery.Properties.Resources.visitor;
            this.visitorLogo.Location = new System.Drawing.Point(208, 31);
            this.visitorLogo.Name = "visitorLogo";
            this.visitorLogo.Size = new System.Drawing.Size(100, 100);
            this.visitorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.visitorLogo.TabIndex = 2;
            this.visitorLogo.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.browseBtn.BackColor = System.Drawing.Color.Tomato;
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(185, 233);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(148, 40);
            this.browseBtn.TabIndex = 1;
            this.browseBtn.Text = "Browse Artworks";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // visitorIntro
            // 
            this.visitorIntro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.visitorIntro.AutoSize = true;
            this.visitorIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorIntro.Location = new System.Drawing.Point(28, 162);
            this.visitorIntro.Name = "visitorIntro";
            this.visitorIntro.Size = new System.Drawing.Size(472, 40);
            this.visitorIntro.TabIndex = 0;
            this.visitorIntro.Text = "Visitor window showcases my artworks that I\'ve done till now. \r\nClick the below b" +
    "utton to browse them.";
            this.visitorIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(340, 550);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // intro
            // 
            this.intro.AutoSize = true;
            this.intro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intro.ForeColor = System.Drawing.Color.Black;
            this.intro.Location = new System.Drawing.Point(21, 304);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(298, 40);
            this.intro.TabIndex = 8;
            this.intro.Text = "My various artworks are containerized \r\nin this app.";
            this.intro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Tomato;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(19, 232);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(10);
            this.title.Size = new System.Drawing.Size(302, 59);
            this.title.TabIndex = 7;
            this.title.Text = "Artworks Gallery";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.DoubleClick += new System.EventHandler(this.title_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox2.Image = global::Artworks_Gallery.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(109, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(890, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.title);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.visitorBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artworks Gallery";
            this.visitorBox.ResumeLayout(false);
            this.visitorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitorLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            VisitorSection visitorSection = new VisitorSection();
            visitorSection.ShowDialog();
        }

        private void title_DoubleClick(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();
            login.ShowDialog();
        }
    }
}
