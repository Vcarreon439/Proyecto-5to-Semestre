
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rounded_Panel1 = new CustomControls.Rounded_Panel(this.components);
            this.kryptonLinkLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.kryptonLinkLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rounded_Button1 = new CustomControls.Rounded_Button();
            this.rounded_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            resources.ApplyResources(this.txtUserName, "txtUserName");
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
            this.rounded_Panel1.Controls.Add(this.rounded_Button1);
            this.rounded_Panel1.Controls.Add(this.kryptonLinkLabel2);
            this.rounded_Panel1.Controls.Add(this.kryptonLinkLabel1);
            this.rounded_Panel1.Controls.Add(this.label1);
            this.rounded_Panel1.Controls.Add(this.kryptonTextBox1);
            this.rounded_Panel1.Controls.Add(this.txtMail);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 20;
            // 
            // kryptonLinkLabel2
            // 
            resources.ApplyResources(this.kryptonLinkLabel2, "kryptonLinkLabel2");
            this.kryptonLinkLabel2.Name = "kryptonLinkLabel2";
            this.kryptonLinkLabel2.Values.Text = resources.GetString("kryptonLinkLabel2.Values.Text");
            this.kryptonLinkLabel2.LinkClicked += new System.EventHandler(this.kryptonLinkLabel2_LinkClicked);
            // 
            // kryptonLinkLabel1
            // 
            resources.ApplyResources(this.kryptonLinkLabel1, "kryptonLinkLabel1");
            this.kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.Values.Text = resources.GetString("kryptonLinkLabel1.Values.Text");
            this.kryptonLinkLabel1.LinkClicked += new System.EventHandler(this.kryptonLinkLabel1_LinkClicked);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // kryptonTextBox1
            // 
            resources.ApplyResources(this.kryptonTextBox1, "kryptonTextBox1");
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 20;
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            this.txtMail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMail.StateCommon.Border.Rounding = 20;
            this.txtMail.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // rounded_Button1
            // 
            this.rounded_Button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded_Button1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rounded_Button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rounded_Button1.BorderRadius = 20;
            this.rounded_Button1.BorderSize = 0;
            this.rounded_Button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rounded_Button1, "rounded_Button1");
            this.rounded_Button1.ForeColor = System.Drawing.Color.White;
            this.rounded_Button1.Name = "rounded_Button1";
            this.rounded_Button1.TextColor = System.Drawing.Color.White;
            this.rounded_Button1.UseVisualStyleBackColor = false;
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
            this.Load += new System.EventHandler(this.Login_Load);
            this.rounded_Panel1.ResumeLayout(false);
            this.rounded_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserName;
        protected CustomControls.Rounded_Panel rounded_Panel1;
        protected ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMail;
        protected ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel2;
        private CustomControls.Rounded_Button rounded_Button1;

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

