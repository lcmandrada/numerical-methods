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

namespace MP2
{
    public partial class frmSecant : Form
    {
        // globally initialize variables
        int count;
        double error = 0.00001;
        double x0, x1, x2 = 9999;
        double fx0, fx1, fx2, temp;
        int test;

        ExpressionParser myParse;
        Hashtable myHash;

        public frmSecant()
        {
            InitializeComponent();
        }

        public int check()
        {
            // solve for fx0 and fx1
            fx0 = fx1 = fx2 = 0;

            // handle errors
            try
            {
                myHash.Clear();
                myHash.Add("x", x0.ToString());
                fx0 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                myHash.Clear();
                myHash.Add("x", x1.ToString());
                fx1 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                // check for Nan or inf
                if (double.IsNaN(fx0) || double.IsNaN(fx1) || double.IsInfinity(fx0) || double.IsInfinity(fx0))
                {
                    MessageBox.Show("Hi. I'm sorry but with the given function and initial values,\nI can tell you that the result will be NaN and I can't handle NaN.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                    return 1;
                }

                // check if fx0 and fx1 are the same
                if (fx0 == fx1)
                {
                    MessageBox.Show("Hi. I'm sorry but the f(x)'s of the initial values can't be the same.\nIf so, we'll be diving by zero and ending the world.\nI want you try again, okay?", "ERR", MessageBoxButtons.OK);
                    return 1;
                }
            }

            catch
            {
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return 1;
            }

            return 0;
        }

        private void btnSecant_solve_Click(object sender, EventArgs e)
        {
            // iteration counter
            count = 0;

            x2 = 9999;

            // handle format errors
            try
            {
                myParse = new ExpressionParser();
                myHash = new Hashtable();

                x0 = double.Parse(txtBoxSecant_int1.Text);
                x1 = double.Parse(txtBoxSecant_int2.Text);
            }

            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            // clear textboxes
            clearBox();

            // exit if the initial values are invalid
            test = check();

            if (test != 0)
                return;

            do
            {
                // write x0 and x1
                count++;
                fx0 = fx1 = fx2 = 0;

                lBoxSecant_x0.Items.Add(Math.Round(x0, 5).ToString("0.00000"));
                lBoxSecant_x1.Items.Add(Math.Round(x1, 5).ToString("0.00000"));

                // solve for fx0 and fx1
                myHash.Clear();
                myHash.Add("x", x0.ToString());
                fx0 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                myHash.Clear();
                myHash.Add("x", x1.ToString());
                fx1 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                // write fx0 and fx1
                lBoxSecant_fx0.Items.Add(Math.Round(fx0, 5).ToString("0.00000"));
                lBoxSecant_fx1.Items.Add(Math.Round(fx1, 5).ToString("0.00000"));

                temp = x2;

                // check for Nan or inf
                if (double.IsNaN(fx0) || double.IsNaN(fx1) || double.IsInfinity(fx0) || double.IsInfinity(fx0))
                {
                    clearBox();
                    MessageBox.Show("Hi. I'm sorry but with the given function and initial values,\nI can tell you that the result will be NaN and I can't handle NaN.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                    return;
                }

                // check if fx0 and fx1 are the same
                if (fx0 == fx1)
                {
                    clearBox();
                    MessageBox.Show("Hi. I'm sorry but the f(x)'s of the x values at iteration " + count + " are the same.\nIf so, we'll be diving by zero and ending the world.\nI want you try again, okay?", "ERR", MessageBoxButtons.OK);
                    return;
                }

                // solve and write x2
                x2 = x1 - fx1 * ((x1 - x0) / (fx1 - fx0));
                lBoxSecant_x2.Items.Add(Math.Round(x2, 5).ToString("0.00000"));

                // solve and write fx2
                myHash.Clear();
                myHash.Add("x", x2.ToString());
                fx2 = myParse.Parse(txtBoxSecant_eq.Text, myHash);

                lBoxSecant_fx2.Items.Add(Math.Round(fx2, 5).ToString("0.00000"));

                // swap values
                x0 = x1;
                x1 = x2;

            } while ((Math.Abs(temp - x2)) >= error && count < 1000);

            if (count == 1000)
            {
                MessageBox.Show("Hi. I'm sorry but I can't solve it.\nI tried but the iterations were over a thousand!", "ERR", MessageBoxButtons.OK);
                return;
            }

            // display result
            MessageBox.Show("Yay! A root of the function is " + Math.Round(x2, 5).ToString("0.00000") + " and was solved in " + count + " iterations.\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        private void btnSecant_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxSecant_int1.Text = "X0";
            txtBoxSecant_int2.Text = "X1";
            txtBoxSecant_eq.Text = "EQUATION";

            clearBox();
        }

        private void clearBox()
        {
            lBoxSecant_x0.Items.Clear();
            lBoxSecant_x2.Items.Clear();
            lBoxSecant_x1.Items.Clear();
            lBoxSecant_fx0.Items.Clear();
            lBoxSecant_fx2.Items.Clear();
            lBoxSecant_fx1.Items.Clear();
        }
    }
}
