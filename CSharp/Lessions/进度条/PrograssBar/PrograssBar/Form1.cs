using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograssBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            //bgw.WorkerReportsProgress = true;           //是否可报告进度更新
            //bgw.WorkerSupportsCancellation = true;      //是否支持异步取消机制
            //bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            //bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProcessChanged);
            //bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_WorkerCompleted);
            
        }

        private delegate void DeleWork(string cnt);
        private event DeleWork EveHandler;
        RoundPanel rp;
        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            RoundPanel rpl = new RoundPanel();
            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Color FColor = Color.DarkGray;

            Color TColor = Color.DarkSlateBlue;

            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.ForwardDiagonal);

            g.FillRectangle(b, this.ClientRectangle);

        }

        //private void DoWorkEventHandler(object sender, DoWorkEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
