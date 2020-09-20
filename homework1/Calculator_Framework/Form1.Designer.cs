namespace Calculator_Framework
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CalButton = new System.Windows.Forms.Button();
            this.Num1Text = new System.Windows.Forms.TextBox();
            this.Num2Text = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.symble = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CalButton
            // 
            this.CalButton.Location = new System.Drawing.Point(337, 249);
            this.CalButton.Name = "CalButton";
            this.CalButton.Size = new System.Drawing.Size(101, 36);
            this.CalButton.TabIndex = 0;
            this.CalButton.Text = "计算";
            this.CalButton.UseVisualStyleBackColor = true;
            this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
            // 
            // Num1Text
            // 
            this.Num1Text.Location = new System.Drawing.Point(130, 129);
            this.Num1Text.Name = "Num1Text";
            this.Num1Text.Size = new System.Drawing.Size(85, 25);
            this.Num1Text.TabIndex = 1;
            this.Num1Text.TextChanged += new System.EventHandler(this.Num1Text_TextChanged);
            // 
            // Num2Text
            // 
            this.Num2Text.Location = new System.Drawing.Point(354, 128);
            this.Num2Text.Name = "Num2Text";
            this.Num2Text.Size = new System.Drawing.Size(98, 25);
            this.Num2Text.TabIndex = 2;
            this.Num2Text.TextChanged += new System.EventHandler(this.Num2Text_TextChanged);
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(539, 128);
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(119, 25);
            this.ResultText.TabIndex = 3;
            this.ResultText.TextChanged += new System.EventHandler(this.ResultText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // symble
            // 
            this.symble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.symble.FormattingEnabled = true;
            this.symble.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.symble.Location = new System.Drawing.Point(262, 128);
            this.symble.Name = "symble";
            this.symble.Size = new System.Drawing.Size(39, 23);
            this.symble.TabIndex = 6;
            this.symble.SelectedIndexChanged += new System.EventHandler(this.symble_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.symble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.Num2Text);
            this.Controls.Add(this.Num1Text);
            this.Controls.Add(this.CalButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalButton;
        private System.Windows.Forms.TextBox Num1Text;
        private System.Windows.Forms.TextBox Num2Text;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox symble;
    }
}

