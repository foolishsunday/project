using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace learn_com
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        public void Form2IsVisible(bool enable)
        {
            if (enable == true)
            {
                this.Visible = true;
            }
            else
                this.Visible = false;
        }

        private void button_Extent_Click(object sender, EventArgs e)
        {
            Form2IsVisible(false);
        }
    }
}
