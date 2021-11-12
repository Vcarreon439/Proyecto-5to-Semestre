
namespace MainForm
{
    partial class rentarLibro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temasLibro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.autoresLibro = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloLibro,
            this.editorialLibro,
            this.temasLibro,
            this.autoresLibro});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 7;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(12, 32);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(175, 35);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Generar Ficha";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(203, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "12-11-2021 12:50";
            // 
            // tituloLibro
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tituloLibro.DefaultCellStyle = dataGridViewCellStyle1;
            this.tituloLibro.HeaderText = "Titulo";
            this.tituloLibro.Name = "tituloLibro";
            this.tituloLibro.ReadOnly = true;
            // 
            // editorialLibro
            // 
            this.editorialLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.editorialLibro.HeaderText = "Editorial";
            this.editorialLibro.Name = "editorialLibro";
            // 
            // temasLibro
            // 
            this.temasLibro.HeaderText = "Temas";
            this.temasLibro.Name = "temasLibro";
            this.temasLibro.Width = 175;
            // 
            // autoresLibro
            // 
            this.autoresLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoresLibro.HeaderText = "Autores";
            this.autoresLibro.Name = "autoresLibro";
            // 
            // rentarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rentarLibro";
            this.Text = "rentarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialLibro;
        private System.Windows.Forms.DataGridViewComboBoxColumn temasLibro;
        private System.Windows.Forms.DataGridViewComboBoxColumn autoresLibro;
    }
}