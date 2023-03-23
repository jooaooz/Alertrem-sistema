
namespace sistemaAlertrem
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.gpbMenu.Controls.Add(this.btnUsuario);
            this.gpbMenu.Location = new System.Drawing.Point(-1, 0);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(801, 124);
            this.gpbMenu.TabIndex = 1;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "groupBox1";
            // 
            // btnUsuario
            // 
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.Location = new System.Drawing.Point(75, 19);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(105, 85);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "&Usuários";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbMenu);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.gpbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnUsuario;
    }
}