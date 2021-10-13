
namespace Login
{
    partial class ResetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            this.rounded_Panel1 = new CustomControls.Rounded_Panel(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rounded_PictureBox1 = new CustomControls.Rounded_PictureBox(this.components);
            this.txtMail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rounded_Button1 = new CustomControls.Rounded_Button();
            this.rounded_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rounded_PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rounded_Panel1
            // 
            resources.ApplyResources(this.rounded_Panel1, "rounded_Panel1");
            this.rounded_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.rounded_Panel1.Controls.Add(this.rounded_Button1);
            this.rounded_Panel1.Controls.Add(this.label2);
            this.rounded_Panel1.Controls.Add(this.label1);
            this.rounded_Panel1.Controls.Add(this.rounded_PictureBox1);
            this.rounded_Panel1.Controls.Add(this.txtMail);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 20;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rounded_PictureBox1
            // 
            this.rounded_PictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.rounded_PictureBox1.ColorMargin = System.Drawing.Color.Empty;
            this.rounded_PictureBox1.Image = global::Login.Properties.Resources._lock;
            resources.ApplyResources(this.rounded_PictureBox1, "rounded_PictureBox1");
            this.rounded_PictureBox1.Name = "rounded_PictureBox1";
            this.rounded_PictureBox1.TabStop = false;
            this.rounded_PictureBox1.WidhtMargin = 0;
            this.rounded_PictureBox1.Click += new System.EventHandler(this.rounded_PictureBox1_Click);
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            this.txtMail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMail.StateCommon.Border.Rounding = 20;
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
            // ResetPassword
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.rounded_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rounded_Panel1.ResumeLayout(false);
            this.rounded_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rounded_PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected CustomControls.Rounded_Panel rounded_Panel1;
        private CustomControls.Rounded_PictureBox rounded_PictureBox1;
        protected ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.Rounded_Button rounded_Button1;
    }
}