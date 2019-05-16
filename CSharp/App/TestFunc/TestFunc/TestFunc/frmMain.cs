using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestFunc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Array.Skip(1).Take(2).ToArray() 从第三个字开始取2个
            byte[] data = new byte[] { 0x7E ,0x30 ,0x30 ,0x46 ,0x46 ,0x30 ,0x33 ,0x35 ,0x30 ,0x30 ,0x30 ,
                                      0x30 ,0x30 ,0x30 ,0x30 ,0x30 ,0x31 ,0x0D ,0x34 ,0x30};
            byte[] cmd = Function.sliceBytes2Array(data,7,2);   //结果为53 48（ascii码），对应Hex为0x35，0x30， 控制字符为5 0
            byte[] id = Function.sliceBytes2Array(data, 9, 8);
            byte[] msg_data = Function.sliceBytes2Array(data, 17, 16);
            string msgid = Encoding.GetEncoding("ascii").GetString(id);
            string msgdata = Encoding.GetEncoding("ascii").GetString(msg_data);
            lblAll.Text = "msgid:" + msgid + "; " + "msgdata" + "; " + msgdata;
            //char[] cha = Encoding.ASCII.GetChars(cmd); //byte 转化为 char

            ////char转化为string
            //System.Text.StringBuilder sb = new StringBuilder();
            //sb.Append(cha);
            //string str = sb.ToString();
            //lblShow.Text = str;

            //byte[]转化为string
            string s = Encoding.Default.GetString(data);
            lblString.Text = s;

            List<byte[]> b = new List<byte[]> { new byte[] { 0x30, 0x31 }, new byte[] { 0x82, 0x83 }, new byte[] { 0x34, 0x35 }, new byte[] { 0x36, 0x37 } };
            b.RemoveRange(0,1);
            List<byte[]> c = b;
        }
    }
}
