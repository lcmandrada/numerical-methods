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
    public partial class frmNewton : Form
    {
        // globally initialize variables
        int dataNewton_xfxSize;
        double check;

        int n, test;
        static string temp;
        static decimal[,] List;
        decimal x0, x1, y0, y1;
        decimal tempVal;

        public frmNewton()
        {
            InitializeComponent();
        }

        public void GenerateFunction()
        {
            // reinitialize variables
            n = dataNewton_xfx.Rows.Count;

            // solve for the coefficients
            test = NewtonsInterpolation();

            if (test == 1)
            {
                return;
            }

            // store the equation in a string
            string fnc = dataNewton_xfx[2, 0].Value.ToString();

            for (int i = 0; i < (n - 1); i++)
            {
                if (Decimal.Parse(List[0, i].ToString()) > 0)
                    fnc += " + ";
                else if (Decimal.Parse(List[0, i].ToString()) < 0)
                    fnc += " - ";
                else
                    continue;
                
                temp = "";

                for (int j = 0; j <= i; j++)
                {
                    x0 = Decimal.Parse(dataNewton_xfx[1, j].Value.ToString());

                    if (x0 > 0)
                        temp += "(x - " + x0 + ")";
                    else if (x0 < 0)
                        temp += "(x + " + (x0 * -1) + ")";
                    else
                        temp += "(x)";
                }

                fnc += Math.Abs(List[0, i]).ToString();
                fnc += temp;
            }

            // write equation
            txtBoxNewton_eq.Text = fnc;

            MessageBox.Show("Yay! I don't have anything to say but,\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        public int NewtonsInterpolation()
        {
            // create the table
            List = new decimal[n - 1, n - 1];

            for (int j = 0; j < n - 1; j++)
            {
                for (int i = 0; i < n - (j + 1); i++)
                {
                    if (j == 0)
                    {
                        x0 = Decimal.Parse(dataNewton_xfx[1, i].Value.ToString());
                        x1 = Decimal.Parse(dataNewton_xfx[1, i + 1].Value.ToString());
                        y0 = Decimal.Parse(dataNewton_xfx[2, i].Value.ToString());
                        y1 = Decimal.Parse(dataNewton_xfx[2, i + 1].Value.ToString());

                        // check for zero division or NaN or inf
                        try
                        {
                            tempVal = (y1 - y0) / (x1 - x0);
                        }

                        catch (DivideByZeroException)
                        {
                            txtBoxNewton_eq.Text = "EQUATION";

                            dataNewton_xfxSize = 0;
                            dataNewton_xfx.Rows.Clear();

                            MessageBox.Show("Hi. I'm sorry but we tried dividing by zero.\nIf you're still alive, then I want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                            return 1;
                        }

                        List[i, j] = Math.Round(tempVal, 5);
                    } else
                    {
                        x0 = Decimal.Parse(dataNewton_xfx[1, i].Value.ToString());
                        x1 = Decimal.Parse(dataNewton_xfx[1, i + (j + 1)].Value.ToString());

                        // check for zero division or NaN or inf
                        try
                        {
                            tempVal = (List[(i + 1), (j - 1)] - List[i, j - +1]) / (x1 - x0);
                        }

                        catch (DivideByZeroException)
                        {
                            txtBoxNewton_eq.Text = "EQUATION";

                            dataNewton_xfxSize = 0;
                            dataNewton_xfx.Rows.Clear();

                            MessageBox.Show("Hi. I'm sorry but we tried dividing by zero.\nIf you're still alive, then I want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                            return 1;
                        }

                        List[i, j] = Math.Round(tempVal, 5);
                    }
                }
            }

            return 0;
        }

        private void btnNewton_add_Click(object sender, EventArgs e)
        {
            // handle errors
            try
            {
                check = Double.Parse(txtBoxNewton_x.Text);
                check = Double.Parse(txtBoxNewton_fx.Text);
            }

            catch (FormatException)
            {
                txtBoxNewton_eq.Text = "EQUATION";
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            // write data points
            dataNewton_xfx.Rows.Add(dataNewton_xfxSize, txtBoxNewton_x.Text.ToString(), txtBoxNewton_fx.Text.ToString());
            dataNewton_xfxSize++;

            // clear textboxes
            txtBoxNewton_x.Text = "X";
            txtBoxNewton_fx.Text = "f(X)";

            this.ActiveControl = txtBoxNewton_x;
        }

        private void btnNewton_solve_Click(object sender, EventArgs e)
        {
            if (dataNewton_xfx.Rows.Count == 0)
            {
                txtBoxNewton_eq.Text = "EQUATION";
                MessageBox.Show("Hi. I'm sorry but you lack inputs. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                return;
            }

            GenerateFunction();
        }

        private void btnNewton_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxNewton_x.Text = "X";
            txtBoxNewton_fx.Text = "f(X)";
            txtBoxNewton_eq.Text = "EQUATION";

            dataNewton_xfxSize = 0;
            dataNewton_xfx.Rows.Clear();
        }
    }
}
