namespace KInsuranceTestTask
{
    partial class Form1
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
            this.dataOutput = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.task1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.task3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterLabel = new System.Windows.Forms.Label();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataOutput
            // 
            this.dataOutput.AllowUserToAddRows = false;
            this.dataOutput.AllowUserToDeleteRows = false;
            this.dataOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataOutput.Location = new System.Drawing.Point(0, 24);
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.Size = new System.Drawing.Size(800, 429);
            this.dataOutput.TabIndex = 0;
            this.dataOutput.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataOutput_ColumnHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task1ToolStripMenuItem,
            this.task2ToolStripMenuItem,
            this.task3ToolStripMenuItem,
            this.removeFilterToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // task1ToolStripMenuItem
            // 
            this.task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
            this.task1ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.task1ToolStripMenuItem.Text = "Задание 1";
            this.task1ToolStripMenuItem.Click += new System.EventHandler(this.task1ToolStripMenuItem_Click);
            // 
            // task2ToolStripMenuItem
            // 
            this.task2ToolStripMenuItem.Name = "task2ToolStripMenuItem";
            this.task2ToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.task2ToolStripMenuItem.Text = "Задание 2 ";
            this.task2ToolStripMenuItem.Click += new System.EventHandler(this.task2ToolStripMenuItem_Click);
            // 
            // task3ToolStripMenuItem
            // 
            this.task3ToolStripMenuItem.Name = "task3ToolStripMenuItem";
            this.task3ToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.task3ToolStripMenuItem.Text = "Задание 3";
            this.task3ToolStripMenuItem.Click += new System.EventHandler(this.task3ToolStripMenuItem_Click);
            // 
            // removeFilterToolStripMenuItem
            // 
            this.removeFilterToolStripMenuItem.Name = "removeFilterToolStripMenuItem";
            this.removeFilterToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.removeFilterToolStripMenuItem.Text = "Снять Фильтр";
            this.removeFilterToolStripMenuItem.Click += new System.EventHandler(this.removeFilterToolStripMenuItem_Click);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filterLabel.Location = new System.Drawing.Point(0, 438);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(74, 15);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Нет фильтра";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.exportToolStripMenuItem.Text = "Экспорт";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.dataOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Данные";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem task1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem task3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFilterToolStripMenuItem;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    }
}

