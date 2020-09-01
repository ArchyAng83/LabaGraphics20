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
    public partial class MainForm : Form
    {
        public double Xnach { get; private set; }
        public double Xkon { get; private set; }
        public double Step { get; private set; }
        public double ConstA { get; private set; }
        public double ConstB { get; private set; }
        public int Count { get; private set; }
        public bool IsSelectFuncOne { get; private set; }
        public bool IsSelectFuncTwo { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            calculateButton.DialogResult = DialogResult.OK;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Xnach = double.Parse(xStartTextBox.Text);
                Xkon = double.Parse(xFinishTextBox.Text);
                Step = double.Parse(stepComboBox.Text);
                ConstA = double.Parse(aConstTextBox.Text);
                ConstB = double.Parse(bConstTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод данных");
                return;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Не выбрана функция");
                return;
            }
            if (Step <= 0)
            {
                MessageBox.Show("Шаг не может быть отрицательным или нулевым");
                return;
            }
            if (Xnach > Xkon)
            {
                MessageBox.Show("Неверный выбор границ графика");
                return;
            }

            if (radioButton1.Checked)
            {
                IsSelectFuncOne = true;
            }
            if (radioButton2.Checked)
            {
                IsSelectFuncTwo = true;
            }

            Count = (int)((Math.Abs(Xkon - Xnach)) / Step) + 1;

            OutputForm outputForm = new OutputForm
            {
                Xnach = Xnach,
                Xkon = Xkon,
                Step = Step,
                ConstA = ConstA,
                ConstB = ConstB,
                Count = Count,
                IsSelectFuncOne = IsSelectFuncOne,
                IsSelectFuncTwo = IsSelectFuncTwo
            };
            outputForm.ShowDialog();
        }
    }
}
