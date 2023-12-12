using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoListForm
    {
        private Label labelTitulo;
        private Button button_AddTask;
        private DataGridView dataGridView_TodoTasks;

        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.button_AddTask = new System.Windows.Forms.Button();
            this.dataGridView_TodoTasks = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // labelTitulo
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("MS UI Gothic", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelTitulo.Location = new System.Drawing.Point(17, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(221, 33);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Tarefas";

            // dataGridView
            this.dataGridView_TodoTasks.Name = "dataGridView_TodoTasks";
            this.dataGridView_TodoTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TodoTasks_CellContentClick);
            this.dataGridView_TodoTasks.AllowUserToAddRows = false;
            this.dataGridView_TodoTasks.AllowUserToResizeColumns = false;
            this.dataGridView_TodoTasks.AllowUserToResizeRows = false;
            this.dataGridView_TodoTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_TodoTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_TodoTasks.ForeColor = System.Drawing.Color.White;
            this.dataGridView_TodoTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TodoTasks.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_TodoTasks.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_TodoTasks.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.dataGridView_TodoTasks.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_TodoTasks.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_TodoTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            this.dataGridView_TodoTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_TodoTasks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_TodoTasks.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_TodoTasks.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_TodoTasks.Location = new System.Drawing.Point(30, 60);
            this.dataGridView_TodoTasks.Size = new System.Drawing.Size(430, 371);
            this.dataGridView_TodoTasks.ColumnHeadersVisible = false;
            this.dataGridView_TodoTasks.RowHeadersVisible = false;
            this.dataGridView_TodoTasks.TabIndex = 1;

            // Adicionar coluna de ID 
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "ColumnId";
            idColumn.HeaderText = "ID";
            idColumn.Visible = false; // Configuração para ocultar a coluna
            this.dataGridView_TodoTasks.Columns.Add(idColumn);

            // Adicionar coluna de checkbox
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 30;
            checkBoxColumn.Name = "ColumnConcluida";
            this.dataGridView_TodoTasks.Columns.Add(checkBoxColumn);

            // Adicionar coluna de descrição
            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn();
            descriptionColumn.HeaderText = "Descrição";
            descriptionColumn.Name = "ColumnDescricao";
            descriptionColumn.Width = 280;
            descriptionColumn.ReadOnly = true;
            this.dataGridView_TodoTasks.Columns.Add(descriptionColumn);

            // Adicionar coluna de botão para editar
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.HeaderText = "Editar";
            editButtonColumn.Name = "ColumnEditar";
            editButtonColumn.Text = "Editar";
            editButtonColumn.Width = 60;
            editButtonColumn.UseColumnTextForButtonValue = true;
            this.dataGridView_TodoTasks.Columns.Add(editButtonColumn);

            // Adicionar coluna de botão para excluir
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "Excluir";
            deleteButtonColumn.Name = "ColumnExcluir";
            deleteButtonColumn.Text = "Excluir";
            deleteButtonColumn.Width = 60;
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            this.dataGridView_TodoTasks.Columns.Add(deleteButtonColumn);

            // button_AddTask
            this.button_AddTask.BackColor = System.Drawing.Color.MediumPurple;
            this.button_AddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddTask.FlatAppearance.BorderSize = 0;
            this.button_AddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddTask.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddTask.ForeColor = System.Drawing.Color.White;
            this.button_AddTask.Location = new System.Drawing.Point(100, 440);
            this.button_AddTask.Name = "btnAdicionar";
            this.button_AddTask.Size = new System.Drawing.Size(300, 40);
            this.button_AddTask.TabIndex = 6;
            this.button_AddTask.Text = "Adicionar Tarefa";
            this.button_AddTask.UseVisualStyleBackColor = false;
            this.button_AddTask.Click += new System.EventHandler(this.button_AddTask_Click);

            // ToDoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.labelTitulo);
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