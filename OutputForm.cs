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
    public partial class OutputForm : Form
    {
        public double Xnach { get;  set; }
        public double Xkon { get;  set; }
        public double Step { get;  set; }
        public double ConstA { get;  set; }
        public double ConstB { get;  set; }
        public int Count { get;  set; }
        public bool IsSelectFuncOne { get;  set; }
        public bool IsSelectFuncTwo { get;  set; }
        //private double xnach;
        //private double xkon;
        //private double step;
        //private double constA;
        //private double constB;
        //private int count;
        //private bool isSelectFuncOne;
        //private bool isSelectFuncTwo;



        public OutputForm()
        {
            InitializeComponent();
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
           
            //    Xnach = mainForm.Xnach;
            //    Xkon = mainForm.Xkon;
            //    Step = mainForm.Step;
            //    ConstA = mainForm.ConstA;
            //    ConstB = mainForm.ConstB;
            //    Count = mainForm.Count;
            //    IsSelectFuncOne = mainForm.IsSelectFuncOne;
            //    IsSelectFuncTwo = mainForm.IsSelectFuncTwo;
            

            int indexCount = 0;
            double[] xItemsList = new double[Count];
            double[] yItemsList = new double[Count];

            if (IsSelectFuncOne)
            {
                for (double i = Xnach; i <= Xkon; i += Step)
                {
                    yItemsList[indexCount] = 0.1 * ConstA * Math.Pow(i, 3) * Math.Tan(ConstA - ConstB * i);
                    xItemsList[indexCount] = i;
                    indexCount++;
                }
            }
            if (IsSelectFuncTwo)
            {
                for (double i = Xnach; i <= Xkon; i += Step)
                {
                    yItemsList[indexCount] = 9.0 * (i + 15 * Math.Sqrt(Math.Pow(i, 3) + Math.Pow(ConstB, 3)));
                    xItemsList[indexCount] = i;
                    indexCount++;
                }
            }

            for (int i = 0; i < Count; i++)
            {
                listBox1.Items.Add(xItemsList[i].ToString() + "\t" + yItemsList[i].ToString());
            }
        }

        private void graphicBuildButton_Click(object sender, EventArgs e)
        {

        }
    }
}
