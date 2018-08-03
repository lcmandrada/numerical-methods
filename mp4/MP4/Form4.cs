using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace MP4
{
    public partial class frmTrapezoidal : Form
    {
        // globally initialize variables
        double[] xi;
        double[] fxi;
        double[] trapRule;
        double LLimit, ULimit;
        double h;
        double integral;
        int n;
        double sum;

        ExpressionParser myParse;
        Hashtable myHash;

        public frmTrapezoidal()
        {
            InitializeComponent();
        }

        public void SetData()
        {
            // write the intervals
            for (int i = 0; i < (n + 1); i++)
            {
                xi[i] = Math.Round(LLimit, 5);
                LLimit += h;
            }
        }

        public void useTrapRule()
        {
            // perform trapezoidal rule
            sum = 0;

            for (int i = 0; i < (n + 1); i++)
            {
                if (checkFirstLast(i))
                    trapRule[i] = Math.Round(fxi[i], 5);
                else if (!checkFirstLast(i))
                    trapRule[i] = Math.Round((2 * fxi[i]), 5);

                sum += trapRule[i];
            }

            integral = (h / 2) * sum;
            txtBoxTrapezoidal_i.Text = Math.Round(integral, 5).ToString("0.00000");

            // display result
            MessageBox.Show("Yay! The integral approximation of the function within the given limits is " + txtBoxTrapezoidal_i.Text + ".\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        public bool checkFirstLast(int i)
        {
            // check if fx is first or last
            if (i == 0 || i == n)
                return true;
            else
                return false;
        }

        private void btnTrapezoidal_solve_Click(object sender, EventArgs e)
        {
            // handle errors
            try
            {
                n = int.Parse(txtBoxTrapezoidal_n.Text);
                LLimit = Double.Parse(txtBoxTrapezoidal_a.Text);
                ULimit = Double.Parse(txtBoxTrapezoidal_b.Text);
            }
            catch (FormatException)
            {
                txtBoxTrapezoidal_i.Text = "I";
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            if(n <= 0)
            {
                txtBoxTrapezoidal_i.Text = "I";
                MessageBox.Show("Hi. I'm sorry but n cannot be zero or below. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            // reinitialize variables
            myParse = new ExpressionParser();
            myHash = new Hashtable();

            xi = new double[n + 1];
            fxi = new double[n + 1];
            trapRule = new double[n + 1];

            h = (ULimit - LLimit) / n;

            SetData();

            // equation parse
            for (int i = 0; i < (n + 1); i++)
            {
                // handle errors
                try
                {
                    myHash.Clear();
                    myHash.Add("x", xi[i].ToString());
                    fxi[i] = Math.Round(myParse.Parse(txtBoxTrapezoidal_eq.Text, myHash), 5);

                    // check for Nan or inf
                    if (double.IsNaN(fxi[i]) || double.IsInfinity(fxi[i]))
                    {
                        txtBoxTrapezoidal_i.Text = "I";
                        MessageBox.Show("Hi. I'm sorry but with the given function and limits,\nI can tell you that the result will be NaN and I can't handle NaN.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                        return;
                    }
                }

                catch
                {
                    txtBoxTrapezoidal_i.Text = "I";
                    MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                    return;
                }
            }

            useTrapRule();
        }

        private void btnTrapezoidal_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxTrapezoidal_eq.Text = "EQUATION";
            txtBoxTrapezoidal_n.Text = "n";
            txtBoxTrapezoidal_a.Text = "a";
            txtBoxTrapezoidal_b.Text = "b";
            txtBoxTrapezoidal_i.Text = "I";
        }
    }
}
