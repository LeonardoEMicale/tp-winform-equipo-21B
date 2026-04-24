namespace TPWinForm
{
    partial class frmGestionImagen
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
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.lbListaImg = new System.Windows.Forms.ListBox();
            this.pbGestImagen = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtUrlNueva = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGestImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(256, 191);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(114, 23);
            this.btnAgregarImg.TabIndex = 4;
            this.btnAgregarImg.Text = "Agregar Imagen";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Location = new System.Drawing.Point(256, 220);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(114, 23);
            this.btnEliminarImg.TabIndex = 5;
            this.btnEliminarImg.Text = "Eliminar Imagen";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // lbListaImg
            // 
            this.lbListaImg.FormattingEnabled = true;
            this.lbListaImg.Location = new System.Drawing.Point(57, 12);
            this.lbListaImg.Name = "lbListaImg";
            this.lbListaImg.Size = new System.Drawing.Size(313, 173);
            this.lbListaImg.TabIndex = 6;
            this.lbListaImg.SelectedIndexChanged += new System.EventHandler(this.lbListaImg_SelectedIndexChanged);
            // 
            // pbGestImagen
            // 
            this.pbGestImagen.Location = new System.Drawing.Point(423, 12);
            this.pbGestImagen.Name = "pbGestImagen";
            this.pbGestImagen.Size = new System.Drawing.Size(212, 173);
            this.pbGestImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGestImagen.TabIndex = 7;
            this.pbGestImagen.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(560, 220);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtUrlNueva
            // 
            this.txtUrlNueva.Location = new System.Drawing.Point(57, 191);
            this.txtUrlNueva.Name = "txtUrlNueva";
            this.txtUrlNueva.Size = new System.Drawing.Size(193, 20);
            this.txtUrlNueva.TabIndex = 9;
            // 
            // frmGestionImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 266);
            this.Controls.Add(this.txtUrlNueva);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbGestImagen);
            this.Controls.Add(this.lbListaImg);
            this.Controls.Add(this.btnEliminarImg);
            this.Controls.Add(this.btnAgregarImg);
            this.Name = "frmGestionImagen";
            this.Text = "Gestion de Imagenes";
            this.Load += new System.EventHandler(this.frmGestionImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGestImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarImg;
        private System.Windows.Forms.Button btnEliminarImg;
        private System.Windows.Forms.ListBox lbListaImg;
        private System.Windows.Forms.PictureBox pbGestImagen;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtUrlNueva;
    }
}