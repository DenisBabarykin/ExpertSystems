using System.Windows.Forms;

namespace Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.variablesListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lingName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.values = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteVariable = new System.Windows.Forms.Button();
            this.addVariable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteRule = new System.Windows.Forms.Button();
            this.addRule = new System.Windows.Forms.Button();
            this.rulesListView = new System.Windows.Forms.ListView();
            this.conditions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conclusion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.solveProblem = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDataTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lingResultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // variablesListView
            // 
            this.variablesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.lingName,
            this.values});
            this.variablesListView.FullRowSelect = true;
            this.variablesListView.GridLines = true;
            this.variablesListView.Location = new System.Drawing.Point(6, 19);
            this.variablesListView.MultiSelect = false;
            this.variablesListView.Name = "variablesListView";
            this.variablesListView.Size = new System.Drawing.Size(322, 120);
            this.variablesListView.TabIndex = 1;
            this.variablesListView.UseCompatibleStateImageBehavior = false;
            this.variablesListView.View = System.Windows.Forms.View.Details;
            this.variablesListView.DoubleClick += new System.EventHandler(this.editVariable_Click);
            // 
            // name
            // 
            this.name.Text = "Имя";
            this.name.Width = 38;
            // 
            // lingName
            // 
            this.lingName.Text = "Лингвистическое имя";
            this.lingName.Width = 128;
            // 
            // values
            // 
            this.values.Text = "Значения";
            this.values.Width = 129;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteVariable);
            this.groupBox1.Controls.Add(this.addVariable);
            this.groupBox1.Controls.Add(this.variablesListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Переменные";
            // 
            // deleteVariable
            // 
            this.deleteVariable.Location = new System.Drawing.Point(177, 145);
            this.deleteVariable.Name = "deleteVariable";
            this.deleteVariable.Size = new System.Drawing.Size(151, 23);
            this.deleteVariable.TabIndex = 3;
            this.deleteVariable.Text = "Удалить";
            this.deleteVariable.UseVisualStyleBackColor = true;
            this.deleteVariable.Click += new System.EventHandler(this.deleteVariable_Click);
            // 
            // addVariable
            // 
            this.addVariable.Location = new System.Drawing.Point(6, 145);
            this.addVariable.Name = "addVariable";
            this.addVariable.Size = new System.Drawing.Size(165, 23);
            this.addVariable.TabIndex = 2;
            this.addVariable.Text = "Добавить";
            this.addVariable.UseVisualStyleBackColor = true;
            this.addVariable.Click += new System.EventHandler(this.addVariable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteRule);
            this.groupBox2.Controls.Add(this.addRule);
            this.groupBox2.Controls.Add(this.rulesListView);
            this.groupBox2.Location = new System.Drawing.Point(352, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Правила вывода";
            // 
            // deleteRule
            // 
            this.deleteRule.Location = new System.Drawing.Point(140, 144);
            this.deleteRule.Name = "deleteRule";
            this.deleteRule.Size = new System.Drawing.Size(115, 23);
            this.deleteRule.TabIndex = 2;
            this.deleteRule.Text = "Удалить";
            this.deleteRule.UseVisualStyleBackColor = true;
            this.deleteRule.Click += new System.EventHandler(this.deleteRule_Click);
            // 
            // addRule
            // 
            this.addRule.Location = new System.Drawing.Point(6, 144);
            this.addRule.Name = "addRule";
            this.addRule.Size = new System.Drawing.Size(128, 23);
            this.addRule.TabIndex = 1;
            this.addRule.Text = "Добавить";
            this.addRule.UseVisualStyleBackColor = true;
            this.addRule.Click += new System.EventHandler(this.addRule_Click);
            // 
            // rulesListView
            // 
            this.rulesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.conditions,
            this.conclusion});
            this.rulesListView.FullRowSelect = true;
            this.rulesListView.GridLines = true;
            this.rulesListView.Location = new System.Drawing.Point(6, 18);
            this.rulesListView.Name = "rulesListView";
            this.rulesListView.Size = new System.Drawing.Size(249, 120);
            this.rulesListView.TabIndex = 0;
            this.rulesListView.UseCompatibleStateImageBehavior = false;
            this.rulesListView.View = System.Windows.Forms.View.Details;
            this.rulesListView.DoubleClick += new System.EventHandler(this.editRule_Click);
            // 
            // conditions
            // 
            this.conditions.Text = "Условия";
            this.conditions.Width = 151;
            // 
            // conclusion
            // 
            this.conclusion.Text = "Результат";
            this.conclusion.Width = 66;
            // 
            // solveProblem
            // 
            this.solveProblem.Location = new System.Drawing.Point(473, 213);
            this.solveProblem.Name = "solveProblem";
            this.solveProblem.Size = new System.Drawing.Size(140, 23);
            this.solveProblem.TabIndex = 4;
            this.solveProblem.Text = "Запустить решение задачи";
            this.solveProblem.UseVisualStyleBackColor = true;
            this.solveProblem.Click += new System.EventHandler(this.solveProblem_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(18, 246);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(111, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Числовой результат";
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Location = new System.Drawing.Point(174, 243);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(439, 20);
            this.resultTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Входные данные (через точку с запятой)";
            // 
            // inputDataTextBox
            // 
            this.inputDataTextBox.Location = new System.Drawing.Point(237, 213);
            this.inputDataTextBox.Name = "inputDataTextBox";
            this.inputDataTextBox.Size = new System.Drawing.Size(230, 20);
            this.inputDataTextBox.TabIndex = 8;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(623, 24);
            this.mainMenuStrip.TabIndex = 9;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.fillToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task1ToolStripMenuItem,
            this.task2ToolStripMenuItem,
            this.task3ToolStripMenuItem});
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fillToolStripMenuItem.Text = "Шаблоны задач";
            // 
            // task1ToolStripMenuItem
            // 
            this.task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            this.task1ToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.task1ToolStripMenuItem.Text = "Оценка достоверности информации работодателей";
            this.task1ToolStripMenuItem.Click += new System.EventHandler(this.task1ToolStripMenuItem_Click);
            // 
            // task2ToolStripMenuItem
            // 
            this.task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            this.task2ToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.task2ToolStripMenuItem.Text = "Отбор профилей подготовки";
            this.task2ToolStripMenuItem.Click += new System.EventHandler(this.task2ToolStripMenuItem_Click);
            // 
            // task3ToolStripMenuItem
            // 
            this.task3ToolStripMenuItem.Name = "task3ToolStripMenuItem";
            this.task3ToolStripMenuItem.Size = new System.Drawing.Size(361, 22);
            this.task3ToolStripMenuItem.Text = "Оценка траекторий подготовки студента";
            this.task3ToolStripMenuItem.Click += new System.EventHandler(this.task3ToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Лингвистический результат";
            // 
            // lingResultTextBox
            // 
            this.lingResultTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lingResultTextBox.Enabled = false;
            this.lingResultTextBox.Location = new System.Drawing.Point(174, 269);
            this.lingResultTextBox.Name = "lingResultTextBox";
            this.lingResultTextBox.ReadOnly = true;
            this.lingResultTextBox.Size = new System.Drawing.Size(439, 20);
            this.lingResultTextBox.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(623, 297);
            this.Controls.Add(this.lingResultTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputDataTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.solveProblem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenuStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Экспертная система";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView variablesListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteVariable;
        private System.Windows.Forms.Button addVariable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button deleteRule;
        private System.Windows.Forms.Button addRule;
        private System.Windows.Forms.ListView rulesListView;
        private System.Windows.Forms.ColumnHeader conditions;
        private System.Windows.Forms.ColumnHeader conclusion;
        private System.Windows.Forms.Button solveProblem;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.ColumnHeader values;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputDataTextBox;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem fillToolStripMenuItem;
        private ToolStripMenuItem task1ToolStripMenuItem;
        private ToolStripMenuItem task2ToolStripMenuItem;
        private ToolStripMenuItem task3ToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ColumnHeader lingName;
        private Label label2;
        private TextBox lingResultTextBox;
    }
}

