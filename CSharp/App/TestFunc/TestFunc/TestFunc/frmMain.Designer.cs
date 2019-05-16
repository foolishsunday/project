namespace TestFunc
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
            this.btnTest = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.lblAll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(22, 38);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(152, 48);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(47, 12);
            this.lblShow.TabIndex = 1;
            this.lblShow.Text = "lblShow";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(154, 85);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(59, 12);
            this.lblString.TabIndex = 2;
            this.lblString.Text = "lblString";
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.Location = new System.Drawing.Point(22, 164);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(23, 12);
            this.lblAll.TabIndex = 3;
            this.lblAll.Text = "All";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAll);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnTest);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblAll;
    }
}

