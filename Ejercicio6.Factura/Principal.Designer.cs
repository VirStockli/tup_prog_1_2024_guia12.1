﻿namespace Ejercicio6.Factura
{
    partial class Principal
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
            this.lbFactura = new System.Windows.Forms.ListBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnVerRec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFactura
            // 
            this.lbFactura.FormattingEnabled = true;
            this.lbFactura.Location = new System.Drawing.Point(12, 12);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(256, 290);
            this.lbFactura.TabIndex = 0;
            // 
            // btnFacturar
            // 
            this.btnFacturar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFacturar.Location = new System.Drawing.Point(274, 56);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(105, 54);
            this.btnFacturar.TabIndex = 1;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnVerRec
            // 
            this.btnVerRec.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerRec.Location = new System.Drawing.Point(274, 189);
            this.btnVerRec.Name = "btnVerRec";
            this.btnVerRec.Size = new System.Drawing.Size(105, 53);
            this.btnVerRec.TabIndex = 2;
            this.btnVerRec.Text = "Ver Recaudación";
            this.btnVerRec.UseVisualStyleBackColor = true;
            this.btnVerRec.Click += new System.EventHandler(this.btnVerRec_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 316);
            this.Controls.Add(this.btnVerRec);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lbFactura);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFactura;
        public System.Windows.Forms.Button btnFacturar;
        public System.Windows.Forms.Button btnVerRec;
    }
}

