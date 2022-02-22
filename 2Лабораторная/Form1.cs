using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Лабораторная
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.1;

        Random random = new Random();

        int day = 1;

        double Euro, Dollar;
        private void btStart_Click(object sender, EventArgs e)
        {
            Euro = (double)edEuro.Value;
            Dollar = (double)edDollar.Value;

            timer1.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Euro = Euro * (1 + k * (random.NextDouble() - 0.5));
            Dollar = Dollar * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(day, Euro);
            chart1.Series[1].Points.AddXY(day, Dollar);
            day++;
        }
    }
}
