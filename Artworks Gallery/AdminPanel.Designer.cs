
namespace Artworks_Gallery
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.adminTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.saveArtworkBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.materialsInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dimensionsInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimensions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteAllDataBtn = new System.Windows.Forms.Button();
            this.reloadDataBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.newPassInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminTitle
            // 
            this.adminTitle.AutoSize = true;
            this.adminTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.adminTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTitle.Location = new System.Drawing.Point(12, 19);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Padding = new System.Windows.Forms.Padding(10);
            this.adminTitle.Size = new System.Drawing.Size(121, 38);
            this.adminTitle.TabIndex = 1;
            this.adminTitle.Text = "Admin Panel";
            this.adminTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Controls.Add(this.pbPreview);
            this.groupBox1.Controls.Add(this.saveArtworkBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.categoryInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.materialsInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dimensionsInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 429);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD ARTWORKS";
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.browseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.ForeColor = System.Drawing.Color.White;
            this.browseBtn.Location = new System.Drawing.Point(241, 233);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(96, 36);
            this.browseBtn.TabIndex = 12;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Location = new System.Drawing.Point(85, 177);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(150, 150);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 11;
            this.pbPreview.TabStop = false;
            // 
            // saveArtworkBtn
            // 
            this.saveArtworkBtn.BackColor = System.Drawing.Color.Tomato;
            this.saveArtworkBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveArtworkBtn.FlatAppearance.BorderSize = 0;
            this.saveArtworkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveArtworkBtn.ForeColor = System.Drawing.Color.White;
            this.saveArtworkBtn.Location = new System.Drawing.Point(85, 355);
            this.saveArtworkBtn.Name = "saveArtworkBtn";
            this.saveArtworkBtn.Size = new System.Drawing.Size(168, 42);
            this.saveArtworkBtn.TabIndex = 10;
            this.saveArtworkBtn.Text = "Save Artwork Data";
            this.saveArtworkBtn.UseVisualStyleBackColor = false;
            this.saveArtworkBtn.Click += new System.EventHandler(this.saveArtworkBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Image";
            // 
            // categoryInput
            // 
            this.categoryInput.Location = new System.Drawing.Point(85, 141);
            this.categoryInput.Multiline = true;
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(252, 30);
            this.categoryInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category";
            // 
            // materialsInput
            // 
            this.materialsInput.Location = new System.Drawing.Point(85, 105);
            this.materialsInput.Multiline = true;
            this.materialsInput.Name = "materialsInput";
            this.materialsInput.Size = new System.Drawing.Size(252, 30);
            this.materialsInput.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Materials";
            // 
            // dimensionsInput
            // 
            this.dimensionsInput.Location = new System.Drawing.Point(85, 69);
            this.dimensionsInput.Multiline = true;
            this.dimensionsInput.Name = "dimensionsInput";
            this.dimensionsInput.Size = new System.Drawing.Size(252, 30);
            this.dimensionsInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dimensions";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(85, 33);
            this.titleInput.Multiline = true;
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(252, 30);
            this.titleInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.dataView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(361, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARTWORKS DATA";
            // 
            // dataView
            // 
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Title,
            this.Dimensions,
            this.Materials,
            this.Category});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataView.GridColor = System.Drawing.SystemColors.Control;
            this.dataView.Location = new System.Drawing.Point(6, 28);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataView.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataView.RowTemplate.Height = 3;
            this.dataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView.ShowEditingIcon = false;
            this.dataView.Size = new System.Drawing.Size(640, 293);
            this.dataView.TabIndex = 0;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            this.dataView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellDoubleClick);
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Image.DataPropertyName = "image";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.Image.DefaultCellStyle = dataGridViewCellStyle2;
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 127;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Dimensions
            // 
            this.Dimensions.DataPropertyName = "dimensions";
            this.Dimensions.HeaderText = "Dimensions";
            this.Dimensions.Name = "Dimensions";
            this.Dimensions.ReadOnly = true;
            // 
            // Materials
            // 
            this.Materials.DataPropertyName = "materials";
            this.Materials.HeaderText = "Materials";
            this.Materials.Name = "Materials";
            this.Materials.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "From here you can add your artwroks, view and manage data and delete them.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox3.Controls.Add(this.deleteAllDataBtn);
            this.groupBox3.Controls.Add(this.reloadDataBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(658, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 66);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACTIONS";
            // 
            // deleteAllDataBtn
            // 
            this.deleteAllDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAllDataBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteAllDataBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteAllDataBtn.FlatAppearance.BorderSize = 0;
            this.deleteAllDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllDataBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllDataBtn.Location = new System.Drawing.Point(188, 23);
            this.deleteAllDataBtn.Name = "deleteAllDataBtn";
            this.deleteAllDataBtn.Size = new System.Drawing.Size(161, 37);
            this.deleteAllDataBtn.TabIndex = 1;
            this.deleteAllDataBtn.Text = "Delete All Data";
            this.deleteAllDataBtn.UseVisualStyleBackColor = false;
            this.deleteAllDataBtn.Click += new System.EventHandler(this.deleteAllDataBtn_Click);
            // 
            // reloadDataBtn
            // 
            this.reloadDataBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.reloadDataBtn.FlatAppearance.BorderSize = 0;
            this.reloadDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadDataBtn.ForeColor = System.Drawing.Color.White;
            this.reloadDataBtn.Location = new System.Drawing.Point(6, 23);
            this.reloadDataBtn.Name = "reloadDataBtn";
            this.reloadDataBtn.Size = new System.Drawing.Size(176, 37);
            this.reloadDataBtn.TabIndex = 0;
            this.reloadDataBtn.Text = "Reload Artworks Data";
            this.reloadDataBtn.UseVisualStyleBackColor = false;
            this.reloadDataBtn.Click += new System.EventHandler(this.reloadDataBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox4.Controls.Add(this.changePassBtn);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(361, 428);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(646, 96);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CHANGE ADMIN PASSWORD";
            // 
            // changePassBtn
            // 
            this.changePassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePassBtn.BackColor = System.Drawing.Color.Tomato;
            this.changePassBtn.FlatAppearance.BorderSize = 0;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.ForeColor = System.Drawing.Color.White;
            this.changePassBtn.Location = new System.Drawing.Point(435, 41);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(146, 40);
            this.changePassBtn.TabIndex = 1;
            this.changePassBtn.Text = "Change Password";
            this.changePassBtn.UseVisualStyleBackColor = false;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox5.Controls.Add(this.newPassInput);
            this.groupBox5.Location = new System.Drawing.Point(6, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(411, 48);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New Password";
            // 
            // newPassInput
            // 
            this.newPassInput.BackColor = System.Drawing.Color.MistyRose;
            this.newPassInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPassInput.Location = new System.Drawing.Point(6, 20);
            this.newPassInput.Name = "newPassInput";
            this.newPassInput.Size = new System.Drawing.Size(399, 14);
            this.newPassInput.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 536);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adminTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveArtworkBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox categoryInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox materialsInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dimensionsInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteAllDataBtn;
        private System.Windows.Forms.Button reloadDataBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox newPassInput;
    }
}