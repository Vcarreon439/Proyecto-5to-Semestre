
namespace MainForm
{
    partial class frmAddEditorials
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.codigoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.correoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.direccionKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nombreKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.dgvEditoriales = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.telefonoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fullEditorialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            codigoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullEditorialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            codigoLabel.Location = new System.Drawing.Point(22, 22);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(57, 23);
            codigoLabel.TabIndex = 1;
            codigoLabel.Text = "Codigo:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            correoLabel.Location = new System.Drawing.Point(22, 100);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(57, 23);
            correoLabel.TabIndex = 2;
            correoLabel.Text = "Correo:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            direccionLabel.Location = new System.Drawing.Point(442, 24);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(72, 23);
            direccionLabel.TabIndex = 4;
            direccionLabel.Text = "Direccion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            nombreLabel.Location = new System.Drawing.Point(22, 61);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(65, 23);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre:";
            // 
            // codigoKryptonTextBox
            // 
            this.codigoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullEditorialBindingSource, "Codigo", true));
            this.codigoKryptonTextBox.Location = new System.Drawing.Point(200, 22);
            this.codigoKryptonTextBox.Name = "codigoKryptonTextBox";
            this.codigoKryptonTextBox.Size = new System.Drawing.Size(217, 33);
            this.codigoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.codigoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.codigoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.codigoKryptonTextBox.TabIndex = 1;
            // 
            // correoKryptonTextBox
            // 
            this.correoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullEditorialBindingSource, "Correo", true));
            this.correoKryptonTextBox.Location = new System.Drawing.Point(93, 100);
            this.correoKryptonTextBox.Name = "correoKryptonTextBox";
            this.correoKryptonTextBox.Size = new System.Drawing.Size(324, 33);
            this.correoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.correoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.correoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.correoKryptonTextBox.TabIndex = 3;
            // 
            // direccionKryptonTextBox
            // 
            this.direccionKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullEditorialBindingSource, "Direccion", true));
            this.direccionKryptonTextBox.Location = new System.Drawing.Point(446, 50);
            this.direccionKryptonTextBox.Multiline = true;
            this.direccionKryptonTextBox.Name = "direccionKryptonTextBox";
            this.direccionKryptonTextBox.Size = new System.Drawing.Size(342, 122);
            this.direccionKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.direccionKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.direccionKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.direccionKryptonTextBox.TabIndex = 5;
            // 
            // nombreKryptonTextBox
            // 
            this.nombreKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullEditorialBindingSource, "Nombre", true));
            this.nombreKryptonTextBox.Location = new System.Drawing.Point(93, 61);
            this.nombreKryptonTextBox.Name = "nombreKryptonTextBox";
            this.nombreKryptonTextBox.Size = new System.Drawing.Size(324, 33);
            this.nombreKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nombreKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.nombreKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.nombreKryptonTextBox.TabIndex = 2;
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoriales.Location = new System.Drawing.Point(23, 216);
            this.dgvEditoriales.Name = "dgvEditoriales";
            this.dgvEditoriales.ReadOnly = true;
            this.dgvEditoriales.Size = new System.Drawing.Size(765, 192);
            this.dgvEditoriales.TabIndex = 10;
            this.dgvEditoriales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditoriales_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(713, 178);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Delete";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(632, 178);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Edit";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(551, 178);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Add";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            telefonoLabel.Location = new System.Drawing.Point(22, 149);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(68, 23);
            telefonoLabel.TabIndex = 12;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoKryptonTextBox
            // 
            this.telefonoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullEditorialBindingSource, "Telefono", true));
            this.telefonoKryptonTextBox.Location = new System.Drawing.Point(93, 139);
            this.telefonoKryptonTextBox.Name = "telefonoKryptonTextBox";
            this.telefonoKryptonTextBox.Size = new System.Drawing.Size(324, 33);
            this.telefonoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.telefonoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.telefonoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.telefonoKryptonTextBox.TabIndex = 13;
            // 
            // fullEditorialBindingSource
            // 
            this.fullEditorialBindingSource.DataSource = typeof(Elementos.ElementosBiblioteca.Editorial.FullEditorial);
            // 
            // frmAddEditorials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 428);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoKryptonTextBox);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEditoriales);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreKryptonTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionKryptonTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoKryptonTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoKryptonTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditorials";
            this.Text = "frmAddEditorials";
            this.Load += new System.EventHandler(this.frmAddEditorials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullEditorialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fullEditorialBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox codigoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox correoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox direccionKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nombreKryptonTextBox;
        private System.Windows.Forms.DataGridView dgvEditoriales;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox telefonoKryptonTextBox;
    }
}