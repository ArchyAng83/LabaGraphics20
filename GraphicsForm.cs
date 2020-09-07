using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaGraphics20
{
    public partial class GraphicsForm : Form
    {
        private double[] x;
        private double[] y1;
        private double[] y2;

        public double Xnach { get; set; }
        public double Xkon { get; set; }
        public double Step { get; set; }
        public double ConstA { get; set; }
        public double ConstB { get; set; }
        public int Count { get; set; }
        public bool IsSelectFuncOne { get; set; }
        public bool IsSelectFuncTwo { get; set; }

        public GraphicsForm()
        {
            InitializeComponent();
        }

        private void Calculation()
        {
            
            x = new double[Count];
            y1 = new double[Count];
            y2 = new double[Count];

            for (int i = 0; i < Count; i++)
            {
                x[i] = Xnach + Step * i;
                y1[i] = 0.1 * ConstA * Math.Pow(x[i], 3) * Math.Tan(ConstA - ConstB * x[i]);
                y2[i] = 9.0 * (x[i] + 15 * Math.Sqrt(Math.Pow(x[i], 3) + Math.Pow(ConstB, 3)));
            }
        }

        private void CreateChart()
        {
            chart1.SetBounds(10, 10, Width - 20, Height - 20);
            chart1.ChartAreas[0].AxisX.Minimum = Xnach;
            chart1.ChartAreas[0].AxisX.Maximum = Xkon;

            chart1.Series[0].LegendText = "0.1 * a * x^3 * tg(a - b * x)";
            chart1.Series[1].LegendText = "9 * (x + 15 * sqrt(x^3 + b^3))";
        }

        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            CreateChart();
            Calculation();
            if (IsSelectFuncOne)
            {

                chart1.Series[0].Points.DataBindXY(x, y1);
            }
            if (IsSelectFuncTwo)
            {
                chart1.Series[1].Points.DataBindXY(x, y2);
                //chart1.Series.Clear();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            chart1.Series[0].Points.Clear();
            //chart1.Series[1].Points.Clear();
        }
    }
}
