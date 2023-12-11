using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoListForm
    {
        private Button button_AddTask;
        private DataGridView dataGridView_TodoTasks;

        private void InitializeComponent()
        {
            this.button_AddTask = new System.Windows.Forms.Button();
            this.dataGridView_TodoTasks = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // dataGridView_TodoTasks
            this.dataGridView_TodoTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_TodoTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_TodoTasks.ForeColor = System.Drawing.Color.White;
            this.dataGridView_TodoTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TodoTasks.Location = new System.Drawing.Point(10, 28);
            this.dataGridView_TodoTasks.Name = "dataGridView_TodoTasks";
            this.dataGridView_TodoTasks.Size = new System.Drawing.Size(480, 371);
            this.dataGridView_TodoTasks.TabIndex = 1;
            this.dataGridView_TodoTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TodoTasks_CellContentClick);

            // Adicionar coluna de ID 
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ColumnId";
            idColumn.HeaderText = "ID";
            idColumn.Visible = false; // Configuração para ocultar a coluna
            this.dataGridView_TodoTasks.Columns.Add(idColumn);

            // Adicionar coluna de checkbox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Concluída";
            checkBoxColumn.Name = "ColumnConcluida";
            this.dataGridView_TodoTasks.Columns.Add(checkBoxColumn);

            // Adicionar coluna de descrição
            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Descrição";
            descriptionColumn.Name = "ColumnDescricao";
            descriptionColumn.ReadOnly = true;
            this.dataGridView_TodoTasks.Columns.Add(descriptionColumn);

            // Adicionar coluna de botão para editar
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Editar";
            editButtonColumn.Name = "ColumnEditar";
            editButtonColumn.Text = "Editar";
            editButtonColumn.UseColumnTextForButtonValue = true;
            this.dataGridView_TodoTasks.Columns.Add(editButtonColumn);

            // Adicionar coluna de botão para excluir
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Excluir";
            deleteButtonColumn.Name = "ColumnExcluir";
            deleteButtonColumn.Text = "Excluir";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            this.dataGridView_TodoTasks.Columns.Add(deleteButtonColumn);

            // button_AddTask
            this.button_AddTask.Size = new System.Drawing.Size(120, 30);
            this.button_AddTask.Text = "Adicionar Tarefa";
            this.button_AddTask.BackColor = System.Drawing.Color.Lime;
            this.button_AddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_AddTask.Location = new System.Drawing.Point(10, 440);
            this.button_AddTask.Click += new System.EventHandler(this.button_AddTask_Click);

            // ToDoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.button_AddTask);
            this.Controls.Add(this.dataGridView_TodoTasks);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToDoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TodoTasks)).EndInit();
            this.ResumeLayout(false);
        }
    }
}