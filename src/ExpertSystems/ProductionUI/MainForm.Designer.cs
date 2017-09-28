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
            this.openRulesFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtbxFact = new System.Windows.Forms.TextBox();
            this.txtbxGoal = new System.Windows.Forms.TextBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.grpbxInput = new System.Windows.Forms.GroupBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.grpbxOutput = new System.Windows.Forms.GroupBox();
            this.txtbxSolution = new System.Windows.Forms.TextBox();
            this.btnForwardChaining = new System.Windows.Forms.Button();
            this.btnBackwardChaining = new System.Windows.Forms.Button();
            this.rbProduction = new System.Windows.Forms.RadioButton();
            this.rbLogic = new System.Windows.Forms.RadioButton();
            this.mainMenu.SuspendLayout();
            this.grpbxInput.SuspendLayout();
            this.grpbxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxRules
            // 
            this.txtbxRules.Location = new System.Drawing.Point(8, 42);
            this.txtbxRules.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxRules.Multiline = true;
            this.txtbxRules.Name = "txtbxRules";
            this.txtbxRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxRules.Size = new System.Drawing.Size(283, 208);
            this.txtbxRules.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files (*.txt)|";
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(833, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openRulesFileToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openRulesFileToolStripMenuItem
            // 
            this.openRulesFileToolStripMenuItem.Name = "openRulesFileToolStripMenuItem";
            this.openRulesFileToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.openRulesFileToolStripMenuItem.Text = "Открыть файл правил";
            this.openRulesFileToolStripMenuItem.Click += new System.EventHandler(this.OpenRulesFileToolStripMenuItem_Click);
            // 
            // txtbxFact
            // 
            this.txtbxFact.Location = new System.Drawing.Point(303, 42);
            this.txtbxFact.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxFact.Name = "txtbxFact";
            this.txtbxFact.Size = new System.Drawing.Size(143, 22);
            this.txtbxFact.TabIndex = 2;
            // 
            // txtbxGoal
            // 
            this.txtbxGoal.Location = new System.Drawing.Point(303, 98);
            this.txtbxGoal.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxGoal.Name = "txtbxGoal";
            this.txtbxGoal.Size = new System.Drawing.Size(143, 22);
            this.txtbxGoal.TabIndex = 3;
            // 
            // lblFact
            // 
            this.lblFact.AutoSize = true;
            this.lblFact.Location = new System.Drawing.Point(299, 22);
            this.lblFact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(47, 17);
            this.lblFact.TabIndex = 4;
            this.lblFact.Text = "Факт:";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(299, 79);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(46, 17);
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
            this.grpbxInput.Location = new System.Drawing.Point(13, 105);
            this.grpbxInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxInput.Name = "grpbxInput";
            this.grpbxInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxInput.Size = new System.Drawing.Size(454, 262);
            this.grpbxInput.TabIndex = 6;
            this.grpbxInput.TabStop = false;
            this.grpbxInput.Text = "Входные данные";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(8, 22);
            this.lblRules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(69, 17);
            this.lblRules.TabIndex = 7;
            this.lblRules.Text = "Правила:";
            // 
            // grpbxOutput
            // 
            this.grpbxOutput.Controls.Add(this.txtbxSolution);
            this.grpbxOutput.Location = new System.Drawing.Point(467, 105);
            this.grpbxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpbxOutput.Name = "grpbxOutput";
            this.grpbxOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpbxOutput.Size = new System.Drawing.Size(320, 262);
            this.grpbxOutput.TabIndex = 7;
            this.grpbxOutput.TabStop = false;
            this.grpbxOutput.Text = "Решение";
            // 
            // txtbxSolution
            // 
            this.txtbxSolution.Location = new System.Drawing.Point(8, 42);
            this.txtbxSolution.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxSolution.Multiline = true;
            this.txtbxSolution.Name = "txtbxSolution";
            this.txtbxSolution.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxSolution.Size = new System.Drawing.Size(304, 208);
            this.txtbxSolution.TabIndex = 1;
            // 
            // btnForwardChaining
            // 
            this.btnForwardChaining.Location = new System.Drawing.Point(13, 375);
            this.btnForwardChaining.Margin = new System.Windows.Forms.Padding(4);
            this.btnForwardChaining.Name = "btnForwardChaining";
            this.btnForwardChaining.Size = new System.Drawing.Size(297, 34);
            this.btnForwardChaining.TabIndex = 8;
            this.btnForwardChaining.Text = "Прямой вывод";
            this.btnForwardChaining.UseVisualStyleBackColor = true;
            this.btnForwardChaining.Click += new System.EventHandler(this.btnForwardChaining_Click);
            // 
            // btnBackwardChaining
            // 
            this.btnBackwardChaining.Location = new System.Drawing.Point(13, 424);
            this.btnBackwardChaining.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackwardChaining.Name = "btnBackwardChaining";
            this.btnBackwardChaining.Size = new System.Drawing.Size(297, 34);
            this.btnBackwardChaining.TabIndex = 9;
            this.btnBackwardChaining.Text = "Обратный вывод";
            this.btnBackwardChaining.UseVisualStyleBackColor = true;
            this.btnBackwardChaining.Click += new System.EventHandler(this.btnBackwardChaining_Click);
            // 
            // rbProduction
            // 
            this.rbProduction.AutoSize = true;
            this.rbProduction.Checked = true;
            this.rbProduction.Location = new System.Drawing.Point(21, 41);
            this.rbProduction.Name = "rbProduction";
            this.rbProduction.Size = new System.Drawing.Size(179, 21);
            this.rbProduction.TabIndex = 8;
            this.rbProduction.TabStop = true;
            this.rbProduction.Text = "Продукционный вывод";
            this.rbProduction.UseVisualStyleBackColor = true;
            this.rbProduction.CheckedChanged += new System.EventHandler(this.rbProduction_CheckedChanged);
            // 
            // rbLogic
            // 
            this.rbLogic.AutoSize = true;
            this.rbLogic.Location = new System.Drawing.Point(21, 68);
            this.rbLogic.Name = "rbLogic";
            this.rbLogic.Size = new System.Drawing.Size(150, 21);
            this.rbLogic.TabIndex = 10;
            this.rbLogic.Text = "Логический вывод";
            this.rbLogic.UseVisualStyleBackColor = true;
            this.rbLogic.CheckedChanged += new System.EventHandler(this.rbLogic_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 471);
            this.Controls.Add(this.rbLogic);
            this.Controls.Add(this.rbProduction);
            this.Controls.Add(this.btnBackwardChaining);
            this.Controls.Add(this.btnForwardChaining);
            this.Controls.Add(this.grpbxOutput);
            this.Controls.Add(this.grpbxInput);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem openRulesFileToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbxFact;
        private System.Windows.Forms.TextBox txtbxGoal;
        private System.Windows.Forms.Label lblFact;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.GroupBox grpbxInput;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.GroupBox grpbxOutput;
        private System.Windows.Forms.TextBox txtbxSolution;
        private System.Windows.Forms.Button btnForwardChaining;
        private System.Windows.Forms.Button btnBackwardChaining;
        private System.Windows.Forms.RadioButton rbProduction;
        private System.Windows.Forms.RadioButton rbLogic;
    }
}

