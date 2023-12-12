using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.Data;
using TodoList.Utils;
using ToDoList.Forms;

namespace ToDoList
{
    public partial class ToDoListForm : Form
    {
        private readonly string userID;

        public ToDoListForm(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            ToDoListForm_Load(this, EventArgs.Empty);
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
        }

        private void CarregarTarefas(string userID)
        {
            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string query = QueryHelper.SelectTasksByUserId;
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TaskModel task = new TaskModel
                                {
                                    Id = reader["Id"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Done = Convert.ToBoolean(reader["Done"])
                                };

                                // Criar uma nova linha para a tarefa
                                DataGridViewRow row = new DataGridViewRow();

                                // Adicionar ID à célula
                                DataGridViewTextBoxCell idCell = new DataGridViewTextBoxCell();
                                idCell.Value = task.Id;
                                row.Cells.Add(idCell);

                                // Adicionar checkbox à célula
                                DataGridViewCheckBoxCell checkBoxCell = new DataGridViewCheckBoxCell();
                                checkBoxCell.Value = task.Done;
                                row.Cells.Add(checkBoxCell);

                                // Adicionar descrição à célula
                                DataGridViewTextBoxCell descriptionCell = new DataGridViewTextBoxCell();
                                descriptionCell.Value = task.Description;
                                row.Cells.Add(descriptionCell);

                                // Adicionar botão de editar à célula
                                DataGridViewButtonCell editButtonCell = new DataGridViewButtonCell();
                                editButtonCell.Value = "Editar";
                                row.Cells.Add(editButtonCell);

                                // Adicionar botão de excluir à célula
                                DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
                                deleteButtonCell.Value = "Excluir";
                                row.Cells.Add(deleteButtonCell);

                                // Adicionar a linha completa ao dataGridView
                                dataGridView_TodoTasks.Rows.Add(row);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar tarefas: " + ex.Message);
                }
            }
        }

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            CarregarTarefas(userID);
        }

        private void dataGridView_TodoTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Manipular cliques nos botões da DataGridView
            if (e.RowIndex >= 0 && e.ColumnIndex < dataGridView_TodoTasks.Columns.Count)
            {
                DataGridViewColumn column = dataGridView_TodoTasks.Columns[e.ColumnIndex];

                // Identificar a coluna pelo nome
                if (column.Name == "ColumnEditar")
                    EditarTarefa(e.RowIndex);
                else if (column.Name == "ColumnExcluir")
                    ExcluirTarefa(e.RowIndex);
                else if (column.Name == "ColumnConcluida")
                    CompletarTarefa(e.RowIndex);
            }
        }

        private void button_AddTask_Click(object sender, EventArgs e)
        {
            using (AdicionarTarefaForm adicionarTarefaForm = new AdicionarTarefaForm(userID))
            {
                if (adicionarTarefaForm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView_TodoTasks.Rows.Clear();
                    CarregarTarefas(userID);
                }
            }
        }

        private void EditarTarefa(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView_TodoTasks.Rows.Count)
            {
                DataGridViewRow row = dataGridView_TodoTasks.Rows[rowIndex];

                // Verificar se a célula da coluna "ColumnId" está presente
                if (row.Cells["ColumnId"] != null && row.Cells["ColumnId"].Value != null)
                {
                    string id = row.Cells["ColumnId"].Value.ToString();

                    using (EditarTarefaForm editarTerefaForm = new EditarTarefaForm(id))
                    {
                        if (editarTerefaForm.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView_TodoTasks.Rows.Clear();
                            CarregarTarefas(userID);
                        }
                    }
                }
            }
        }

        private void ExcluirTarefa(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView_TodoTasks.Rows.Count)
            {
                DataGridViewRow row = dataGridView_TodoTasks.Rows[rowIndex];

                // Verificar se a célula da coluna "ColumnId" está presente
                if (row.Cells["ColumnId"] != null && row.Cells["ColumnId"].Value != null)
                {
                    string id = row.Cells["ColumnId"].Value.ToString();

                    using (ExcluirTarefaForm excluirTarefaForm = new ExcluirTarefaForm(id))
                    {
                        if (excluirTarefaForm.ShowDialog() == DialogResult.OK)
                        {
                            dataGridView_TodoTasks.Rows.Clear();
                            CarregarTarefas(userID);
                        }
                    }
                }
            }
        }

        private void CompletarTarefa(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridView_TodoTasks.Rows.Count)
            {
                DataGridViewRow row = dataGridView_TodoTasks.Rows[rowIndex];

                // Verificar se a célula da coluna "ColumnId" está presente
                if (row.Cells["ColumnId"] != null && row.Cells["ColumnId"].Value != null)
                {
                    string id = row.Cells["ColumnId"].Value.ToString();

                    if (row.Cells["ColumnConcluida"] is DataGridViewCheckBoxCell checkBoxCell)
                    {
                        // Obter o valor booleano do CheckBox
                        bool concluida = (bool)checkBoxCell.Value;
                        int completed = 1;

                        if(concluida)
                        {
                            completed = 0;
                        }


                        bool returnOk = CompletarTarefaDB(id, completed);

                        if (returnOk)
                        {
                            dataGridView_TodoTasks.Rows.Clear();
                            CarregarTarefas(userID);
                        }
                    }
                }
            }
        }

        private bool CompletarTarefaDB(string idTask, int done)
        {
            string queryCompletedTaks = QueryHelper.CompleteTask;

            using (SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(queryCompletedTaks, connection))
                    {
                        command.Parameters.AddWithValue("@Done", done);
                        command.Parameters.AddWithValue("@Id", idTask);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar tarefa: " + ex.Message);
                    return false;
                }
            }
        }
    }
}