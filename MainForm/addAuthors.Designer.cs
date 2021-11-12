
namespace MainForm
{
    partial class addAuthors
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
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label comentariosLabel;
            System.Windows.Forms.Label paisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAuthors));
            this.nombreKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.fullAutorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ciudadKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.codigoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.comentariosKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.paisComboBoxCountrySelect = new FlagsISO.ComboBoxCountrySelect();
            this.rjButton1 = new RJCodeAdvance.RJControls.RJButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnTabla = new System.Windows.Forms.Button();
            this.pctPrueba = new System.Windows.Forms.PictureBox();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            comentariosLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fullAutorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            nombreLabel.Location = new System.Drawing.Point(280, 74);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(81, 23);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "First Name:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            apellidoLabel.Location = new System.Drawing.Point(280, 136);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(97, 23);
            apellidoLabel.TabIndex = 2;
            apellidoLabel.Text = "Second Name:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            ciudadLabel.Location = new System.Drawing.Point(587, 136);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(38, 23);
            ciudadLabel.TabIndex = 4;
            ciudadLabel.Text = "City:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            codigoLabel.Location = new System.Drawing.Point(280, 12);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(27, 23);
            codigoLabel.TabIndex = 6;
            codigoLabel.Text = "ID:";
            // 
            // comentariosLabel
            // 
            comentariosLabel.AutoSize = true;
            comentariosLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            comentariosLabel.Location = new System.Drawing.Point(280, 214);
            comentariosLabel.Name = "comentariosLabel";
            comentariosLabel.Size = new System.Drawing.Size(50, 23);
            comentariosLabel.TabIndex = 8;
            comentariosLabel.Text = "Notes:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            paisLabel.Location = new System.Drawing.Point(588, 74);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(64, 23);
            paisLabel.TabIndex = 14;
            paisLabel.Text = "Country:";
            // 
            // nombreKryptonTextBox
            // 
            this.nombreKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "Nombre", true));
            this.nombreKryptonTextBox.Location = new System.Drawing.Point(284, 100);
            this.nombreKryptonTextBox.Name = "nombreKryptonTextBox";
            this.nombreKryptonTextBox.Size = new System.Drawing.Size(289, 33);
            this.nombreKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.nombreKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.nombreKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nombreKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.nombreKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.nombreKryptonTextBox.TabIndex = 1;
            // 
            // fullAutorBindingSource
            // 
            this.fullAutorBindingSource.DataSource = typeof(Elementos.ElementosBiblioteca.Autor.FullAutor);
            // 
            // apellidoKryptonTextBox
            // 
            this.apellidoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "Apellido", true));
            this.apellidoKryptonTextBox.Location = new System.Drawing.Point(284, 162);
            this.apellidoKryptonTextBox.Name = "apellidoKryptonTextBox";
            this.apellidoKryptonTextBox.Size = new System.Drawing.Size(289, 33);
            this.apellidoKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.apellidoKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.apellidoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.apellidoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.apellidoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.apellidoKryptonTextBox.TabIndex = 3;
            // 
            // ciudadKryptonTextBox
            // 
            this.ciudadKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "ciudad", true));
            this.ciudadKryptonTextBox.Location = new System.Drawing.Point(591, 162);
            this.ciudadKryptonTextBox.Name = "ciudadKryptonTextBox";
            this.ciudadKryptonTextBox.Size = new System.Drawing.Size(197, 33);
            this.ciudadKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.ciudadKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.ciudadKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ciudadKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.ciudadKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.ciudadKryptonTextBox.TabIndex = 5;
            // 
            // codigoKryptonTextBox
            // 
            this.codigoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "Codigo", true));
            this.codigoKryptonTextBox.Enabled = false;
            this.codigoKryptonTextBox.Location = new System.Drawing.Point(284, 38);
            this.codigoKryptonTextBox.Name = "codigoKryptonTextBox";
            this.codigoKryptonTextBox.Size = new System.Drawing.Size(134, 33);
            this.codigoKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.codigoKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.codigoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.codigoKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.codigoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.codigoKryptonTextBox.TabIndex = 7;
            // 
            // comentariosKryptonTextBox
            // 
            this.comentariosKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "comentarios", true));
            this.comentariosKryptonTextBox.Location = new System.Drawing.Point(284, 246);
            this.comentariosKryptonTextBox.Multiline = true;
            this.comentariosKryptonTextBox.Name = "comentariosKryptonTextBox";
            this.comentariosKryptonTextBox.Size = new System.Drawing.Size(504, 160);
            this.comentariosKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Silver;
            this.comentariosKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.comentariosKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comentariosKryptonTextBox.StateCommon.Border.Rounding = 5;
            this.comentariosKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 12F);
            this.comentariosKryptonTextBox.TabIndex = 9;
            // 
            // paisComboBoxCountrySelect
            // 
            this.paisComboBoxCountrySelect.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fullAutorBindingSource, "pais", true));
            this.paisComboBoxCountrySelect.DontGetShiny = false;
            this.paisComboBoxCountrySelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paisComboBoxCountrySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paisComboBoxCountrySelect.FlagSize = FlagsISO.ComboBoxCountrySelect.FlagSizeType.Size16;
            this.paisComboBoxCountrySelect.Font = new System.Drawing.Font("Open Sans", 12F);
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
            this.paisComboBoxCountrySelect.Location = new System.Drawing.Point(591, 106);
            this.paisComboBoxCountrySelect.Name = "paisComboBoxCountrySelect";
            this.paisComboBoxCountrySelect.SelectedRegion = ((System.Globalization.RegionInfo)(resources.GetObject("paisComboBoxCountrySelect.SelectedRegion")));
            this.paisComboBoxCountrySelect.Size = new System.Drawing.Size(197, 21);
            this.paisComboBoxCountrySelect.TabIndex = 15;
            this.paisComboBoxCountrySelect.UseNativeName = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.Transparent;
            this.rjButton1.BorderRadius = 5;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(12, 256);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(250, 31);
            this.rjButton1.TabIndex = 16;
            this.rjButton1.Text = "Add Picture";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location = new System.Drawing.Point(12, 293);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(250, 43);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Add";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnTabla
            // 
            this.btnTabla.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.btnTabla.Location = new System.Drawing.Point(12, 342);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(250, 64);
            this.btnTabla.TabIndex = 20;
            this.btnTabla.Text = "Open Table";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // pctPrueba
            // 
            this.pctPrueba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctPrueba.Location = new System.Drawing.Point(12, 12);
            this.pctPrueba.Name = "pctPrueba";
            this.pctPrueba.Size = new System.Drawing.Size(250, 238);
            this.pctPrueba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrueba.TabIndex = 21;
            this.pctPrueba.TabStop = false;
            this.pctPrueba.DragDrop += new System.Windows.Forms.DragEventHandler(this.pctPrueba_DragDrop);
            this.pctPrueba.DragEnter += new System.Windows.Forms.DragEventHandler(this.pctPrueba_DragEnter);
            // 
            // addAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.pctPrueba);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisComboBoxCountrySelect);
            this.Controls.Add(comentariosLabel);
            this.Controls.Add(this.comentariosKryptonTextBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoKryptonTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadKryptonTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoKryptonTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreKryptonTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addAuthors";
            this.Text = "addAuthors";
            this.Load += new System.EventHandler(this.addAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fullAutorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fullAutorBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nombreKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox apellidoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ciudadKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox codigoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox comentariosKryptonTextBox;
        private FlagsISO.ComboBoxCountrySelect paisComboBoxCountrySelect;
        private RJCodeAdvance.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.PictureBox pctPrueba;
    }
}