using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_LAB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Cost { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            double coffeeCost1 = Convert.ToDouble(label13.Text) * (double)numericUpDown1.Value;
            double coffeeCost2 = Convert.ToDouble(label12.Text) * (double)numericUpDown2.Value;
            double coffeeCost3 = Convert.ToDouble(label11.Text) * (double)numericUpDown3.Value;

            // Вартість тістечок (ціна за порцію * кількість порцій)
            double cakeCost1 = Convert.ToDouble(label8.Text) * (double)numericUpDown4.Value;
            double cakeCost2 = Convert.ToDouble(label9.Text) * (double)numericUpDown5.Value;
            double cakeCost3 = Convert.ToDouble(label10.Text) * (double)numericUpDown6.Value;

            // Обчислення загальної вартості
            Cost = coffeeCost1 + coffeeCost2 + coffeeCost3 + cakeCost1 + cakeCost2 + cakeCost3;

            // Показ результату
            MessageBox.Show("Загальна вартість замовлення: " + Cost.ToString("0.00") + " грн.", "Замовлення підтверджено");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}