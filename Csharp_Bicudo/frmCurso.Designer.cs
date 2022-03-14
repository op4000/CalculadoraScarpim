namespace Csharp_Bicudo
{
    partial class frmCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurso));
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.somar = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.vezes = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.ResultadoValor = new System.Windows.Forms.Label();
            this.Historico = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.AccessibleDescription = "";
            this.valor1.Location = new System.Drawing.Point(173, 51);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(100, 20);
            this.valor1.TabIndex = 6;
            this.valor1.Tag = "";
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(173, 92);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(100, 20);
            this.valor2.TabIndex = 8;
            // 
            // somar
            // 
            this.somar.Location = new System.Drawing.Point(70, 106);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(75, 23);
            this.somar.TabIndex = 2;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.Location = new System.Drawing.Point(70, 135);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(75, 23);
            this.Subtrair.TabIndex = 3;
            this.Subtrair.Text = "-";
            this.Subtrair.UseVisualStyleBackColor = true;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // vezes
            // 
            this.vezes.Location = new System.Drawing.Point(70, 77);
            this.vezes.Name = "vezes";
            this.vezes.Size = new System.Drawing.Size(75, 23);
            this.vezes.TabIndex = 4;
            this.vezes.Text = "x";
            this.vezes.UseVisualStyleBackColor = true;
            this.vezes.Click += new System.EventHandler(this.vezes_Click);
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(70, 48);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(75, 23);
            this.Dividir.TabIndex = 5;
            this.Dividir.Text = "/";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // ResultadoValor
            // 
            this.ResultadoValor.Location = new System.Drawing.Point(171, 127);
            this.ResultadoValor.Name = "ResultadoValor";
            this.ResultadoValor.Size = new System.Drawing.Size(100, 23);
            this.ResultadoValor.TabIndex = 0;
            this.ResultadoValor.Text = "0";
            this.ResultadoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Historico
            // 
            this.Historico.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Historico.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Historico.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Historico.ForeColor = System.Drawing.SystemColors.Control;
            this.Historico.Location = new System.Drawing.Point(304, 9);
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(175, 177);
            this.Historico.TabIndex = 0;
            this.Historico.UseWaitCursor = true;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(301, 189);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(178, 28);
            this.Limpar.TabIndex = 7;
            this.Limpar.Text = "Limpar Registro";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmCurso
            // 
            this.AccessibleName = "Calculadora";
            this.ClientSize = new System.Drawing.Size(491, 229);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Historico);
            this.Controls.Add(this.ResultadoValor);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.vezes);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCurso";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox valor_1;
        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button vezes;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Label ResultadoValor;
        private System.Windows.Forms.Button Limpar;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label Historico;
    }
}

