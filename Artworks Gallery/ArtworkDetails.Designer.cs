
namespace Artworks_Gallery
{
    partial class ArtworkDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtworkDetails));
            this.detailsTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dataCat = new System.Windows.Forms.Label();
            this.dataMat = new System.Windows.Forms.Label();
            this.dataDim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataTitle = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbLargePreview = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.dataLayout.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLargePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // detailsTitle
            // 
            this.detailsTitle.AutoSize = true;
            this.detailsTitle.BackColor = System.Drawing.Color.Tomato;
            this.detailsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsTitle.ForeColor = System.Drawing.Color.White;
            this.detailsTitle.Location = new System.Drawing.Point(12, 18);
            this.detailsTitle.Name = "detailsTitle";
            this.detailsTitle.Padding = new System.Windows.Forms.Padding(10);
            this.detailsTitle.Size = new System.Drawing.Size(143, 38);
            this.detailsTitle.TabIndex = 0;
            this.detailsTitle.Text = "Artwork Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.groupBox1.Controls.Add(this.dataLayout);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(583, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 463);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARTWORK DATA";
            // 
            // dataLayout
            // 
            this.dataLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLayout.AutoSize = true;
            this.dataLayout.ColumnCount = 2;
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.dataLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.dataLayout.Controls.Add(this.dataCat, 1, 3);
            this.dataLayout.Controls.Add(this.dataMat, 1, 2);
            this.dataLayout.Controls.Add(this.dataDim, 1, 1);
            this.dataLayout.Controls.Add(this.label1, 0, 0);
            this.dataLayout.Controls.Add(this.label2, 0, 1);
            this.dataLayout.Controls.Add(this.label3, 0, 2);
            this.dataLayout.Controls.Add(this.label4, 0, 3);
            this.dataLayout.Controls.Add(this.dataTitle, 1, 0);
            this.dataLayout.Location = new System.Drawing.Point(7, 20);
            this.dataLayout.Name = "dataLayout";
            this.dataLayout.Padding = new System.Windows.Forms.Padding(5);
            this.dataLayout.RowCount = 4;
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.dataLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.dataLayout.Size = new System.Drawing.Size(403, 307);
            this.dataLayout.TabIndex = 0;
            // 
            // dataCat
            // 
            this.dataCat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCat.AutoSize = true;
            this.dataCat.Location = new System.Drawing.Point(125, 155);
            this.dataCat.Name = "dataCat";
            this.dataCat.Size = new System.Drawing.Size(270, 15);
            this.dataCat.TabIndex = 7;
            this.dataCat.Text = "label8";
            // 
            // dataMat
            // 
            this.dataMat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataMat.AutoSize = true;
            this.dataMat.Location = new System.Drawing.Point(125, 105);
            this.dataMat.Name = "dataMat";
            this.dataMat.Size = new System.Drawing.Size(270, 15);
            this.dataMat.TabIndex = 6;
            this.dataMat.Text = "label7";
            // 
            // dataDim
            // 
            this.dataDim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataDim.AutoSize = true;
            this.dataDim.Location = new System.Drawing.Point(125, 55);
            this.dataDim.Name = "dataDim";
            this.dataDim.Size = new System.Drawing.Size(270, 15);
            this.dataDim.TabIndex = 5;
            this.dataDim.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artwork Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dimensions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // dataTitle
            // 
            this.dataTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTitle.AutoSize = true;
            this.dataTitle.Location = new System.Drawing.Point(125, 5);
            this.dataTitle.Name = "dataTitle";
            this.dataTitle.Size = new System.Drawing.Size(270, 15);
            this.dataTitle.TabIndex = 4;
            this.dataTitle.Text = "label5";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteBtn.BackColor = System.Drawing.Color.Tomato;
            this.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(135, 396);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(166, 53);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete Artwork";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.pbLargePreview);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 463);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ARTWORK IMAGE";
            // 
            // pbLargePreview
            // 
            this.pbLargePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLargePreview.BackColor = System.Drawing.Color.Transparent;
            this.pbLargePreview.Location = new System.Drawing.Point(6, 20);
            this.pbLargePreview.Name = "pbLargePreview";
            this.pbLargePreview.Size = new System.Drawing.Size(553, 437);
            this.pbLargePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLargePreview.TabIndex = 2;
            this.pbLargePreview.TabStop = false;
            // 
            // ArtworkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1011, 552);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.detailsTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArtworkDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artwork Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.dataLayout.ResumeLayout(false);
            this.dataLayout.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLargePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label detailsTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel dataLayout;
        private System.Windows.Forms.Label dataCat;
        private System.Windows.Forms.Label dataMat;
        private System.Windows.Forms.Label dataDim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dataTitle;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbLargePreview;
    }
}