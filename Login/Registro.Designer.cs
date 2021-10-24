
namespace Login
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.rounded_Panel1 = new CustomControls.Rounded_Panel(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apellidosKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.confirmarContraKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.contraseñaKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.correoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.nombreKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnRegister = new CustomControls.Rounded_Button();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.usuarioTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rounded_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioTempBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rounded_Panel1
            // 
            resources.ApplyResources(this.rounded_Panel1, "rounded_Panel1");
            this.rounded_Panel1.Controls.Add(this.rjCircularPictureBox1);
            this.rounded_Panel1.Controls.Add(this.label5);
            this.rounded_Panel1.Controls.Add(this.label4);
            this.rounded_Panel1.Controls.Add(this.label3);
            this.rounded_Panel1.Controls.Add(this.label2);
            this.rounded_Panel1.Controls.Add(this.label1);
            this.rounded_Panel1.Controls.Add(this.apellidosKryptonTextBox);
            this.rounded_Panel1.Controls.Add(this.confirmarContraKryptonTextBox);
            this.rounded_Panel1.Controls.Add(this.contraseñaKryptonTextBox);
            this.rounded_Panel1.Controls.Add(this.correoKryptonTextBox);
            this.rounded_Panel1.Controls.Add(this.nombreKryptonTextBox);
            this.rounded_Panel1.Controls.Add(this.btnRegister);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 20;
            this.rounded_Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rounded_Panel1_MouseMove);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // apellidosKryptonTextBox
            // 
            this.apellidosKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioTempBindingSource, "Apellidos", true));
            resources.ApplyResources(this.apellidosKryptonTextBox, "apellidosKryptonTextBox");
            this.apellidosKryptonTextBox.Name = "apellidosKryptonTextBox";
            this.apellidosKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.apellidosKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.apellidosKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.apellidosKryptonTextBox.StateCommon.Border.Rounding = 10;
            this.apellidosKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // confirmarContraKryptonTextBox
            // 
            this.confirmarContraKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioTempBindingSource, "ConfirmarContra", true));
            resources.ApplyResources(this.confirmarContraKryptonTextBox, "confirmarContraKryptonTextBox");
            this.confirmarContraKryptonTextBox.Name = "confirmarContraKryptonTextBox";
            this.confirmarContraKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.confirmarContraKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.confirmarContraKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.confirmarContraKryptonTextBox.StateCommon.Border.Rounding = 10;
            this.confirmarContraKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // contraseñaKryptonTextBox
            // 
            this.contraseñaKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioTempBindingSource, "Contraseña", true));
            resources.ApplyResources(this.contraseñaKryptonTextBox, "contraseñaKryptonTextBox");
            this.contraseñaKryptonTextBox.Name = "contraseñaKryptonTextBox";
            this.contraseñaKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.contraseñaKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.contraseñaKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contraseñaKryptonTextBox.StateCommon.Border.Rounding = 10;
            this.contraseñaKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // correoKryptonTextBox
            // 
            this.correoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioTempBindingSource, "Correo", true));
            resources.ApplyResources(this.correoKryptonTextBox, "correoKryptonTextBox");
            this.correoKryptonTextBox.Name = "correoKryptonTextBox";
            this.correoKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.correoKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.correoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.correoKryptonTextBox.StateCommon.Border.Rounding = 10;
            this.correoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // nombreKryptonTextBox
            // 
            this.nombreKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioTempBindingSource, "Nombre", true));
            resources.ApplyResources(this.nombreKryptonTextBox, "nombreKryptonTextBox");
            this.nombreKryptonTextBox.Name = "nombreKryptonTextBox";
            this.nombreKryptonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.nombreKryptonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.nombreKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nombreKryptonTextBox.StateCommon.Border.Rounding = 10;
            this.nombreKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegister.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegister.BorderRadius = 20;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.MediumSlateBlue;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            resources.ApplyResources(this.rjCircularPictureBox1, "rjCircularPictureBox1");
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // usuarioTempBindingSource
            // 
            this.usuarioTempBindingSource.DataSource = typeof(Elementos.UsuarioTemp);
            // 
            // Registro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.rounded_Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rounded_Panel1.ResumeLayout(false);
            this.rounded_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioTempBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Rounded_Panel rounded_Panel1;
        private CustomControls.Rounded_Button btnRegister;
        private System.Windows.Forms.BindingSource usuarioTempBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox apellidosKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox confirmarContraKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox contraseñaKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox correoKryptonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nombreKryptonTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}