namespace LB5._2
{
    partial class EditPackageForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.SizeBox = new System.Windows.Forms.ComboBox();
            this.ColorBox = new System.Windows.Forms.ComboBox();
            this.VarietyBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PackageTypeBox = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цвет";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вариативное";
            // 
            // SizeBox
            // 
            this.SizeBox.FormattingEnabled = true;
            this.SizeBox.Location = new System.Drawing.Point(119, 88);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(121, 21);
            this.SizeBox.TabIndex = 4;
            // 
            // ColorBox
            // 
            this.ColorBox.FormattingEnabled = true;
            this.ColorBox.Location = new System.Drawing.Point(119, 126);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(121, 21);
            this.ColorBox.TabIndex = 5;
            // 
            // VarietyBox
            // 
            this.VarietyBox.FormattingEnabled = true;
            this.VarietyBox.Location = new System.Drawing.Point(119, 161);
            this.VarietyBox.Name = "VarietyBox";
            this.VarietyBox.Size = new System.Drawing.Size(121, 21);
            this.VarietyBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип упаковки";
            // 
            // PackageTypeBox
            // 
            this.PackageTypeBox.FormattingEnabled = true;
            this.PackageTypeBox.Location = new System.Drawing.Point(119, 30);
            this.PackageTypeBox.Name = "PackageTypeBox";
            this.PackageTypeBox.Size = new System.Drawing.Size(121, 21);
            this.PackageTypeBox.TabIndex = 8;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(36, 215);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancButton
            // 
            this.CancButton.Location = new System.Drawing.Point(165, 215);
            this.CancButton.Name = "CancButton";
            this.CancButton.Size = new System.Drawing.Size(75, 23);
            this.CancButton.TabIndex = 10;
            this.CancButton.Text = "Отмена";
            this.CancButton.UseVisualStyleBackColor = true;
            this.CancButton.Click += new System.EventHandler(this.CancButton_Click);
            // 
            // EditPackageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CancButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PackageTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VarietyBox);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.SizeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPackageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPackageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SizeBox;
        private System.Windows.Forms.ComboBox ColorBox;
        private System.Windows.Forms.ComboBox VarietyBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PackageTypeBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancButton;
    }
}