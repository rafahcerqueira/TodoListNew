using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Register_System
{
    partial class RegisterForm
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
            this.title = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.labelConfirmSenha = new System.Windows.Forms.Label();
            this.inputConfirmSenha = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelRedirect = new System.Windows.Forms.Label();
            this.inputRedirect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("MS UI Gothic", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.MediumPurple;
            this.title.Location = new System.Drawing.Point(171, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(172, 33);
            this.title.TabIndex = 6;
            this.title.Text = "REGISTER";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(90, 107);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // inputEmail
            // 
            this.inputEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmail.ForeColor = System.Drawing.Color.White;
            this.inputEmail.Location = new System.Drawing.Point(93, 137);
            this.inputEmail.Multiline = true;
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(300, 40);
            this.inputEmail.TabIndex = 0;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(90, 193);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(45, 17);
            this.labelSenha.TabIndex = 8;
            this.labelSenha.Text = "Senha";
            // 
            // inputSenha
            // 
            this.inputSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSenha.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSenha.ForeColor = System.Drawing.Color.White;
            this.inputSenha.Location = new System.Drawing.Point(93, 222);
            this.inputSenha.Multiline = true;
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.PasswordChar = '*';
            this.inputSenha.Size = new System.Drawing.Size(300, 40);
            this.inputSenha.TabIndex = 1;
            // 
            // labelConfirmSenha
            // 
            this.labelConfirmSenha.AutoSize = true;
            this.labelConfirmSenha.ForeColor = System.Drawing.Color.White;
            this.labelConfirmSenha.Location = new System.Drawing.Point(90, 278);
            this.labelConfirmSenha.Name = "labelConfirmSenha";
            this.labelConfirmSenha.Size = new System.Drawing.Size(111, 17);
            this.labelConfirmSenha.TabIndex = 22;
            this.labelConfirmSenha.Text = "Confirmar Senha";
            // 
            // inputConfirmSenha
            // 
            this.inputConfirmSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputConfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputConfirmSenha.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputConfirmSenha.ForeColor = System.Drawing.Color.White;
            this.inputConfirmSenha.Location = new System.Drawing.Point(93, 307);
            this.inputConfirmSenha.Multiline = true;
            this.inputConfirmSenha.Name = "inputConfirmSenha";
            this.inputConfirmSenha.PasswordChar = '*';
            this.inputConfirmSenha.Size = new System.Drawing.Size(300, 40);
            this.inputConfirmSenha.TabIndex = 21;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumPurple;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(93, 378);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 40);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelRedirect
            // 
            this.labelRedirect.AutoSize = true;
            this.labelRedirect.Location = new System.Drawing.Point(154, 444);
            this.labelRedirect.Name = "labelRedirect";
            this.labelRedirect.Size = new System.Drawing.Size(93, 17);
            this.labelRedirect.TabIndex = 20;
            this.labelRedirect.Text = "Já tem conta?";
            this.labelRedirect.Click += new System.EventHandler(this.labelRedirect_Click);
            // 
            // inputRedirect
            // 
            this.inputRedirect.AutoSize = true;
            this.inputRedirect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputRedirect.ForeColor = System.Drawing.Color.MediumPurple;
            this.inputRedirect.Location = new System.Drawing.Point(248, 444);
            this.inputRedirect.Name = "inputRedirect";
            this.inputRedirect.Size = new System.Drawing.Size(84, 17);
            this.inputRedirect.TabIndex = 19;
            this.inputRedirect.Text = "Entrar agora";
            this.inputRedirect.Click += new System.EventHandler(this.inputRedirect_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.inputConfirmSenha);
            this.Controls.Add(this.labelConfirmSenha);
            this.Controls.Add(this.inputRedirect);
            this.Controls.Add(this.labelRedirect);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Label labelConfirmSenha;
        private System.Windows.Forms.TextBox inputConfirmSenha;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelRedirect;
        private System.Windows.Forms.Label inputRedirect;
    }
}
