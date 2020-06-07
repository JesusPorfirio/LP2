namespace Atvidade7
{
    partial class frmEx7
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
            this.bttExecut = new System.Windows.Forms.Button();
            this.listNomes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttExecut
            // 
            this.bttExecut.Location = new System.Drawing.Point(69, 12);
            this.bttExecut.Name = "bttExecut";
            this.bttExecut.Size = new System.Drawing.Size(218, 169);
            this.bttExecut.TabIndex = 0;
            this.bttExecut.Text = "Add Nomes";
            this.bttExecut.UseVisualStyleBackColor = true;
            this.bttExecut.Click += new System.EventHandler(this.bttExecut_Click);
            // 
            // listNomes
            // 
            this.listNomes.FormattingEnabled = true;
            this.listNomes.ItemHeight = 16;
            this.listNomes.Location = new System.Drawing.Point(484, 12);
            this.listNomes.Name = "listNomes";
            this.listNomes.Size = new System.Drawing.Size(593, 420);
            this.listNomes.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 87);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remover item selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 76);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar Lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmEx7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listNomes);
            this.Controls.Add(this.bttExecut);
            this.Name = "frmEx7";
            this.Text = "frmEx7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttExecut;
        private System.Windows.Forms.ListBox listNomes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}