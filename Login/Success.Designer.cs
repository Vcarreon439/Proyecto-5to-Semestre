
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
            this.rounded_Button1 = new CustomControls.Rounded_Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.rounded_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rounded_Panel1
            // 
            resources.ApplyResources(this.rounded_Panel1, "rounded_Panel1");
            this.rounded_Panel1.Controls.Add(this.label2);
            this.rounded_Panel1.Controls.Add(this.rounded_Button1);
            this.rounded_Panel1.Controls.Add(this.label1);
            this.rounded_Panel1.Controls.Add(this.rjCircularPictureBox1);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 20;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BackColor = System.Drawing.Color.White;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::Login.Properties.Resources.check_3x;
            resources.ApplyResources(this.rjCircularPictureBox1, "rjCircularPictureBox1");
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Rounded_Panel rounded_Panel1;
        private System.Windows.Forms.Label label2;
        private CustomControls.Rounded_Button rounded_Button1;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}