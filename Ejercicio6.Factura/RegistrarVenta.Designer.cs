namespace Ejercicio6.Factura
{
    partial class RegistrarVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido, Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(154, 31);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(267, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // gbItems
            // 
            this.gbItems.Controls.Add(this.lbPrecio);
            this.gbItems.Controls.Add(this.label2);
            this.gbItems.Controls.Add(this.lbCantidad);
            this.gbItems.Controls.Add(this.lbCodigo);
            this.gbItems.Controls.Add(this.tbCantidad);
            this.gbItems.Controls.Add(this.tbCodigo);
            this.gbItems.Controls.Add(this.btnBuscar);
            this.gbItems.Location = new System.Drawing.Point(12, 57);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(434, 100);
            this.gbItems.TabIndex = 2;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Items";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(342, 64);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(28, 13);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "U$S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio en U$S";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(24, 67);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 4;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(24, 36);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 3;
            this.lbCodigo.Text = "Código";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(101, 64);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 2;
            this.tbCantidad.Text = "0";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(101, 30);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnBuscar.Location = new System.Drawing.Point(223, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 54);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total a Pagar";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(191, 171);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(22, 13);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "$...";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Location = new System.Drawing.Point(113, 202);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(96, 33);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(235, 202);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 33);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 247);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarVenta";
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.GroupBox gbItems;
        public System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Label lbCantidad;
        public System.Windows.Forms.Label lbCodigo;
        public System.Windows.Forms.TextBox tbCantidad;
        public System.Windows.Forms.TextBox tbCodigo;
        public System.Windows.Forms.Label lbPrecio;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbTotal;
        public System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.Button btnCancel;
    }
}