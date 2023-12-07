using Login_System;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TodoList.Utils;

namespace Register_System
{
    public partial class RegisterForm : Form
    {
        private const string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void inputRedirect_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = inputEmail.Text;
            string senha = inputSenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string novoUuid = UuidGenerator.GenerateUuid();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO Usuarios (ID, Email, Senha) VALUES (@ID, @Email, @Senha)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", novoUuid);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro bem-sucedido!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao registrar: " + ex.Message);
                }
            }
        }


        private void labelRedirect_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
