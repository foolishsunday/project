namespace CommAssist
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbCom = new System.Windows.Forms.ComboBox();
            this.cbbBaud = new System.Windows.Forms.ComboBox();
            this.btnRefreshCom = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCom
            // 
            this.cbbCom.FormattingEnabled = true;
            this.cbbCom.Location = new System.Drawing.Point(47, 65);
            this.cbbCom.Name = "cbbCom";
            this.cbbCom.Size = new System.Drawing.Size(75, 20);
            this.cbbCom.TabIndex = 0;
            // 
            // cbbBaud
            // 
            this.cbbBaud.FormattingEnabled = true;
            this.cbbBaud.Location = new System.Drawing.Point(47, 141);
            this.cbbBaud.Name = "cbbBaud";
            this.cbbBaud.Size = new System.Drawing.Size(75, 20);
            this.cbbBaud.TabIndex = 1;
            // 
            // btnRefreshCom
            // 
            this.btnRefreshCom.Location = new System.Drawing.Point(47, 206);
            this.btnRefreshCom.Name = "btnRefreshCom";
            this.btnRefreshCom.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCom.TabIndex = 2;
            this.btnRefreshCom.Text = "刷新";
            this.btnRefreshCom.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(47, 254);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "打开串口";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 343);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnRefreshCom);
            this.Controls.Add(this.cbbBaud);
            this.Controls.Add(this.cbbCom);
            this.Name = "frmMain";
            this.Text = "CommAssist";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCom;
        private System.Windows.Forms.ComboBox cbbBaud;
        private System.Windows.Forms.Button btnRefreshCom;
        private System.Windows.Forms.Button btnOpen;
    }
}

