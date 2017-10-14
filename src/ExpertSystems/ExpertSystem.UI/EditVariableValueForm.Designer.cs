namespace Forms
{
    partial class EditVariableValueForm
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
            this.name = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текстовое значение";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(132, 6);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(133, 20);
            this.name.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 112);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(253, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(34, 40);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(165, 40);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "b";
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(34, 76);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "c";
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(165, 76);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(100, 20);
            this.d.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "d";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(280, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 130);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EditVariableValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 147);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "EditVariableValueForm";
            this.Text = "Добавление переменной";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}