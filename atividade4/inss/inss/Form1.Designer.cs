namespace inss
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
            this.Nome = new System.Windows.Forms.MaskedTextBox();
            this.Sbruto = new System.Windows.Forms.MaskedTextBox();
            this.Filhos = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Femea = new System.Windows.Forms.RadioButton();
            this.Macho = new System.Windows.Forms.RadioButton();
            this.Desconto = new System.Windows.Forms.Button();
            this.dialogo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AliInss = new System.Windows.Forms.MaskedTextBox();
            this.irpf = new System.Windows.Forms.MaskedTextBox();
            this.sfilhos = new System.Windows.Forms.MaskedTextBox();
            this.salario = new System.Windows.Forms.MaskedTextBox();
            this.dInss = new System.Windows.Forms.MaskedTextBox();
            this.dIrpf = new System.Windows.Forms.MaskedTextBox();
            this.Casado = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Funcionario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario bruto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de filhos";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(142, 17);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 22);
            this.Nome.TabIndex = 3;
            // 
            // Sbruto
            // 
            this.Sbruto.Location = new System.Drawing.Point(142, 45);
            this.Sbruto.Mask = "000000.00";
            this.Sbruto.Name = "Sbruto";
            this.Sbruto.Size = new System.Drawing.Size(100, 22);
            this.Sbruto.TabIndex = 4;
            // 
            // Filhos
            // 
            this.Filhos.Location = new System.Drawing.Point(142, 73);
            this.Filhos.Mask = "00";
            this.Filhos.Name = "Filhos";
            this.Filhos.Size = new System.Drawing.Size(100, 22);
            this.Filhos.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Femea);
            this.groupBox1.Controls.Add(this.Macho);
            this.groupBox1.Location = new System.Drawing.Point(284, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // Femea
            // 
            this.Femea.AutoSize = true;
            this.Femea.Location = new System.Drawing.Point(6, 48);
            this.Femea.Name = "Femea";
            this.Femea.Size = new System.Drawing.Size(86, 21);
            this.Femea.TabIndex = 8;
            this.Femea.Text = "Feminino";
            this.Femea.UseVisualStyleBackColor = true;
            this.Femea.CheckedChanged += new System.EventHandler(this.Femea_CheckedChanged);
            // 
            // Macho
            // 
            this.Macho.AutoSize = true;
            this.Macho.Checked = true;
            this.Macho.Location = new System.Drawing.Point(6, 21);
            this.Macho.Name = "Macho";
            this.Macho.Size = new System.Drawing.Size(92, 21);
            this.Macho.TabIndex = 7;
            this.Macho.TabStop = true;
            this.Macho.Text = "Masculino";
            this.Macho.UseVisualStyleBackColor = true;
            this.Macho.CheckedChanged += new System.EventHandler(this.Macho_CheckedChanged);
            // 
            // Desconto
            // 
            this.Desconto.Location = new System.Drawing.Point(12, 108);
            this.Desconto.Name = "Desconto";
            this.Desconto.Size = new System.Drawing.Size(230, 113);
            this.Desconto.TabIndex = 0;
            this.Desconto.Text = "Verificar Desconto";
            this.Desconto.UseVisualStyleBackColor = true;
            this.Desconto.Click += new System.EventHandler(this.Desconto_Click);
            // 
            // dialogo
            // 
            this.dialogo.AutoSize = true;
            this.dialogo.Location = new System.Drawing.Point(13, 246);
            this.dialogo.Name = "dialogo";
            this.dialogo.Size = new System.Drawing.Size(68, 17);
            this.dialogo.TabIndex = 10;
            this.dialogo.Text = "LblDados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aliquota Inss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Aliquota Irpf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Salario Familia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salario Liquido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Desconto Inss";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Desconto Irpf";
            // 
            // AliInss
            // 
            this.AliInss.Enabled = false;
            this.AliInss.Location = new System.Drawing.Point(142, 290);
            this.AliInss.Name = "AliInss";
            this.AliInss.Size = new System.Drawing.Size(100, 22);
            this.AliInss.TabIndex = 17;
            // 
            // irpf
            // 
            this.irpf.Enabled = false;
            this.irpf.Location = new System.Drawing.Point(142, 339);
            this.irpf.Name = "irpf";
            this.irpf.Size = new System.Drawing.Size(100, 22);
            this.irpf.TabIndex = 18;
            // 
            // sfilhos
            // 
            this.sfilhos.Enabled = false;
            this.sfilhos.Location = new System.Drawing.Point(142, 378);
            this.sfilhos.Name = "sfilhos";
            this.sfilhos.Size = new System.Drawing.Size(100, 22);
            this.sfilhos.TabIndex = 19;
            // 
            // salario
            // 
            this.salario.Enabled = false;
            this.salario.Location = new System.Drawing.Point(142, 421);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(100, 22);
            this.salario.TabIndex = 20;
            // 
            // dInss
            // 
            this.dInss.Enabled = false;
            this.dInss.Location = new System.Drawing.Point(399, 289);
            this.dInss.Name = "dInss";
            this.dInss.Size = new System.Drawing.Size(100, 22);
            this.dInss.TabIndex = 21;
            // 
            // dIrpf
            // 
            this.dIrpf.Enabled = false;
            this.dIrpf.Location = new System.Drawing.Point(399, 341);
            this.dIrpf.Name = "dIrpf";
            this.dIrpf.Size = new System.Drawing.Size(100, 22);
            this.dIrpf.TabIndex = 22;
            // 
            // Casado
            // 
            this.Casado.AutoSize = true;
            this.Casado.Location = new System.Drawing.Point(284, 126);
            this.Casado.Name = "Casado";
            this.Casado.Size = new System.Drawing.Size(78, 21);
            this.Casado.TabIndex = 9;
            this.Casado.Text = "Casado";
            this.Casado.UseVisualStyleBackColor = true;
            this.Casado.CheckedChanged += new System.EventHandler(this.Casado_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 232);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(472, 51);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inss.Properties.Resources.images_9_;
            this.pictureBox1.Location = new System.Drawing.Point(248, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(300, 400);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(514, 457);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Casado);
            this.Controls.Add(this.dIrpf);
            this.Controls.Add(this.dInss);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.sfilhos);
            this.Controls.Add(this.irpf);
            this.Controls.Add(this.AliInss);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dialogo);
            this.Controls.Add(this.Desconto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filhos);
            this.Controls.Add(this.Sbruto);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo Inss";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Nome;
        private System.Windows.Forms.MaskedTextBox Sbruto;
        private System.Windows.Forms.MaskedTextBox Filhos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Femea;
        private System.Windows.Forms.RadioButton Macho;
        private System.Windows.Forms.Button Desconto;
        private System.Windows.Forms.Label dialogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox AliInss;
        private System.Windows.Forms.MaskedTextBox irpf;
        private System.Windows.Forms.MaskedTextBox sfilhos;
        private System.Windows.Forms.MaskedTextBox salario;
        private System.Windows.Forms.MaskedTextBox dInss;
        private System.Windows.Forms.MaskedTextBox dIrpf;
        private System.Windows.Forms.CheckBox Casado;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

