using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
// using Npgsql;
// using Register_System;

namespace Login_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        // NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
        // NpgsqlCommand cmd = new NpgsqlCommand();
        // NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        private void inputRedirect_Click(object sender, EventArgs e)
        {
            // new RegisterForm().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
/*            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string login = ("SELECT * FROM csharp_user WHERE username =  '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "' ");
            cmd = new NpgsqlCommand(login, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();*/


/*            if (dr.Read() == true)
            {
                conn.Close();
                new Dashboard().Show();
                Dashboard.instance.lbl.Text = txtUsername.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, please try Again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }*/
        }
    }
}