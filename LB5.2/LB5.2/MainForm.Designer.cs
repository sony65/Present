namespace LB5._2
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
            this.SweetnessBox = new System.Windows.Forms.ListBox();
            this.PackageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EditPackageButton = new System.Windows.Forms.Button();
            this.AddSweetsButton = new System.Windows.Forms.Button();
            this.RemoveSweetsButton = new System.Windows.Forms.Button();
            this.EditSweetsButton = new System.Windows.Forms.Button();
            this.GiftWeightLabel = new System.Windows.Forms.Label();
            this.InfoPackageButton = new System.Windows.Forms.Button();
            this.InfoSweetnessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SweetnessBox
            // 
            this.SweetnessBox.FormattingEnabled = true;
            this.SweetnessBox.Location = new System.Drawing.Point(297, 50);
            this.SweetnessBox.Name = "SweetnessBox";
            this.SweetnessBox.Size = new System.Drawing.Size(149, 147);
            this.SweetnessBox.TabIndex = 1;
            this.SweetnessBox.DataSourceChanged += new System.EventHandler(this.SweetnessBox_DataSourceChanged);
            // 
            // PackageBox
            // 
            this.PackageBox.Location = new System.Drawing.Point(31, 50);
            this.PackageBox.Name = "PackageBox";
            this.PackageBox.Size = new System.Drawing.Size(140, 20);
            this.PackageBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Упаковка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Сладости";
            // 
            // EditPackageButton
            // 
            this.EditPackageButton.Location = new System.Drawing.Point(49, 76);
            this.EditPackageButton.Name = "EditPackageButton";
            this.EditPackageButton.Size = new System.Drawing.Size(112, 23);
            this.EditPackageButton.TabIndex = 5;
            this.EditPackageButton.Text = "Редактировать";
            this.EditPackageButton.UseVisualStyleBackColor = true;
            this.EditPackageButton.Click += new System.EventHandler(this.EditPackageButton_Click);
            // 
            // AddSweetsButton
            // 
            this.AddSweetsButton.Location = new System.Drawing.Point(238, 215);
            this.AddSweetsButton.Name = "AddSweetsButton";
            this.AddSweetsButton.Size = new System.Drawing.Size(75, 23);
            this.AddSweetsButton.TabIndex = 6;
            this.AddSweetsButton.Text = "Добавить";
            this.AddSweetsButton.UseVisualStyleBackColor = true;
            this.AddSweetsButton.Click += new System.EventHandler(this.AddSweetsButton_Click);
            // 
            // RemoveSweetsButton
            // 
            this.RemoveSweetsButton.Location = new System.Drawing.Point(427, 215);
            this.RemoveSweetsButton.Name = "RemoveSweetsButton";
            this.RemoveSweetsButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSweetsButton.TabIndex = 7;
            this.RemoveSweetsButton.Text = "Удалить";
            this.RemoveSweetsButton.UseVisualStyleBackColor = true;
            this.RemoveSweetsButton.Click += new System.EventHandler(this.RemoveSweetsButton_Click);
            // 
            // EditSweetsButton
            // 
            this.EditSweetsButton.Location = new System.Drawing.Point(319, 215);
            this.EditSweetsButton.Name = "EditSweetsButton";
            this.EditSweetsButton.Size = new System.Drawing.Size(102, 23);
            this.EditSweetsButton.TabIndex = 8;
            this.EditSweetsButton.Text = "Редактировать";
            this.EditSweetsButton.UseVisualStyleBackColor = true;
            this.EditSweetsButton.Click += new System.EventHandler(this.EditSweetsButton_Click);
            // 
            // GiftWeightLabel
            // 
            this.GiftWeightLabel.AutoSize = true;
            this.GiftWeightLabel.Location = new System.Drawing.Point(28, 215);
            this.GiftWeightLabel.Name = "GiftWeightLabel";
            this.GiftWeightLabel.Size = new System.Drawing.Size(0, 13);
            this.GiftWeightLabel.TabIndex = 9;
            // 
            // InfoPackageButton
            // 
            this.InfoPackageButton.Location = new System.Drawing.Point(49, 105);
            this.InfoPackageButton.Name = "InfoPackageButton";
            this.InfoPackageButton.Size = new System.Drawing.Size(112, 23);
            this.InfoPackageButton.TabIndex = 10;
            this.InfoPackageButton.Text = "Информация";
            this.InfoPackageButton.UseVisualStyleBackColor = true;
            this.InfoPackageButton.Click += new System.EventHandler(this.InfoPackageButton_Click);
            // 
            // InfoSweetnessButton
            // 
            this.InfoSweetnessButton.Location = new System.Drawing.Point(319, 254);
            this.InfoSweetnessButton.Name = "InfoSweetnessButton";
            this.InfoSweetnessButton.Size = new System.Drawing.Size(102, 23);
            this.InfoSweetnessButton.TabIndex = 11;
            this.InfoSweetnessButton.Text = "Информация";
            this.InfoSweetnessButton.UseVisualStyleBackColor = true;
            this.InfoSweetnessButton.Click += new System.EventHandler(this.InfoSweetnessButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 289);
            this.Controls.Add(this.InfoSweetnessButton);
            this.Controls.Add(this.InfoPackageButton);
            this.Controls.Add(this.GiftWeightLabel);
            this.Controls.Add(this.EditSweetsButton);
            this.Controls.Add(this.RemoveSweetsButton);
            this.Controls.Add(this.AddSweetsButton);
            this.Controls.Add(this.EditPackageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PackageBox);
            this.Controls.Add(this.SweetnessBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SweetnessBox;
        private System.Windows.Forms.TextBox PackageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EditPackageButton;
        private System.Windows.Forms.Button AddSweetsButton;
        private System.Windows.Forms.Button RemoveSweetsButton;
        private System.Windows.Forms.Button EditSweetsButton;
        private System.Windows.Forms.Label GiftWeightLabel;
        private System.Windows.Forms.Button InfoPackageButton;
        private System.Windows.Forms.Button InfoSweetnessButton;
    }
}