namespace TPWinForm
{
    partial class frmDetalleArticulo
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
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.txtDetalleCategoria = new System.Windows.Forms.TextBox();
            this.txtDetalleMarca = new System.Windows.Forms.TextBox();
            this.txtDetalleCodigo = new System.Windows.Forms.TextBox();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.txtDetallePrecio = new System.Windows.Forms.TextBox();
            this.lblDetalleDescripcion = new System.Windows.Forms.Label();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.lblDetalleCategoria = new System.Windows.Forms.Label();
            this.txtDetalleNombre = new System.Windows.Forms.TextBox();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.txtDetalleDescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDetalleVolver = new System.Windows.Forms.Button();
            this.gbArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbArticulo
            // 
            this.gbArticulo.Controls.Add(this.txtDetalleCategoria);
            this.gbArticulo.Controls.Add(this.txtDetalleMarca);
            this.gbArticulo.Controls.Add(this.txtDetalleCodigo);
            this.gbArticulo.Controls.Add(this.lblDetalleNombre);
            this.gbArticulo.Controls.Add(this.txtDetallePrecio);
            this.gbArticulo.Controls.Add(this.lblDetalleDescripcion);
            this.gbArticulo.Controls.Add(this.lblDetallePrecio);
            this.gbArticulo.Controls.Add(this.lblDetalleCodigo);
            this.gbArticulo.Controls.Add(this.lblDetalleCategoria);
            this.gbArticulo.Controls.Add(this.txtDetalleNombre);
            this.gbArticulo.Controls.Add(this.lblDetalleMarca);
            this.gbArticulo.Controls.Add(this.txtDetalleDescripcion);
            this.gbArticulo.Location = new System.Drawing.Point(122, 44);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(257, 297);
            this.gbArticulo.TabIndex = 16;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Detalle del artículo";
            // 
            // txtDetalleCategoria
            // 
            this.txtDetalleCategoria.Location = new System.Drawing.Point(126, 210);
            this.txtDetalleCategoria.Name = "txtDetalleCategoria";
            this.txtDetalleCategoria.Size = new System.Drawing.Size(121, 20);
            this.txtDetalleCategoria.TabIndex = 14;
            // 
            // txtDetalleMarca
            // 
            this.txtDetalleMarca.Location = new System.Drawing.Point(126, 168);
            this.txtDetalleMarca.Name = "txtDetalleMarca";
            this.txtDetalleMarca.Size = new System.Drawing.Size(121, 20);
            this.txtDetalleMarca.TabIndex = 13;
            // 
            // txtDetalleCodigo
            // 
            this.txtDetalleCodigo.Location = new System.Drawing.Point(126, 42);
            this.txtDetalleCodigo.Name = "txtDetalleCodigo";
            this.txtDetalleCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtDetalleCodigo.TabIndex = 8;
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Location = new System.Drawing.Point(4, 87);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(44, 13);
            this.lblDetalleNombre.TabIndex = 0;
            this.lblDetalleNombre.Text = "Nombre";
            // 
            // txtDetallePrecio
            // 
            this.txtDetallePrecio.Location = new System.Drawing.Point(126, 251);
            this.txtDetallePrecio.Name = "txtDetallePrecio";
            this.txtDetallePrecio.Size = new System.Drawing.Size(121, 20);
            this.txtDetallePrecio.TabIndex = 10;
            // 
            // lblDetalleDescripcion
            // 
            this.lblDetalleDescripcion.AutoSize = true;
            this.lblDetalleDescripcion.Location = new System.Drawing.Point(4, 131);
            this.lblDetalleDescripcion.Name = "lblDetalleDescripcion";
            this.lblDetalleDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDetalleDescripcion.TabIndex = 1;
            this.lblDetalleDescripcion.Text = "Descripción";
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Location = new System.Drawing.Point(4, 254);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(37, 13);
            this.lblDetallePrecio.TabIndex = 5;
            this.lblDetallePrecio.Text = "Precio";
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(4, 42);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblDetalleCodigo.TabIndex = 2;
            this.lblDetalleCodigo.Text = "Código";
            // 
            // lblDetalleCategoria
            // 
            this.lblDetalleCategoria.AutoSize = true;
            this.lblDetalleCategoria.Location = new System.Drawing.Point(4, 213);
            this.lblDetalleCategoria.Name = "lblDetalleCategoria";
            this.lblDetalleCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblDetalleCategoria.TabIndex = 4;
            this.lblDetalleCategoria.Text = "Categoría";
            // 
            // txtDetalleNombre
            // 
            this.txtDetalleNombre.Location = new System.Drawing.Point(126, 80);
            this.txtDetalleNombre.Name = "txtDetalleNombre";
            this.txtDetalleNombre.Size = new System.Drawing.Size(121, 20);
            this.txtDetalleNombre.TabIndex = 6;
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Location = new System.Drawing.Point(4, 175);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(37, 13);
            this.lblDetalleMarca.TabIndex = 3;
            this.lblDetalleMarca.Text = "Marca";
            // 
            // txtDetalleDescripcion
            // 
            this.txtDetalleDescripcion.Location = new System.Drawing.Point(126, 124);
            this.txtDetalleDescripcion.Name = "txtDetalleDescripcion";
            this.txtDetalleDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDetalleDescripcion.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(461, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 297);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnDetalleVolver
            // 
            this.btnDetalleVolver.Location = new System.Drawing.Point(661, 376);
            this.btnDetalleVolver.Name = "btnDetalleVolver";
            this.btnDetalleVolver.Size = new System.Drawing.Size(75, 23);
            this.btnDetalleVolver.TabIndex = 18;
            this.btnDetalleVolver.Text = "Volver";
            this.btnDetalleVolver.UseVisualStyleBackColor = true;
            this.btnDetalleVolver.Click += new System.EventHandler(this.btnDetalleVolver_Click);
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetalleVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle de artículo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            this.gbArticulo.ResumeLayout(false);
            this.gbArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbArticulo;
        private System.Windows.Forms.TextBox txtDetalleCategoria;
        private System.Windows.Forms.TextBox txtDetalleMarca;
        private System.Windows.Forms.TextBox txtDetalleCodigo;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.TextBox txtDetallePrecio;
        private System.Windows.Forms.Label lblDetalleDescripcion;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.Label lblDetalleCategoria;
        private System.Windows.Forms.TextBox txtDetalleNombre;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.TextBox txtDetalleDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDetalleVolver;
    }
}