using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP4
{
    public partial class frmLinear : Form
    {
        // globally initialize variables
        int dataLinear_xfxSize = 0;

        int n;
        double sumx, sumy, sumxy;
        double a0, a1;
        double sumxx;
        double temp, check;
        int i;

        public frmLinear()
        {
            InitializeComponent();
        }

        public void solve()
        {
            // reinitialize variables
            n = dataLinear_xfx.Rows.Count;
            sumx = 0.0;
            sumy = 0.0;
            sumxy = 0.0;
            a0 = 0.0;
            a1 = 0.0;
            sumxx = 0.0;
            temp = 0.0;
            check = 0.0;

            // summation of x
            for (i = 0; i < n; i++)
                sumx += Double.Parse(dataLinear_xfx[1, i].Value.ToString());

            // summation of y
            for (i = 0; i < n; i++)
                sumy += Double.Parse(dataLinear_xfx[2, i].Value.ToString());

            // summation of xy
            for (i = 0; i < n; i++)
            {
                temp = Double.Parse(dataLinear_xfx[1, i].Value.ToString()) * Double.Parse(dataLinear_xfx[2, i].Value.ToString());
                sumxy += Math.Round(temp, 5);
            }

            // summation of x^2
            for (i = 0; i < n; i++)
            {
                temp = Double.Parse(dataLinear_xfx[1, i].Value.ToString()) * Double.Parse(dataLinear_xfx[1, i].Value.ToString());
                sumxx += Math.Round(temp, 5);
            }

            // solve for the coefficients
            a1 = (n * sumxy - sumx * sumy) / (n * sumxx - (sumx * sumx));
            a1 = Math.Round(a1, 5);

            a0 = (sumy / n) - a1 * (sumx / n);
            a0 = Math.Round(a0, 5);

            // check for zero division or NaN or inf
            if (double.IsNaN(a1))
            {
                dataLinear_xfxSize = 0;
                dataLinear_xfx.Rows.Clear();
                clearBox();

                MessageBox.Show("Hi. I'm sorry but we tried dividing by zero in solving for a1.\nIf you're still alive, then I want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            // write the coefficients
            txtBoxLinear_a0.Text = a0.ToString();
            txtBoxLinear_a1.Text = a1.ToString();

            MessageBox.Show("Yay! I don't have anything to say but,\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        private void btnLinear_add_Click(object sender, EventArgs e)
        {
            // handle errors
            try
            {
                check = Double.Parse(txtBoxLinear_x.Text);
                check = Double.Parse(txtBoxLinear_fx.Text); 
            } 
            
            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            // write data points
            dataLinear_xfx.Rows.Add(dataLinear_xfxSize, txtBoxLinear_x.Text.ToString(), txtBoxLinear_fx.Text.ToString());
            dataLinear_xfxSize++;

            // clear textboxes
            txtBoxLinear_x.Text = "X";
            txtBoxLinear_fx.Text = "f(X)";
            this.ActiveControl = txtBoxLinear_x;
        }

        private void btnLinear_solve_Click(object sender, EventArgs e)
        {
            // check if inputs > 0
            if (dataLinear_xfxSize > 0)
                // solve for the coefficients
                solve();
            else
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but you lack inputs. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnLinear_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxLinear_x.Text = "X";
            txtBoxLinear_fx.Text = "f(X)";
            
            clearBox();

            dataLinear_xfxSize = 0;
            dataLinear_xfx.Rows.Clear();
        }

        private void clearBox()
        {
            txtBoxLinear_a0.Text = "a0";
            txtBoxLinear_a1.Text = "a1";
        }
    }
}
