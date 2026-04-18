namespace TPWinForm
{
    partial class frmAdminMarcasYCategorias
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
            this.tabcMarcaYCategoria = new System.Windows.Forms.TabControl();
            this.tabMarca = new System.Windows.Forms.TabPage();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.lblNombreMarca = new System.Windows.Forms.Label();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.tabCategoria = new System.Windows.Forms.TabPage();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lvlNombreCategoria = new System.Windows.Forms.Label();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.tabcMarcaYCategoria.SuspendLayout();
            this.tabMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.tabCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcMarcaYCategoria
            // 
            this.tabcMarcaYCategoria.Controls.Add(this.tabMarca);
            this.tabcMarcaYCategoria.Controls.Add(this.tabCategoria);
            this.tabcMarcaYCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcMarcaYCategoria.Location = new System.Drawing.Point(0, 0);
            this.tabcMarcaYCategoria.Name = "tabcMarcaYCategoria";
            this.tabcMarcaYCategoria.SelectedIndex = 0;
            this.tabcMarcaYCategoria.Size = new System.Drawing.Size(800, 450);
            this.tabcMarcaYCategoria.TabIndex = 0;
            // 
            // tabMarca
            // 
            this.tabMarca.Controls.Add(this.txtDescripcionMarca);
            this.tabMarca.Controls.Add(this.lblDescripcionMarca);
            this.tabMarca.Controls.Add(this.btnEliminarMarca);
            this.tabMarca.Controls.Add(this.btnModificarMarca);
            this.tabMarca.Controls.Add(this.btnAgregarMarca);
            this.tabMarca.Controls.Add(this.txtNombreMarca);
            this.tabMarca.Controls.Add(this.lblNombreMarca);
            this.tabMarca.Controls.Add(this.dgvMarca);
            this.tabMarca.Location = new System.Drawing.Point(4, 22);
            this.tabMarca.Name = "tabMarca";
            this.tabMarca.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarca.Size = new System.Drawing.Size(792, 424);
            this.tabMarca.TabIndex = 0;
            this.tabMarca.Text = "Marca";
            this.tabMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(545, 100);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 5;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(452, 100);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMarca.TabIndex = 4;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(358, 100);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 3;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Location = new System.Drawing.Point(430, 33);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMarca.TabIndex = 2;
            // 
            // lblNombreMarca
            // 
            this.lblNombreMarca.AutoSize = true;
            this.lblNombreMarca.Location = new System.Drawing.Point(355, 40);
            this.lblNombreMarca.Name = "lblNombreMarca";
            this.lblNombreMarca.Size = new System.Drawing.Size(47, 13);
            this.lblNombreMarca.TabIndex = 1;
            this.lblNombreMarca.Text = "Nombre:";
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(17, 33);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(332, 337);
            this.dgvMarca.TabIndex = 0;
            // 
            // tabCategoria
            // 
            this.tabCategoria.Controls.Add(this.txtDescripcionCategoria);
            this.tabCategoria.Controls.Add(this.lblDescripcionCategoria);
            this.tabCategoria.Controls.Add(this.btnEliminarCategoria);
            this.tabCategoria.Controls.Add(this.btnModificarCategoria);
            this.tabCategoria.Controls.Add(this.btnAgregarCategoria);
            this.tabCategoria.Controls.Add(this.txtNombreCategoria);
            this.tabCategoria.Controls.Add(this.lvlNombreCategoria);
            this.tabCategoria.Controls.Add(this.dgvCategoria);
            this.tabCategoria.Location = new System.Drawing.Point(4, 22);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategoria.Size = new System.Drawing.Size(792, 424);
            this.tabCategoria.TabIndex = 1;
            this.tabCategoria.Text = "Categoría";
            this.tabCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(545, 100);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 11;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(452, 100);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 10;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(358, 100);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 9;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(430, 33);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCategoria.TabIndex = 8;
            // 
            // lvlNombreCategoria
            // 
            this.lvlNombreCategoria.AutoSize = true;
            this.lvlNombreCategoria.Location = new System.Drawing.Point(355, 40);
            this.lvlNombreCategoria.Name = "lvlNombreCategoria";
            this.lvlNombreCategoria.Size = new System.Drawing.Size(47, 13);
            this.lvlNombreCategoria.TabIndex = 7;
            this.lvlNombreCategoria.Text = "Nombre:";
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(17, 33);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(332, 337);
            this.dgvCategoria.TabIndex = 6;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(355, 69);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionMarca.TabIndex = 6;
            this.lblDescripcionMarca.Text = "Descripción:";
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(430, 62);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionMarca.TabIndex = 7;
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(430, 62);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionCategoria.TabIndex = 13;
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(355, 69);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionCategoria.TabIndex = 12;
            this.lblDescripcionCategoria.Text = "Descripción:";
            // 
            // frmAdminMarcasYCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcMarcaYCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAdminMarcasYCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admistrar Marcas y Categorías";
            this.Load += new System.EventHandler(this.frmAdminMarcasYCategorias_Load);
            this.tabcMarcaYCategoria.ResumeLayout(false);
            this.tabMarca.ResumeLayout(false);
            this.tabMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.tabCategoria.ResumeLayout(false);
            this.tabCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcMarcaYCategoria;
        private System.Windows.Forms.TabPage tabMarca;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.Label lblNombreMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lvlNombreCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Label lblDescripcionCategoria;
    }
}