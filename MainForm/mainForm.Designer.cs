
namespace MainForm
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdministrator = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudentOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIssueBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReturnBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.pctFondo = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.MediumSlateBlue;
            resources.ApplyResources(this.menuPrincipal, "menuPrincipal");
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.btnAdministrator,
            this.btnBooks,
            this.btnStudentOptions,
            this.btnIssueBooks,
            this.btnReturnBooks,
            this.btnExit});
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPrincipal_MouseMove);
            // 
            // masterToolStripMenuItem
            // 
            resources.ApplyResources(this.masterToolStripMenuItem, "masterToolStripMenuItem");
            this.masterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.masterToolStripMenuItem.Image = global::MainForm.Properties.Resources.masterIcon;
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            // 
            // btnAdministrator
            // 
            this.btnAdministrator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStudentsToolStripMenuItem1});
            resources.ApplyResources(this.btnAdministrator, "btnAdministrator");
            this.btnAdministrator.ForeColor = System.Drawing.Color.White;
            this.btnAdministrator.Image = global::MainForm.Properties.Resources.adminIcon;
            this.btnAdministrator.Name = "btnAdministrator";
            // 
            // manageStudentsToolStripMenuItem1
            // 
            this.manageStudentsToolStripMenuItem1.Image = global::MainForm.Properties.Resources.estudiante;
            this.manageStudentsToolStripMenuItem1.Name = "manageStudentsToolStripMenuItem1";
            resources.ApplyResources(this.manageStudentsToolStripMenuItem1, "manageStudentsToolStripMenuItem1");
            // 
            // btnBooks
            // 
            this.btnBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarLibros,
            this.searchBookToolStripMenuItem});
            resources.ApplyResources(this.btnBooks, "btnBooks");
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Image = global::MainForm.Properties.Resources.libro;
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.MouseEnter += new System.EventHandler(this.btnBooks_MouseEnter);
            // 
            // btnAgregarLibros
            // 
            resources.ApplyResources(this.btnAgregarLibros, "btnAgregarLibros");
            this.btnAgregarLibros.Image = global::MainForm.Properties.Resources.addBook;
            this.btnAgregarLibros.Name = "btnAgregarLibros";
            this.btnAgregarLibros.Click += new System.EventHandler(this.btnAgregarLibros_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            resources.ApplyResources(this.searchBookToolStripMenuItem, "searchBookToolStripMenuItem");
            this.searchBookToolStripMenuItem.Image = global::MainForm.Properties.Resources.searchbook;
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            // 
            // btnStudentOptions
            // 
            this.btnStudentOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMyProfile});
            resources.ApplyResources(this.btnStudentOptions, "btnStudentOptions");
            this.btnStudentOptions.ForeColor = System.Drawing.Color.White;
            this.btnStudentOptions.Name = "btnStudentOptions";
            // 
            // btnMyProfile
            // 
            resources.ApplyResources(this.btnMyProfile, "btnMyProfile");
            this.btnMyProfile.Image = global::MainForm.Properties.Resources.myProfile;
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnIssueBooks
            // 
            resources.ApplyResources(this.btnIssueBooks, "btnIssueBooks");
            this.btnIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnIssueBooks.Name = "btnIssueBooks";
            // 
            // btnReturnBooks
            // 
            resources.ApplyResources(this.btnReturnBooks, "btnReturnBooks");
            this.btnReturnBooks.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooks.Name = "btnReturnBooks";
            // 
            // pctFondo
            // 
            resources.ApplyResources(this.pctFondo, "pctFondo");
            this.pctFondo.Name = "pctFondo";
            this.pctFondo.TabStop = false;
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pctFondo);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem btnBooks;
        private System.Windows.Forms.ToolStripMenuItem btnStudentOptions;
        private System.Windows.Forms.ToolStripMenuItem btnIssueBooks;
        private System.Windows.Forms.ToolStripMenuItem btnReturnBooks;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.PictureBox pctFondo;
        private System.Windows.Forms.ToolStripMenuItem btnAgregarLibros;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMyProfile;
        private System.Windows.Forms.ToolStripMenuItem btnAdministrator;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
    }
}

