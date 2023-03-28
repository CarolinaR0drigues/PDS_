namespace ProjetoVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastro = new System.Windows.Forms.Button();
            this.btListarCadastros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU INICIAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCadastro
            // 
            this.btCadastro.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastro.Location = new System.Drawing.Point(64, 128);
            this.btCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(237, 37);
            this.btCadastro.TabIndex = 1;
            this.btCadastro.Text = "CADASTRO";
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // btListarCadastros
            // 
            this.btListarCadastros.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarCadastros.Location = new System.Drawing.Point(64, 220);
            this.btListarCadastros.Margin = new System.Windows.Forms.Padding(2);
            this.btListarCadastros.Name = "btListarCadastros";
            this.btListarCadastros.Size = new System.Drawing.Size(237, 37);
            this.btListarCadastros.TabIndex = 2;
            this.btListarCadastros.Text = "CADASTRADOS";
            this.btListarCadastros.UseVisualStyleBackColor = true;
            this.btListarCadastros.Click += new System.EventHandler(this.btListarCadastros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 395);
            this.Controls.Add(this.btListarCadastros);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "<< Menu Incial >>";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btListarCadastros;
    }
}

