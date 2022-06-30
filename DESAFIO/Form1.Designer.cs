namespace DESAFIO
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(116, 69);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Festa do\r\nRATINHOOOO\r\n\r\n";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 63);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 62);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "ann";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(14, 92);
            this.lblSobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(72, 16);
            this.lblSobrenome.TabIndex = 3;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(108, 92);
            this.txtSobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(145, 22);
            this.txtSobrenome.TabIndex = 4;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(108, 160);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(145, 28);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(14, 121);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(73, 32);
            this.lblNascimento.TabIndex = 6;
            this.lblNascimento.Text = "Ano de \r\nNascimento:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(108, 131);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(145, 22);
            this.txtData.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(105, 210);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(74, 16);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "RESULTADO";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(17, 287);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(108, 286);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(283, 62);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(253, 247);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 12;
            this.picture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 554);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox picture;
    }
}

