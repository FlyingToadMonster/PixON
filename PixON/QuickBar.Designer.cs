﻿namespace PixON
{
    partial class QuickBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickBar));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("一号图片", 0);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.resultBox = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.recentBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(137, 26);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem1.Text = "显示主界面";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBox.Location = new System.Drawing.Point(0, 220);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(347, 31);
            this.searchBox.TabIndex = 1;
            this.searchBox.Visible = false;
            // 
            // iconBox
            // 
            this.iconBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBox.Image = ((System.Drawing.Image)(resources.GetObject("iconBox.Image")));
            this.iconBox.Location = new System.Drawing.Point(350, 210);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(50, 50);
            this.iconBox.TabIndex = 2;
            this.iconBox.TabStop = false;
            this.iconBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconBox_MouseDown);
            this.iconBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.iconBox_MouseMove);
            this.iconBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iconBox_MouseUp);
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.resultBox.LargeImageList = this.imageList1;
            this.resultBox.Location = new System.Drawing.Point(0, 257);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(347, 344);
            this.resultBox.SmallImageList = this.imageList1;
            this.resultBox.TabIndex = 3;
            this.resultBox.UseCompatibleStateImageBehavior = false;
            this.resultBox.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "QuickBarIcon.png");
            // 
            // recentBox
            // 
            this.recentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentBox.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.recentBox.FormattingEnabled = true;
            this.recentBox.ItemHeight = 21;
            this.recentBox.Items.AddRange(new object[] {
            "（此处会显示您最近搜索过的字词）"});
            this.recentBox.Location = new System.Drawing.Point(0, 0);
            this.recentBox.Name = "recentBox";
            this.recentBox.Size = new System.Drawing.Size(347, 214);
            this.recentBox.TabIndex = 4;
            this.recentBox.Visible = false;
            this.recentBox.SelectedIndexChanged += new System.EventHandler(this.recentBox_SelectedIndexChanged);
            // 
            // QuickBar
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.ControlBox = false;
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.recentBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuickBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.QuickBar_DragDrop);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.PictureBox iconBox;
        private System.Windows.Forms.ListView resultBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox recentBox;
    }
}