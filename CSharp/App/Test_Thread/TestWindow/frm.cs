using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindow
{
    public partial class frm : UserControl
    {
        public frm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();

            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();

            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            indexTest = dataGridView1.Rows.Add(1);
            dataGridView1.Rows[indexTest].Cells[0].Value = (indexTest + 1).ToString();
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("nameA", "textA");
        }
    }
}
