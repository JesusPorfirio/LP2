namespace Triangulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.TextBox();
            this.lc = new System.Windows.Forms.TextBox();
            this.tiptrian = new System.Windows.Forms.Button();
            this.triang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgtrian = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgtrian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "lado1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "lado2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "lado3";
            // 
            // la
            // 
            this.la.Location = new System.Drawing.Point(64, 20);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(100, 22);
            this.la.TabIndex = 3;
            // 
            // lb
            // 
            this.lb.Location = new System.Drawing.Point(64, 59);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(100, 22);
            this.lb.TabIndex = 4;
            // 
            // lc
            // 
            this.lc.Location = new System.Drawing.Point(64, 103);
            this.lc.Name = "lc";
            this.lc.Size = new System.Drawing.Size(100, 22);
            this.lc.TabIndex = 5;
            // 
            // tiptrian
            // 
            this.tiptrian.Location = new System.Drawing.Point(12, 144);
            this.tiptrian.Name = "tiptrian";
            this.tiptrian.Size = new System.Drawing.Size(152, 38);
            this.tiptrian.TabIndex = 6;
            this.tiptrian.Text = "Tipo de triangulo";
            this.tiptrian.UseVisualStyleBackColor = true;
            this.tiptrian.Click += new System.EventHandler(this.tiptrian_Click);
            // 
            // triang
            // 
            this.triang.Enabled = false;
            this.triang.Location = new System.Drawing.Point(391, 20);
            this.triang.Name = "triang";
            this.triang.Size = new System.Drawing.Size(134, 22);
            this.triang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "triangulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Triangulos.Properties.Resources.imagesFK5RU8DU;
            this.pictureBox1.Location = new System.Drawing.Point(12, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 0);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // imgtrian
            // 
            this.imgtrian.Location = new System.Drawing.Point(316, 59);
            this.imgtrian.Name = "imgtrian";
            this.imgtrian.Size = new System.Drawing.Size(209, 123);
            this.imgtrian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgtrian.TabIndex = 7;
            this.imgtrian.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 206);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.triang);
            this.Controls.Add(this.imgtrian);
            this.Controls.Add(this.tiptrian);
            this.Controls.Add(this.lc);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.la);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa dos triangulos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgtrian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox la;
        private System.Windows.Forms.TextBox lb;
        private System.Windows.Forms.TextBox lc;
        private System.Windows.Forms.Button tiptrian;
        private System.Windows.Forms.PictureBox imgtrian;
        private System.Windows.Forms.TextBox triang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

