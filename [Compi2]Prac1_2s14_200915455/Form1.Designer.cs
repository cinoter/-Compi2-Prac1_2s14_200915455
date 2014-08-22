namespace _Compi2_Prac1_2s14_200915455
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEntrada = new System.Windows.Forms.TabPage();
            this.rtbEntrada = new System.Windows.Forms.RichTextBox();
            this.tabSalida = new System.Windows.Forms.TabPage();
            this.rtbSalida = new System.Windows.Forms.RichTextBox();
            this.tabReporte = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEntrada.SuspendLayout();
            this.tabSalida.SuspendLayout();
            this.tabReporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabEntrada);
            this.tabControl1.Controls.Add(this.tabSalida);
            this.tabControl1.Controls.Add(this.tabReporte);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEntrada
            // 
            this.tabEntrada.Controls.Add(this.rtbEntrada);
            this.tabEntrada.Location = new System.Drawing.Point(4, 22);
            this.tabEntrada.Name = "tabEntrada";
            this.tabEntrada.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntrada.Size = new System.Drawing.Size(670, 327);
            this.tabEntrada.TabIndex = 0;
            this.tabEntrada.Text = "Entrada";
            this.tabEntrada.UseVisualStyleBackColor = true;
            // 
            // rtbEntrada
            // 
            this.rtbEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbEntrada.Location = new System.Drawing.Point(6, 6);
            this.rtbEntrada.Name = "rtbEntrada";
            this.rtbEntrada.Size = new System.Drawing.Size(657, 315);
            this.rtbEntrada.TabIndex = 0;
            this.rtbEntrada.Text = "";
            // 
            // tabSalida
            // 
            this.tabSalida.Controls.Add(this.rtbSalida);
            this.tabSalida.Location = new System.Drawing.Point(4, 22);
            this.tabSalida.Name = "tabSalida";
            this.tabSalida.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalida.Size = new System.Drawing.Size(670, 327);
            this.tabSalida.TabIndex = 1;
            this.tabSalida.Text = "Salida";
            this.tabSalida.UseVisualStyleBackColor = true;
            // 
            // rtbSalida
            // 
            this.rtbSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSalida.Location = new System.Drawing.Point(6, 6);
            this.rtbSalida.Name = "rtbSalida";
            this.rtbSalida.Size = new System.Drawing.Size(658, 321);
            this.rtbSalida.TabIndex = 0;
            this.rtbSalida.Text = "";
            // 
            // tabReporte
            // 
            this.tabReporte.Controls.Add(this.webBrowser1);
            this.tabReporte.Location = new System.Drawing.Point(4, 22);
            this.tabReporte.Name = "tabReporte";
            this.tabReporte.Size = new System.Drawing.Size(670, 327);
            this.tabReporte.TabIndex = 2;
            this.tabReporte.Text = "Reporte";
            this.tabReporte.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(667, 324);
            this.webBrowser1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(285, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Compilar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "APLICACION B";
            this.tabControl1.ResumeLayout(false);
            this.tabEntrada.ResumeLayout(false);
            this.tabSalida.ResumeLayout(false);
            this.tabReporte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEntrada;
        private System.Windows.Forms.RichTextBox rtbEntrada;
        private System.Windows.Forms.TabPage tabSalida;
        private System.Windows.Forms.TabPage tabReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbSalida;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

