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
    public partial class VisitorSection : Form
    {
        public VisitorSection()
        {
            InitializeComponent();
            this.visitorDataView.EnableHeadersVisualStyles = false;
            showData();
        }

        private void showData()
        {
            using (SqlConnection connection = DatabaseHelper.initDb())
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM artworks;", connection);
                DataTable table = new DataTable("Artworks");

                adapter.Fill(table);
                this.visitorDataView.DataSource = table;
                connection.Close();
            }
        }

        private void visitorDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && this.visitorDataView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                showArtworkDetails(e);
            }
            return;
        }

        private void visitorDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                showArtworkDetails(e);
            }
            return;
        }

        private void showArtworkDetails(DataGridViewCellEventArgs e)
        {
            if (this.visitorDataView.Rows[e.RowIndex].Cells["Image"].Value == DBNull.Value)
            {
                return;
            }
            string title = this.visitorDataView.Rows[e.RowIndex].Cells["Title"].FormattedValue.ToString();
            string dim = this.visitorDataView.Rows[e.RowIndex].Cells["Dimensions"].FormattedValue.ToString();
            string mat = this.visitorDataView.Rows[e.RowIndex].Cells["Materials"].FormattedValue.ToString();
            string cat = this.visitorDataView.Rows[e.RowIndex].Cells["Category"].FormattedValue.ToString();

            byte[] img = (byte[])this.visitorDataView.Rows[e.RowIndex].Cells["Image"].Value;
            ArtworkDetails details = new ArtworkDetails(title, dim, mat, cat, img);
            details.ShowDialog();
        }
    }
}
