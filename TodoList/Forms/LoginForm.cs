using Register_System;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TodoList.Data;
using TodoList.Utils;
using ToDoList;

namespace Login_System
{
    public partial class LoginForm : Form
    {
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

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string selectUserByEmailAndPassword = QueryHelper.SelectUserCountByEmailAndPassword;

                    using (SqlCommand command = new SqlCommand(selectUserByEmailAndPassword, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // Consulta para obter o ID do usuário
                            string queryUserId = QueryHelper.SelectUserIdByEmail;
                            using (SqlCommand commandUserId = new SqlCommand(queryUserId, connection))
                            {
                                commandUserId.Parameters.Add(new SqlParameter("@Email", email));

                                object userIdResult = commandUserId.ExecuteScalar();

                                if (userIdResult != null)
                                {
                                    // Armazenar o userID para enviar ao ToDoListForm
                                    string userId = userIdResult.ToString();

                                    ToDoListForm toDoListForm = new ToDoListForm(userId);
                                    toDoListForm.Show();
                                    this.Hide();
                                }
                            }
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
