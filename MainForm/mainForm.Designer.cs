
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
            this.manageTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookPublishersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRentas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudentOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.popularBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarLibros = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.MediumSlateBlue;
            resources.ApplyResources(this.menuPrincipal, "menuPrincipal");
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.btnAdministrator,
            this.btnStudentOptions,
            this.btnBooks,
            this.btnIssueBooks,
            this.btnReturnBooks,
            this.btnExit});
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
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
            this.manageStudentsToolStripMenuItem1,
            this.manageTopicsToolStripMenuItem,
            this.bookPublishersToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.btnRentas});
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
            // manageTopicsToolStripMenuItem
            // 
            this.manageTopicsToolStripMenuItem.Image = global::MainForm.Properties.Resources.temas;
            this.manageTopicsToolStripMenuItem.Name = "manageTopicsToolStripMenuItem";
            resources.ApplyResources(this.manageTopicsToolStripMenuItem, "manageTopicsToolStripMenuItem");
            this.manageTopicsToolStripMenuItem.Click += new System.EventHandler(this.manageTopicsToolStripMenuItem_Click);
            // 
            // bookPublishersToolStripMenuItem
            // 
            this.bookPublishersToolStripMenuItem.Name = "bookPublishersToolStripMenuItem";
            resources.ApplyResources(this.bookPublishersToolStripMenuItem, "bookPublishersToolStripMenuItem");
            this.bookPublishersToolStripMenuItem.Click += new System.EventHandler(this.bookPublishersToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            resources.ApplyResources(this.authorsToolStripMenuItem, "authorsToolStripMenuItem");
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // btnRentas
            // 
            this.btnRentas.Name = "btnRentas";
            resources.ApplyResources(this.btnRentas, "btnRentas");
            this.btnRentas.Click += new System.EventHandler(this.btnRentas_Click);
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
            // btnBooks
            // 
            this.btnBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popularBooksToolStripMenuItem,
            this.searchBookToolStripMenuItem,
            this.btnAgregarLibros});
            resources.ApplyResources(this.btnBooks, "btnBooks");
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Image = global::MainForm.Properties.Resources.libro;
            this.btnBooks.Name = "btnBooks";
            // 
            // popularBooksToolStripMenuItem
            // 
            this.popularBooksToolStripMenuItem.Name = "popularBooksToolStripMenuItem";
            resources.ApplyResources(this.popularBooksToolStripMenuItem, "popularBooksToolStripMenuItem");
            this.popularBooksToolStripMenuItem.Click += new System.EventHandler(this.popularBooksToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            resources.ApplyResources(this.searchBookToolStripMenuItem, "searchBookToolStripMenuItem");
            this.searchBookToolStripMenuItem.Image = global::MainForm.Properties.Resources.searchbook;
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // btnAgregarLibros
            // 
            resources.ApplyResources(this.btnAgregarLibros, "btnAgregarLibros");
            this.btnAgregarLibros.Image = global::MainForm.Properties.Resources.addBook;
            this.btnAgregarLibros.Name = "btnAgregarLibros";
            this.btnAgregarLibros.Click += new System.EventHandler(this.btnAgregarLibros_Click);
            // 
            // btnIssueBooks
            // 
            resources.ApplyResources(this.btnIssueBooks, "btnIssueBooks");
            this.btnIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
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
        private System.Windows.Forms.ToolStripMenuItem manageTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookPublishersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRentas;
        private System.Windows.Forms.ToolStripMenuItem popularBooksToolStripMenuItem;
    }
}

