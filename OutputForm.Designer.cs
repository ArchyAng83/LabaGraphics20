namespace LabaGraphics20
{
    partial class OutputForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.graphicBuildButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 342);
            this.listBox1.TabIndex = 0;
            // 
            // graphicBuildButton
            // 
            this.graphicBuildButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.graphicBuildButton.Location = new System.Drawing.Point(146, 346);
            this.graphicBuildButton.Name = "graphicBuildButton";
            this.graphicBuildButton.Size = new System.Drawing.Size(144, 23);
            this.graphicBuildButton.TabIndex = 1;
            this.graphicBuildButton.Text = "Построить график";
            this.graphicBuildButton.UseVisualStyleBackColor = true;
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 381);
            this.Controls.Add(this.graphicBuildButton);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(496, 587);
            this.MinimumSize = new System.Drawing.Size(318, 419);
            this.Name = "OutputForm";
            this.Text = "Вывод данных";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button graphicBuildButton;
    }
}