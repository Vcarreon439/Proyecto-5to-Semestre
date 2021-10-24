
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Plasmoid.Extensions;

namespace Login
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contraseñaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            System.Windows.Forms.Label correoLabel;
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rounded_Panel1 = new CustomControls.Rounded_Panel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.correoKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userAccesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contraseñaKryptonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.lnkForget = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new CustomControls.Rounded_Button();
            this.lnkSignUp = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            contraseñaLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            this.rounded_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAccesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseñaLabel
            // 
            resources.ApplyResources(contraseñaLabel, "contraseñaLabel");
            contraseñaLabel.Name = "contraseñaLabel";
            // 
            // correoLabel
            // 
            resources.ApplyResources(correoLabel, "correoLabel");
            correoLabel.Name = "correoLabel";
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUserName.StateCommon.Border.Rounding = 20;
            // 
            // rounded_Panel1
            // 
            resources.ApplyResources(this.rounded_Panel1, "rounded_Panel1");
            this.rounded_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.rounded_Panel1.Controls.Add(this.label1);
            this.rounded_Panel1.Controls.Add(correoLabel);
            this.rounded_Panel1.Controls.Add(this.correoKryptonTextBox);
            this.rounded_Panel1.Controls.Add(contraseñaLabel);
            this.rounded_Panel1.Controls.Add(this.contraseñaKryptonTextBox);
            this.rounded_Panel1.Controls.Add(this.btnCerrar);
            this.rounded_Panel1.Controls.Add(this.lnkForget);
            this.rounded_Panel1.Controls.Add(this.btnLogin);
            this.rounded_Panel1.Controls.Add(this.lnkSignUp);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 20;
            this.rounded_Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rounded_Panel1_MouseMove);
            this.rounded_Panel1.Move += new System.EventHandler(this.rounded_Panel1_Move);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // correoKryptonTextBox
            // 
            resources.ApplyResources(this.correoKryptonTextBox, "correoKryptonTextBox");
            this.correoKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccesBindingSource, "Correo", true));
            this.correoKryptonTextBox.Name = "correoKryptonTextBox";
            this.correoKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.correoKryptonTextBox.StateCommon.Border.Rounding = 20;
            this.correoKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F);
            // 
            // userAccesBindingSource
            // 
            this.userAccesBindingSource.DataSource = typeof(Elementos.UserAcces);
            // 
            // contraseñaKryptonTextBox
            // 
            resources.ApplyResources(this.contraseñaKryptonTextBox, "contraseñaKryptonTextBox");
            this.contraseñaKryptonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userAccesBindingSource, "Contraseña", true));
            this.contraseñaKryptonTextBox.Name = "contraseñaKryptonTextBox";
            this.contraseñaKryptonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.contraseñaKryptonTextBox.StateCommon.Border.Rounding = 20;
            this.contraseñaKryptonTextBox.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9.75F);
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.btnCerrar.MouseEnter += new System.EventHandler(this.btnCerrar_MouseEnter);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            // 
            // lnkForget
            // 
            resources.ApplyResources(this.lnkForget, "lnkForget");
            this.lnkForget.Name = "lnkForget";
            this.lnkForget.TabStop = true;
            this.lnkForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForget_LinkClicked);
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkSignUp
            // 
            resources.ApplyResources(this.lnkSignUp, "lnkSignUp");
            this.lnkSignUp.Name = "lnkSignUp";
            this.lnkSignUp.Values.ExtraText = resources.GetString("lnkSignUp.Values.ExtraText");
            this.lnkSignUp.Values.ImageTransparentColor = ((System.Drawing.Color)(resources.GetObject("lnkSignUp.Values.ImageTransparentColor")));
            this.lnkSignUp.Values.Text = resources.GetString("lnkSignUp.Values.Text");
            this.lnkSignUp.LinkClicked += new System.EventHandler(this.lnkSignUp_LinkClicked);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.rounded_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rounded_Panel1.ResumeLayout(false);
            this.rounded_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAccesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        protected CustomControls.Rounded_Panel rounded_Panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lnkSignUp;
        private CustomControls.Rounded_Button btnLogin;
        private LinkLabel lnkForget;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox correoKryptonTextBox;
        private BindingSource userAccesBindingSource;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox contraseñaKryptonTextBox;
        private Label label1;

        private class RPanel : Panel
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRoundedRectangle(new SolidBrush(Color.White), 0, 0, this.Width, this.Height, 10);
            }
        }
    }
}

