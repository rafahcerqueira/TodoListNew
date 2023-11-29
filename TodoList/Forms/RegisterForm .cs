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
using Npgsql;
using Login_System;

namespace Register_System
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
        NpgsqlCommand cmd = new NpgsqlCommand();
        NpgsqlDataAdapter da = new NpgsqlDataAdapter();

        private void label6_Click(object sender, EventArgs e)
        {
            // Voltar para o formulário de login
            new LoginForm().Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Limpar os campos de entrada
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

            // Código para realizar o registro do usuário no banco de dados
            // Substitua o seguinte trecho pelo código específico do seu sistema
            string registerQuery = "INSERT INTO csharp_user(username, password) VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";

            cmd = new NpgsqlCommand(registerQuery, conn);
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registro bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                // Adicione aqui a lógica para lidar com o sucesso do registro
            }
            else
            {
                MessageBox.Show("Erro ao registrar usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Adicione aqui a lógica para lidar com falha no registro
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Mostrar ou ocultar a senha com base na seleção da caixa de seleção
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
