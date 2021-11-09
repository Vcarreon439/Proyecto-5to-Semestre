
namespace MainForm
{
    partial class frnAddBook
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
            CustomControls.CheckBoxComboBox.CheckBoxProperties checkBoxProperties1 = new CustomControls.CheckBoxComboBox.CheckBoxProperties();
            CustomControls.CheckBoxComboBox.CheckBoxProperties checkBoxProperties2 = new CustomControls.CheckBoxComboBox.CheckBoxProperties();
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label numEdicionLabel;
            System.Windows.Forms.Label copiasLabel;
            System.Windows.Forms.Label añoEdicionLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label codEditorialLabel;
            this.pctImagenLibro = new System.Windows.Forms.PictureBox();
            this.cbochkAutores = new CustomControls.CheckBoxComboBox.CheckBoxComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboTema = new CustomControls.CheckBoxComboBox.CheckBoxComboBox();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.numEdicionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.copiasNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.añoEdicionTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.codEditorialComboBox = new System.Windows.Forms.ComboBox();
            this.btnPrueba = new System.Windows.Forms.Button();
            tituloLabel = new System.Windows.Forms.Label();
            numEdicionLabel = new System.Windows.Forms.Label();
            copiasLabel = new System.Windows.Forms.Label();
            añoEdicionLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            codEditorialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagenLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdicionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiasNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pctImagenLibro
            // 
            this.pctImagenLibro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctImagenLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImagenLibro.Location = new System.Drawing.Point(12, 12);
            this.pctImagenLibro.Name = "pctImagenLibro";
            this.pctImagenLibro.Size = new System.Drawing.Size(233, 363);
            this.pctImagenLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImagenLibro.TabIndex = 0;
            this.pctImagenLibro.TabStop = false;
            this.pctImagenLibro.DragDrop += new System.Windows.Forms.DragEventHandler(this.pctImagenLibro_DragDrop);
            this.pctImagenLibro.DragEnter += new System.Windows.Forms.DragEventHandler(this.pctImagenLibro_DragEnter);
            // 
            // cbochkAutores
            // 
            this.cbochkAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbochkAutores.CheckBoxProperties = checkBoxProperties1;
            this.cbochkAutores.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "numEdicion", true));
            this.cbochkAutores.DisplayMemberSingleItem = "";
            this.cbochkAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbochkAutores.FormattingEnabled = true;
            this.cbochkAutores.Location = new System.Drawing.Point(543, 150);
            this.cbochkAutores.Name = "cbochkAutores";
            this.cbochkAutores.Size = new System.Drawing.Size(247, 26);
            this.cbochkAutores.TabIndex = 8;
            this.cbochkAutores.Enter += new System.EventHandler(this.cbochkAutores_Enter);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(481, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "Autores:";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(684, 381);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(106, 23);
            this.btnInsertar.TabIndex = 37;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tema:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(542, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 22);
            this.label11.TabIndex = 28;
            this.label11.Text = "ISBN:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Agregar Imagen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboTema
            // 
            this.cboTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboTema.CheckBoxProperties = checkBoxProperties2;
            this.cboTema.DisplayMemberSingleItem = "";
            this.cboTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(319, 115);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(153, 26);
            this.cboTema.TabIndex = 4;
            this.cboTema.Enter += new System.EventHandler(this.cboTema_Enter);
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataSource = typeof(Elementos.Libro);
            // 
            // tituloLabel
            // 
            tituloLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 12F, System.Drawing.FontStyle.Bold);
            tituloLabel.Location = new System.Drawing.Point(257, 12);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(48, 23);
            tituloLabel.TabIndex = 41;
            tituloLabel.Text = "Titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Titulo", true));
            this.tituloTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tituloTextBox.Location = new System.Drawing.Point(261, 40);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(529, 26);
            this.tituloTextBox.TabIndex = 42;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "ISBN", true));
            this.iSBNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.iSBNTextBox.Location = new System.Drawing.Point(588, 80);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(202, 24);
            this.iSBNTextBox.TabIndex = 44;
            this.iSBNTextBox.TextChanged += new System.EventHandler(this.iSBNTextBox_TextChanged);
            // 
            // numEdicionLabel
            // 
            numEdicionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            numEdicionLabel.AutoSize = true;
            numEdicionLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            numEdicionLabel.Location = new System.Drawing.Point(478, 116);
            numEdicionLabel.Name = "numEdicionLabel";
            numEdicionLabel.Size = new System.Drawing.Size(120, 22);
            numEdicionLabel.TabIndex = 44;
            numEdicionLabel.Text = "Numero de edicion:";
            // 
            // numEdicionNumericUpDown
            // 
            this.numEdicionNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numEdicionNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libroBindingSource, "numEdicion", true));
            this.numEdicionNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numEdicionNumericUpDown.Location = new System.Drawing.Point(604, 116);
            this.numEdicionNumericUpDown.Name = "numEdicionNumericUpDown";
            this.numEdicionNumericUpDown.Size = new System.Drawing.Size(64, 24);
            this.numEdicionNumericUpDown.TabIndex = 45;
            this.numEdicionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEdicionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // copiasLabel
            // 
            copiasLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            copiasLabel.AutoSize = true;
            copiasLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            copiasLabel.Location = new System.Drawing.Point(673, 116);
            copiasLabel.Name = "copiasLabel";
            copiasLabel.Size = new System.Drawing.Size(50, 22);
            copiasLabel.TabIndex = 45;
            copiasLabel.Text = "Copias:";
            // 
            // copiasNumericUpDown
            // 
            this.copiasNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copiasNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.libroBindingSource, "Copias", true));
            this.copiasNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.copiasNumericUpDown.Location = new System.Drawing.Point(729, 116);
            this.copiasNumericUpDown.Name = "copiasNumericUpDown";
            this.copiasNumericUpDown.Size = new System.Drawing.Size(61, 24);
            this.copiasNumericUpDown.TabIndex = 46;
            this.copiasNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.copiasNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // añoEdicionLabel
            // 
            añoEdicionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            añoEdicionLabel.AutoSize = true;
            añoEdicionLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            añoEdicionLabel.Location = new System.Drawing.Point(257, 156);
            añoEdicionLabel.Name = "añoEdicionLabel";
            añoEdicionLabel.Size = new System.Drawing.Size(77, 22);
            añoEdicionLabel.TabIndex = 46;
            añoEdicionLabel.Text = "Año Edicion:";
            // 
            // añoEdicionTextBox
            // 
            this.añoEdicionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.añoEdicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "AñoEdicion", true));
            this.añoEdicionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.añoEdicionTextBox.Location = new System.Drawing.Point(340, 154);
            this.añoEdicionTextBox.Name = "añoEdicionTextBox";
            this.añoEdicionTextBox.Size = new System.Drawing.Size(132, 24);
            this.añoEdicionTextBox.TabIndex = 47;
            // 
            // descripcionLabel
            // 
            descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            descripcionLabel.Location = new System.Drawing.Point(257, 195);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(78, 22);
            descripcionLabel.TabIndex = 47;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "Descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.descripcionTextBox.Location = new System.Drawing.Point(261, 226);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(529, 149);
            this.descripcionTextBox.TabIndex = 48;
            // 
            // codEditorialLabel
            // 
            codEditorialLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            codEditorialLabel.AutoSize = true;
            codEditorialLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            codEditorialLabel.Location = new System.Drawing.Point(257, 80);
            codEditorialLabel.Name = "codEditorialLabel";
            codEditorialLabel.Size = new System.Drawing.Size(59, 22);
            codEditorialLabel.TabIndex = 48;
            codEditorialLabel.Text = "Editorial:";
            // 
            // codEditorialComboBox
            // 
            this.codEditorialComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codEditorialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libroBindingSource, "codEditorial", true));
            this.codEditorialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.codEditorialComboBox.FormattingEnabled = true;
            this.codEditorialComboBox.Location = new System.Drawing.Point(319, 81);
            this.codEditorialComboBox.Name = "codEditorialComboBox";
            this.codEditorialComboBox.Size = new System.Drawing.Size(217, 26);
            this.codEditorialComboBox.TabIndex = 49;
            // 
            // btnPrueba
            // 
            this.btnPrueba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrueba.Location = new System.Drawing.Point(492, 381);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(106, 23);
            this.btnPrueba.TabIndex = 50;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // frnAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 426);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(codEditorialLabel);
            this.Controls.Add(this.codEditorialComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(añoEdicionLabel);
            this.Controls.Add(this.añoEdicionTextBox);
            this.Controls.Add(copiasLabel);
            this.Controls.Add(this.copiasNumericUpDown);
            this.Controls.Add(this.numEdicionNumericUpDown);
            this.Controls.Add(numEdicionLabel);
            this.Controls.Add(this.iSBNTextBox);
            this.Controls.Add(tituloLabel);
            this.Controls.Add(this.cboTema);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbochkAutores);
            this.Controls.Add(this.pctImagenLibro);
            this.Controls.Add(this.tituloTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frnAddBook";
            this.Text = "Add  Libro";
            ((System.ComponentModel.ISupportInitialize)(this.pctImagenLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdicionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiasNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctImagenLibro;
        private CustomControls.CheckBoxComboBox.CheckBoxComboBox cbochkAutores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private CustomControls.CheckBoxComboBox.CheckBoxComboBox cboTema;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.NumericUpDown numEdicionNumericUpDown;
        private System.Windows.Forms.NumericUpDown copiasNumericUpDown;
        private System.Windows.Forms.TextBox añoEdicionTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox codEditorialComboBox;
        private System.Windows.Forms.Button btnPrueba;
    }
}