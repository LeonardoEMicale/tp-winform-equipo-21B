namespace TPWinForm
{
    partial class frmAltaMarca
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
            this.btcAceptarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btcAceptarMarca
            // 
            this.btcAceptarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btcAceptarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btcAceptarMarca.Location = new System.Drawing.Point(82, 163);
            this.btcAceptarMarca.Name = "btcAceptarMarca";
            this.btcAceptarMarca.Size = new System.Drawing.Size(75, 23);
            this.btcAceptarMarca.TabIndex = 2;
            this.btcAceptarMarca.Text = "Aceptar";
            this.btcAceptarMarca.UseVisualStyleBackColor = true;
            this.btcAceptarMarca.Click += new System.EventHandler(this.btcAceptarMarca_Click);
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelarMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.btnCancelarMarca.Location = new System.Drawing.Point(176, 163);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMarca.TabIndex = 1;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(151, 100);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionMarca.TabIndex = 0;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(79, 107);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionMarca.TabIndex = 3;
            this.lblDescripcionMarca.Text = "Descripción:";
            // 
            // frmAltaMarca
            // 
            this.AcceptButton = this.btcAceptarMarca;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(337, 292);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btcAceptarMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de Marca";
            this.Load += new System.EventHandler(this.frmAltaMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcAceptarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
    }
}