namespace WIPR
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            sTUDENTToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            studentListToolStripMenuItem = new ToolStripMenuItem();
            staticsToolStripMenuItem = new ToolStripMenuItem();
            editRemoveToolStripMenuItem = new ToolStripMenuItem();
            manageStudentFormToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            cOURSEToolStripMenuItem = new ToolStripMenuItem();
            sCOREToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sTUDENTToolStripMenuItem, cOURSEToolStripMenuItem, sCOREToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            sTUDENTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, studentListToolStripMenuItem, staticsToolStripMenuItem, editRemoveToolStripMenuItem, manageStudentFormToolStripMenuItem, printToolStripMenuItem });
            sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            sTUDENTToolStripMenuItem.Size = new Size(87, 24);
            sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(239, 26);
            addNewStudentToolStripMenuItem.Text = "Add New Student";
            addNewStudentToolStripMenuItem.Click += addNewStudentToolStripMenuItem_Click;
            // 
            // studentListToolStripMenuItem
            // 
            studentListToolStripMenuItem.Name = "studentListToolStripMenuItem";
            studentListToolStripMenuItem.Size = new Size(239, 26);
            studentListToolStripMenuItem.Text = "Student List";
            // 
            // staticsToolStripMenuItem
            // 
            staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            staticsToolStripMenuItem.Size = new Size(239, 26);
            staticsToolStripMenuItem.Text = "Statics";
            // 
            // editRemoveToolStripMenuItem
            // 
            editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            editRemoveToolStripMenuItem.Size = new Size(239, 26);
            editRemoveToolStripMenuItem.Text = "Edit / Remove";
            // 
            // manageStudentFormToolStripMenuItem
            // 
            manageStudentFormToolStripMenuItem.Name = "manageStudentFormToolStripMenuItem";
            manageStudentFormToolStripMenuItem.Size = new Size(239, 26);
            manageStudentFormToolStripMenuItem.Text = "Manage Student Form";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(239, 26);
            printToolStripMenuItem.Text = "Print";
            // 
            // cOURSEToolStripMenuItem
            // 
            cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            cOURSEToolStripMenuItem.Size = new Size(78, 24);
            cOURSEToolStripMenuItem.Text = "COURSE";
            // 
            // sCOREToolStripMenuItem
            // 
            sCOREToolStripMenuItem.Name = "sCOREToolStripMenuItem";
            sCOREToolStripMenuItem.Size = new Size(68, 24);
            sCOREToolStripMenuItem.Text = "SCORE";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sTUDENTToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem studentListToolStripMenuItem;
        private ToolStripMenuItem staticsToolStripMenuItem;
        private ToolStripMenuItem editRemoveToolStripMenuItem;
        private ToolStripMenuItem manageStudentFormToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem cOURSEToolStripMenuItem;
        private ToolStripMenuItem sCOREToolStripMenuItem;
        private MenuStrip menuStrip2;
    }
}