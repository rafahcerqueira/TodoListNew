using Register_System;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ToDoList;

namespace Login_System
{
    public partial class LoginForm : Form
    {
        private const string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void inputRedirect_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string senha = inputSenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Email = @Email AND Senha = @Senha";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login bem-sucedido!");
                            new Form1().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Credenciais inválidas. Verifique seu e-mail e senha.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao realizar login: " + ex.Message);
                }
            }
        }
    }
}
