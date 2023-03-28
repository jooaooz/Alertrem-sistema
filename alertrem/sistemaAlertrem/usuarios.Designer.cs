
namespace sistemaAlertrem
{
    partial class usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.pictBoxCor = new System.Windows.Forms.PictureBox();
            this.pictboxImagemUsu = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionarfoto = new System.Windows.Forms.Button();
            this.btnExcuirfoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxImagemUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxCor
            // 
            this.pictBoxCor.BackColor = System.Drawing.Color.SpringGreen;
            this.pictBoxCor.Location = new System.Drawing.Point(0, -1);
            this.pictBoxCor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictBoxCor.Name = "pictBoxCor";
            this.pictBoxCor.Size = new System.Drawing.Size(806, 63);
            this.pictBoxCor.TabIndex = 0;
            this.pictBoxCor.TabStop = false;
            // 
            // pictboxImagemUsu
            // 
            this.pictboxImagemUsu.ErrorImage = null;
            this.pictboxImagemUsu.Location = new System.Drawing.Point(264, 121);
            this.pictboxImagemUsu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictboxImagemUsu.Name = "pictboxImagemUsu";
            this.pictboxImagemUsu.Size = new System.Drawing.Size(226, 147);
            this.pictboxImagemUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictboxImagemUsu.TabIndex = 2;
            this.pictboxImagemUsu.TabStop = false;
            this.pictboxImagemUsu.Click += new System.EventHandler(this.pictboxImagemUsu_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(649, 425);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 48);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(193, 294);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(385, 61);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarfoto
            // 
            this.btnAdicionarfoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdicionarfoto.Location = new System.Drawing.Point(519, 121);
            this.btnAdicionarfoto.Name = "btnAdicionarfoto";
            this.btnAdicionarfoto.Size = new System.Drawing.Size(75, 41);
            this.btnAdicionarfoto.TabIndex = 6;
            this.btnAdicionarfoto.Text = "adicionar";
            this.btnAdicionarfoto.UseVisualStyleBackColor = false;
            this.btnAdicionarfoto.Click += new System.EventHandler(this.btnAdicionarfoto_Click);
            // 
            // btnExcuirfoto
            // 
            this.btnExcuirfoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExcuirfoto.Location = new System.Drawing.Point(519, 192);
            this.btnExcuirfoto.Name = "btnExcuirfoto";
            this.btnExcuirfoto.Size = new System.Drawing.Size(75, 38);
            this.btnExcuirfoto.TabIndex = 7;
            this.btnExcuirfoto.Text = "excluir";
            this.btnExcuirfoto.UseVisualStyleBackColor = false;
            this.btnExcuirfoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 485);
            this.Controls.Add(this.btnExcuirfoto);
            this.Controls.Add(this.btnAdicionarfoto);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictboxImagemUsu);
            this.Controls.Add(this.pictBoxCor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "usuarios";
            this.Text = "usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxImagemUsu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxCor;
        private System.Windows.Forms.PictureBox pictboxImagemUsu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAdicionarfoto;
        private System.Windows.Forms.Button btnExcuirfoto;
    }
}