namespace ToDoList
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox_Action = new System.Windows.Forms.GroupBox();
            this.button_ActionModify = new System.Windows.Forms.Button();
            this.button_ActionDelete = new System.Windows.Forms.Button();
            this.button_ActionAdd = new System.Windows.Forms.Button();
            this.button_ActionSave = new System.Windows.Forms.Button();
            this.groupBox_TodoToday = new System.Windows.Forms.GroupBox();
            this.checkedListBox_TodoToday = new System.Windows.Forms.CheckedListBox();
            this.groupBox_Action.SuspendLayout();
            this.groupBox_TodoToday.SuspendLayout();
            this.SuspendLayout();
            
            // groupBox_Action
            
            this.groupBox_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.groupBox_Action.Controls.Add(this.button_ActionModify);
            this.groupBox_Action.Controls.Add(this.button_ActionDelete);
            this.groupBox_Action.Controls.Add(this.button_ActionAdd);
            this.groupBox_Action.Controls.Add(this.button_ActionSave);
            this.groupBox_Action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Action.ForeColor = System.Drawing.Color.White;
            this.groupBox_Action.Location = new System.Drawing.Point(0, 429);
            this.groupBox_Action.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Action.Name = "groupBox_Action";
            this.groupBox_Action.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupBox_Action.Size = new System.Drawing.Size(500, 71);
            this.groupBox_Action.TabIndex = 5;
            this.groupBox_Action.TabStop = false;
            this.groupBox_Action.Text = "Ações";
            this.groupBox_Action.Enter += new System.EventHandler(this.groupBox_Action_Enter_1);
             
            // button_ActionModify
            
            this.button_ActionModify.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_ActionModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ActionModify.ForeColor = System.Drawing.Color.White;
            this.button_ActionModify.Location = new System.Drawing.Point(177, 28);
            this.button_ActionModify.Name = "button_ActionModify";
            this.button_ActionModify.Size = new System.Drawing.Size(90, 40);
            this.button_ActionModify.TabIndex = 10;
            this.button_ActionModify.Text = "Editar";
            this.button_ActionModify.UseVisualStyleBackColor = false;
            this.button_ActionModify.Click += new System.EventHandler(this.button_ActionModify_Click);
            
            // button_ActionDelete
            
            this.button_ActionDelete.BackColor = System.Drawing.Color.Red;
            this.button_ActionDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ActionDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.button_ActionDelete.Location = new System.Drawing.Point(94, 28);
            this.button_ActionDelete.Name = "button_ActionDelete";
            this.button_ActionDelete.Size = new System.Drawing.Size(90, 40);
            this.button_ActionDelete.TabIndex = 9;
            this.button_ActionDelete.Text = "Remover";
            this.button_ActionDelete.UseVisualStyleBackColor = false;
            this.button_ActionDelete.Click += new System.EventHandler(this.button_ActionDelete_Click);
             
            // button_ActionAdd
             
            this.button_ActionAdd.BackColor = System.Drawing.Color.Lime;
            this.button_ActionAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ActionAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ActionAdd.Location = new System.Drawing.Point(11, 28);
            this.button_ActionAdd.Name = "button_ActionAdd";
            this.button_ActionAdd.Size = new System.Drawing.Size(90, 40);
            this.button_ActionAdd.TabIndex = 5;
            this.button_ActionAdd.Text = "Adicionar";
            this.button_ActionAdd.UseVisualStyleBackColor = false;
            this.button_ActionAdd.Click += new System.EventHandler(this.button_ActionAdd_Click);
            
            // button_ActionSave
            
            this.button_ActionSave.BackColor = System.Drawing.Color.MediumPurple;
            this.button_ActionSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ActionSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ActionSave.ForeColor = System.Drawing.Color.White;
            this.button_ActionSave.Location = new System.Drawing.Point(403, 28);
            this.button_ActionSave.Name = "button_ActionSave";
            this.button_ActionSave.Size = new System.Drawing.Size(90, 40);
            this.button_ActionSave.TabIndex = 3;
            this.button_ActionSave.Text = "Salvar";
            this.button_ActionSave.UseVisualStyleBackColor = false;
            this.button_ActionSave.Click += new System.EventHandler(this.button_ActionSave_Click);
             
            // groupBox_TodoToday
             
            this.groupBox_TodoToday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_TodoToday.Controls.Add(this.checkedListBox_TodoToday);
            this.groupBox_TodoToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TodoToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_TodoToday.ForeColor = System.Drawing.Color.White;
            this.groupBox_TodoToday.Location = new System.Drawing.Point(0, 0);
            this.groupBox_TodoToday.Name = "groupBox_TodoToday";
            this.groupBox_TodoToday.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox_TodoToday.Size = new System.Drawing.Size(500, 409);
            this.groupBox_TodoToday.TabIndex = 0;
            this.groupBox_TodoToday.TabStop = false;
            
            // checkedListBox_TodoToday
             
            this.checkedListBox_TodoToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.checkedListBox_TodoToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_TodoToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_TodoToday.ForeColor = System.Drawing.Color.White;
            this.checkedListBox_TodoToday.FormattingEnabled = true;
            this.checkedListBox_TodoToday.HorizontalScrollbar = true;
            this.checkedListBox_TodoToday.IntegralHeight = false;
            this.checkedListBox_TodoToday.Location = new System.Drawing.Point(10, 28);
            this.checkedListBox_TodoToday.MinimumSize = new System.Drawing.Size(4, 66);
            this.checkedListBox_TodoToday.Name = "checkedListBox_TodoToday";
            this.checkedListBox_TodoToday.Size = new System.Drawing.Size(480, 371);
            this.checkedListBox_TodoToday.TabIndex = 0;
            this.checkedListBox_TodoToday.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_TodoToday_ItemCheck);
            this.checkedListBox_TodoToday.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_TodoToday_SelectedIndexChanged);
             
            // Form1
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.groupBox_TodoToday);
            this.Controls.Add(this.groupBox_Action);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.groupBox_Action.ResumeLayout(false);
            this.groupBox_TodoToday.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Action;
        private System.Windows.Forms.Button button_ActionModify;
        private System.Windows.Forms.Button button_ActionDelete;
        private System.Windows.Forms.Button button_ActionAdd;
        private System.Windows.Forms.Button button_ActionSave;
        private System.Windows.Forms.GroupBox groupBox_TodoToday;
        private System.Windows.Forms.CheckedListBox checkedListBox_TodoToday;
    }
}
