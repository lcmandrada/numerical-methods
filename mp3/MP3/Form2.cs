using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3
{
    public partial class frmMuller : Form
    {
        public frmMuller()
        {
            InitializeComponent();
        }

        private void btnMuller_solve_Click(object sender, EventArgs e)
        {
            // initialize variables
            double s1, s0, h1, h0, a, b, c, d, f, x1, x0, x2, x3, f0, f1, f2, error = 9999, count = 0, a1, b1, c1, d1;
            double[] data = new double[5];

            // handle errors
            try
            {
                x0 = double.Parse(txtBoxMuller_x0.Text);
                x1 = double.Parse(txtBoxMuller_x1.Text);
                x2 = double.Parse(txtBoxMuller_x2.Text);

                a = double.Parse(txtBoxMuller_a.Text);
                b = double.Parse(txtBoxMuller_b.Text);
                c = double.Parse(txtBoxMuller_c.Text);
                d = double.Parse(txtBoxMuller_d.Text);
                f = double.Parse(txtBoxMuller_e.Text);

                if (a == 0 && b == 0 && c == 0 && d == 0 && f == 0)
                {
                    clearBox();
                    MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                    return;
                }
            } 
            
            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            // clear boxes
            clearBox();

            while (error > .00001 && count < 1000)
            {
                // solve for the values of y
                f0 = (a * (x0 * x0 * x0 * x0)) + (b * x0 * x0 * x0) + (c * x0 * x0) + (d * x0) + f;
                f1 = (a * (x1 * x1 * x1 * x1)) + (b * x1 * x1 * x1) + (c * x1 * x1) + (d * x1) + f;
                f2 = (a * (x2 * x2 * x2 * x2)) + (b * x2 * x2 * x2) + (c * x2 * x2) + (d * x2) + f;

                // solve for the curve-fitting values
                h0 = x1 - x0;
                h1 = x2 - x1;
                s0 = (f1 - f0) / h0;
                s1 = (f2 - f1) / h1;

                // solve for the coefficients
                a1 = (s1 - s0) / h1 + h0;
                b1 = (a1 * h1) + s1;
                c1 = f2;

                // solve for the base discriminant
                d1 = (b1 * b1) - (4 * a1 * c1);

                // check if the base discriminant is positive
                if (d1 >= 0 && b1 - d1 != 0)
                {
                    // solve for x3
                    d1 = Math.Sqrt(d1);
                    if (Math.Abs(b1 + d1) > Math.Abs(b1 - d1))
                        x3 = x2 + ((-2 * c1) / (b1 + d1));
                    else
                        x3 = x2 + ((-2 * c1) / (b1 - d1));

                    // solve for error
                    error = Math.Abs((x3 - x2));

                    // iteration counter
                    count++;

                    // write values
                    lBoxMuller_k.Items.Add(count);
                    lBoxMuller_x0.Items.Add(Math.Round(x0, 5).ToString("0.00000"));
                    lBoxMuller_x1.Items.Add(Math.Round(x1, 5).ToString("0.00000"));
                    lBoxMuller_x2.Items.Add(Math.Round(x2, 5).ToString("0.00000"));
                    lBoxMuller_x3.Items.Add(Math.Round(x3, 5).ToString("0.00000"));

                    // swap values
                    x0 = x1;
                    x1 = x2;
                    x2 = x3;
                } else
                {
                    // clear boxes
                    clearBox();

                    // promt user if the result is imaginary
                    MessageBox.Show("Hi. I'm sorry but with the given function and initial values, I can tell you that the result will be imaginary and I can't handle imaginary.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                    error = 9999;
                    return;
                }
            };

            if (count == 1000)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but I can't solve it.\nI tried but the iterations were over a thousand!", "ERR", MessageBoxButtons.OK);
                return;
            }

            // display result
            MessageBox.Show("Yay! A root of the function is " + Math.Round(x2, 5).ToString("0.00000") + " and was solved in " + count + " iterations.\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        private void btnMuller_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxMuller_e.Text = "eX^0";
            txtBoxMuller_d.Text = "dX^1";
            txtBoxMuller_c.Text = "cX^2";
            txtBoxMuller_b.Text = "bX^3";
            txtBoxMuller_a.Text = "aX^4";
            txtBoxMuller_x0.Text = "X0";
            txtBoxMuller_x1.Text = "X1";
            txtBoxMuller_x2.Text = "X2";

            clearBox();
        }

        private void clearBox()
        {
            lBoxMuller_k.Items.Clear();
            lBoxMuller_x0.Items.Clear();
            lBoxMuller_x1.Items.Clear();
            lBoxMuller_x2.Items.Clear();
            lBoxMuller_x3.Items.Clear();
        }
    }
}
