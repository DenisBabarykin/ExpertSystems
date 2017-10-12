namespace ANFIS.UI
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtbxOut = new System.Windows.Forms.TextBox();
            this.txtbxRulesCount = new System.Windows.Forms.TextBox();
            this.lblRulesCount = new System.Windows.Forms.Label();
            this.lblTestCount = new System.Windows.Forms.Label();
            this.txtbxTestCount = new System.Windows.Forms.TextBox();
            this.lblMaxIterCount = new System.Windows.Forms.Label();
            this.txtbxMaxIterCount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 226);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 31);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "Начать расчёт";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtbxOut
            // 
            this.txtbxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxOut.Location = new System.Drawing.Point(161, 24);
            this.txtbxOut.Multiline = true;
            this.txtbxOut.Name = "txtbxOut";
            this.txtbxOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxOut.Size = new System.Drawing.Size(586, 460);
            this.txtbxOut.TabIndex = 2;
            // 
            // txtbxRulesCount
            // 
            this.txtbxRulesCount.Location = new System.Drawing.Point(16, 40);
            this.txtbxRulesCount.Name = "txtbxRulesCount";
            this.txtbxRulesCount.Size = new System.Drawing.Size(100, 20);
            this.txtbxRulesCount.TabIndex = 3;
            this.txtbxRulesCount.Text = "15";
            // 
            // lblRulesCount
            // 
            this.lblRulesCount.AutoSize = true;
            this.lblRulesCount.Location = new System.Drawing.Point(13, 24);
            this.lblRulesCount.Name = "lblRulesCount";
            this.lblRulesCount.Size = new System.Drawing.Size(105, 13);
            this.lblRulesCount.TabIndex = 4;
            this.lblRulesCount.Text = "Количество правил";
            // 
            // lblTestCount
            // 
            this.lblTestCount.AutoSize = true;
            this.lblTestCount.Location = new System.Drawing.Point(13, 69);
            this.lblTestCount.Name = "lblTestCount";
            this.lblTestCount.Size = new System.Drawing.Size(142, 13);
            this.lblTestCount.TabIndex = 6;
            this.lblTestCount.Text = "Размер тестовой выборки";
            // 
            // txtbxTestCount
            // 
            this.txtbxTestCount.Location = new System.Drawing.Point(16, 85);
            this.txtbxTestCount.Name = "txtbxTestCount";
            this.txtbxTestCount.Size = new System.Drawing.Size(100, 20);
            this.txtbxTestCount.TabIndex = 5;
            this.txtbxTestCount.Text = "30";
            // 
            // lblMaxIterCount
            // 
            this.lblMaxIterCount.Location = new System.Drawing.Point(13, 117);
            this.lblMaxIterCount.Name = "lblMaxIterCount";
            this.lblMaxIterCount.Size = new System.Drawing.Size(145, 26);
            this.lblMaxIterCount.TabIndex = 8;
            this.lblMaxIterCount.Text = "Максимальное количество итераций обучения (эпох)";
            // 
            // txtbxMaxIterCount
            // 
            this.txtbxMaxIterCount.Location = new System.Drawing.Point(16, 146);
            this.txtbxMaxIterCount.Name = "txtbxMaxIterCount";
            this.txtbxMaxIterCount.Size = new System.Drawing.Size(100, 20);
            this.txtbxMaxIterCount.TabIndex = 7;
            this.txtbxMaxIterCount.Text = "1000";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 31);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Очистить вывод";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 496);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMaxIterCount);
            this.Controls.Add(this.txtbxMaxIterCount);
            this.Controls.Add(this.lblTestCount);
            this.Controls.Add(this.txtbxTestCount);
            this.Controls.Add(this.lblRulesCount);
            this.Controls.Add(this.txtbxRulesCount);
            this.Controls.Add(this.txtbxOut);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ANFIS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtbxOut;
        private System.Windows.Forms.TextBox txtbxRulesCount;
        private System.Windows.Forms.Label lblRulesCount;
        private System.Windows.Forms.Label lblTestCount;
        private System.Windows.Forms.TextBox txtbxTestCount;
        private System.Windows.Forms.Label lblMaxIterCount;
        private System.Windows.Forms.TextBox txtbxMaxIterCount;
        private System.Windows.Forms.Button btnClear;
    }
}

