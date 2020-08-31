namespace LabaGraphics20
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.xStartTextBox = new System.Windows.Forms.TextBox();
            this.xFinishTextBox = new System.Windows.Forms.TextBox();
            this.aConstTextBox = new System.Windows.Forms.TextBox();
            this.bConstTextBox = new System.Windows.Forms.TextBox();
            this.stepComboBox = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Х_нач";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Х_кон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Шаг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Const_A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Const_B";
            // 
            // xStartTextBox
            // 
            this.xStartTextBox.Location = new System.Drawing.Point(67, 10);
            this.xStartTextBox.Name = "xStartTextBox";
            this.xStartTextBox.Size = new System.Drawing.Size(100, 22);
            this.xStartTextBox.TabIndex = 5;
            // 
            // xFinishTextBox
            // 
            this.xFinishTextBox.Location = new System.Drawing.Point(67, 58);
            this.xFinishTextBox.Name = "xFinishTextBox";
            this.xFinishTextBox.Size = new System.Drawing.Size(100, 22);
            this.xFinishTextBox.TabIndex = 6;
            // 
            // aConstTextBox
            // 
            this.aConstTextBox.Location = new System.Drawing.Point(280, 10);
            this.aConstTextBox.Name = "aConstTextBox";
            this.aConstTextBox.Size = new System.Drawing.Size(100, 22);
            this.aConstTextBox.TabIndex = 7;
            // 
            // bConstTextBox
            // 
            this.bConstTextBox.Location = new System.Drawing.Point(280, 58);
            this.bConstTextBox.Name = "bConstTextBox";
            this.bConstTextBox.Size = new System.Drawing.Size(100, 22);
            this.bConstTextBox.TabIndex = 8;
            // 
            // stepComboBox
            // 
            this.stepComboBox.FormattingEnabled = true;
            this.stepComboBox.Items.AddRange(new object[] {
            "0.0001",
            "0.005",
            "0.01",
            "0.5",
            "1",
            "5",
            "10"});
            this.stepComboBox.Location = new System.Drawing.Point(67, 107);
            this.stepComboBox.Name = "stepComboBox";
            this.stepComboBox.Size = new System.Drawing.Size(100, 21);
            this.stepComboBox.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 185);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(176, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "y  = 0.1 * a * x^3 * tg(a - b * x)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 227);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "y = 9 * (x + 15 * sqrt(x^3 +b^3))";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.Location = new System.Drawing.Point(304, 334);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Расчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 369);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.stepComboBox);
            this.Controls.Add(this.bConstTextBox);
            this.Controls.Add(this.aConstTextBox);
            this.Controls.Add(this.xFinishTextBox);
            this.Controls.Add(this.xStartTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(407, 407);
            this.Name = "MainForm";
            this.Text = "Ввод данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox xStartTextBox;
        private System.Windows.Forms.TextBox xFinishTextBox;
        private System.Windows.Forms.TextBox aConstTextBox;
        private System.Windows.Forms.TextBox bConstTextBox;
        private System.Windows.Forms.ComboBox stepComboBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button calculateButton;
    }
}

