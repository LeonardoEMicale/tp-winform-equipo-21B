namespace TPWinForm
{
    partial class frmAltaCategoria
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
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.btcAceptarCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(79, 107);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionCategoria.TabIndex = 7;
            this.lblDescripcionCategoria.Text = "Descripción:";
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(151, 100);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionCategoria.TabIndex = 0;
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btnCancelarCategoria.Location = new System.Drawing.Point(176, 163);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCategoria.TabIndex = 5;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = false;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.btnCancelarCategoria_Click);
            // 
            // btcAceptarCategoria
            // 
            this.btcAceptarCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btcAceptarCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btcAceptarCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btcAceptarCategoria.Location = new System.Drawing.Point(82, 163);
            this.btcAceptarCategoria.Name = "btcAceptarCategoria";
            this.btcAceptarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btcAceptarCategoria.TabIndex = 4;
            this.btcAceptarCategoria.Text = "Aceptar";
            this.btcAceptarCategoria.UseVisualStyleBackColor = false;
            this.btcAceptarCategoria.Click += new System.EventHandler(this.btcAceptarCategoria_Click);
            // 
            // frmAltaCategoria
            // 
            this.AcceptButton = this.btcAceptarCategoria;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(337, 292);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.btcAceptarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de Categoría";
            this.Load += new System.EventHandler(this.frmAltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.Button btcAceptarCategoria;
    }
}