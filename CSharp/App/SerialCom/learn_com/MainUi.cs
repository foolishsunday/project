using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.IO.Ports;
using System.Threading;
using learn_com;
namespace learn_com
{
    
    public partial class frmMain : Form
    {
        public delegate void View(StringBuilder str);
        private int _txCount;
        private int _rxCount;
        public SerialPort _Com = new SerialPort();
        //public event SerialDataReceivedEventHandler ComDataHandle;
        
        public frmMain()
        {
            InitializeComponent();
        }

        public delegate void MyDelegate();
        public event MyDelegate myEvent;
        RcvdData cpn;
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitialSerialPort();
            this.cmbSelectData.SelectedIndexChanged += new EventHandler(cmbSelectData_SelectedIndexChanged);
            this.cmbSelectData.Click += new EventHandler(cmbSelectData_Click);
            this.chkbStopShow.CheckedChanged += new EventHandler(chkbStopShow_CheckedChanged);


            this.cmbConfigSelect.SelectedIndexChanged += new EventHandler(cmbConfigSelect_SelectedIndexChanged);
            _DataMessage.LoadData("XmlFile.xml");//载入数据方法需放在此处，而不是放在添加或删除节点方法中

            Type type = Type.GetType("learn_com.RcvdData");
            object obj = Activator.CreateInstance(type);
            cpn = (RcvdData)obj;
            //cpn.Frm = frmMain;
            pnlData.Controls.Add((Control)obj);

            chbHexRcvd.Checked = true;
            chbHexSend.Checked = true;
            
            
        }
        private void TestDele()
        {
            myEvent();
        }
        private void InitialSerialPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);
                cmbPortName.Items.Clear();
                cmbPortName.Items.AddRange(ports);
                cmbPortName.SelectedIndex = cmbPortName.Items.Count > 0 ? 0 : -1;

                cmbBaud.SelectedIndex = cmbBaud.Items.IndexOf("115200");

                _Com.BaudRate = 115200;
                _Com.Parity = Parity.None;
                _Com.StopBits = StopBits.One;

                _Com.DataReceived += new SerialDataReceivedEventHandler(ComReceivedDataHandle);
                this.btnOpenSerial.BackColor = SystemColors.Highlight;
                
                

            }

            catch
            {
                MessageBox.Show("Initial error");
            }
        }
        
        

        private void button_send_Click(object sender, EventArgs e)
        {
            if (_Com.IsOpen == true) 
            {
                this.SendString(rhbSend.Text);
                this.lblSentCnt.Text = "TX count: " + _txCount.ToString();
            }
            else this.btnOpenSerial.BackColor = SystemColors.HotTrack;
                

        }
        private void SendString(string str)
        {
            try
            {
                if (chbHexSend.Checked == true)
                {
                    byte[] sendBuf = null;
                    sendBuf = Function.HexStringToBytes(str);
                    _Com.Write(sendBuf, 0, sendBuf.Length);
                    _txCount += sendBuf.Length;
                }
                else
                {
                    _Com.Write(str);
                    _txCount += str.Length;
                } 
                        

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ViewReceivedData(StringBuilder str)
        {
            try
            {
                if (chkbStopShow.Checked == false)
                {
                    textNewLineTimer.Stop();
                    if (_isNewLine == true && chbReadLine.Checked == true)
                    {
                        if (this.rhbRcvd.Text != "")
                            this.rhbRcvd.Text += "\r";

                        _isNewLine = false;
                    }
                    this.rhbRcvd.Text += str;
                    InitialTimer();
                    TimerStart();
                }
                
            }
            catch
            {
                MessageBox.Show("Show error");
            }
        }

        //Levi
        public void ComReceivedDataHandle(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                int cnt = _Com.BytesToRead;
                byte[] buffer = new byte[cnt];
                _Com.Read(buffer, 0, cnt);

                if (chkbStopShow.Checked == false)
                {

                    _rxCount += cnt;
                    StringBuilder content = new StringBuilder();

                    if (chbHexRcvd.Checked == true)
                    {
                        foreach (byte element in buffer)
                        {
                            content.Append(element.ToString("X2") + " ");
                        }
                    }
                    else
                        content = new StringBuilder(System.Text.Encoding.Default.GetString(buffer));

                    //数据处理
                    List<byte> bufList = new List<byte>(4096);
                    SerialPort sp = _Com;
                    if (sp.IsOpen)
                    {
                        byte[] buf = buffer;
                        bufList.AddRange(buf);
                    }
                    //2.完整性判断
                    while (bufList.Count >= 12)
                    {
                        //2.1 查找数据头
                        //if (bufList[0] == 0x7E && bufList[1] == 0x30 && bufList[2] == 0x30 && bufList[3] == 0x46 && bufList[4] == 0x46 
                        //    && bufList[5] == 0x34 && bufList[6] == 0x33 && bufList[7] == 0x35 && bufList[8] == 0x30)
                        if (bufList[0] == 0x7E && bufList[1] == 0x30 && bufList[2] == 0x30 && bufList[3] == 0x46 && bufList[4] == 0x46
                            && bufList[5] == 0x30 && bufList[6] == 0x33 && bufList[7] == 0x35 && bufList[8] == 0x30)
                        {
                            int len = 20;//幀长
                            if (bufList.Count < len) //数据区尚未接收完整
                            {
                                break;
                            }
                            byte[] ReceiveBytes = new byte[len];
                            bufList.CopyTo(0, ReceiveBytes, 0, len);
                            bufList.RemoveRange(0, len);    //移除一定范围内的元素
                            //Action委托匿名方法
                            Action async_dgv = delegate()
                            {
                                cpn.GetData = ReceiveBytes;
                                cpn.LoadData();
                            };
                            this.Invoke(async_dgv);

                        }
                        else //帧头不正确时，记得清除
                        {
                            bufList.RemoveAt(0);
                        }
                    }

                    //用委托
                    View async = new View(ViewReceivedData);
                    this.Invoke(async, content);

                    //Action委托匿名方法
                    Action async_rxCount = delegate()
                    {
                        this.lblRcvdCnt.Text = "Rcvd Count: " + _rxCount.ToString();
                        //this.rhtbRx.Focus();
                        this.rhbRcvd.Select(this.rhbRcvd.TextLength, 0);
                    };
                    this.Invoke(async_rxCount);
                }

                
                
                
               
                /*Action async = delegate()
                {         
        
                    this.richTextBox_Receive.Text += content;
                };*/
                //this.Invoke(async);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //private void HandleGridData(byte[] data)
        //{
        //    byte[] cmd = sliceBytes2Array(data, 7, 2);
        //    if (cmd.SequenceEqual(receivedcmd50))
        //    {
        //        byte[] id = sliceBytes2Array(data, 9, 8);
        //        byte[] msg_data = sliceBytes2Array(data, 17, 16);
        //        string msgid = Encoding.GetEncoding("ascii").GetString(id);
        //        string msgdata = Encoding.GetEncoding("ascii").GetString(msg_data);
        //        Application.DoEvents();

        //        //add by Levi for thread
        //        FillDataGrid(msgid, msgdata, "接收");
        //        //if (dgvRcvData.InvokeRequired.Equals(true))
        //        //{
        //        //    this.Invoke(new Action(() =>
        //        //    {
        //        //        //FillDataGrid(msgid, msgdata, "接收");
        //        //    }));
        //        //}
        //        //else
        //        //{
        //        //    //FillDataGrid(msgid, msgdata, "接收");
        //        //}

        //        //refreshTable = new Thread(delegate () { FillDataGrid(msgid, msgdata, "接收"); });
        //        //refreshTable.Start();
        //    }
        //}
        //public static byte[] sliceBytes2Array(byte[] ab, int s, int t)
        //{
        //    byte[] newA = ab.Skip(s).Take(t).ToArray();
        //    return newA;
        //}
        //public static byte[] receivedcmd50 = { 0x35, 0x30 };

        //public void FillDataGrid(string msgid, string msgdata, string dir)
        //{
        //    //Application.DoEvents();
        //    //if (cpn != null)
        //    //{ 
        //    //    int index = 
        //    //}
        //}

        private void btnClearReceive_Click(object sender, EventArgs e)
        {
            rhbRcvd.Text = "";
            _rxCount = 0;
            this.lblRcvdCnt.Text = "Rcvd Count: " + _rxCount.ToString();
            cpn.Clear();
        }

        DataMessage _DataMessage = new DataMessage();


        private void cmbSelectData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSelectData.SelectedItem == null) return;
            try
            {
                string str = _DataMessage.GetValue(this.cmbSelectData.SelectedItem.ToString());
                this.rhbSend.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelectData_Click(object sender, EventArgs e)
        {
            try
            {
                this.cmbSelectData.Items.Clear();
                foreach (var item in _DataMessage.DataModules)
                {
                    this.cmbSelectData.Items.Add(item.Name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveNode_Click(object sender, EventArgs e)
        {
            try
            {
                //_DataMessage.LoadData("XmlFile.xml");
                string name = this.cmbConfigSelect.SelectedItem.ToString();
                string value = _DataMessage.GetValue(name);

                if (name != null)
                {
                    DataModule module = new DataModule(name, value);
                    if(this._DataMessage.RemoveNode("XmlFile.xml", module)) MessageBox.Show("删除成功！");
                    else MessageBox.Show("删除失败！");
                }
                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAddNode_Click(object sender, EventArgs e)
        {
            try
            {
                DataModule module = new DataModule(rhtbConfigName.Text,rhtbConfigValue.Text);
                _DataMessage.AddDataToXml("XmlFile.xml", module);
                MessageBox.Show("添加成功");
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void chkbStopShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbStopShow.Checked == true)
            {
                rhbRcvd.BackColor = Color.DarkGray;
            }
            else
            {
                rhbRcvd.BackColor = SystemColors.Window;
            }
        }
        Form configForm = new Form();
        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = true;
            pnlConfig.Visible = false;
        }

        private void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMain.Visible = false;
            pnlConfig.Visible = true;
        }

        private void cmbConfigSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbConfigSelect.SelectedItem == null) return;
            try
            {
                string str = _DataMessage.GetValue(this.cmbConfigSelect.SelectedItem.ToString());
                this.rhtbConfigName.Text = this.cmbConfigSelect.SelectedItem.ToString();
                this.rhtbConfigValue.Text = str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbConfigSelect_Click(object sender, EventArgs e)
        {
            try
            {
                this.cmbConfigSelect.Items.Clear();
                foreach (var item in _DataMessage.DataModules)
                {
                    this.cmbConfigSelect.Items.Add(item.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rhtbRx_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                cntmenuRightButton.Show(Control.MousePosition);
            else
                cntmenuRightButton.Hide();
        }

        private void cntmenuRightButton_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            { 
                case "复制":
                    rhbRcvd.Copy();
                    break;
                case "全选":
                    rhbRcvd.SelectAll();
                    break;
                default:break;
            }
        }

        private void btnClearSend_Click(object sender, EventArgs e)
        {
            rhbSend.Text = "";
            _txCount = 0;
            this.lblSentCnt.Text = "Sent Count: " + _txCount.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitialSerialPort();
        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            try
            {

                if (_Com.IsOpen == false)
                {
                    InitialTimer();
                    _Com.PortName = cmbPortName.Text;
                    _Com.BaudRate = int.Parse(cmbBaud.Text);
                    this.btnOpenSerial.BackColor = SystemColors.ButtonShadow;
                    _Com.Open();
                    btnOpenSerial.Text = "关闭串口";
                    this.btnOpenSerial.BackgroundImage = global::SerialCom.Properties.Resources._83;

                }
                else
                {
                    _Com.Close();
                    btnOpenSerial.Text = "打开串口";
                    this.btnOpenSerial.BackgroundImage = global::SerialCom.Properties.Resources.red;
                }
            }
            catch
            {
                MessageBox.Show("Open error");
            }
        }



     
    }

}
