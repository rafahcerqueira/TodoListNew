using System;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoListForm
    {
        private ListBox listBox_TodoTasks;
        private Button button_AddTask;

        private void InitializeComponent()
        {
            this.listBox_TodoTasks = new System.Windows.Forms.ListBox();
            this.button_AddTask = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // listBox_TodoTasks
            this.listBox_TodoTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listBox_TodoTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_TodoTasks.ForeColor = System.Drawing.Color.White;
            this.listBox_TodoTasks.FormattingEnabled = true;
            this.listBox_TodoTasks.HorizontalScrollbar = true;
            this.listBox_TodoTasks.Location = new System.Drawing.Point(10, 28);
            this.listBox_TodoTasks.MinimumSize = new System.Drawing.Size(4, 66);
            this.listBox_TodoTasks.Name = "listBox_TodoTasks";
            this.listBox_TodoTasks.Size = new System.Drawing.Size(480, 371);
            this.listBox_TodoTasks.TabIndex = 0;

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
            this.Controls.Add(this.listBox_TodoTasks);
            this.Controls.Add(this.button_AddTask);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToDoListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoListForm";
            this.ResumeLayout(false);
        }
    }
}
