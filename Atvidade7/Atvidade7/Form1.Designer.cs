namespace Atvidade7
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
            this.bttEx1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bttEx4 = new System.Windows.Forms.Button();
            this.bttEx5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bttEx7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttEx1
            // 
            this.bttEx1.Location = new System.Drawing.Point(0, 0);
            this.bttEx1.Name = "bttEx1";
            this.bttEx1.Size = new System.Drawing.Size(138, 74);
            this.bttEx1.TabIndex = 0;
            this.bttEx1.Text = "ler 20 numeros e inverter";
            this.bttEx1.UseVisualStyleBackColor = true;
            this.bttEx1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "ler 20 numeros e inverter (reverse)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(400, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Recebe Dados do Armazem.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bttEx4
            // 
            this.bttEx4.Location = new System.Drawing.Point(0, 129);
            this.bttEx4.Name = "bttEx4";
            this.bttEx4.Size = new System.Drawing.Size(138, 78);
            this.bttEx4.TabIndex = 3;
            this.bttEx4.Text = "final do laço";
            this.bttEx4.UseVisualStyleBackColor = true;
            this.bttEx4.Click += new System.EventHandler(this.bttEx4_Click);
            // 
            // bttEx5
            // 
            this.bttEx5.Location = new System.Drawing.Point(181, 129);
            this.bttEx5.Name = "bttEx5";
            this.bttEx5.Size = new System.Drawing.Size(153, 78);
            this.bttEx5.TabIndex = 4;
            this.bttEx5.Text = "Array list";
            this.bttEx5.UseVisualStyleBackColor = true;
            this.bttEx5.UseWaitCursor = true;
            this.bttEx5.Click += new System.EventHandler(this.bttEx5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(400, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 78);
            this.button4.TabIndex = 5;
            this.button4.Text = "Notas por aluno";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bttEx7
            // 
            this.bttEx7.Location = new System.Drawing.Point(0, 213);
            this.bttEx7.Name = "bttEx7";
            this.bttEx7.Size = new System.Drawing.Size(542, 119);
            this.bttEx7.TabIndex = 6;
            this.bttEx7.Text = "caracteres do nome";
            this.bttEx7.UseVisualStyleBackColor = true;
            this.bttEx7.Click += new System.EventHandler(this.bttEx7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttEx7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bttEx5);
            this.Controls.Add(this.bttEx4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bttEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttEx1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bttEx4;
        private System.Windows.Forms.Button bttEx5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bttEx7;
    }
}

