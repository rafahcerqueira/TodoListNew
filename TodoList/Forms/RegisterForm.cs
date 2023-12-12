using Login_System;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TodoList.Data;
using TodoList.Utils;

namespace Register_System
{
    public partial class RegisterForm : Form
    {
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
            string confirmacaoSenha = inputConfirmSenha.Text;

            // Validações
            if (string.IsNullOrWhiteSpace(email) || !Validation.IsValidEmail(email))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(senha) || senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                return;
            }

            if (senha != confirmacaoSenha)
            {
                MessageBox.Show("A senha e a confirmação de senha não coincidem.");
                return;
            }

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            string novoUuid = UuidGenerator.GenerateUuid();

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = QueryHelper.InsertUsuarios;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", novoUuid);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro bem-sucedido!");
                    new LoginForm().Show();
                    this.Hide();

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
