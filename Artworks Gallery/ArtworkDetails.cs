using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Artworks_Gallery
{
    public partial class ArtworkDetails : Form
    {
        private string finder;
        public ArtworkDetails(string title, string dim, string mat, string cat, byte[] img, bool isAdmin = false)
        {
            InitializeComponent();
            if(isAdmin)
            {
                finder = title;
                this.deleteBtn.Visible = true;
            }
            this.dataTitle.Text = title;
            this.dataDim.Text = dim;
            this.dataMat.Text = mat;
            this.dataCat.Text = cat;

            this.pbLargePreview.Image = byteToImage(img);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = DatabaseHelper.initDb())
            {
               try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM artworks WHERE title = @title;", connection);
                    cmd.Parameters.AddWithValue("@title", finder);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Bitmap byteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
