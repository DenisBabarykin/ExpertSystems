namespace Forms
{
    partial class EditVariableForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.variableName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.a = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.b = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addVariable = new System.Windows.Forms.Button();
            this.addValue = new System.Windows.Forms.Button();
            this.deleteValue = new System.Windows.Forms.Button();
            this.variableLingName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.isResult = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя переменной";
            // 
            // variableName
            // 
            this.variableName.Location = new System.Drawing.Point(203, 10);
            this.variableName.Name = "variableName";
            this.variableName.Size = new System.Drawing.Size(188, 20);
            this.variableName.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.value,
            this.a,
            this.b,
            this.c,
            this.d});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(16, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 130);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.editValue_Click);
            // 
            // value
            // 
            this.value.Text = "Значение";
            this.value.Width = 111;
            // 
            // a
            // 
            this.a.Text = "a";
            // 
            // b
            // 
            this.b.Text = "b";
            // 
            // c
            // 
            this.c.Text = "c";
            // 
            // d
            // 
            this.d.Text = "d";
            // 
            // addVariable
            // 
            this.addVariable.Location = new System.Drawing.Point(16, 252);
            this.addVariable.Name = "addVariable";
            this.addVariable.Size = new System.Drawing.Size(372, 23);
            this.addVariable.TabIndex = 3;
            this.addVariable.Text = "Сохранить переменную";
            this.addVariable.UseVisualStyleBackColor = true;
            this.addVariable.Click += new System.EventHandler(this.addVariable_Click);
            // 
            // addValue
            // 
            this.addValue.Location = new System.Drawing.Point(16, 223);
            this.addValue.Name = "addValue";
            this.addValue.Size = new System.Drawing.Size(181, 23);
            this.addValue.TabIndex = 4;
            this.addValue.Text = "Добавить значение";
            this.addValue.UseVisualStyleBackColor = true;
            this.addValue.Click += new System.EventHandler(this.addValue_Click);
            // 
            // deleteValue
            // 
            this.deleteValue.Location = new System.Drawing.Point(203, 223);
            this.deleteValue.Name = "deleteValue";
            this.deleteValue.Size = new System.Drawing.Size(185, 23);
            this.deleteValue.TabIndex = 5;
            this.deleteValue.Text = "Удалить значение";
            this.deleteValue.UseVisualStyleBackColor = true;
            this.deleteValue.Click += new System.EventHandler(this.deleteValue_Click);
            // 
            // variableLingName
            // 
            this.variableLingName.Location = new System.Drawing.Point(203, 38);
            this.variableLingName.Name = "variableLingName";
            this.variableLingName.Size = new System.Drawing.Size(188, 20);
            this.variableLingName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Лингвистическое имя переменной";
            // 
            // isResult
            // 
            this.isResult.AutoSize = true;
            this.isResult.Location = new System.Drawing.Point(203, 64);
            this.isResult.Name = "isResult";
            this.isResult.Size = new System.Drawing.Size(141, 17);
            this.isResult.TabIndex = 8;
            this.isResult.Text = "Выходная переменная";
            this.isResult.UseVisualStyleBackColor = true;
            // 
            // EditVariableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 287);
            this.Controls.Add(this.isResult);
            this.Controls.Add(this.variableLingName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteValue);
            this.Controls.Add(this.addValue);
            this.Controls.Add(this.addVariable);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.variableName);
            this.Controls.Add(this.label1);
            this.Name = "EditVariableForm";
            this.Text = "Добавление нечеткой переменной";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox variableName;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader value;
        private System.Windows.Forms.ColumnHeader a;
        private System.Windows.Forms.ColumnHeader b;
        private System.Windows.Forms.ColumnHeader c;
        private System.Windows.Forms.ColumnHeader d;
        private System.Windows.Forms.Button addVariable;
        private System.Windows.Forms.Button addValue;
        private System.Windows.Forms.Button deleteValue;
        private System.Windows.Forms.TextBox variableLingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isResult;
    }
}