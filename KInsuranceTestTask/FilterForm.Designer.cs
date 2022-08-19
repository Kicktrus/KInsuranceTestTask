namespace KInsuranceTestTask
{
    partial class FilterForm
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
            this.filterDropBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterDropBox
            // 
            this.filterDropBox.FormattingEnabled = true;
            this.filterDropBox.Location = new System.Drawing.Point(12, 12);
            this.filterDropBox.Name = "filterDropBox";
            this.filterDropBox.Size = new System.Drawing.Size(310, 21);
            this.filterDropBox.Sorted = true;
            this.filterDropBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(335, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отфильтровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 53);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterDropBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FilterForm";
            this.Text = "Фильтрация";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox filterDropBox;
        private System.Windows.Forms.Button button1;
    }
}