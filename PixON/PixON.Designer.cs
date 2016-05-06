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
            this.lbPathList = new System.Windows.Forms.ListBox();
            this.tbPathInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.fbdSelectPath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnQBar = new System.Windows.Forms.Button();
            this.btnClipImp = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lbPathList
            // 
            this.lbPathList.FormattingEnabled = true;
            this.lbPathList.ItemHeight = 12;
            this.lbPathList.Location = new System.Drawing.Point(23, 68);
            this.lbPathList.Name = "lbPathList";
            this.lbPathList.Size = new System.Drawing.Size(179, 136);
            this.lbPathList.TabIndex = 0;
            // 
            // tbPathInput
            // 
            this.tbPathInput.Location = new System.Drawing.Point(23, 41);
            this.tbPathInput.Name = "tbPathInput";
            this.tbPathInput.Size = new System.Drawing.Size(135, 21);
            this.tbPathInput.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加路径";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(217, 68);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(85, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "删除选定项";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(164, 41);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(38, 23);
            this.btnSelectPath.TabIndex = 4;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // btnQBar
            // 
            this.btnQBar.Location = new System.Drawing.Point(217, 182);
            this.btnQBar.Name = "btnQBar";
            this.btnQBar.Size = new System.Drawing.Size(85, 23);
            this.btnQBar.TabIndex = 5;
            this.btnQBar.Text = "悬浮窗";
            this.btnQBar.UseVisualStyleBackColor = true;
            this.btnQBar.Click += new System.EventHandler(this.btnQBar_Click);
            // 
            // btnClipImp
            // 
            this.btnClipImp.Location = new System.Drawing.Point(217, 135);
            this.btnClipImp.Name = "btnClipImp";
            this.btnClipImp.Size = new System.Drawing.Size(85, 41);
            this.btnClipImp.TabIndex = 6;
            this.btnClipImp.Text = "从剪贴板添加图片";
            this.btnClipImp.UseVisualStyleBackColor = true;
            this.btnClipImp.Click += new System.EventHandler(this.btnClipImp_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // PixON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 235);
            this.Controls.Add(this.btnClipImp);
            this.Controls.Add(this.btnQBar);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPathInput);
            this.Controls.Add(this.lbPathList);
            this.Name = "PixON";
            this.Text = "PixON";
            this.Resize += new System.EventHandler(this.PixON_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPathList;
        private System.Windows.Forms.TextBox tbPathInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.FolderBrowserDialog fbdSelectPath;
        private System.Windows.Forms.Button btnQBar;
        private System.Windows.Forms.Button btnClipImp;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

