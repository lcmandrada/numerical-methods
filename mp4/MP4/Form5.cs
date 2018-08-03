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
    public partial class frmCenter : Form
    {
        // globally initialize variables
        double xi, fxi;
        double xiadd, fxiadd;
        double ximinus, fximinus;
        double h;
        double derivative;

        ExpressionParser myParse;
        Hashtable myHash;

        public frmCenter()
        {
            InitializeComponent();
        }

        public void useCenter()
        {
            // solve for estimate
            derivative = (fxiadd - fximinus) / (xiadd - ximinus);
        }

        private void btnCenter_solve_Click(object sender, EventArgs e)
        {
            // handle errors
            try
            {
                h = Double.Parse(txtBoxCenter_h.Text);
                xi = Double.Parse(txtBoxCenter_xi.Text);
            }

            catch (FormatException)
            {
                txtBoxCenter_d.Text = "D";
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            myParse = new ExpressionParser();
            myHash = new Hashtable();

            // solve for xis
            xiadd = xi + h;
            ximinus = xi - h;

            // handle errors
            try
            {
                // solve for fxs
                myHash.Clear();
                myHash.Add("x", xi.ToString());
                fxi = myParse.Parse(txtBoxCenter_eq.Text, myHash);

                myHash.Clear();
                myHash.Add("x", xiadd.ToString());
                fxiadd = myParse.Parse(txtBoxCenter_eq.Text, myHash);

                myHash.Clear();
                myHash.Add("x", ximinus.ToString());
                fximinus = myParse.Parse(txtBoxCenter_eq.Text, myHash);

                // check for Nan or inf
                if (double.IsNaN(fxi) || double.IsInfinity(fxi) ||
                    double.IsNaN(fxiadd) || double.IsInfinity(fxiadd) ||
                    double.IsNaN(fximinus) || double.IsInfinity(fximinus))
                {
                    txtBoxCenter_d.Text = "D";
                    MessageBox.Show("Hi. I'm sorry but with the given function and value,\nI can tell you that the result will be NaN and I can't handle NaN.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                    return;
                }
            }

            catch
            {
                txtBoxCenter_d.Text = "D";
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            useCenter();
            txtBoxCenter_d.Text = Math.Round(derivative, 5).ToString();

            // display result
            MessageBox.Show("Yay! The derivative approximation of the function at the given value is " + txtBoxCenter_d.Text + ".\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        private void btnCenter_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxCenter_eq.Text = "EQUATION";
            txtBoxCenter_xi.Text = "Xi";
            txtBoxCenter_h.Text = "h";
            txtBoxCenter_d.Text = "D";
        }
    }
}
