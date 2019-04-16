using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bubble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            int[] array = new int[10]{6,99,7,23,14,55,66,88,32,10};
            int temp = 0;
            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]<array[i])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                label1.Text += array[i].ToString() + ",";
            }

        }
    }
}
