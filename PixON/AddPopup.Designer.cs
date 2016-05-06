namespace PixON
{
    partial class AddPopup
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dgvKeyValue = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(195, 222);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvKeyValue
            // 
            this.dgvKeyValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeyValue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.Value});
            this.dgvKeyValue.Location = new System.Drawing.Point(12, 12);
            this.dgvKeyValue.Name = "dgvKeyValue";
            this.dgvKeyValue.RowTemplate.Height = 23;
            this.dgvKeyValue.Size = new System.Drawing.Size(258, 204);
            this.dgvKeyValue.TabIndex = 7;
            // 
            // Key
            // 
            this.Key.HeaderText = "标签名称";
            this.Key.Name = "Key";
            // 
            // Value
            // 
            this.Value.HeaderText = "标签内容";
            this.Value.Name = "Value";
            // 
            // AddPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 257);
            this.Controls.Add(this.dgvKeyValue);
            this.Controls.Add(this.btnConfirm);
            this.Name = "AddPopup";
            this.Text = "AddPopup";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeyValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dgvKeyValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}