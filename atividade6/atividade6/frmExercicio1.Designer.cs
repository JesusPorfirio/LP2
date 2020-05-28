namespace atividade6
{
    partial class frmExercicio1
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
            this.bttEspacoBranco = new System.Windows.Forms.Button();
            this.bttTotR = new System.Windows.Forms.Button();
            this.bttTotPares = new System.Windows.Forms.Button();
            this.rchCaixaTexto = new System.Windows.Forms.RichTextBox();
            this.txtBran = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttEspacoBranco
            // 
            this.bttEspacoBranco.Location = new System.Drawing.Point(306, 12);
            this.bttEspacoBranco.Name = "bttEspacoBranco";
            this.bttEspacoBranco.Size = new System.Drawing.Size(129, 51);
            this.bttEspacoBranco.TabIndex = 0;
            this.bttEspacoBranco.Text = "Espaços em Branco";
            this.bttEspacoBranco.UseVisualStyleBackColor = true;
            this.bttEspacoBranco.Click += new System.EventHandler(this.bttEspacoBranco_Click);
            // 
            // bttTotR
            // 
            this.bttTotR.Location = new System.Drawing.Point(306, 69);
            this.bttTotR.Name = "bttTotR";
            this.bttTotR.Size = new System.Drawing.Size(129, 38);
            this.bttTotR.TabIndex = 1;
            this.bttTotR.Text = "Total de leltras R";
            this.bttTotR.UseVisualStyleBackColor = true;
            this.bttTotR.Click += new System.EventHandler(this.bttTotR_Click);
            // 
            // bttTotPares
            // 
            this.bttTotPares.Location = new System.Drawing.Point(306, 113);
            this.bttTotPares.Name = "bttTotPares";
            this.bttTotPares.Size = new System.Drawing.Size(153, 51);
            this.bttTotPares.TabIndex = 2;
            this.bttTotPares.Text = "Total de Caracteres Pares";
            this.bttTotPares.UseVisualStyleBackColor = true;
            this.bttTotPares.Click += new System.EventHandler(this.bttTotPares_Click);
            // 
            // rchCaixaTexto
            // 
            this.rchCaixaTexto.Location = new System.Drawing.Point(12, 12);
            this.rchCaixaTexto.Name = "rchCaixaTexto";
            this.rchCaixaTexto.Size = new System.Drawing.Size(268, 351);
            this.rchCaixaTexto.TabIndex = 3;
            this.rchCaixaTexto.Text = "";
            // 
            // txtBran
            // 
            this.txtBran.Location = new System.Drawing.Point(490, 41);
            this.txtBran.Name = "txtBran";
            this.txtBran.Size = new System.Drawing.Size(100, 22);
            this.txtBran.TabIndex = 4;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(490, 85);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 22);
            this.txtR.TabIndex = 5;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(490, 142);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 22);
            this.txtCP.TabIndex = 6;
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 410);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtBran);
            this.Controls.Add(this.rchCaixaTexto);
            this.Controls.Add(this.bttTotPares);
            this.Controls.Add(this.bttTotR);
            this.Controls.Add(this.bttEspacoBranco);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttEspacoBranco;
        private System.Windows.Forms.Button bttTotR;
        private System.Windows.Forms.Button bttTotPares;
        private System.Windows.Forms.RichTextBox rchCaixaTexto;
        private System.Windows.Forms.TextBox txtBran;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtCP;
    }
}