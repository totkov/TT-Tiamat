﻿namespace Tiamat.WindowsForms
{
    partial class AccountNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountNote));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_Rows = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Cols = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripStatusLabel_Background = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItem_Light = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Dark = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_Rows,
            this.toolStripStatusLabel_Cols,
            this.toolStripStatusLabel_Background,
            this.toolStripSplitButton1});
            this.statusStrip.Location = new System.Drawing.Point(0, 273);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(463, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStripStatusLabel_Rows
            // 
            this.toolStripStatusLabel_Rows.Name = "toolStripStatusLabel_Rows";
            this.toolStripStatusLabel_Rows.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel_Rows.Text = "Редове: 0";
            // 
            // toolStripStatusLabel_Cols
            // 
            this.toolStripStatusLabel_Cols.Name = "toolStripStatusLabel_Cols";
            this.toolStripStatusLabel_Cols.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel_Cols.Text = "Колони: 3";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(463, 273);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // toolStripStatusLabel_Background
            // 
            this.toolStripStatusLabel_Background.Name = "toolStripStatusLabel_Background";
            this.toolStripStatusLabel_Background.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel_Background.Text = "Избери тема";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Dark,
            this.ToolStripMenuItem_Light});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // ToolStripMenuItem_Light
            // 
            this.ToolStripMenuItem_Light.Name = "ToolStripMenuItem_Light";
            this.ToolStripMenuItem_Light.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Light.Text = "Светла";
            this.ToolStripMenuItem_Light.Click += new System.EventHandler(this.ToolStripMenuItem_Light_Click);
            // 
            // ToolStripMenuItem_Dark
            // 
            this.ToolStripMenuItem_Dark.Name = "ToolStripMenuItem_Dark";
            this.ToolStripMenuItem_Dark.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItem_Dark.Text = "Тъмна";
            this.ToolStripMenuItem_Dark.Click += new System.EventHandler(this.ToolStripMenuItem_Dark_Click);
            // 
            // AccountNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 295);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountNote";
            this.Text = "AccountNote";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Rows;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Cols;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Background;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Dark;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Light;
    }
}