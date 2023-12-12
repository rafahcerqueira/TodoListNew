using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Login_System
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelRedirect = new System.Windows.Forms.Label();
            this.inputRedirect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 24.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.MediumPurple;
            this.title.Location = new System.Drawing.Point(188, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 45);
            this.title.TabIndex = 6;
            this.title.Text = "LOGIN";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(92, 142);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // inputEmail
            // 
            this.inputEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputEmail.ForeColor = System.Drawing.Color.White;
            this.inputEmail.Location = new System.Drawing.Point(95, 172);
            this.inputEmail.MaximumSize = new System.Drawing.Size(300, 40);
            this.inputEmail.MinimumSize = new System.Drawing.Size(300, 40);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(300, 40);
            this.inputEmail.TabIndex = 0;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(92, 228);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(45, 17);
            this.labelSenha.TabIndex = 8;
            this.labelSenha.Text = "Senha";
            // 
            // inputSenha
            // 
            this.inputSenha.AcceptsTab = true;
            this.inputSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputSenha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSenha.ForeColor = System.Drawing.Color.White;
            this.inputSenha.Location = new System.Drawing.Point(95, 257);
            this.inputSenha.Margin = new System.Windows.Forms.Padding(10);
            this.inputSenha.MaximumSize = new System.Drawing.Size(300, 40);
            this.inputSenha.MinimumSize = new System.Drawing.Size(300, 40);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.PasswordChar = '*';
            this.inputSenha.Size = new System.Drawing.Size(300, 40);
            this.inputSenha.TabIndex = 1;
            this.inputSenha.WordWrap = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(95, 338);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelRedirect
            // 
            this.labelRedirect.AutoSize = true;
            this.labelRedirect.Location = new System.Drawing.Point(155, 398);
            this.labelRedirect.Name = "labelRedirect";
            this.labelRedirect.Size = new System.Drawing.Size(105, 17);
            this.labelRedirect.TabIndex = 20;
            this.labelRedirect.Text = "Não tem conta?";
            // 
            // inputRedirect
            // 
            this.inputRedirect.AutoSize = true;
            this.inputRedirect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputRedirect.ForeColor = System.Drawing.Color.MediumPurple;
            this.inputRedirect.Location = new System.Drawing.Point(259, 398);
            this.inputRedirect.Name = "inputRedirect";
            this.inputRedirect.Size = new System.Drawing.Size(75, 17);
            this.inputRedirect.TabIndex = 19;
            this.inputRedirect.Text = "Criar conta";
            this.inputRedirect.Click += new System.EventHandler(this.inputRedirect_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.inputRedirect);
            this.Controls.Add(this.labelRedirect);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelRedirect;
        private System.Windows.Forms.Label inputRedirect;
    }
}
