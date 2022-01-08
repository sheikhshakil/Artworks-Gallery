using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Artworks_Gallery
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
            this.dataView.EnableHeadersVisualStyles = false;
            showData();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            Stream imgStream = null;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image File(*.jpe; *.jpeg; *.jpg; *.png; *.bmp) | *.jpg; *.jpeg; *.bmp; *.png";

            if(fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if((imgStream = fileDialog.OpenFile()) != null)
                    {
                        string fileName = fileDialog.FileName;
                        this.pbPreview.Load(fileName);
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Some error occured. Code AD46!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveArtworkBtn_Click(object sender, EventArgs e)
        {
            if(this.titleInput.Text.Trim().Length < 1 || pbPreview == null || pbPreview.Image == null)
            {
                MessageBox.Show("ID, Title and Image are required!", "Error");
                return;
            }

            try
            {
                SqlConnection connection = DatabaseHelper.initDb();

                SqlCommand command = new SqlCommand("INSERT INTO artworks (title, dimensions, materials, category, image) VALUES(@title, @dimensions, @materials, @category, @image);", connection);

                command.Parameters.AddWithValue("@title", this.titleInput.Text.Trim());
                command.Parameters.AddWithValue("@dimensions", this.dimensionsInput.Text.Trim());
                command.Parameters.AddWithValue("@materials", this.materialsInput.Text.Trim());
                command.Parameters.AddWithValue("@category", this.categoryInput.Text.Trim());

                MemoryStream stream = new MemoryStream();
                pbPreview.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] image = stream.ToArray();
                command.Parameters.AddWithValue("@image", image);

                connection.Open();
                int row = command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Successfully saved your artwork data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                showData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showData()
        {
            using(SqlConnection connection = DatabaseHelper.initDb())
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM artworks;", connection);
                DataTable dataTable = new DataTable("artworks");

                adapter.Fill(dataTable);
                this.dataView.DataSource = dataTable;
                connection.Close();
            }
        }

        private void dataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && this.dataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                showArtworkDetails(e);
            }
            return;
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                showArtworkDetails(e);
            }
            return;
        }

        private void showArtworkDetails(DataGridViewCellEventArgs e)
        {
            if (this.dataView.Rows[e.RowIndex].Cells["Image"].Value == DBNull.Value)
            {
                return;
            }
            string title = this.dataView.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
            string dim = this.dataView.Rows[e.RowIndex].Cells["Dimensions"].FormattedValue.ToString();
            string mat = this.dataView.Rows[e.RowIndex].Cells["Materials"].FormattedValue.ToString();
            string cat = this.dataView.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();
            
            byte[] img = (byte[])this.dataView.Rows[e.RowIndex].Cells["Image"].Value;
            ArtworkDetails details = new ArtworkDetails(title, dim, mat, cat, img, isAdmin:true);
            details.ShowDialog();
        }

        private void reloadDataBtn_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void deleteAllDataBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("All data from database will be deleted! Are your sure?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                try
                {
                    using(SqlConnection connection = DatabaseHelper.initDb())
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM artworks;", connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Successfully deleted all data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showData();
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                return;
            }
        }
        private void changePassBtn_Click(object sender, EventArgs e)
        {
            string newPass = this.newPassInput.Text.Trim();
            if(newPass.Length >=3)
            {
                try
                {
                    using(SqlConnection connection = DatabaseHelper.initDb())
                    {
                        if (connection.State == ConnectionState.Closed)
                            connection.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE admin SET password = @newPass WHERE username = @username;", connection);
                        cmd.Parameters.AddWithValue("@newPass", newPass);
                        cmd.Parameters.AddWithValue("@username", "admin");

                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Successfully updated your password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Minimum 5 character password required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
