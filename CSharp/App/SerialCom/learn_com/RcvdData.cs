using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace learn_com
{
    public partial class RcvdData : UserControl
    {
        public RcvdData()
        {
            InitializeComponent();
        }

        //private frmMain _frm;
        //public frmMain Frm
        //{
        //    get { return _frm; }
        //    set { _frm = value; }
        //}

        //private void ReceiveData()
        //{
            
        //}

        private void RcvdData_Load(object sender, EventArgs e)
        {
   
        }
        //private void UpdateUi_Event()
        //{ 
            
        //}
        private byte[] _GetData;
        public byte[] GetData
        {
            get { return _GetData; }
            set { _GetData = value; }
        }
        public static byte[] sliceBytes2Array(byte[] ab, int s, int t)
        {
            byte[] newA = ab.Skip(s).Take(t).ToArray();
            return newA;
        }
        public static byte[] receivedcmd50 = { 0x35, 0x30 };
        public void LoadData()
        {
            byte[] cmd = sliceBytes2Array(_GetData, 7, 2);
            if (cmd.SequenceEqual(receivedcmd50))
            {
                byte[] id = sliceBytes2Array(_GetData, 9, 8);
                byte[] msg_data = sliceBytes2Array(_GetData, 17, 16);
                string msgid = Encoding.GetEncoding("ascii").GetString(id);
                string msgdata = Encoding.GetEncoding("ascii").GetString(msg_data);
                FillDataGrid(msgid, msgdata, "接收");
            }
        }
        public void FillDataGrid(string msgid, string msgdata, string dir)
        {
            //Application.DoEvents();
            int index =dgvRcvData.Rows.Add(1);
            dgvRcvData.Rows[index].Cells[1].Value = dir;
            dgvRcvData.Rows[index].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff");
            dgvRcvData.Rows[index].Cells[3].Value = msgid;
            dgvRcvData.Rows[index].Cells[4].Value = msgdata.Count() / 2;
        }
        public void Clear()
        {
            dgvRcvData.Rows.Clear();
        }
    }
}
