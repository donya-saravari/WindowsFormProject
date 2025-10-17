namespace firstSessionwindowsform.forms
{
    partial class Dashbord
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
            components = new System.ComponentModel.Container();
            managmentContextMenuStrip = new ContextMenuStrip(components);
            acountToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            scoreToolStripMenuItem = new ToolStripMenuItem();
            coursesInfoToolStripMenuItem = new ToolStripMenuItem();
            managmentContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // managmentContextMenuStrip
            // 
            managmentContextMenuStrip.AccessibleRole = AccessibleRole.MenuBar;
            managmentContextMenuStrip.AllowDrop = true;
            managmentContextMenuStrip.ImageScalingSize = new Size(20, 20);
            managmentContextMenuStrip.Items.AddRange(new ToolStripItem[] { acountToolStripMenuItem, coursesToolStripMenuItem });
            managmentContextMenuStrip.Name = "contextMenuStrip1";
            managmentContextMenuStrip.Size = new Size(130, 52);
            managmentContextMenuStrip.Text = "Dashbord";
            // 
            // acountToolStripMenuItem
            // 
            acountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            acountToolStripMenuItem.Name = "acountToolStripMenuItem";
            acountToolStripMenuItem.Size = new Size(129, 24);
            acountToolStripMenuItem.Text = "Acount";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(224, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scoreToolStripMenuItem, coursesInfoToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(129, 24);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // scoreToolStripMenuItem
            // 
            scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            scoreToolStripMenuItem.Size = new Size(224, 26);
            scoreToolStripMenuItem.Text = "Score";
            // 
            // coursesInfoToolStripMenuItem
            // 
            coursesInfoToolStripMenuItem.Name = "coursesInfoToolStripMenuItem";
            coursesInfoToolStripMenuItem.Size = new Size(224, 26);
            coursesInfoToolStripMenuItem.Text = "Courses info";
            coursesInfoToolStripMenuItem.Click += coursesInfoToolStripMenuItem_Click;
            // 
            // Dashbord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Name = "Dashbord";
            Text = "Dashbord";
            Load += Dashbord_Load;
            managmentContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip managmentContextMenuStrip;
        private ToolStripMenuItem acountToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem scoreToolStripMenuItem;
        private ToolStripMenuItem coursesInfoToolStripMenuItem;
    }
}