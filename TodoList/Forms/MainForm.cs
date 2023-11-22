using System;
using System.Windows.Forms;

namespace ToDoList.Forms
{
	public partial class MainForm : Form
	{
		private ListBox taskListBox;
		private TextBox taskTextBox;
		private Button addButton;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// Carregue as tarefas ao iniciar o formulário
			LoadTasks();
		}

		private void LoadTasks()
		{
			// Carregue as tarefas na lista
			taskListBox.DataSource = null;
			taskListBox.DataSource = TaskManager.Tasks;
			taskListBox.DisplayMember = "Title";
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			// Adicione uma nova tarefa
			string title = taskTextBox.Text.Trim();
			if (!string.IsNullOrEmpty(title))
			{
				TaskManager.Tasks.Add(new TaskModel { Title = title, IsCompleted = false });
				LoadTasks();
				taskTextBox.Clear();
			}
		}

		private void CompleteButton_Click(object sender, EventArgs e)
		{
			// Marque a tarefa como concluída
			if (taskListBox.SelectedItem is TaskModel selectedTask)
			{
				selectedTask.IsCompleted = true;
				LoadTasks();
			}
		}

		private void InitializeComponent()
		{
			this.taskListBox = new System.Windows.Forms.ListBox();
			this.taskTextBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// taskListBox
			// 
			this.taskListBox.BackColor = System.Drawing.Color.Black;
			this.taskListBox.ForeColor = System.Drawing.Color.White;
			this.taskListBox.FormattingEnabled = true;
			this.taskListBox.Location = new System.Drawing.Point(0, 1);
			this.taskListBox.Name = "taskListBox";
			this.taskListBox.Size = new System.Drawing.Size(390, 355);
			this.taskListBox.TabIndex = 0;
			// 
			// taskTextBox
			// 
			this.taskTextBox.Location = new System.Drawing.Point(12, 23);
			this.taskTextBox.Name = "taskTextBox";
			this.taskTextBox.Size = new System.Drawing.Size(136, 20);
			this.taskTextBox.TabIndex = 1;
			this.taskTextBox.TextChanged += new System.EventHandler(this.TaskTextBox_TextChanged);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(155, 276);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "addButton";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(390, 356);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.taskTextBox);
			this.Controls.Add(this.taskListBox);
			this.Name = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			// Edite a tarefa selecionada
			if (taskListBox.SelectedItem is TaskModel selectedTask)
			{
				string newTitle = taskTextBox.Text.Trim();
				if (!string.IsNullOrEmpty(newTitle))
				{
					selectedTask.EditTask(newTitle);
					LoadTasks();
					taskTextBox.Clear();
				}
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			// Exclua a tarefa selecionada
			if (taskListBox.SelectedItem is TaskModel selectedTask)
			{
				TaskManager.Tasks.Remove(selectedTask);
				LoadTasks();
				taskTextBox.Clear();
			}
		}

		private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void TaskTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
