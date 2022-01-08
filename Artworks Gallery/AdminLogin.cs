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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameInput.Text.Trim();
            string password = this.passwordInput.Text.Trim();

            try
            {
                SqlConnection connection = DatabaseHelper.initDb();

                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM admin WHERE username = @uname;", connection);
                command.Parameters.AddWithValue("@uname", username);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (password == reader[1].ToString())
                    {
                        connection.Close();
                        this.Hide();
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong login creadentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong login credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
