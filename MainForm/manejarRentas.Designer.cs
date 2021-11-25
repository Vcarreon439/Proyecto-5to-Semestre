
namespace MainForm
{
    partial class manejarRentas
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
            CustomControls.CheckBoxComboBox.CheckBoxProperties checkBoxProperties2 = new CustomControls.CheckBoxComboBox.CheckBoxProperties();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxComboBox1 = new CustomControls.CheckBoxComboBox.CheckBoxComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCliente,
            this.codRenta,
            this.estado,
            this.fecha,
            this.fechaLimite});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // nomCliente
            // 
            this.nomCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomCliente.HeaderText = "Nombre";
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.ReadOnly = true;
            // 
            // codRenta
            // 
            this.codRenta.HeaderText = "Renta";
            this.codRenta.Name = "codRenta";
            this.codRenta.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado de renta";
            this.estado.Items.AddRange(new object[] {
            "Por confirmar",
            "Activa",
            "Vencida"});
            this.estado.Name = "estado";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fechaLimite
            // 
            this.fechaLimite.HeaderText = "Fecha Limite";
            this.fechaLimite.Name = "fechaLimite";
            this.fechaLimite.ReadOnly = true;
            // 
            // checkBoxComboBox1
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxComboBox1.CheckBoxProperties = checkBoxProperties2;
            this.checkBoxComboBox1.DisplayMemberSingleItem = "";
            this.checkBoxComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.checkBoxComboBox1.FormattingEnabled = true;
            this.checkBoxComboBox1.Items.AddRange(new object[] {
            "Por confirmar",
            "Activa",
            "Vencida"});
            this.checkBoxComboBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBoxComboBox1.Name = "checkBoxComboBox1";
            this.checkBoxComboBox1.Size = new System.Drawing.Size(241, 28);
            this.checkBoxComboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox1.Location = new System.Drawing.Point(565, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 27);
            this.textBox1.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(527, 13);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // manejarRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxComboBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "manejarRentas";
            this.Text = "manejarRentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codRenta;
        private System.Windows.Forms.DataGridViewComboBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLimite;
        private CustomControls.CheckBoxComboBox.CheckBoxComboBox checkBoxComboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}