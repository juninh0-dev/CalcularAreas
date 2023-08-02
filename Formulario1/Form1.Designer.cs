namespace Formulario1
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.btnchama2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.btncalcular_quadrado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnchama2
            // 
            this.btnchama2.Location = new System.Drawing.Point(783, 495);
            this.btnchama2.Name = "btnchama2";
            this.btnchama2.Size = new System.Drawing.Size(93, 25);
            this.btnchama2.TabIndex = 0;
            this.btnchama2.Text = "Chama form2";
            this.btnchama2.UseVisualStyleBackColor = true;
            this.btnchama2.Click += new System.EventHandler(this.btnchama2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(317, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(288, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Calculo da Área do quadrado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "VALOR DO LADO:";
            // 
            // txtlado
            // 
            this.txtlado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlado.Location = new System.Drawing.Point(207, 122);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(223, 26);
            this.txtlado.TabIndex = 4;
            // 
            // btncalcular_quadrado
            // 
            this.btncalcular_quadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular_quadrado.Location = new System.Drawing.Point(207, 179);
            this.btncalcular_quadrado.Name = "btncalcular_quadrado";
            this.btncalcular_quadrado.Size = new System.Drawing.Size(90, 27);
            this.btncalcular_quadrado.TabIndex = 5;
            this.btncalcular_quadrado.Text = "<< CALCULAR >>";
            this.btncalcular_quadrado.UseVisualStyleBackColor = true;
            this.btncalcular_quadrado.Click += new System.EventHandler(this.btncalcular_quadrado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "RESULTADO =>";
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(207, 263);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(223, 26);
            this.txtresultado.TabIndex = 7;
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(207, 332);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(90, 27);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "<< LIMPAR >>";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfechar.Location = new System.Drawing.Point(366, 332);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(90, 27);
            this.btnfechar.TabIndex = 9;
            this.btnfechar.Text = "<< FECHAR >>";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 532);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncalcular_quadrado);
            this.Controls.Add(this.txtlado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnchama2);
            this.Name = "frm1";
            this.Text = "Formulario1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchama2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.Button btncalcular_quadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnfechar;
    }
}

