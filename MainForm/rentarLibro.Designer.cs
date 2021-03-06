
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temasLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoresLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRentar = new RJCodeAdvance.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnUpdate = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tituloLibro,
            this.editorialLibro,
            this.temasLibro,
            this.autoresLibro});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // tituloLibro
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.editorialLibro.ReadOnly = true;
            // 
            // temasLibro
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.temasLibro.DefaultCellStyle = dataGridViewCellStyle2;
            this.temasLibro.HeaderText = "Temas";
            this.temasLibro.Name = "temasLibro";
            this.temasLibro.ReadOnly = true;
            this.temasLibro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.temasLibro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.temasLibro.Width = 175;
            // 
            // autoresLibro
            // 
            this.autoresLibro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.autoresLibro.DefaultCellStyle = dataGridViewCellStyle3;
            this.autoresLibro.HeaderText = "Autores";
            this.autoresLibro.Name = "autoresLibro";
            this.autoresLibro.ReadOnly = true;
            this.autoresLibro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.autoresLibro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnRentar
            // 
            this.btnRentar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRentar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRentar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRentar.BorderRadius = 0;
            this.btnRentar.BorderSize = 0;
            this.btnRentar.FlatAppearance.BorderSize = 0;
            this.btnRentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnRentar.ForeColor = System.Drawing.Color.White;
            this.btnRentar.Location = new System.Drawing.Point(13, 15);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(175, 35);
            this.btnRentar.TabIndex = 1;
            this.btnRentar.Text = "Generar Ficha";
            this.btnRentar.TextColor = System.Drawing.Color.White;
            this.btnRentar.UseVisualStyleBackColor = false;
            this.btnRentar.Click += new System.EventHandler(this.btnRentar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "12-11-2021 12:50";
            // 
            // timerReloj
            // 
            this.timerReloj.Interval = 1;
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnUpdate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(756, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rentarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRentar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rentarLibro";
            this.Text = "rentarLibro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RJCodeAdvance.RJControls.RJButton btnRentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn temasLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoresLibro;
        private FontAwesome.Sharp.IconPictureBox btnUpdate;
    }
}