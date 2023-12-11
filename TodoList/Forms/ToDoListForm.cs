using System;
using System.Data.SqlClient;
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
                            // Limpar a lista de tarefas antes de recarregar
                            listBox_TodoTasks.Items.Clear();

                            while (reader.Read())
                            {
                                string id = reader["ID"].ToString();
                                string description = reader["Description"].ToString();
                                bool done = (bool)reader["Done"];

                                // Adicionar tarefa à ListBox
                                listBox_TodoTasks.Items.Add($"{id}: {description} {(done ? "(Concluída)" : "")}");
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

        private void button_AddTask_Click(object sender, EventArgs e)
        {
            using (AdicionarTarefaForm adicionarTarefaForm = new AdicionarTarefaForm(userID))
            {
                if (adicionarTarefaForm.ShowDialog() == DialogResult.OK)
                    CarregarTarefas(userID);
            }
        }
    }
}
