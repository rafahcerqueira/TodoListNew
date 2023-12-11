using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TodoList.Data;
using TodoList.Utils;

namespace ToDoList.Forms
{
    public partial class ExcluirTarefaForm : Form
    {
        private string idTask;

        public ExcluirTarefaForm(string idTask)
        {
            InitializeComponent();
            this.idTask = idTask;
            this.Text = "Excluir Tarefa";
            labelTitulo.Text = "Excluir Tarefa";
            btnExcluir.Text = "Excluir";
            btnCancelar.Text = "Cancelar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirTarefaNoBancoDeDados();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ExcluirTarefaNoBancoDeDados()
        {
            string queryDeleteTask = QueryHelper.DeleteTaskById;

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(queryDeleteTask, connection))
                    {
                        command.Parameters.AddWithValue("@Id", idTask);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Exclusão feita com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir tarefa: " + ex.Message);
                }
            }
        }

    }
}
