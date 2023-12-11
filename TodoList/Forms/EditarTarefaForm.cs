using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TodoList.Data;
using TodoList.Utils;

namespace ToDoList.Forms
{
    public partial class EditarTarefaForm : Form
    {
        private string idTask;

        public EditarTarefaForm(string idTask)
        {
            InitializeComponent();
            this.idTask = idTask;
            this.Text = "Editar Tarefa";
            labelTitulo.Text = "Editar Tarefa";
            btnEditar.Text = "Editar";
            btnCancelar.Text = "Cancelar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Por favor, preencha a descrição da tarefa.");
                return;
            }

            EditarTarefaNoBancoDeDados();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditarTarefaNoBancoDeDados()
        {
            string descricao = txtDescricao.Text;
            DateTime dataSelecionada = datePicker.Value;

            string queryUpdateTask = QueryHelper.UpdateTask;

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    //"UPDATE Todo SET Description = @Description, Done = @Done Data = @Data WHERE ID = @Id"

                    using (SqlCommand command = new SqlCommand(queryUpdateTask, connection))
                    {
                        command.Parameters.AddWithValue("@Description", descricao);
                        command.Parameters.AddWithValue("@Done", 0);
                        command.Parameters.AddWithValue("@Data", dataSelecionada);
                        command.Parameters.AddWithValue("@Id", idTask);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Edição feita com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao editar tarefa: " + ex.Message);
                }
            }
        }

    }
}
