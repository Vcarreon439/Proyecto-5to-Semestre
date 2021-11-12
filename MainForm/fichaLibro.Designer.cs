
namespace MainForm
{
    partial class fichaLibro
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
            this.pnlContenedorPrincipal = new CustomControls.Rounded_Panel(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.btnRentar = new RJCodeAdvance.RJControls.RJButton();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.pnlContenedorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorPrincipal
            // 
            this.pnlContenedorPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorPrincipal.Controls.Add(this.btnCerrar);
            this.pnlContenedorPrincipal.Controls.Add(this.btnRentar);
            this.pnlContenedorPrincipal.Controls.Add(this.lblEdicion);
            this.pnlContenedorPrincipal.Controls.Add(this.lblEditorial);
            this.pnlContenedorPrincipal.Controls.Add(this.lblDescripcion);
            this.pnlContenedorPrincipal.Controls.Add(this.lblISBN);
            this.pnlContenedorPrincipal.Controls.Add(this.lblTitulo);
            this.pnlContenedorPrincipal.Controls.Add(this.pictureBox1);
            this.pnlContenedorPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            this.pnlContenedorPrincipal.PanelColor = System.Drawing.Color.White;
            this.pnlContenedorPrincipal.Radio = 10;
            this.pnlContenedorPrincipal.Size = new System.Drawing.Size(653, 366);
            this.pnlContenedorPrincipal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MainForm.Properties.Resources.ImageNotAvalible;
            this.pictureBox1.Location = new System.Drawing.Point(21, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(261, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 27);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.Transparent;
            this.lblISBN.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblISBN.Location = new System.Drawing.Point(261, 46);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(132, 27);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "000000000000000";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(261, 146);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblDescripcion.Size = new System.Drawing.Size(373, 126);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor in" +
    "cididunt ut labore et dolore magna aliqua.\r\n";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.BackColor = System.Drawing.Color.Transparent;
            this.lblEditorial.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEditorial.Location = new System.Drawing.Point(261, 108);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(69, 27);
            this.lblEditorial.TabIndex = 10;
            this.lblEditorial.Text = "Editorial";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.BackColor = System.Drawing.Color.Transparent;
            this.lblEdicion.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEdicion.Location = new System.Drawing.Point(261, 77);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(167, 27);
            this.lblEdicion.TabIndex = 11;
            this.lblEdicion.Text = "Edición: 1 - 00/00/0000";
            // 
            // btnRentar
            // 
            this.btnRentar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRentar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRentar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRentar.BorderRadius = 12;
            this.btnRentar.BorderSize = 0;
            this.btnRentar.FlatAppearance.BorderSize = 0;
            this.btnRentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnRentar.ForeColor = System.Drawing.Color.White;
            this.btnRentar.Location = new System.Drawing.Point(470, 303);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(164, 40);
            this.btnRentar.TabIndex = 12;
            this.btnRentar.Text = "Rentar Libro";
            this.btnRentar.TextColor = System.Drawing.Color.White;
            this.btnRentar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Red;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.Location = new System.Drawing.Point(610, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // fichaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(677, 390);
            this.Controls.Add(this.pnlContenedorPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fichaLibro";
            this.Text = "fichaLibro";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlContenedorPrincipal.ResumeLayout(false);
            this.pnlContenedorPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Rounded_Panel pnlContenedorPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblDescripcion;
        private RJCodeAdvance.RJControls.RJButton btnRentar;
        private System.Windows.Forms.Label lblEdicion;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
    }
}