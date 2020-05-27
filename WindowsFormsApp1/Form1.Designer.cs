namespace Restaurant
{
    partial class Form1
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
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.listBoxComenzi = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modAplicatieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angajatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUtilizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.panelMeniu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeniu
            // 
            this.panelMeniu.AutoScroll = true;
            this.panelMeniu.Controls.Add(this.button7);
            this.panelMeniu.Controls.Add(this.listBoxComenzi);
            this.panelMeniu.Location = new System.Drawing.Point(36, 42);
            this.panelMeniu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(1164, 585);
            this.panelMeniu.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(688, 398);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(231, 35);
            this.button7.TabIndex = 20;
            this.button7.Text = "Trimite comanda";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // listBoxComenzi
            // 
            this.listBoxComenzi.FormattingEnabled = true;
            this.listBoxComenzi.ItemHeight = 20;
            this.listBoxComenzi.Location = new System.Drawing.Point(614, 25);
            this.listBoxComenzi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxComenzi.Name = "listBoxComenzi";
            this.listBoxComenzi.Size = new System.Drawing.Size(370, 344);
            this.listBoxComenzi.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modAplicatieToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modAplicatieToolStripMenuItem
            // 
            this.modAplicatieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clentToolStripMenuItem,
            this.angajatToolStripMenuItem});
            this.modAplicatieToolStripMenuItem.Name = "modAplicatieToolStripMenuItem";
            this.modAplicatieToolStripMenuItem.Size = new System.Drawing.Size(135, 29);
            this.modAplicatieToolStripMenuItem.Text = "Mod aplicatie";
            // 
            // clentToolStripMenuItem
            // 
            this.clentToolStripMenuItem.Name = "clentToolStripMenuItem";
            this.clentToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.clentToolStripMenuItem.Text = "Client";
            this.clentToolStripMenuItem.Click += new System.EventHandler(this.clentToolStripMenuItem_Click);
            // 
            // angajatToolStripMenuItem
            // 
            this.angajatToolStripMenuItem.Name = "angajatToolStripMenuItem";
            this.angajatToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.angajatToolStripMenuItem.Text = "Angajat";
            this.angajatToolStripMenuItem.Click += new System.EventHandler(this.angajatToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUtilizareToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.helpToolStripMenuItem.Text = "Ajutor";
            // 
            // manualDeUtilizareToolStripMenuItem
            // 
            this.manualDeUtilizareToolStripMenuItem.Name = "manualDeUtilizareToolStripMenuItem";
            this.manualDeUtilizareToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.manualDeUtilizareToolStripMenuItem.Text = "Manual de utilizare";
            this.manualDeUtilizareToolStripMenuItem.Click += new System.EventHandler(this.manualDeUtilizareToolStripMenuItem_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // panelEmployee
            // 
            this.panelEmployee.Location = new System.Drawing.Point(18, 42);
            this.panelEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(1119, 558);
            this.panelEmployee.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.panelEmployee);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMeniu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modAplicatieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angajatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUtilizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBoxComenzi;
        private System.Windows.Forms.Panel panelEmployee;
    }
}

