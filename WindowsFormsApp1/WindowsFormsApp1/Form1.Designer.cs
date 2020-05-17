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
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.buttonAddCommand = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMeniu = new System.Windows.Forms.Button();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.tabControlMeniu = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.panelAddCommand = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelMasa = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            this.tabControlMeniu.SuspendLayout();
            this.panelMeniu.SuspendLayout();
            this.panelAddCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.buttonAddCommand);
            this.groupBoxUser.Controls.Add(this.buttonEmployee);
            this.groupBoxUser.Controls.Add(this.button2);
            this.groupBoxUser.Controls.Add(this.buttonMeniu);
            this.groupBoxUser.Location = new System.Drawing.Point(53, 2);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(684, 50);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Client/Angajat";
            // 
            // buttonAddCommand
            // 
            this.buttonAddCommand.Location = new System.Drawing.Point(300, 15);
            this.buttonAddCommand.Name = "buttonAddCommand";
            this.buttonAddCommand.Size = new System.Drawing.Size(109, 23);
            this.buttonAddCommand.TabIndex = 3;
            this.buttonAddCommand.Text = "Creaza comanda";
            this.buttonAddCommand.UseVisualStyleBackColor = true;
            this.buttonAddCommand.Click += new System.EventHandler(this.buttonAddCommand_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Location = new System.Drawing.Point(518, 16);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonEmployee.TabIndex = 2;
            this.buttonEmployee.Text = "Angajat";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.Location = new System.Drawing.Point(95, 15);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.Size = new System.Drawing.Size(75, 23);
            this.buttonMeniu.TabIndex = 0;
            this.buttonMeniu.Text = "Meniu";
            this.buttonMeniu.UseVisualStyleBackColor = true;
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // panelEmployee
            // 
            this.panelEmployee.Location = new System.Drawing.Point(53, 70);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(684, 368);
            this.panelEmployee.TabIndex = 1;
            // 
            // tabControlMeniu
            // 
            this.tabControlMeniu.Controls.Add(this.tabPage);
            this.tabControlMeniu.Controls.Add(this.tabPage2);
            this.tabControlMeniu.Location = new System.Drawing.Point(3, 3);
            this.tabControlMeniu.Name = "tabControlMeniu";
            this.tabControlMeniu.SelectedIndex = 0;
            this.tabControlMeniu.Size = new System.Drawing.Size(678, 350);
            this.tabControlMeniu.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.AutoScroll = true;
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(670, 324);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "tabPage1";
            this.tabPage.UseVisualStyleBackColor = true;
            this.tabPage.Click += new System.EventHandler(this.tabPage_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelMeniu
            // 
            this.panelMeniu.AutoScroll = true;
            this.panelMeniu.Controls.Add(this.tabControlMeniu);
            this.panelMeniu.Location = new System.Drawing.Point(53, 70);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(681, 368);
            this.panelMeniu.TabIndex = 1;
            // 
            // panelAddCommand
            // 
            this.panelAddCommand.AutoScroll = true;
            this.panelAddCommand.Controls.Add(this.textBox1);
            this.panelAddCommand.Controls.Add(this.labelMasa);
            this.panelAddCommand.Location = new System.Drawing.Point(53, 73);
            this.panelAddCommand.Name = "panelAddCommand";
            this.panelAddCommand.Size = new System.Drawing.Size(684, 368);
            this.panelAddCommand.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelMasa
            // 
            this.labelMasa.AutoSize = true;
            this.labelMasa.Location = new System.Drawing.Point(26, 12);
            this.labelMasa.Name = "labelMasa";
            this.labelMasa.Size = new System.Drawing.Size(50, 13);
            this.labelMasa.TabIndex = 0;
            this.labelMasa.Text = "Masa Nr.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.panelAddCommand);
            this.Controls.Add(this.panelEmployee);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.tabControlMeniu.ResumeLayout(false);
            this.panelMeniu.ResumeLayout(false);
            this.panelAddCommand.ResumeLayout(false);
            this.panelAddCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMeniu;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.TabControl tabControlMeniu;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAddCommand;
        private System.Windows.Forms.Panel panelAddCommand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelMasa;
    }
}

