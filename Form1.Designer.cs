namespace PruebaGitHub_FrancisAlexander
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlIzquierda = new System.Windows.Forms.Panel();
			this.pnlContenedor = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.pnlHeader.SuspendLayout();
			this.pnlContenedor.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(185, 80);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "Francis Gonzalez";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(320, 220);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.SystemColors.Highlight;
			this.pnlHeader.Controls.Add(this.label2);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(912, 43);
			this.pnlHeader.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(833, 5);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 39);
			this.label2.TabIndex = 2;
			this.label2.Text = "X";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// pnlIzquierda
			// 
			this.pnlIzquierda.BackColor = System.Drawing.SystemColors.Highlight;
			this.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlIzquierda.Location = new System.Drawing.Point(0, 43);
			this.pnlIzquierda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlIzquierda.Name = "pnlIzquierda";
			this.pnlIzquierda.Size = new System.Drawing.Size(181, 442);
			this.pnlIzquierda.TabIndex = 3;
			// 
			// pnlContenedor
			// 
			this.pnlContenedor.Controls.Add(this.comboBox1);
			this.pnlContenedor.Controls.Add(this.button2);
			this.pnlContenedor.Controls.Add(this.button1);
			this.pnlContenedor.Controls.Add(this.label1);
			this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContenedor.Location = new System.Drawing.Point(181, 43);
			this.pnlContenedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlContenedor.Name = "pnlContenedor";
			this.pnlContenedor.Size = new System.Drawing.Size(731, 442);
			this.pnlContenedor.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(133, 214);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(285, 315);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(912, 485);
			this.Controls.Add(this.pnlContenedor);
			this.Controls.Add(this.pnlIzquierda);
			this.Controls.Add(this.pnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.pnlContenedor.ResumeLayout(false);
			this.pnlContenedor.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlIzquierda;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

