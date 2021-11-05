
namespace MainForm
{
    partial class fichaAutor
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label comentariosLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fichaAutor));
            this.rounded_Panel1 = new CustomControls.Rounded_Panel(this.components);
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            this.ciudadKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fullAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisComboBoxCountrySelect = new FlagsISO.ComboBoxCountrySelect();
            this.codigoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.comentariosKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.apellidoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nombreKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            this.rounded_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            nombreLabel.Location = new System.Drawing.Point(9, 227);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(64, 19);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "First Name:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            apellidoLabel.Location = new System.Drawing.Point(9, 281);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(78, 19);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Second Name:";
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            comentariosLabel.Location = new System.Drawing.Point(9, 442);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(41, 19);
            comentariosLabel.TabIndex = 5;
            comentariosLabel.Text = "Notes:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            codigoLabel.Location = new System.Drawing.Point(184, 195);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(22, 19);
            codigoLabel.TabIndex = 7;
            codigoLabel.Text = "ID:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            paisLabel.Location = new System.Drawing.Point(136, 403);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(49, 19);
            paisLabel.TabIndex = 9;
            paisLabel.Text = "Country:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Open Sans Condensed SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            ciudadLabel.Location = new System.Drawing.Point(9, 335);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(30, 19);
            ciudadLabel.TabIndex = 11;
            ciudadLabel.Text = "City:";
            // 
            // rounded_Panel1
            // 
            this.rounded_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rounded_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.rounded_Panel1.Controls.Add(this.btnDelete);
            this.rounded_Panel1.Controls.Add(this.btnUpdate);
            this.rounded_Panel1.Controls.Add(ciudadLabel);
            this.rounded_Panel1.Controls.Add(this.ciudadKryptonTextBox);
            this.rounded_Panel1.Controls.Add(paisLabel);
            this.rounded_Panel1.Controls.Add(this.paisComboBoxCountrySelect);
            this.rounded_Panel1.Controls.Add(codigoLabel);
            this.rounded_Panel1.Controls.Add(this.codigoKryptonTextBox);
            this.rounded_Panel1.Controls.Add(comentariosLabel);
            this.rounded_Panel1.Controls.Add(this.comentariosKryptonTextBox);
            this.rounded_Panel1.Controls.Add(apellidoLabel);
            this.rounded_Panel1.Controls.Add(this.apellidoKryptonTextBox);
            this.rounded_Panel1.Controls.Add(nombreLabel);
            this.rounded_Panel1.Controls.Add(this.nombreKryptonTextBox);
            this.rounded_Panel1.Controls.Add(this.rjCircularPictureBox1);
            this.rounded_Panel1.Location = new System.Drawing.Point(12, 12);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 10;
            this.rounded_Panel1.Size = new System.Drawing.Size(326, 647);
            this.rounded_Panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(191, 591);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 40);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 7;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(64, 591);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ciudadKryptonTextBox
            // 
            this.ciudadKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "ciudad", true));
            this.ciudadKryptonTextBox.Location = new System.Drawing.Point(13, 357);
            this.ciudadKryptonTextBox.Name = "ciudadKryptonTextBox";
            this.ciudadKryptonTextBox.Size = new System.Drawing.Size(299, 29);
            this.ciudadKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.ciudadKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.ciudadKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ciudadKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.ciudadKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadKryptonTextBox.TabIndex = 12;
            // 
            // fullAutorBindingSource
            // 
            this.fullAutorBindingSource.DataSource = typeof(Elementos.ElementosBiblioteca.Autor.FullAutor);
            // 
            // paisComboBoxCountrySelect
            // 
            this.paisComboBoxCountrySelect.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "pais", true));
            this.paisComboBoxCountrySelect.DontGetShiny = false;
            this.paisComboBoxCountrySelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paisComboBoxCountrySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paisComboBoxCountrySelect.FlagSize = FlagsISO.ComboBoxCountrySelect.FlagSizeType.Size16;
            this.paisComboBoxCountrySelect.IntegralHeight = false;
            this.paisComboBoxCountrySelect.ItemHeight = 15;
            this.paisComboBoxCountrySelect.Items.AddRange(new object[] {
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items1"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items2"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items3"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items4"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items5"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items6"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items7"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items8"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items9"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items10"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items11"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items12"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items13"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items14"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items15"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items16"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items17"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items18"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items19"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items20"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items21"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items22"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items23"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items24"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items25"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items26"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items27"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items28"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items29"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items30"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items31"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items32"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items33"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items34"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items35"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items36"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items37"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items38"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items39"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items40"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items41"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items42"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items43"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items44"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items45"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items46"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items47"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items48"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items49"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items50"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items51"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items52"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items53"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items54"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items55"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items56"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items57"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items58"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items59"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items60"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items61"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items62"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items63"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items64"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items65"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items66"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items67"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items68"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items69"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items70"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items71"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items72"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items73"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items74"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items75"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items76"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items77"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items78"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items79"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items80"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items81"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items82"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items83"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items84"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items85"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items86"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items87"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items88"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items89"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items90"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items91"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items92"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items93"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items94"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items95"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items96"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items97"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items98"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items99"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items100"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items101"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items102"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items103"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items104"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items105"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items106"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items107"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items108"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items109"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items110"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items111"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items112"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items113"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items114"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items115"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items116"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items117"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items118"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items119"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items120"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items121"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items122"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items123"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items124"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items125"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items126"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items127"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items128"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items129"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items130"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items131"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items132"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items133"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items134"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items135"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items136"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items137"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items138"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items139"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items140"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items141"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items142"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items143"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items144"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items145"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items146"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items147"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items148"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items149"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items150"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items151"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items152"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items153"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items154"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items155"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items156"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items157"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items158"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items159"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items160"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items161"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items162"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items163"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items164"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items165"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items166"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items167"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items168"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items169"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items170"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items171"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items172"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items173"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items174"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items175"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items176"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items177"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items178"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items179"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items180"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items181"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items182"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items183"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items184"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items185"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items186"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items187"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items188"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items189"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items190"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items191"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items192"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items193"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items194"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items195"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items196"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items197"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items198"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items199"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items200"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items201"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items202"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items203"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items204"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items205"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items206"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items207"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items208"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items209"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items210"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items211"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items212"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items213"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items214"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items215"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items216"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items217"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items218"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items219"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items220"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items221"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items222"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items223"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items224"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items225"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items226"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items227"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items228"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items229"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items230"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items231"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items232"))),
            ((object)(resources.GetObject("paisComboBoxCountrySelect.Items233")))});
            this.paisComboBoxCountrySelect.Location = new System.Drawing.Point(191, 401);
            this.paisComboBoxCountrySelect.Name = "paisComboBoxCountrySelect";
            this.paisComboBoxCountrySelect.SelectedRegion = ((System.Globalization.RegionInfo)(resources.GetObject("paisComboBoxCountrySelect.SelectedRegion")));
            this.paisComboBoxCountrySelect.Size = new System.Drawing.Size(121, 21);
            this.paisComboBoxCountrySelect.TabIndex = 10;
            this.paisComboBoxCountrySelect.UseNativeName = false;
            // 
            // codigoKryptonTextBox
            // 
            this.codigoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "Codigo", true));
            this.codigoKryptonTextBox.Location = new System.Drawing.Point(212, 185);
            this.codigoKryptonTextBox.Name = "codigoKryptonTextBox";
            this.codigoKryptonTextBox.Size = new System.Drawing.Size(100, 29);
            this.codigoKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.codigoKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.codigoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.codigoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.codigoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoKryptonTextBox.TabIndex = 8;
            // 
            // comentariosKryptonTextBox
            // 
            this.comentariosKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "comentarios", true));
            this.comentariosKryptonTextBox.Location = new System.Drawing.Point(13, 464);
            this.comentariosKryptonTextBox.Multiline = true;
            this.comentariosKryptonTextBox.Name = "comentariosKryptonTextBox";
            this.comentariosKryptonTextBox.Size = new System.Drawing.Size(299, 112);
            this.comentariosKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.comentariosKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.comentariosKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comentariosKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.comentariosKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comentariosKryptonTextBox.TabIndex = 6;
            // 
            // apellidoKryptonTextBox
            // 
            this.apellidoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "Apellido", true));
            this.apellidoKryptonTextBox.Location = new System.Drawing.Point(13, 303);
            this.apellidoKryptonTextBox.Name = "apellidoKryptonTextBox";
            this.apellidoKryptonTextBox.Size = new System.Drawing.Size(299, 29);
            this.apellidoKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.apellidoKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.apellidoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.apellidoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.apellidoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoKryptonTextBox.TabIndex = 4;
            // 
            // nombreKryptonTextBox
            // 
            this.nombreKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "Nombre", true));
            this.nombreKryptonTextBox.Location = new System.Drawing.Point(13, 249);
            this.nombreKryptonTextBox.Name = "nombreKryptonTextBox";
            this.nombreKryptonTextBox.Size = new System.Drawing.Size(299, 29);
            this.nombreKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.nombreKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.nombreKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nombreKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.nombreKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreKryptonTextBox.TabIndex = 2;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.MediumSlateBlue;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(93, 14);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(145, 145);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 0;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // fichaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(350, 671);
            this.Controls.Add(this.rounded_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fichaAutor";
            this.Text = "fichaAutor";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rounded_Panel1.ResumeLayout(false);
            this.rounded_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Rounded_Panel rounded_Panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ciudadKryptonTextBox;
        private System.Windows.Forms.BindingSource fullAutorBindingSource;
        private FlagsISO.ComboBoxCountrySelect paisComboBoxCountrySelect;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox codigoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox comentariosKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox apellidoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nombreKryptonTextBox;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
    }
}