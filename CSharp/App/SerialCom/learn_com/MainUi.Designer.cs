namespace learn_com
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rhbRcvd = new System.Windows.Forms.RichTextBox();
            this.rhbSend = new System.Windows.Forms.RichTextBox();
            this.chbHexRcvd = new System.Windows.Forms.CheckBox();
            this.chbHexSend = new System.Windows.Forms.CheckBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.label_Baud = new System.Windows.Forms.Label();
            this.lblSentCnt = new System.Windows.Forms.Label();
            this.lblRcvdCnt = new System.Windows.Forms.Label();
            this.chbReadLine = new System.Windows.Forms.CheckBox();
            this.cmbSelectData = new System.Windows.Forms.ComboBox();
            this.rhtbConfigName = new System.Windows.Forms.RichTextBox();
            this.rhtbConfigValue = new System.Windows.Forms.RichTextBox();
            this.chkbStopShow = new System.Windows.Forms.CheckBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClearReceive = new System.Windows.Forms.Button();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbSelectNode = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.lbConfigValue = new System.Windows.Forms.Label();
            this.lbConfigName = new System.Windows.Forms.Label();
            this.lbConfigSelect = new System.Windows.Forms.Label();
            this.cmbConfigSelect = new System.Windows.Forms.ComboBox();
            this.btnRemoveNode = new System.Windows.Forms.Button();
            this.btnAddNode = new System.Windows.Forms.Button();
            this.cntmenuRightButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RightButtonItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.RightButtonItemAllSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tbctrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlData = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.cntmenuRightButton.SuspendLayout();
            this.tbctrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rhbRcvd
            // 
            this.rhbRcvd.BackColor = System.Drawing.SystemColors.Window;
            this.rhbRcvd.Location = new System.Drawing.Point(82, 18);
            this.rhbRcvd.Name = "rhbRcvd";
            this.rhbRcvd.ReadOnly = true;
            this.rhbRcvd.Size = new System.Drawing.Size(596, 348);
            this.rhbRcvd.TabIndex = 1;
            this.rhbRcvd.Text = "";
            this.rhbRcvd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rhtbRx_MouseUp);
            // 
            // rhbSend
            // 
            this.rhbSend.BackColor = System.Drawing.SystemColors.Window;
            this.rhbSend.Location = new System.Drawing.Point(82, 416);
            this.rhbSend.Name = "rhbSend";
            this.rhbSend.Size = new System.Drawing.Size(612, 63);
            this.rhbSend.TabIndex = 3;
            this.rhbSend.Text = "";
            // 
            // chbHexRcvd
            // 
            this.chbHexRcvd.AutoSize = true;
            this.chbHexRcvd.Location = new System.Drawing.Point(82, 372);
            this.chbHexRcvd.Name = "chbHexRcvd";
            this.chbHexRcvd.Size = new System.Drawing.Size(66, 16);
            this.chbHexRcvd.TabIndex = 4;
            this.chbHexRcvd.Text = "Hex接收";
            this.chbHexRcvd.UseVisualStyleBackColor = true;
            // 
            // chbHexSend
            // 
            this.chbHexSend.AutoSize = true;
            this.chbHexSend.Location = new System.Drawing.Point(82, 499);
            this.chbHexSend.Name = "chbHexSend";
            this.chbHexSend.Size = new System.Drawing.Size(66, 16);
            this.chbHexSend.TabIndex = 5;
            this.chbHexSend.Text = "Hex发送";
            this.chbHexSend.UseVisualStyleBackColor = true;
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(5, 76);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(73, 20);
            this.cmbPortName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "接收区：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "发送区：";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(3, 61);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(41, 12);
            this.label_Port.TabIndex = 11;
            this.label_Port.Text = "串口：";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "56700",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(5, 126);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(73, 20);
            this.cmbBaud.TabIndex = 12;
            // 
            // label_Baud
            // 
            this.label_Baud.AutoSize = true;
            this.label_Baud.Location = new System.Drawing.Point(3, 111);
            this.label_Baud.Name = "label_Baud";
            this.label_Baud.Size = new System.Drawing.Size(53, 12);
            this.label_Baud.TabIndex = 13;
            this.label_Baud.Text = "波特率：";
            // 
            // lblSentCnt
            // 
            this.lblSentCnt.AutoSize = true;
            this.lblSentCnt.Location = new System.Drawing.Point(174, 503);
            this.lblSentCnt.Name = "lblSentCnt";
            this.lblSentCnt.Size = new System.Drawing.Size(83, 12);
            this.lblSentCnt.TabIndex = 15;
            this.lblSentCnt.Text = "Sent Count: 0";
            // 
            // lblRcvdCnt
            // 
            this.lblRcvdCnt.AutoSize = true;
            this.lblRcvdCnt.Location = new System.Drawing.Point(174, 372);
            this.lblRcvdCnt.Name = "lblRcvdCnt";
            this.lblRcvdCnt.Size = new System.Drawing.Size(83, 12);
            this.lblRcvdCnt.TabIndex = 16;
            this.lblRcvdCnt.Text = "Rcvd Count: 0";
            // 
            // chbReadLine
            // 
            this.chbReadLine.AutoSize = true;
            this.chbReadLine.Location = new System.Drawing.Point(511, 372);
            this.chbReadLine.Name = "chbReadLine";
            this.chbReadLine.Size = new System.Drawing.Size(72, 16);
            this.chbReadLine.TabIndex = 17;
            this.chbReadLine.Text = "分行接收";
            this.chbReadLine.UseVisualStyleBackColor = true;
            // 
            // cmbSelectData
            // 
            this.cmbSelectData.FormattingEnabled = true;
            this.cmbSelectData.Location = new System.Drawing.Point(245, 390);
            this.cmbSelectData.Name = "cmbSelectData";
            this.cmbSelectData.Size = new System.Drawing.Size(338, 20);
            this.cmbSelectData.TabIndex = 25;
            this.cmbSelectData.SelectedIndexChanged += new System.EventHandler(this.cmbSelectData_SelectedIndexChanged);
            this.cmbSelectData.Click += new System.EventHandler(this.cmbSelectData_Click);
            // 
            // rhtbConfigName
            // 
            this.rhtbConfigName.Location = new System.Drawing.Point(84, 90);
            this.rhtbConfigName.Name = "rhtbConfigName";
            this.rhtbConfigName.Size = new System.Drawing.Size(152, 30);
            this.rhtbConfigName.TabIndex = 26;
            this.rhtbConfigName.Text = "";
            // 
            // rhtbConfigValue
            // 
            this.rhtbConfigValue.Location = new System.Drawing.Point(84, 156);
            this.rhtbConfigValue.Name = "rhtbConfigValue";
            this.rhtbConfigValue.Size = new System.Drawing.Size(594, 77);
            this.rhtbConfigValue.TabIndex = 27;
            this.rhtbConfigValue.Text = "";
            // 
            // chkbStopShow
            // 
            this.chkbStopShow.AutoSize = true;
            this.chkbStopShow.Location = new System.Drawing.Point(618, 371);
            this.chkbStopShow.Name = "chkbStopShow";
            this.chkbStopShow.Size = new System.Drawing.Size(72, 16);
            this.chkbStopShow.TabIndex = 29;
            this.chkbStopShow.Text = "停止显示";
            this.chkbStopShow.UseVisualStyleBackColor = true;
            this.chkbStopShow.CheckedChanged += new System.EventHandler(this.chkbStopShow_CheckedChanged);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页ToolStripMenuItem,
            this.配置ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1026, 25);
            this.menuMain.TabIndex = 30;
            this.menuMain.Text = "menuStrip1";
            // 
            // 主页ToolStripMenuItem
            // 
            this.主页ToolStripMenuItem.Name = "主页ToolStripMenuItem";
            this.主页ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.主页ToolStripMenuItem.Text = "主页";
            this.主页ToolStripMenuItem.Click += new System.EventHandler(this.主页ToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            this.配置ToolStripMenuItem.Click += new System.EventHandler(this.配置ToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClearReceive);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.btnOpenSerial);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.lbSelectNode);
            this.pnlMain.Controls.Add(this.label_Baud);
            this.pnlMain.Controls.Add(this.cmbBaud);
            this.pnlMain.Controls.Add(this.chkbStopShow);
            this.pnlMain.Controls.Add(this.lblSentCnt);
            this.pnlMain.Controls.Add(this.cmbPortName);
            this.pnlMain.Controls.Add(this.lblRcvdCnt);
            this.pnlMain.Controls.Add(this.label_Port);
            this.pnlMain.Controls.Add(this.rhbSend);
            this.pnlMain.Controls.Add(this.chbHexRcvd);
            this.pnlMain.Controls.Add(this.cmbSelectData);
            this.pnlMain.Controls.Add(this.btnSend);
            this.pnlMain.Controls.Add(this.chbHexSend);
            this.pnlMain.Controls.Add(this.btnClearSend);
            this.pnlMain.Controls.Add(this.rhbRcvd);
            this.pnlMain.Controls.Add(this.chbReadLine);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(0, 27);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(693, 549);
            this.pnlMain.TabIndex = 32;
            // 
            // btnClearReceive
            // 
            this.btnClearReceive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearReceive.BackgroundImage")));
            this.btnClearReceive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearReceive.Location = new System.Drawing.Point(5, 12);
            this.btnClearReceive.Name = "btnClearReceive";
            this.btnClearReceive.Size = new System.Drawing.Size(76, 30);
            this.btnClearReceive.TabIndex = 6;
            this.btnClearReceive.Text = "清除接收区";
            this.btnClearReceive.UseVisualStyleBackColor = true;
            this.btnClearReceive.Click += new System.EventHandler(this.btnClearReceive_Click);
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenSerial.BackgroundImage = global::SerialCom.Properties.Resources.red;
            this.btnOpenSerial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenSerial.Location = new System.Drawing.Point(5, 206);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(75, 30);
            this.btnOpenSerial.TabIndex = 18;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SerialCom.Properties.Resources._83;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(5, 159);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 30);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "刷新串口";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbSelectNode
            // 
            this.lbSelectNode.AutoSize = true;
            this.lbSelectNode.Location = new System.Drawing.Point(171, 398);
            this.lbSelectNode.Name = "lbSelectNode";
            this.lbSelectNode.Size = new System.Drawing.Size(65, 12);
            this.lbSelectNode.TabIndex = 30;
            this.lbSelectNode.Text = "选择数据项";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(615, 485);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button_send_Click);
            // 
            // btnClearSend
            // 
            this.btnClearSend.BackgroundImage = global::SerialCom.Properties.Resources._83;
            this.btnClearSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearSend.Location = new System.Drawing.Point(3, 416);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(75, 30);
            this.btnClearSend.TabIndex = 10;
            this.btnClearSend.Text = "清除发送区";
            this.btnClearSend.UseVisualStyleBackColor = true;
            this.btnClearSend.Click += new System.EventHandler(this.btnClearSend_Click);
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.lbConfigValue);
            this.pnlConfig.Controls.Add(this.lbConfigName);
            this.pnlConfig.Controls.Add(this.lbConfigSelect);
            this.pnlConfig.Controls.Add(this.cmbConfigSelect);
            this.pnlConfig.Controls.Add(this.rhtbConfigValue);
            this.pnlConfig.Controls.Add(this.btnRemoveNode);
            this.pnlConfig.Controls.Add(this.rhtbConfigName);
            this.pnlConfig.Controls.Add(this.btnAddNode);
            this.pnlConfig.Location = new System.Drawing.Point(0, 30);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(681, 462);
            this.pnlConfig.TabIndex = 33;
            this.pnlConfig.Visible = false;
            // 
            // lbConfigValue
            // 
            this.lbConfigValue.AutoSize = true;
            this.lbConfigValue.Location = new System.Drawing.Point(82, 141);
            this.lbConfigValue.Name = "lbConfigValue";
            this.lbConfigValue.Size = new System.Drawing.Size(17, 12);
            this.lbConfigValue.TabIndex = 32;
            this.lbConfigValue.Text = "值";
            // 
            // lbConfigName
            // 
            this.lbConfigName.AutoSize = true;
            this.lbConfigName.Location = new System.Drawing.Point(82, 72);
            this.lbConfigName.Name = "lbConfigName";
            this.lbConfigName.Size = new System.Drawing.Size(65, 12);
            this.lbConfigName.TabIndex = 31;
            this.lbConfigName.Text = "数据项名称";
            // 
            // lbConfigSelect
            // 
            this.lbConfigSelect.AutoSize = true;
            this.lbConfigSelect.Location = new System.Drawing.Point(82, 8);
            this.lbConfigSelect.Name = "lbConfigSelect";
            this.lbConfigSelect.Size = new System.Drawing.Size(65, 12);
            this.lbConfigSelect.TabIndex = 30;
            this.lbConfigSelect.Text = "选择数据项";
            // 
            // cmbConfigSelect
            // 
            this.cmbConfigSelect.FormattingEnabled = true;
            this.cmbConfigSelect.Location = new System.Drawing.Point(84, 23);
            this.cmbConfigSelect.Name = "cmbConfigSelect";
            this.cmbConfigSelect.Size = new System.Drawing.Size(152, 20);
            this.cmbConfigSelect.TabIndex = 29;
            this.cmbConfigSelect.SelectedIndexChanged += new System.EventHandler(this.cmbConfigSelect_SelectedIndexChanged);
            this.cmbConfigSelect.Click += new System.EventHandler(this.cmbConfigSelect_Click);
            // 
            // btnRemoveNode
            // 
            this.btnRemoveNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveNode.BackgroundImage")));
            this.btnRemoveNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveNode.Location = new System.Drawing.Point(3, 25);
            this.btnRemoveNode.Name = "btnRemoveNode";
            this.btnRemoveNode.Size = new System.Drawing.Size(75, 30);
            this.btnRemoveNode.TabIndex = 28;
            this.btnRemoveNode.Text = "删除数据项";
            this.btnRemoveNode.UseVisualStyleBackColor = true;
            this.btnRemoveNode.Click += new System.EventHandler(this.btnRemoveNode_Click);
            // 
            // btnAddNode
            // 
            this.btnAddNode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNode.BackgroundImage")));
            this.btnAddNode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNode.Location = new System.Drawing.Point(3, 90);
            this.btnAddNode.Name = "btnAddNode";
            this.btnAddNode.Size = new System.Drawing.Size(75, 30);
            this.btnAddNode.TabIndex = 24;
            this.btnAddNode.Text = "添加数据项";
            this.btnAddNode.UseVisualStyleBackColor = true;
            this.btnAddNode.Click += new System.EventHandler(this.btnAddNode_Click);
            // 
            // cntmenuRightButton
            // 
            this.cntmenuRightButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RightButtonItemCopy,
            this.RightButtonItemAllSelect});
            this.cntmenuRightButton.Name = "cntmenuRightButton";
            this.cntmenuRightButton.Size = new System.Drawing.Size(101, 48);
            this.cntmenuRightButton.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cntmenuRightButton_ItemClicked);
            // 
            // RightButtonItemCopy
            // 
            this.RightButtonItemCopy.Name = "RightButtonItemCopy";
            this.RightButtonItemCopy.Size = new System.Drawing.Size(100, 22);
            this.RightButtonItemCopy.Text = "复制";
            // 
            // RightButtonItemAllSelect
            // 
            this.RightButtonItemAllSelect.Name = "RightButtonItemAllSelect";
            this.RightButtonItemAllSelect.Size = new System.Drawing.Size(100, 22);
            this.RightButtonItemAllSelect.Text = "全选";
            // 
            // tbctrl
            // 
            this.tbctrl.Controls.Add(this.tabPage1);
            this.tbctrl.Controls.Add(this.tabPage2);
            this.tbctrl.Location = new System.Drawing.Point(699, 30);
            this.tbctrl.Name = "tbctrl";
            this.tbctrl.SelectedIndex = 0;
            this.tbctrl.Size = new System.Drawing.Size(315, 363);
            this.tbctrl.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(307, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlData
            // 
            this.pnlData.Location = new System.Drawing.Point(7, 7);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(294, 324);
            this.pnlData.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(307, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 545);
            this.Controls.Add(this.tbctrl);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlConfig);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Debug Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.cntmenuRightButton.ResumeLayout(false);
            this.tbctrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rhbRcvd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rhbSend;
        private System.Windows.Forms.CheckBox chbHexRcvd;
        private System.Windows.Forms.CheckBox chbHexSend;
        private System.Windows.Forms.Button btnClearReceive;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Label label_Baud;
        private System.Windows.Forms.Label lblSentCnt;
        private System.Windows.Forms.Label lblRcvdCnt;
        private System.Windows.Forms.CheckBox chbReadLine;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddNode;
        private System.Windows.Forms.ComboBox cmbSelectData;
        private System.Windows.Forms.RichTextBox rhtbConfigName;
        private System.Windows.Forms.RichTextBox rhtbConfigValue;
        private System.Windows.Forms.Button btnRemoveNode;
        private System.Windows.Forms.CheckBox chkbStopShow;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem 主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.ComboBox cmbConfigSelect;
        private System.Windows.Forms.Label lbSelectNode;
        private System.Windows.Forms.Label lbConfigValue;
        private System.Windows.Forms.Label lbConfigName;
        private System.Windows.Forms.Label lbConfigSelect;
        private System.Windows.Forms.ContextMenuStrip cntmenuRightButton;
        private System.Windows.Forms.ToolStripMenuItem RightButtonItemCopy;
        private System.Windows.Forms.ToolStripMenuItem RightButtonItemAllSelect;
        private System.Windows.Forms.TabControl tbctrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

