namespace Forms
{
    partial class EditRuleStatementForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.variablesCombo = new System.Windows.Forms.ComboBox();
            this.termsCombo = new System.Windows.Forms.ComboBox();
            this.addStatement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Переменная";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Значение";
            // 
            // variablesCombo
            // 
            this.variablesCombo.FormattingEnabled = true;
            this.variablesCombo.Location = new System.Drawing.Point(119, 6);
            this.variablesCombo.Name = "variablesCombo";
            this.variablesCombo.Size = new System.Drawing.Size(161, 21);
            this.variablesCombo.TabIndex = 2;
            this.variablesCombo.SelectedValueChanged += new System.EventHandler(this.variablesCombo_SelectedValueChanged);
            // 
            // termsCombo
            // 
            this.termsCombo.FormattingEnabled = true;
            this.termsCombo.Location = new System.Drawing.Point(119, 33);
            this.termsCombo.Name = "termsCombo";
            this.termsCombo.Size = new System.Drawing.Size(161, 21);
            this.termsCombo.TabIndex = 3;
            // 
            // addStatement
            // 
            this.addStatement.Location = new System.Drawing.Point(12, 62);
            this.addStatement.Name = "addStatement";
            this.addStatement.Size = new System.Drawing.Size(268, 23);
            this.addStatement.TabIndex = 4;
            this.addStatement.Text = "Добавить";
            this.addStatement.UseVisualStyleBackColor = true;
            this.addStatement.Click += new System.EventHandler(this.addStatement_Click);
            // 
            // AddRuleStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 91);
            this.Controls.Add(this.addStatement);
            this.Controls.Add(this.termsCombo);
            this.Controls.Add(this.variablesCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRuleStatementForm";
            this.Text = "Добавление пары переменная - значение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox variablesCombo;
        private System.Windows.Forms.ComboBox termsCombo;
        private System.Windows.Forms.Button addStatement;
    }
}