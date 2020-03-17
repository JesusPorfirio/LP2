namespace indice_massa_corporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mulher = new System.Windows.Forms.RadioButton();
            this.homem = new System.Windows.Forms.RadioButton();
            this.gordura = new System.Windows.Forms.MaskedTextBox();
            this.tamanho = new System.Windows.Forms.MaskedTextBox();
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mulher);
            this.groupBox1.Controls.Add(this.homem);
            this.groupBox1.Location = new System.Drawing.Point(144, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe genero";
            // 
            // mulher
            // 
            this.mulher.AutoSize = true;
            this.mulher.Location = new System.Drawing.Point(19, 61);
            this.mulher.Name = "mulher";
            this.mulher.Size = new System.Drawing.Size(72, 21);
            this.mulher.TabIndex = 1;
            this.mulher.TabStop = true;
            this.mulher.Text = "mulher";
            this.mulher.UseVisualStyleBackColor = true;
            this.mulher.CheckedChanged += new System.EventHandler(this.mulher_CheckedChanged);
            // 
            // homem
            // 
            this.homem.AutoSize = true;
            this.homem.Location = new System.Drawing.Point(19, 33);
            this.homem.Name = "homem";
            this.homem.Size = new System.Drawing.Size(75, 21);
            this.homem.TabIndex = 0;
            this.homem.TabStop = true;
            this.homem.Text = "homem";
            this.homem.UseVisualStyleBackColor = true;
            this.homem.CheckedChanged += new System.EventHandler(this.homem_CheckedChanged);
            // 
            // gordura
            // 
            this.gordura.Location = new System.Drawing.Point(12, 36);
            this.gordura.Mask = "###.###";
            this.gordura.Name = "gordura";
            this.gordura.Size = new System.Drawing.Size(100, 22);
            this.gordura.TabIndex = 0;
            this.gordura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // tamanho
            // 
            this.tamanho.Location = new System.Drawing.Point(12, 94);
            this.tamanho.Mask = "#.###";
            this.tamanho.Name = "tamanho";
            this.tamanho.Size = new System.Drawing.Size(100, 22);
            this.tamanho.TabIndex = 1;
            this.tamanho.ValidatingType = typeof(int);
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(9, 16);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(39, 17);
            this.peso.TabIndex = 2;
            this.peso.Text = "peso";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(9, 74);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(44, 17);
            this.altura.TabIndex = 3;
            this.altura.Text = "altura";
            // 
            // IMC
            // 
            this.IMC.Location = new System.Drawing.Point(376, 16);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(195, 100);
            this.IMC.TabIndex = 4;
            this.IMC.Text = "calcular IMC";
            this.IMC.UseVisualStyleBackColor = true;
            this.IMC.Click += new System.EventHandler(this.IMC_Click);
            // 
            // resultado
            // 
            this.resultado.Enabled = false;
            this.resultado.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(12, 131);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(226, 87);
            this.resultado.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.IMC);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.tamanho);
            this.Controls.Add(this.gordura);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "indice massa corporal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mulher;
        private System.Windows.Forms.RadioButton homem;
        private System.Windows.Forms.MaskedTextBox gordura;
        private System.Windows.Forms.MaskedTextBox tamanho;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Button IMC;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

