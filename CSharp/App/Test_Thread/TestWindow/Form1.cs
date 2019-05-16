using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //button1.Enabled = false;

            ////实例化一张表并定义表结构
            //DataTable dt = new DataTable("IPtoHost");
            //dt.Columns.Add("IPaddress");
            //dt.Columns.Add("HostName");

            ////该过程为将数据写入表中的第一行
            //DataRow dr1 = dt.NewRow();
            //dr1["IPaddress"] = "172.16.124.254";
            //dr1["HostName"] = "MS-Computer";
            //dt.Rows.Add(dr1);

            ////该过程为将数据插入表中的第二行
            //DataRow dr2 = dt.NewRow();
            //dr2["IPaddress"] = "172.16.124.255";
            //dr2["HostName"] = "Rout";
            //dt.Rows.Add(dr2);

            //CSVHelper.SaveCSV(dt,@"F:\Work\Project\Repository\project\CSharp\App\Test\test.csv");

            int indexTest = dataGridViewTest.Rows.Add(1);

            dataGridViewTest.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();

            //dataGridViewTest.Rows[indexTest].Cells[1].Value = indexTest+1;
            //dataGridViewTest.Rows[indexTest].Cells[2].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss fff");
            //dataGridViewTest.Rows[indexTest].Cells[3].Value = "1";
            //dataGridViewTest.Rows[indexTest].Cells[4].Value = 2;
            dataGridViewTest.FirstDisplayedScrollingRowIndex = dataGridViewTest.RowCount - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewTest.Columns.Add("nameA", "textA");
            //dataGridViewTest.Columns.Add("nameB", "textB");
            //dataGridViewTest.Columns.Add("nameC", "textC");
            //dataGridViewTest.Columns.Add("nameD", "textD");
            //dataGridViewTest.Columns.Add("nameE", "textE");
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
        frm fm;
        private void Button6_Click(object sender, EventArgs e)
        {
            Type type = Type.GetType("TestWindow.frm");
            object obj = Activator.CreateInstance(type);
            fm = (TestWindow.frm)obj;
            panel1.Controls.Add((Control)obj);
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }
    }
}
