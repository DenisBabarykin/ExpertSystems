namespace ProductionUI
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
            this.txtbxRules = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлПравилToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbxFact = new System.Windows.Forms.TextBox();
            this.txtbxGoal = new System.Windows.Forms.TextBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.grpbxInput = new System.Windows.Forms.GroupBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.grpbxOutput = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnForwardChaining = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.grpbxInput.SuspendLayout();
            this.grpbxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxRules
            // 
            this.txtbxRules.Location = new System.Drawing.Point(6, 34);
            this.txtbxRules.Multiline = true;
            this.txtbxRules.Name = "txtbxRules";
            this.txtbxRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxRules.Size = new System.Drawing.Size(120, 170);
            this.txtbxRules.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files (*.txt)|";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(473, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлПравилToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлПравилToolStripMenuItem
            // 
            this.открытьФайлПравилToolStripMenuItem.Name = "открытьФайлПравилToolStripMenuItem";
            this.открытьФайлПравилToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.открытьФайлПравилToolStripMenuItem.Text = "Открыть файл правил";
            // 
            // txtbxFact
            // 
            this.txtbxFact.Location = new System.Drawing.Point(132, 34);
            this.txtbxFact.Name = "txtbxFact";
            this.txtbxFact.Size = new System.Drawing.Size(86, 20);
            this.txtbxFact.TabIndex = 2;
            // 
            // txtbxGoal
            // 
            this.txtbxGoal.Location = new System.Drawing.Point(132, 80);
            this.txtbxGoal.Name = "txtbxGoal";
            this.txtbxGoal.Size = new System.Drawing.Size(86, 20);
            this.txtbxGoal.TabIndex = 3;
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.Location = new System.Drawing.Point(129, 18);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(38, 13);
            this.lblFact.TabIndex = 4;
            this.lblFact.Text = "Факт:";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(129, 64);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(36, 13);
            this.lblGoal.TabIndex = 5;
            this.lblGoal.Text = "Цель:";
            // 
            // grpbxInput
            // 
            this.grpbxInput.Controls.Add(this.lblRules);
            this.grpbxInput.Controls.Add(this.lblGoal);
            this.grpbxInput.Controls.Add(this.txtbxRules);
            this.grpbxInput.Controls.Add(this.txtbxGoal);
            this.grpbxInput.Controls.Add(this.lblFact);
            this.grpbxInput.Controls.Add(this.txtbxFact);
            this.grpbxInput.Location = new System.Drawing.Point(12, 27);
            this.grpbxInput.Name = "grpbxInput";
            this.grpbxInput.Size = new System.Drawing.Size(223, 213);
            this.grpbxInput.TabIndex = 6;
            this.grpbxInput.TabStop = false;
            this.grpbxInput.Text = "Входные данные";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(6, 18);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(54, 13);
            this.lblRules.TabIndex = 7;
            this.lblRules.Text = "Правила:";
            // 
            // grpbxOutput
            // 
            this.grpbxOutput.Controls.Add(this.textBox1);
            this.grpbxOutput.Location = new System.Drawing.Point(241, 27);
            this.grpbxOutput.Name = "grpbxOutput";
            this.grpbxOutput.Size = new System.Drawing.Size(218, 213);
            this.grpbxOutput.TabIndex = 7;
            this.grpbxOutput.TabStop = false;
            this.grpbxOutput.Text = "Решение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 34);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(206, 170);
            this.textBox1.TabIndex = 1;
            // 
            // btnForwardChaining
            // 
            this.btnForwardChaining.Location = new System.Drawing.Point(12, 246);
            this.btnForwardChaining.Name = "btnForwardChaining";
            this.btnForwardChaining.Size = new System.Drawing.Size(223, 28);
            this.btnForwardChaining.TabIndex = 8;
            this.btnForwardChaining.Text = "Прямой вывод";
            this.btnForwardChaining.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Обратный вывод";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnForwardChaining);
            this.Controls.Add(this.grpbxOutput);
            this.Controls.Add(this.grpbxInput);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Продукционный вывод";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.grpbxInput.ResumeLayout(false);
            this.grpbxInput.PerformLayout();
            this.grpbxOutput.ResumeLayout(false);
            this.grpbxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxRules;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлПравилToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbxFact;
        private System.Windows.Forms.TextBox txtbxGoal;
        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.GroupBox grpbxInput;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.GroupBox grpbxOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnForwardChaining;
        private System.Windows.Forms.Button button1;
    }
}

