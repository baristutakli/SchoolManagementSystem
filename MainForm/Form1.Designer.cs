
namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ınstructorManagementPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllİnstructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewİnstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCurentİnstructorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelTitle = new System.Windows.Forms.Label();
            this.grpBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ınstructorManagementPanelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllStudentsToolStripMenuItem,
            this.registerNewStudentsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 20);
            this.toolStripMenuItem1.Text = "Student Management Panel";
            // 
            // displayAllStudentsToolStripMenuItem
            // 
            this.displayAllStudentsToolStripMenuItem.Name = "displayAllStudentsToolStripMenuItem";
            this.displayAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.displayAllStudentsToolStripMenuItem.Text = "Display All students";
            this.displayAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.displayAllStudentsToolStripMenuItem_Click);
            // 
            // registerNewStudentsToolStripMenuItem
            // 
            this.registerNewStudentsToolStripMenuItem.Name = "registerNewStudentsToolStripMenuItem";
            this.registerNewStudentsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.registerNewStudentsToolStripMenuItem.Text = "Register new students";
            this.registerNewStudentsToolStripMenuItem.Click += new System.EventHandler(this.registerNewStudentsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.updateToolStripMenuItem.Text = "Update ";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // ınstructorManagementPanelToolStripMenuItem
            // 
            this.ınstructorManagementPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllİnstructorToolStripMenuItem,
            this.registerNewİnstructorsToolStripMenuItem,
            this.updateCurentİnstructorsToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ınstructorManagementPanelToolStripMenuItem.Name = "ınstructorManagementPanelToolStripMenuItem";
            this.ınstructorManagementPanelToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.ınstructorManagementPanelToolStripMenuItem.Text = "Instructor Management Panel";
            // 
            // displayAllİnstructorToolStripMenuItem
            // 
            this.displayAllİnstructorToolStripMenuItem.Name = "displayAllİnstructorToolStripMenuItem";
            this.displayAllİnstructorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.displayAllİnstructorToolStripMenuItem.Text = "Display all instructor";
            this.displayAllİnstructorToolStripMenuItem.Click += new System.EventHandler(this.displayAllİnstructorToolStripMenuItem_Click);
            // 
            // registerNewİnstructorsToolStripMenuItem
            // 
            this.registerNewİnstructorsToolStripMenuItem.Name = "registerNewİnstructorsToolStripMenuItem";
            this.registerNewİnstructorsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.registerNewİnstructorsToolStripMenuItem.Text = "Register new instructors";
            // 
            // updateCurentİnstructorsToolStripMenuItem
            // 
            this.updateCurentİnstructorsToolStripMenuItem.Name = "updateCurentİnstructorsToolStripMenuItem";
            this.updateCurentİnstructorsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.updateCurentİnstructorsToolStripMenuItem.Text = "Update curent instructors";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleName = "Panel2";
            this.splitContainer1.Panel2.Controls.Add(this.grpBox);
            this.splitContainer1.Size = new System.Drawing.Size(800, 426);
            this.splitContainer1.SplitterDistance = 40;
            this.splitContainer1.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(800, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Welcome";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpBox
            // 
            this.grpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox.Location = new System.Drawing.Point(0, 0);
            this.grpBox.Name = "grpBox";
            this.grpBox.Size = new System.Drawing.Size(800, 382);
            this.grpBox.TabIndex = 0;
            this.grpBox.TabStop = false;
            this.grpBox.Text = "DetailBox";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerNewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ınstructorManagementPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllİnstructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewİnstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCurentİnstructorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox grpBox;
    }
}

