
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
            this.rounded_Panel1 = new CustomControls.Rounded_Panel(this.components);
            this.txtMail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnRegister = new CustomControls.Rounded_Button();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.txtConfirm = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSecondName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtFirstName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rounded_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rounded_Panel1
            // 
            this.rounded_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rounded_Panel1.Controls.Add(this.txtMail);
            this.rounded_Panel1.Controls.Add(this.btnRegister);
            this.rounded_Panel1.Controls.Add(this.txtPassword);
            this.rounded_Panel1.Controls.Add(this.rjCircularPictureBox1);
            this.rounded_Panel1.Controls.Add(this.txtConfirm);
            this.rounded_Panel1.Controls.Add(this.txtSecondName);
            this.rounded_Panel1.Controls.Add(this.txtFirstName);
            this.rounded_Panel1.Location = new System.Drawing.Point(12, 12);
            this.rounded_Panel1.Name = "rounded_Panel1";
            this.rounded_Panel1.PanelColor = System.Drawing.Color.White;
            this.rounded_Panel1.Radio = 20;
            this.rounded_Panel1.Size = new System.Drawing.Size(376, 472);
            this.rounded_Panel1.TabIndex = 0;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(12, 248);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(349, 36);
            this.txtMail.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.txtMail.StateActive.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMail.StateCommon.Border.Rounding = 20;
            this.txtMail.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.txtMail.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.TabIndex = 11;
            this.txtMail.Text = "Email";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegister.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnRegister.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegister.BorderRadius = 20;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(125, 395);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 40);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.TextColor = System.Drawing.Color.White;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 293);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(349, 36);
            this.txtPassword.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.txtPassword.StateActive.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 20;
            this.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.txtPassword.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password";
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BackColor = System.Drawing.Color.White;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.Black;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.Black;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::Login.Properties.Resources.profile;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(140, 17);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rjCircularPictureBox1.TabIndex = 7;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(12, 337);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(349, 36);
            this.txtConfirm.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.txtConfirm.StateActive.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtConfirm.StateCommon.Border.Rounding = 20;
            this.txtConfirm.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.txtConfirm.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.Text = "Retry password";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(12, 203);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(349, 36);
            this.txtSecondName.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.txtSecondName.StateActive.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSecondName.StateCommon.Border.Rounding = 20;
            this.txtSecondName.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.txtSecondName.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.TabIndex = 2;
            this.txtSecondName.Text = "Second Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(12, 158);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(349, 36);
            this.txtFirstName.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.txtFirstName.StateActive.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFirstName.StateCommon.Border.Rounding = 20;
            this.txtFirstName.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.txtFirstName.StateCommon.Content.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(400, 496);
            this.Controls.Add(this.rounded_Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.Text = "Registro";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rounded_Panel1.ResumeLayout(false);
            this.rounded_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.Rounded_Panel rounded_Panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtConfirm;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSecondName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFirstName;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private CustomControls.Rounded_Button btnRegister;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMail;
    }
}