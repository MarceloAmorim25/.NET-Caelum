namespace BancoApp
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
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(107, 84);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(220, 22);
            this.textTitular.TabIndex = 0;
            this.textTitular.TextChanged += new System.EventHandler(this.textTitular_TextChanged);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(107, 184);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(220, 22);
            this.textSaldo.TabIndex = 1;
            this.textSaldo.TextChanged += new System.EventHandler(this.textSaldo_TextChanged);
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(107, 133);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(220, 22);
            this.textNumero.TabIndex = 2;
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textTitular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button button1;
    }
}

