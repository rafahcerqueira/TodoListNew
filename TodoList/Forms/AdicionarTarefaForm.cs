using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TodoList.Data;
using TodoList.Utils;

namespace ToDoList.Forms
{
    public partial class AdicionarTarefaForm : Form
    {
        private string userID;

        public AdicionarTarefaForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.Text = "Adicionar Tarefa";
            labelTitulo.Text = "Adicionar Tarefa";
            btnAdicionar.Text = "Adicionar";
            btnCancelar.Text = "Cancelar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha a descrição da tarefa.");
                return;
            }

            AdicionarTarefaNoBancoDeDados();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AdicionarTarefaNoBancoDeDados()
        {
            string novoUuid = UuidGenerator.GenerateUuid();
            string descricao = txtDescricao.Text;
            DateTime dataSelecionada = datePicker.Value;

            string queryInsertTask = QueryHelper.InsertTask;

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(queryInsertTask, connection))
                    {
                        command.Parameters.AddWithValue("@Id", novoUuid);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.Parameters.AddWithValue("@Data", dataSelecionada);
                        command.Parameters.AddWithValue("@UsuarioID", userID);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Tarefa adicionada com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar tarefa: " + ex.Message);
                }
            }
        }

    }
}
