
namespace Login
{
    partial class Success
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Success));
            this.rounded_Panel1 = new CustomControls.Rounded_Panel(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new CustomControls.Rounded_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pctImage = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rounded_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rounded_Panel1
            // 
            resources.ApplyResources(this.rounded_Panel1, "rounded_Panel1");
            this.rounded_Panel1.Controls.Add(this.label2);
            this.rounded_Panel1.Controls.Add(this.btnOK);
            this.rounded_Panel1.Controls.Add(this.label1);
            this.rounded_Panel1.Controls.Add(this.pctImage);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 20;
            this.rounded_Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rounded_Panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOK.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOK.BorderRadius = 20;
            this.btnOK.BorderSize = 0;
            this.btnOK.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Name = "btnOK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // pctImage
            // 
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pctImage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pctImage.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pctImage.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pctImage.BorderSize = 2;
            this.pctImage.GradientAngle = 50F;
            this.pctImage.Image = global::Login.Properties.Resources.check_3x;
            resources.ApplyResources(this.pctImage, "pctImage");
            this.pctImage.Name = "pctImage";
            this.pctImage.TabStop = false;
            // 
            // Success
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.rounded_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Success";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rounded_Panel1.ResumeLayout(false);
            this.rounded_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Rounded_Panel rounded_Panel1;
        private System.Windows.Forms.Label label2;
        private CustomControls.Rounded_Button btnOK;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox pctImage;
    }
}