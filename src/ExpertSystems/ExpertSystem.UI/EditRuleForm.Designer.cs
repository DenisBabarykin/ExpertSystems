namespace Forms
{
    partial class EditRuleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conditionsListView = new System.Windows.Forms.ListView();
            this.variable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.conclusionListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addCondition = new System.Windows.Forms.Button();
            this.deleteCondition = new System.Windows.Forms.Button();
            this.deleteConclusion = new System.Windows.Forms.Button();
            this.addConclusion = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conditionsListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия";
            // 
            // conditionsListView
            // 
            this.conditionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.variable,
            this.value});
            this.conditionsListView.GridLines = true;
            this.conditionsListView.Location = new System.Drawing.Point(6, 19);
            this.conditionsListView.Name = "conditionsListView";
            this.conditionsListView.Size = new System.Drawing.Size(344, 96);
            this.conditionsListView.TabIndex = 0;
            this.conditionsListView.UseCompatibleStateImageBehavior = false;
            this.conditionsListView.View = System.Windows.Forms.View.Details;
            // 
            // variable
            // 
            this.variable.Text = "Переменная";
            this.variable.Width = 171;
            // 
            // value
            // 
            this.value.Text = "Значение";
            this.value.Width = 167;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.conclusionListView);
            this.groupBox2.Location = new System.Drawing.Point(13, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // conclusionListView
            // 
            this.conclusionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.conclusionListView.GridLines = true;
            this.conclusionListView.Location = new System.Drawing.Point(6, 19);
            this.conclusionListView.Name = "conclusionListView";
            this.conclusionListView.Size = new System.Drawing.Size(344, 47);
            this.conclusionListView.TabIndex = 1;
            this.conclusionListView.UseCompatibleStateImageBehavior = false;
            this.conclusionListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Переменная";
            this.columnHeader1.Width = 171;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 167;
            // 
            // addCondition
            // 
            this.addCondition.Location = new System.Drawing.Point(13, 225);
            this.addCondition.Name = "addCondition";
            this.addCondition.Size = new System.Drawing.Size(176, 23);
            this.addCondition.TabIndex = 2;
            this.addCondition.Text = "Добавить условие";
            this.addCondition.UseVisualStyleBackColor = true;
            this.addCondition.Click += new System.EventHandler(this.addCondition_Click);
            // 
            // deleteCondition
            // 
            this.deleteCondition.Location = new System.Drawing.Point(195, 225);
            this.deleteCondition.Name = "deleteCondition";
            this.deleteCondition.Size = new System.Drawing.Size(173, 23);
            this.deleteCondition.TabIndex = 3;
            this.deleteCondition.Text = "Удалить условие";
            this.deleteCondition.UseVisualStyleBackColor = true;
            this.deleteCondition.Click += new System.EventHandler(this.deleteCondition_Click);
            // 
            // deleteConclusion
            // 
            this.deleteConclusion.Location = new System.Drawing.Point(194, 254);
            this.deleteConclusion.Name = "deleteConclusion";
            this.deleteConclusion.Size = new System.Drawing.Size(173, 23);
            this.deleteConclusion.TabIndex = 5;
            this.deleteConclusion.Text = "Удалить заключение";
            this.deleteConclusion.UseVisualStyleBackColor = true;
            this.deleteConclusion.Click += new System.EventHandler(this.deleteConclusion_Click);
            // 
            // addConclusion
            // 
            this.addConclusion.Location = new System.Drawing.Point(12, 254);
            this.addConclusion.Name = "addConclusion";
            this.addConclusion.Size = new System.Drawing.Size(176, 23);
            this.addConclusion.TabIndex = 4;
            this.addConclusion.Text = "Добавить заключение";
            this.addConclusion.UseVisualStyleBackColor = true;
            this.addConclusion.Click += new System.EventHandler(this.addConclusion_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 283);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(356, 23);
            this.save.TabIndex = 6;
            this.save.Text = "Сохранить правило";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddRuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 309);
            this.Controls.Add(this.save);
            this.Controls.Add(this.deleteConclusion);
            this.Controls.Add(this.addConclusion);
            this.Controls.Add(this.deleteCondition);
            this.Controls.Add(this.addCondition);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRuleForm";
            this.Text = "Добавление правила";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView conditionsListView;
        private System.Windows.Forms.ColumnHeader variable;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView conclusionListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button addCondition;
        private System.Windows.Forms.Button deleteCondition;
        private System.Windows.Forms.Button deleteConclusion;
        private System.Windows.Forms.Button addConclusion;
        private System.Windows.Forms.Button save;
    }
}