
namespace sistemaAlertrem
{
    partial class Frmcomentario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnteste = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imagens = new System.Windows.Forms.DataGridViewImageColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstadoDoBanco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnteste
            // 
            this.btnteste.Location = new System.Drawing.Point(662, 372);
            this.btnteste.Name = "btnteste";
            this.btnteste.Size = new System.Drawing.Size(75, 23);
            this.btnteste.TabIndex = 0;
            this.btnteste.Text = "testar conexão";
            this.btnteste.UseVisualStyleBackColor = true;
            this.btnteste.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imagens,
            this.nome,
            this.reacao,
            this.hora});
            this.dataGridView1.Location = new System.Drawing.Point(178, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 316);
            this.dataGridView1.TabIndex = 21;
            // 
            // imagens
            // 
            this.imagens.HeaderText = "imagens usuarios";
            this.imagens.Name = "imagens";
            // 
            // nome
            // 
            this.nome.HeaderText = "nome usuário";
            this.nome.Name = "nome";
            // 
            // reacao
            // 
            this.reacao.HeaderText = "Reação ";
            this.reacao.Name = "reacao";
            // 
            // hora
            // 
            this.hora.HeaderText = "Horário ";
            this.hora.Name = "hora";
            // 
            // lblEstadoDoBanco
            // 
            this.lblEstadoDoBanco.AutoSize = true;
            this.lblEstadoDoBanco.Location = new System.Drawing.Point(760, 377);
            this.lblEstadoDoBanco.Name = "lblEstadoDoBanco";
            this.lblEstadoDoBanco.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoDoBanco.TabIndex = 23;
            // 
            // Frmcomentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstadoDoBanco);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnteste);
            this.Name = "Frmcomentario";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Frmcomentario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnteste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn imagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn reacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.Label lblEstadoDoBanco;
    }
}