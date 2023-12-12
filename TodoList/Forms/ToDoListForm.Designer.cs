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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.button_AddTask = new System.Windows.Forms.Button();
            this.dataGridView_TodoTasks = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConcluida = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TodoTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Nirmala UI", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelTitulo.Location = new System.Drawing.Point(17, 20);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(131, 45);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Tarefas";
            // 
            // button_AddTask
            // 
            this.button_AddTask.BackColor = System.Drawing.Color.MediumPurple;
            this.button_AddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddTask.FlatAppearance.BorderSize = 0;
            this.button_AddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddTask.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddTask.ForeColor = System.Drawing.Color.White;
            this.button_AddTask.Location = new System.Drawing.Point(100, 440);
            this.button_AddTask.Name = "button_AddTask";
            this.button_AddTask.Size = new System.Drawing.Size(300, 40);
            this.button_AddTask.TabIndex = 6;
            this.button_AddTask.Text = "Adicionar Tarefa";
            this.button_AddTask.UseVisualStyleBackColor = false;
            this.button_AddTask.Click += new System.EventHandler(this.button_AddTask_Click);
            // 
            // dataGridView_TodoTasks
            // 
            this.dataGridView_TodoTasks.AllowUserToAddRows = false;
            this.dataGridView_TodoTasks.AllowUserToResizeColumns = false;
            this.dataGridView_TodoTasks.AllowUserToResizeRows = false;
            this.dataGridView_TodoTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_TodoTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_TodoTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_TodoTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TodoTasks.ColumnHeadersVisible = false;
            this.dataGridView_TodoTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnConcluida,
            this.ColumnDescricao,
            this.ColumnEditar,
            this.ColumnExcluir});
            this.dataGridView_TodoTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_TodoTasks.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_TodoTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView_TodoTasks.Location = new System.Drawing.Point(40, 90);
            this.dataGridView_TodoTasks.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView_TodoTasks.Name = "dataGridView_TodoTasks";
            this.dataGridView_TodoTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_TodoTasks.RowHeadersVisible = false;
            this.dataGridView_TodoTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_TodoTasks.Size = new System.Drawing.Size(430, 371);
            this.dataGridView_TodoTasks.TabIndex = 1;
            this.dataGridView_TodoTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TodoTasks_CellContentClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnConcluida
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MediumPurple;
            this.ColumnConcluida.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnConcluida.FlatStyle = FlatStyle.Flat;
            this.ColumnConcluida.HeaderText = "";
            this.ColumnConcluida.Name = "ColumnConcluida";
            this.ColumnConcluida.Width = 30;
            // 
            // ColumnDescricao
            // 
            this.ColumnDescricao.HeaderText = "Descrição";
            this.ColumnDescricao.Name = "ColumnDescricao";
            this.ColumnDescricao.ReadOnly = true;
            this.ColumnDescricao.Width = 280;
            // 
            // ColumnEditar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ColumnEditar.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnEditar.FlatStyle = FlatStyle.Flat;
            this.ColumnEditar.HeaderText = "Editar";
            this.ColumnEditar.Name = "ColumnEditar";
            this.ColumnEditar.Text = "Editar";
            this.ColumnEditar.Width = 60;
            // 
            // ColumnExcluir
            // 
            this.ColumnExcluir.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnExcluir.FlatStyle = FlatStyle.Flat;
            this.ColumnExcluir.HeaderText = "Excluir";
            this.ColumnExcluir.Name = "ColumnExcluir";
            this.ColumnExcluir.Text = "Excluir";
            this.ColumnExcluir.UseColumnTextForButtonValue = true;
            this.ColumnExcluir.Width = 60;
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.button_AddTask);
            this.Controls.Add(this.dataGridView_TodoTasks);
            this.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToDoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TodoTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewCheckBoxColumn ColumnConcluida;
        private DataGridViewTextBoxColumn ColumnDescricao;
        private DataGridViewButtonColumn ColumnEditar;
        private DataGridViewButtonColumn ColumnExcluir;
    }
}