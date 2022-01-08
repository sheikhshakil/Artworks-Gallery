using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Artworks_Gallery
{
    class DatabaseHelper
    {
        public static SqlConnection initDb()
        {
            string cnstr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\ArtworksGalleryData\\Database.mdf\";Integrated Security=True";

            SqlConnection connection = new SqlConnection(cnstr);

            return connection;
        }
    }
}
