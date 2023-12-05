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

namespace Register_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
/*            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            string regiter = ("SELECT * FROM csharp_user WHERE username =  '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "' ");
            cmd = new NpgsqlCommand(register, conn);
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
                MessageBox.Show("Invalid Credentials, please try Again.", "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                if (conn != null && conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }*/
        }

        private void labelRedirect_Click(object sender, EventArgs e)
        {

        }
    }
}