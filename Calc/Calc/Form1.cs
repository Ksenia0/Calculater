using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(inputNomberOne.Text);
            double second = Convert.ToDouble(inputNomberTwo.Text);
            double result = first/second;
            res.Text = result.ToString();



        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(inputNomberOne.Text);
            double second = Convert.ToDouble(inputNomberTwo.Text);
            double result = first*second;
            res.Text = result.ToString();

        }

        private void addition_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(inputNomberOne.Text);
            double second = Convert.ToDouble(inputNomberTwo.Text);
            double result = first + second;
            res.Text = result.ToString();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            double first = Convert.ToDouble(inputNomberOne.Text);
            double second = Convert.ToDouble(inputNomberTwo.Text);
            double result = first - second;
            res.Text = result.ToString();
        }
    }
}