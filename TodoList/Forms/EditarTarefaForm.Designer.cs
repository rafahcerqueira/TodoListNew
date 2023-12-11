using System.Windows.Forms;

namespace ToDoList.Forms
{
    partial class EditarTarefaForm
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
            this.components = new System.ComponentModel.Container();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Label Título
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(20, 20);
            this.labelTitulo.Size = new System.Drawing.Size(193, 26);
            this.labelTitulo.Text = "Editar Tarefa";

            // Label Descrição
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(20, 60);
            this.labelDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelDescricao.Text = "Descrição:";

            // TextBox Descrição
            this.txtDescricao.Location = new System.Drawing.Point(120, 60);
            this.txtDescricao.Size = new System.Drawing.Size(250, 20);

            // Label Data
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(20, 100);
            this.labelData.Size = new System.Drawing.Size(33, 13);
            this.labelData.Text = "Data:";

            // DateTimePicker Data
            this.datePicker.Location = new System.Drawing.Point(120, 100);
            this.datePicker.Size = new System.Drawing.Size(250, 20);
            this.Controls.Add(this.datePicker);

            // Botão Cancelar
            this.btnCancelar.Location = new System.Drawing.Point(20, 140);
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // Botão Adicionar
            this.btnEditar.Location = new System.Drawing.Point(150, 140);
            this.btnEditar.Size = new System.Drawing.Size(120, 30);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // Adicionando os controles ao formulário
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
    }
}
