
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
            this.btnReturnBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctFondo = new System.Windows.Forms.PictureBox();
            this.btnBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregarLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStudentOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIssueBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.btnExit.Size = new System.Drawing.Size(38, 20);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.menuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBooks,
            this.manageTopicsToolStripMenuItem,
            this.btnStudentOptions,
            this.btnIssueBooks,
            this.btnReturnBooks,
            this.btnExit});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            this.menuPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuPrincipal_MouseMove);
            this.menuPrincipal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuPrincipal_MouseUp);
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(89, 20);
            this.btnReturnBooks.Text = "Return Books";
            // 
            // manageTopicsToolStripMenuItem
            // 
            this.manageTopicsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTopicsToolStripMenuItem});
            this.manageTopicsToolStripMenuItem.Name = "manageTopicsToolStripMenuItem";
            this.manageTopicsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.manageTopicsToolStripMenuItem.Text = "Manage Topics";
            // 
            // addTopicsToolStripMenuItem
            // 
            this.addTopicsToolStripMenuItem.Name = "addTopicsToolStripMenuItem";
            this.addTopicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTopicsToolStripMenuItem.Text = "Add Topics";
            this.addTopicsToolStripMenuItem.Click += new System.EventHandler(this.addTopicsToolStripMenuItem_Click);
            // 
            // pctFondo
            // 
            this.pctFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctFondo.Location = new System.Drawing.Point(0, 24);
            this.pctFondo.Name = "pctFondo";
            this.pctFondo.Size = new System.Drawing.Size(800, 426);
            this.pctFondo.TabIndex = 2;
            this.pctFondo.TabStop = false;
            // 
            // btnBooks
            // 
            this.btnBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarLibros,
            this.searchBookToolStripMenuItem});
            this.btnBooks.Image = global::MainForm.Properties.Resources.libro;
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(67, 20);
            this.btnBooks.Text = "Books";
            this.btnBooks.MouseEnter += new System.EventHandler(this.btnBooks_MouseEnter);
            this.btnBooks.MouseHover += new System.EventHandler(this.btnBooks_MouseHover);
            // 
            // btnAgregarLibros
            // 
            this.btnAgregarLibros.AutoSize = false;
            this.btnAgregarLibros.Image = global::MainForm.Properties.Resources.addBook;
            this.btnAgregarLibros.Name = "btnAgregarLibros";
            this.btnAgregarLibros.Size = new System.Drawing.Size(200, 30);
            this.btnAgregarLibros.Text = "Add Book";
            this.btnAgregarLibros.Click += new System.EventHandler(this.btnAgregarLibros_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.AutoSize = false;
            this.searchBookToolStripMenuItem.Image = global::MainForm.Properties.Resources.searchbook;
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            // 
            // btnStudentOptions
            // 
            this.btnStudentOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.manageStudentsToolStripMenuItem,
            this.btnMyProfile});
            this.btnStudentOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentOptions.Image")));
            this.btnStudentOptions.Name = "btnStudentOptions";
            this.btnStudentOptions.Size = new System.Drawing.Size(76, 20);
            this.btnStudentOptions.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.AutoSize = false;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Visible = false;
            // 
            // manageStudentsToolStripMenuItem
            // 
            this.manageStudentsToolStripMenuItem.AutoSize = false;
            this.manageStudentsToolStripMenuItem.Name = "manageStudentsToolStripMenuItem";
            this.manageStudentsToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.manageStudentsToolStripMenuItem.Text = "Manage Students";
            this.manageStudentsToolStripMenuItem.Visible = false;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.AutoSize = false;
            this.btnMyProfile.Image = global::MainForm.Properties.Resources.myProfile;
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(200, 30);
            this.btnMyProfile.Text = "My Profile";
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnIssueBooks.Image")));
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(96, 20);
            this.btnIssueBooks.Text = "Issue Books";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctFondo);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnMyProfile;
        private System.Windows.Forms.ToolStripMenuItem manageTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTopicsToolStripMenuItem;
    }
}

