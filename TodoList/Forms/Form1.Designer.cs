namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage_TodoOld = new System.Windows.Forms.TabPage();
            this.tabPage_TodoToday = new System.Windows.Forms.TabPage();
            this.groupBox_TodoToday = new System.Windows.Forms.GroupBox();
            this.checkedListBox_TodoToday = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Action = new System.Windows.Forms.GroupBox();
            this.button_ActionSave = new System.Windows.Forms.Button();
            this.button_ActionAdd = new System.Windows.Forms.Button();
            this.button_ActionDelete = new System.Windows.Forms.Button();
            this.button_ActionModify = new System.Windows.Forms.Button();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_TodoToday.SuspendLayout();
            this.groupBox_TodoToday.SuspendLayout();
            this.groupBox_Action.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(409, 401);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Sábado";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(409, 401);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Sexta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(409, 401);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Quinta";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 401);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Quarta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 401);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Terça";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage_TodoOld
            // 
            this.tabPage_TodoOld.AutoScroll = true;
            this.tabPage_TodoOld.Location = new System.Drawing.Point(4, 27);
            this.tabPage_TodoOld.Name = "tabPage_TodoOld";
            this.tabPage_TodoOld.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.tabPage_TodoOld.Size = new System.Drawing.Size(409, 401);
            this.tabPage_TodoOld.TabIndex = 1;
            this.tabPage_TodoOld.Text = "Segunda";
            this.tabPage_TodoOld.UseVisualStyleBackColor = true;
            // 
            // tabPage_TodoToday
            // 
            this.tabPage_TodoToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tabPage_TodoToday.Controls.Add(this.groupBox_Action);
            this.tabPage_TodoToday.Controls.Add(this.groupBox_TodoToday);
            this.tabPage_TodoToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage_TodoToday.Location = new System.Drawing.Point(4, 27);
            this.tabPage_TodoToday.Name = "tabPage_TodoToday";
            this.tabPage_TodoToday.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.tabPage_TodoToday.Size = new System.Drawing.Size(409, 401);
            this.tabPage_TodoToday.TabIndex = 0;
            this.tabPage_TodoToday.Text = "Domingo";
            // 
            // groupBox_TodoToday
            // 
            this.groupBox_TodoToday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_TodoToday.Controls.Add(this.dateTimePicker1);
            this.groupBox_TodoToday.Controls.Add(this.checkedListBox_TodoToday);
            this.groupBox_TodoToday.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TodoToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_TodoToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox_TodoToday.Location = new System.Drawing.Point(11, 10);
            this.groupBox_TodoToday.Name = "groupBox_TodoToday";
            this.groupBox_TodoToday.Padding = new System.Windows.Forms.Padding(16);
            this.groupBox_TodoToday.Size = new System.Drawing.Size(387, 300);
            this.groupBox_TodoToday.TabIndex = 0;
            this.groupBox_TodoToday.TabStop = false;
            this.groupBox_TodoToday.Enter += new System.EventHandler(this.groupBox_TodoToday_Enter);
            // 
            // checkedListBox_TodoToday
            // 
            this.checkedListBox_TodoToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.checkedListBox_TodoToday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_TodoToday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_TodoToday.ForeColor = System.Drawing.SystemColors.Window;
            this.checkedListBox_TodoToday.FormattingEnabled = true;
            this.checkedListBox_TodoToday.HorizontalScrollbar = true;
            this.checkedListBox_TodoToday.IntegralHeight = false;
            this.checkedListBox_TodoToday.Location = new System.Drawing.Point(16, 31);
            this.checkedListBox_TodoToday.MinimumSize = new System.Drawing.Size(4, 66);
            this.checkedListBox_TodoToday.Name = "checkedListBox_TodoToday";
            this.checkedListBox_TodoToday.Size = new System.Drawing.Size(355, 253);
            this.checkedListBox_TodoToday.TabIndex = 0;
            this.checkedListBox_TodoToday.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_TodoToday_ItemCheck);
            this.checkedListBox_TodoToday.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_TodoToday_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InfoText;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.InfoText;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(1, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(386, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox_Action
            // 
            this.groupBox_Action.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox_Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.groupBox_Action.Controls.Add(this.button_ActionModify);
            this.groupBox_Action.Controls.Add(this.button_ActionDelete);
            this.groupBox_Action.Controls.Add(this.button_ActionAdd);
            this.groupBox_Action.Controls.Add(this.button_ActionSave);
            this.groupBox_Action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Action.ForeColor = System.Drawing.Color.White;
            this.groupBox_Action.Location = new System.Drawing.Point(11, 330);
            this.groupBox_Action.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Action.Name = "groupBox_Action";
            this.groupBox_Action.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.groupBox_Action.Size = new System.Drawing.Size(387, 61);
            this.groupBox_Action.TabIndex = 5;
            this.groupBox_Action.TabStop = false;
            this.groupBox_Action.Text = "Ações";
            this.groupBox_Action.Enter += new System.EventHandler(this.groupBox_Action_Enter);
            // 
            // button_ActionSave
            // 
            this.button_ActionSave.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button_ActionSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ActionSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ActionSave.Location = new System.Drawing.Point(309, 25);
            this.button_ActionSave.Name = "button_ActionSave";
            this.button_ActionSave.Size = new System.Drawing.Size(67, 26);
            this.button_ActionSave.TabIndex = 3;
            this.button_ActionSave.Text = "Salvar";
            this.button_ActionSave.UseVisualStyleBackColor = false;
            this.button_ActionSave.Click += new System.EventHandler(this.button_ActionSave_Click);
            // 
            // button_ActionAdd
            // 
            this.button_ActionAdd.BackColor = System.Drawing.Color.Lime;
            this.button_ActionAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ActionAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_ActionAdd.Location = new System.Drawing.Point(11, 25);
            this.button_ActionAdd.Name = "button_ActionAdd";
            this.button_ActionAdd.Size = new System.Drawing.Size(67, 26);
            this.button_ActionAdd.TabIndex = 5;
            this.button_ActionAdd.Text = "Adicionar";
            this.button_ActionAdd.UseVisualStyleBackColor = false;
            this.button_ActionAdd.Click += new System.EventHandler(this.button_ActionAdd_Click);
            // 
            // button_ActionDelete
            // 
            this.button_ActionDelete.BackColor = System.Drawing.Color.Red;
            this.button_ActionDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ActionDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.button_ActionDelete.Location = new System.Drawing.Point(78, 25);
            this.button_ActionDelete.Name = "button_ActionDelete";
            this.button_ActionDelete.Size = new System.Drawing.Size(67, 26);
            this.button_ActionDelete.TabIndex = 9;
            this.button_ActionDelete.Text = "Remover";
            this.button_ActionDelete.UseVisualStyleBackColor = false;
            this.button_ActionDelete.Click += new System.EventHandler(this.button_ActionDelete_Click);
            // 
            // button_ActionModify
            // 
            this.button_ActionModify.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_ActionModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ActionModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ActionModify.Location = new System.Drawing.Point(145, 25);
            this.button_ActionModify.Name = "button_ActionModify";
            this.button_ActionModify.Size = new System.Drawing.Size(67, 26);
            this.button_ActionModify.TabIndex = 10;
            this.button_ActionModify.Text = "Editar";
            this.button_ActionModify.UseVisualStyleBackColor = false;
            this.button_ActionModify.Click += new System.EventHandler(this.button_ActionModify_Click);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.AllowDrop = true;
            this.tabControl_Main.Controls.Add(this.tabPage_TodoToday);
            this.tabControl_Main.Controls.Add(this.tabPage_TodoOld);
            this.tabControl_Main.Controls.Add(this.tabPage1);
            this.tabControl_Main.Controls.Add(this.tabPage2);
            this.tabControl_Main.Controls.Add(this.tabPage3);
            this.tabControl_Main.Controls.Add(this.tabPage4);
            this.tabControl_Main.Controls.Add(this.tabPage5);
            this.tabControl_Main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl_Main.Font = new System.Drawing.Font("3ds", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Multiline = true;
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.Padding = new System.Drawing.Point(5, 5);
            this.tabControl_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(417, 432);
            this.tabControl_Main.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(416, 432);
            this.Controls.Add(this.tabControl_Main);
            this.MinimumSize = new System.Drawing.Size(432, 326);
            this.Name = "Form1";
            this.Text = "Tarefas Semanais";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabPage_TodoToday.ResumeLayout(false);
            this.groupBox_TodoToday.ResumeLayout(false);
            this.groupBox_Action.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage_TodoOld;
        private System.Windows.Forms.TabPage tabPage_TodoToday;
        private System.Windows.Forms.GroupBox groupBox_Action;
        private System.Windows.Forms.Button button_ActionModify;
        private System.Windows.Forms.Button button_ActionDelete;
        private System.Windows.Forms.Button button_ActionAdd;
        private System.Windows.Forms.Button button_ActionSave;
        private System.Windows.Forms.GroupBox groupBox_TodoToday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckedListBox checkedListBox_TodoToday;
        private System.Windows.Forms.TabControl tabControl_Main;
    }
}

