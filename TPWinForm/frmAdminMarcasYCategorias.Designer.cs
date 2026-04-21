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
            this.btnVolverMarca = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.tabCategoria = new System.Windows.Forms.TabPage();
            this.btnVolverCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
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
            this.tabMarca.Controls.Add(this.btnVolverMarca);
            this.tabMarca.Controls.Add(this.btnEliminarMarca);
            this.tabMarca.Controls.Add(this.btnModificarMarca);
            this.tabMarca.Controls.Add(this.btnAgregarMarca);
            this.tabMarca.Controls.Add(this.dgvMarca);
            this.tabMarca.Location = new System.Drawing.Point(4, 22);
            this.tabMarca.Name = "tabMarca";
            this.tabMarca.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarca.Size = new System.Drawing.Size(792, 424);
            this.tabMarca.TabIndex = 0;
            this.tabMarca.Text = "Marca";
            this.tabMarca.UseVisualStyleBackColor = true;
            // 
            // btnVolverMarca
            // 
            this.btnVolverMarca.Location = new System.Drawing.Point(372, 127);
            this.btnVolverMarca.Name = "btnVolverMarca";
            this.btnVolverMarca.Size = new System.Drawing.Size(75, 23);
            this.btnVolverMarca.TabIndex = 6;
            this.btnVolverMarca.Text = "Volver";
            this.btnVolverMarca.UseVisualStyleBackColor = true;
            this.btnVolverMarca.Click += new System.EventHandler(this.btnVolverMarca_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(559, 33);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMarca.TabIndex = 5;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(466, 33);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMarca.TabIndex = 4;
            this.btnModificarMarca.Text = "Modificar";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            this.btnModificarMarca.Click += new System.EventHandler(this.btnModificarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(372, 33);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 3;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarca.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarca.Location = new System.Drawing.Point(17, 33);
            this.dgvMarca.MultiSelect = false;
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.ReadOnly = true;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(332, 337);
            this.dgvMarca.TabIndex = 0;
            // 
            // tabCategoria
            // 
            this.tabCategoria.Controls.Add(this.btnVolverCategoria);
            this.tabCategoria.Controls.Add(this.btnEliminarCategoria);
            this.tabCategoria.Controls.Add(this.btnModificarCategoria);
            this.tabCategoria.Controls.Add(this.btnAgregarCategoria);
            this.tabCategoria.Controls.Add(this.dgvCategoria);
            this.tabCategoria.Location = new System.Drawing.Point(4, 22);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategoria.Size = new System.Drawing.Size(792, 424);
            this.tabCategoria.TabIndex = 1;
            this.tabCategoria.Text = "Categoría";
            this.tabCategoria.UseVisualStyleBackColor = true;
            // 
            // btnVolverCategoria
            // 
            this.btnVolverCategoria.Location = new System.Drawing.Point(372, 127);
            this.btnVolverCategoria.Name = "btnVolverCategoria";
            this.btnVolverCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnVolverCategoria.TabIndex = 12;
            this.btnVolverCategoria.Text = "Volver";
            this.btnVolverCategoria.UseVisualStyleBackColor = true;
            this.btnVolverCategoria.Click += new System.EventHandler(this.btnVolverCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(559, 33);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 11;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(466, 33);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCategoria.TabIndex = 10;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(372, 33);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 9;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.Location = new System.Drawing.Point(17, 33);
            this.dgvCategoria.MultiSelect = false;
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(332, 337);
            this.dgvCategoria.TabIndex = 6;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.tabCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcMarcaYCategoria;
        private System.Windows.Forms.TabPage tabMarca;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.DataGridView dgvMarca;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnVolverMarca;
        private System.Windows.Forms.Button btnVolverCategoria;
    }
}