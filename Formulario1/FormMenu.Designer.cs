namespace Formulario1
{
    partial class frmmenu
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
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculoDeAreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(218, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "FECHAR PROGRAMA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(182, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calcula de Áreas";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoDeAreasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculoDeAreasToolStripMenuItem
            // 
            this.calculoDeAreasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadradoToolStripMenuItem,
            this.retanguloToolStripMenuItem,
            this.trianguloToolStripMenuItem});
            this.calculoDeAreasToolStripMenuItem.Name = "calculoDeAreasToolStripMenuItem";
            this.calculoDeAreasToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.calculoDeAreasToolStripMenuItem.Text = "Calculo de Areas";
            // 
            // retanguloToolStripMenuItem
            // 
            this.retanguloToolStripMenuItem.Name = "retanguloToolStripMenuItem";
            this.retanguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.retanguloToolStripMenuItem.Text = "Retangulo";
            this.retanguloToolStripMenuItem.Click += new System.EventHandler(this.retanguloToolStripMenuItem_Click);
            // 
            // quadradoToolStripMenuItem
            // 
            this.quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            this.quadradoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quadradoToolStripMenuItem.Text = "Quadrado";
            this.quadradoToolStripMenuItem.Click += new System.EventHandler(this.quadradoToolStripMenuItem_Click);
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.trianguloToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quadrado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(88, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Retangulo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(270, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Triangulo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.Text = "Calculo de Áreas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculoDeAreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retanguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}