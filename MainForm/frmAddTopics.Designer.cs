
namespace MainForm
{
    partial class frmAddTopics
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
            System.Windows.Forms.Label descripcionLabel;
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.codigoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.temaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            codigoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            codigoLabel.Location = new System.Drawing.Point(17, 18);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(62, 23);
            codigoLabel.TabIndex = 16;
            codigoLabel.Text = "Id Topic:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            descripcionLabel.Location = new System.Drawing.Point(17, 101);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(47, 23);
            descripcionLabel.TabIndex = 17;
            descripcionLabel.Text = "Topic:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location = new System.Drawing.Point(143, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 47);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Delete";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(143, 244);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(165, 47);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Edit";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(143, 191);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(165, 47);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Add";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.Location = new System.Drawing.Point(330, 18);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.ReadOnly = true;
            this.dgvGeneros.Size = new System.Drawing.Size(474, 546);
            this.dgvGeneros.TabIndex = 10;
            this.dgvGeneros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneros_CellClick);
            this.dgvGeneros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneros_CellContentClick);
            // 
            // codigoKryptonTextBox
            // 
            this.codigoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temaBindingSource, "Codigo", true));
            this.codigoKryptonTextBox.Location = new System.Drawing.Point(21, 55);
            this.codigoKryptonTextBox.Name = "codigoKryptonTextBox";
            this.codigoKryptonTextBox.Size = new System.Drawing.Size(287, 33);
            this.codigoKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.codigoKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.codigoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.codigoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.codigoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoKryptonTextBox.TabIndex = 17;
            this.codigoKryptonTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigoKryptonTextBox_KeyPress);
            // 
            // temaBindingSource
            // 
            this.temaBindingSource.DataSource = typeof(Elementos.Tema);
            // 
            // descripcionKryptonTextBox
            // 
            this.descripcionKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.temaBindingSource, "Descripcion", true));
            this.descripcionKryptonTextBox.Location = new System.Drawing.Point(21, 135);
            this.descripcionKryptonTextBox.Name = "descripcionKryptonTextBox";
            this.descripcionKryptonTextBox.Size = new System.Drawing.Size(287, 33);
            this.descripcionKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.descripcionKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.descripcionKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.descripcionKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.descripcionKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.descripcionKryptonTextBox.TabIndex = 18;
            // 
            // frmAddTopics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 576);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionKryptonTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoKryptonTextBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvGeneros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddTopics";
            this.Text = "frmAddTopics";
            this.Load += new System.EventHandler(this.frmAddTopics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.BindingSource temaBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox codigoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox descripcionKryptonTextBox;
    }
}