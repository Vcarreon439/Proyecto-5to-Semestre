
namespace MainForm
{
    partial class profileForm
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label domicilioLabel;
            System.Windows.Forms.Label entidadLabel;
            System.Windows.Forms.Label fechaDateTimeLabel;
            System.Windows.Forms.Label generoLabel;
            this.fullUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.domicilioTextBox = new System.Windows.Forms.TextBox();
            this.situacionLabel1 = new System.Windows.Forms.Label();
            this.entidadTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            domicilioLabel = new System.Windows.Forms.Label();
            entidadLabel = new System.Windows.Forms.Label();
            fechaDateTimeLabel = new System.Windows.Forms.Label();
            generoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fullUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            nombreLabel.Location = new System.Drawing.Point(261, 12);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(51, 19);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            apellidosLabel.Location = new System.Drawing.Point(479, 9);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(56, 19);
            apellidosLabel.TabIndex = 3;
            apellidosLabel.Text = "Apellidos:";
            // 
            // correoLabel
            // 
            correoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            correoLabel.AutoSize = true;
            correoLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            correoLabel.Location = new System.Drawing.Point(261, 65);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(44, 19);
            correoLabel.TabIndex = 5;
            correoLabel.Text = "Correo:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            contraseñaLabel.Location = new System.Drawing.Point(483, 65);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(67, 19);
            contraseñaLabel.TabIndex = 7;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // domicilioLabel
            // 
            domicilioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            domicilioLabel.Location = new System.Drawing.Point(261, 181);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new System.Drawing.Size(57, 19);
            domicilioLabel.TabIndex = 9;
            domicilioLabel.Text = "Domicilio:";
            // 
            // entidadLabel
            // 
            entidadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            entidadLabel.AutoSize = true;
            entidadLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            entidadLabel.Location = new System.Drawing.Point(453, 181);
            entidadLabel.Name = "entidadLabel";
            entidadLabel.Size = new System.Drawing.Size(48, 19);
            entidadLabel.TabIndex = 13;
            entidadLabel.Text = "Entidad:";
            // 
            // fechaDateTimeLabel
            // 
            fechaDateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fechaDateTimeLabel.AutoSize = true;
            fechaDateTimeLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            fechaDateTimeLabel.Location = new System.Drawing.Point(483, 121);
            fechaDateTimeLabel.Name = "fechaDateTimeLabel";
            fechaDateTimeLabel.Size = new System.Drawing.Size(112, 19);
            fechaDateTimeLabel.TabIndex = 15;
            fechaDateTimeLabel.Text = "Fecha de Nacimiento:";
            // 
            // generoLabel
            // 
            generoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            generoLabel.AutoSize = true;
            generoLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            generoLabel.Location = new System.Drawing.Point(261, 121);
            generoLabel.Name = "generoLabel";
            generoLabel.Size = new System.Drawing.Size(47, 19);
            generoLabel.TabIndex = 17;
            generoLabel.Text = "Genero:";
            // 
            // fullUserBindingSource
            // 
            this.fullUserBindingSource.DataSource = typeof(Elementos.FullUser);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.nombreTextBox.Location = new System.Drawing.Point(265, 34);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(212, 25);
            this.nombreTextBox.TabIndex = 3;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Apellidos", true));
            this.apellidosTextBox.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.apellidosTextBox.Location = new System.Drawing.Point(483, 34);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(218, 25);
            this.apellidosTextBox.TabIndex = 4;
            // 
            // correoTextBox
            // 
            this.correoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.correoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Correo", true));
            this.correoTextBox.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.correoTextBox.Location = new System.Drawing.Point(265, 87);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(212, 25);
            this.correoTextBox.TabIndex = 6;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Contraseña", true));
            this.contraseñaTextBox.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.contraseñaTextBox.Location = new System.Drawing.Point(483, 87);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(218, 25);
            this.contraseñaTextBox.TabIndex = 8;
            // 
            // domicilioTextBox
            // 
            this.domicilioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.domicilioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Domicilio", true));
            this.domicilioTextBox.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.domicilioTextBox.Location = new System.Drawing.Point(265, 212);
            this.domicilioTextBox.Multiline = true;
            this.domicilioTextBox.Name = "domicilioTextBox";
            this.domicilioTextBox.Size = new System.Drawing.Size(436, 70);
            this.domicilioTextBox.TabIndex = 10;
            // 
            // situacionLabel1
            // 
            this.situacionLabel1.AutoSize = true;
            this.situacionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Situacion", true));
            this.situacionLabel1.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.situacionLabel1.Location = new System.Drawing.Point(140, 263);
            this.situacionLabel1.Name = "situacionLabel1";
            this.situacionLabel1.Size = new System.Drawing.Size(106, 19);
            this.situacionLabel1.TabIndex = 12;
            this.situacionLabel1.Text = "Situación: NINGUNA";
            this.situacionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // entidadTextBox
            // 
            this.entidadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Entidad", true));
            this.entidadTextBox.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.entidadTextBox.Location = new System.Drawing.Point(507, 179);
            this.entidadTextBox.Name = "entidadTextBox";
            this.entidadTextBox.Size = new System.Drawing.Size(194, 25);
            this.entidadTextBox.TabIndex = 14;
            // 
            // fechaDateTimeDateTimePicker
            // 
            this.fechaDateTimeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fullUserBindingSource, "FechaDateTime", true));
            this.fechaDateTimeDateTimePicker.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.fechaDateTimeDateTimePicker.Location = new System.Drawing.Point(483, 144);
            this.fechaDateTimeDateTimePicker.Name = "fechaDateTimeDateTimePicker";
            this.fechaDateTimeDateTimePicker.Size = new System.Drawing.Size(218, 25);
            this.fechaDateTimeDateTimePicker.TabIndex = 16;
            // 
            // generoComboBox
            // 
            this.generoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullUserBindingSource, "Genero", true));
            this.generoComboBox.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(265, 143);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(212, 26);
            this.generoComboBox.TabIndex = 18;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.MediumSlateBlue;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(234, 234);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 19;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 140);
            this.dataGridView1.TabIndex = 20;
            // 
            // profileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(generoLabel);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(fechaDateTimeLabel);
            this.Controls.Add(this.fechaDateTimeDateTimePicker);
            this.Controls.Add(entidadLabel);
            this.Controls.Add(this.entidadTextBox);
            this.Controls.Add(this.situacionLabel1);
            this.Controls.Add(domicilioLabel);
            this.Controls.Add(this.domicilioTextBox);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profileForm";
            this.Text = "profileForm";
            ((System.ComponentModel.ISupportInitialize)(this.fullUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fullUserBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox domicilioTextBox;
        private System.Windows.Forms.Label situacionLabel1;
        private System.Windows.Forms.TextBox entidadTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimeDateTimePicker;
        private System.Windows.Forms.ComboBox generoComboBox;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}