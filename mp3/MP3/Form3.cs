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
    public partial class frmCholesky : Form
    {
        // globally initialize variables
        double y1, y2, y3, x1, x2, x3;
        double[,] A = new double[3, 4];
        double[,] L = new double[3, 3];
        double[,] U = new double[3, 3];
        bool flag1 = false, flag2 = false, flag3 = false;

        public frmCholesky()
        {
            InitializeComponent();
        }

        private void frmCholesky_Load(object sender, EventArgs e)
        {
            flag1 = false;

            // initialize matrices
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    L[i, j] = 0;
                    U[i, j] = 0;
                }
            }

            U[0, 0] = 1;
            U[1, 1] = 1;
            U[2, 2] = 1;
        }

        private void btnCholesky_e1_Click(object sender, EventArgs e)
        {
            // initialize input and handle errors
            try
            {
                A[0, 0] = double.Parse(txtBoxCholesky_e1x1.Text);
                A[0, 1] = double.Parse(txtBoxCholesky_e1x2.Text);
                A[0, 2] = double.Parse(txtBoxCholesky_e1x3.Text);
                A[0, 3] = double.Parse(txtBoxCholesky_e1x.Text);
            } 
            
            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                flag1 = false;
                return;
            }
            
            // check if correctly arranged to diagonal formation
            if (A[0, 0] >= A[0, 1] && A[0, 0] >= A[0, 2])
            {
                flag1 = true;
                return;
            }

            // clear first equation otherwise
            clearBox();
            MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nThe first coefficient should be the largest.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
            flag1 = false;
        }

        private void btnCholesky_e2_Click(object sender, EventArgs e)
        {
            // initialize input and handle errors
            try
            {
                A[1, 0] = double.Parse(txtBoxCholesky_e2x1.Text);
                A[1, 1] = double.Parse(txtBoxCholesky_e2x2.Text);
                A[1, 2] = double.Parse(txtBoxCholesky_e2x3.Text);
                A[1, 3] = double.Parse(txtBoxCholesky_e2x.Text);
            } 
            
            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                flag2 = false;
                return;
            }

            // check if correctly arranged to diagonal structure
            if (A[1, 1] >= A[1, 0] && A[1, 1] >= A[1, 2])
            {
                flag2 = true;
                return;
            }

            // clear second equation otherwise
            clearBox();
            MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nThe second coefficient should be the largest.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
            flag2 = false;
        }

        private void btnCholesky_e3_Click(object sender, EventArgs e)
        {
            // initialize input and handle errors
            try
            {
                A[2, 0] = double.Parse(txtBoxCholesky_e3x1.Text);
                A[2, 1] = double.Parse(txtBoxCholesky_e3x2.Text);
                A[2, 2] = double.Parse(txtBoxCholesky_e3x3.Text);
                A[2, 3] = double.Parse(txtBoxCholesky_e3x.Text);
            } 
            
            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                flag3 = false;
                return;
            }

            // check if correctly arranged to diagonal structure
            if (A[2, 2] >= A[2, 0] && A[2, 2] >= A[2, 1])
            {
                flag3 = true;
                return;
            }

            // clear second equation otherwise
            clearBox();
            MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nThe third coefficient should be the largest.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
            flag3 = false;
        }

        private void btnCholesky_solve_Click(object sender, EventArgs e)
        {
            // check if all equations were entered
            if (!flag1 || !flag2 || !flag3)
            {
                clearBox();
                MessageBox.Show("Hi. A favor, please enter the equations first. Tenk!", "ERR", MessageBoxButtons.OK);
                return;
            }

            // fill the matrices with corresponding values
            for (int i = 0; i < 3; i++)
                L[i, 0] = A[i, 0];

            for (int i = 1; i < 3; i++)
                U[0, i] = A[0, i] / L[0, 0];

            for (int i = 1; i < 3; i++)
                L[i, 1] = A[i, 1] - L[i, 0] * U[0, 1];

            U[1, 2] = (A[1, 2] - L[1, 0] * U[0, 2]) / L[1, 1];
            L[2, 2] = A[2, 2] - L[2, 0] * U[0, 2] - L[2, 1] * U[1, 2];

            // solve for rs
            y1 = A[0, 3] / L[0, 0];
            y2 = (A[1, 3] + -1 * L[1, 0] * y1) / L[1, 1];
            y3 = (-1 * y1 * L[2, 0] + -1 * L[2, 1] * y2 + A[2, 3]) / L[2, 2];

            // solve for xs
            x3 = y3;
            x2 = y2 + x3 * -1 * U[1, 2];
            x1 = y1 + -1 * U[0, 1] * x2 + -1 * U[0, 2] * x3;

            // write the results
            txtBoxCholesky_x1.Text = Convert.ToString(Math.Round(x1, 5).ToString("0.00000"));
            txtBoxCholesky_x2.Text = Convert.ToString(Math.Round(x2, 5).ToString("0.00000"));
            txtBoxCholesky_x3.Text = Convert.ToString(Math.Round(x3, 5).ToString("0.00000"));

            MessageBox.Show("Yay! I don't have anything to say but,\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        private void btnCholesky_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxCholesky_e1x1.Text = "E1 X1";
            txtBoxCholesky_e1x2.Text = "+ E1 X2";
            txtBoxCholesky_e1x3.Text = "+ E1 X3";
            txtBoxCholesky_e1x.Text = "= E1 X";

            txtBoxCholesky_e2x1.Text = "E2 X1";
            txtBoxCholesky_e2x2.Text = "+ E2 X2";
            txtBoxCholesky_e2x3.Text = "+ E2 X3";
            txtBoxCholesky_e2x.Text = "= E2 X";

            txtBoxCholesky_e3x1.Text = "E3 X1";
            txtBoxCholesky_e3x2.Text = "+ E3 X2";
            txtBoxCholesky_e3x3.Text = "+ E3 X3";
            txtBoxCholesky_e3x.Text = "= E3 X";

            clearBox();

            flag1 = flag2 = flag3 = false;
        }

        private void clearBox()
        {
            txtBoxCholesky_x1.Text = "X1";
            txtBoxCholesky_x2.Text = "X2";
            txtBoxCholesky_x3.Text = "X3";
        }
    }
}
