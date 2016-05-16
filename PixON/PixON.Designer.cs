namespace PixON
{
    partial class PixON
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PixON));
            this.fbdSelectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnQBar = new System.Windows.Forms.Button();
            this.btnClipImp = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuTrayShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWebUpload = new System.Windows.Forms.Button();
            this.btnWebSync = new System.Windows.Forms.Button();
            this.menuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQBar
            // 
            this.btnQBar.Location = new System.Drawing.Point(169, 12);
            this.btnQBar.Name = "btnQBar";
            this.btnQBar.Size = new System.Drawing.Size(144, 41);
            this.btnQBar.TabIndex = 5;
            this.btnQBar.Text = "悬浮窗";
            this.btnQBar.UseVisualStyleBackColor = true;
            this.btnQBar.Click += new System.EventHandler(this.btnQBar_Click);
            // 
            // btnClipImp
            // 
            this.btnClipImp.Location = new System.Drawing.Point(12, 12);
            this.btnClipImp.Name = "btnClipImp";
            this.btnClipImp.Size = new System.Drawing.Size(144, 41);
            this.btnClipImp.TabIndex = 6;
            this.btnClipImp.Text = "从剪贴板添加图片";
            this.btnClipImp.UseVisualStyleBackColor = true;
            this.btnClipImp.Click += new System.EventHandler(this.btnClipImp_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.menuTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PixON";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // menuTray
            // 
            this.menuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrayShowMain,
            this.menuTrayExit});
            this.menuTray.Name = "menuTray";
            this.menuTray.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuTray.Size = new System.Drawing.Size(137, 48);
            // 
            // menuTrayShowMain
            // 
            this.menuTrayShowMain.Name = "menuTrayShowMain";
            this.menuTrayShowMain.Size = new System.Drawing.Size(136, 22);
            this.menuTrayShowMain.Text = "显示主界面";
            this.menuTrayShowMain.Click += new System.EventHandler(this.menuTrayShowMain_Click);
            // 
            // menuTrayExit
            // 
            this.menuTrayExit.Name = "menuTrayExit";
            this.menuTrayExit.Size = new System.Drawing.Size(136, 22);
            this.menuTrayExit.Text = "退出程序";
            this.menuTrayExit.Click += new System.EventHandler(this.menuTrayExit_Click);
            // 
            // btnWebUpload
            // 
            this.btnWebUpload.Location = new System.Drawing.Point(12, 59);
            this.btnWebUpload.Name = "btnWebUpload";
            this.btnWebUpload.Size = new System.Drawing.Size(144, 164);
            this.btnWebUpload.TabIndex = 7;
            this.btnWebUpload.Text = "上传至云";
            this.btnWebUpload.UseVisualStyleBackColor = true;
            // 
            // btnWebSync
            // 
            this.btnWebSync.Location = new System.Drawing.Point(169, 59);
            this.btnWebSync.Name = "btnWebSync";
            this.btnWebSync.Size = new System.Drawing.Size(144, 164);
            this.btnWebSync.TabIndex = 8;
            this.btnWebSync.Text = "从云同步";
            this.btnWebSync.UseVisualStyleBackColor = true;
            // 
            // PixON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 235);
            this.Controls.Add(this.btnWebSync);
            this.Controls.Add(this.btnWebUpload);
            this.Controls.Add(this.btnClipImp);
            this.Controls.Add(this.btnQBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PixON";
            this.Text = "PixON";
            this.Resize += new System.EventHandler(this.PixON_Resize);
            this.menuTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fbdSelectPath;
        private System.Windows.Forms.Button btnQBar;
        private System.Windows.Forms.Button btnClipImp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip menuTray;
        private System.Windows.Forms.ToolStripMenuItem menuTrayShowMain;
        private System.Windows.Forms.ToolStripMenuItem menuTrayExit;
        private System.Windows.Forms.Button btnWebUpload;
        private System.Windows.Forms.Button btnWebSync;
    }
}

