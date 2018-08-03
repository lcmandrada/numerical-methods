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
    public partial class frmGaussJacobi : Form
    {
        // globally initialize variables
        double[] first = new double[10];
        double[] second = new double[10];
        double[] third = new double[10];
        double error = 0.00001;
        double v1, v2, v3, temp1, temp2, temp3, tempf1, tempf2, tempf3;
        int count = 0;
        bool flag1 = false, flag2 = false, flag3 = false;

        public frmGaussJacobi()
        {
            InitializeComponent();
        }

        private void btnGaussJacobi_e1_Click(object sender, EventArgs e)
        {
            // initialize input and handle errors
            try
            {
                first[0] = double.Parse(txtBoxGaussJacobi_e1x1.Text);
                first[1] = double.Parse(txtBoxGaussJacobi_e1x2.Text);
                first[2] = double.Parse(txtBoxGaussJacobi_e1x3.Text);
                first[3] = double.Parse(txtBoxGaussJacobi_e1x.Text);
            } 

            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                flag1 = false;
                return;
            }

            // check if correctly arranged to diagonal structure
            if (first[0] >= first[1] && first[0] >= first[2])
            {
                flag1 = true;
                return;
            }

            // clear first equation otherwise
            clearBox();
            MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nThe first coefficient should be the largest.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
            flag1 = false;
        }

        private void btnGaussJacobi_e2_Click(object sender, EventArgs e)
        {
            // initialize input and handle errors
            try
            {
                second[0] = double.Parse(txtBoxGaussJacobi_e2x1.Text);
                second[1] = double.Parse(txtBoxGaussJacobi_e2x2.Text);
                second[2] = double.Parse(txtBoxGaussJacobi_e2x3.Text);
                second[3] = double.Parse(txtBoxGaussJacobi_e2x.Text);
            } 
            
            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                flag2 = false;
                return;
            }

            // check if correctly arranged to diagonal structure
            if (second[1] >= second[0] && second[1] >= second[2])
            {
                flag2 = true;
                return;
            }

            // clear second equation otherwise
            clearBox();
            MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nThe second coefficient should be the largest.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
            flag2 = false;
        }

        private void btnGaussJacobi_e3_Click(object sender, EventArgs e)
        {
            // initialize input and handle errors
            try
            {
                third[0] = double.Parse(txtBoxGaussJacobi_e3x1.Text);
                third[1] = double.Parse(txtBoxGaussJacobi_e3x2.Text);
                third[2] = double.Parse(txtBoxGaussJacobi_e3x3.Text);
                third[3] = double.Parse(txtBoxGaussJacobi_e3x.Text);
            } 
            
            catch (FormatException)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
                flag3 = false;
                return;
            }

            // check if correctly arranged to diagonal structure
            if (third[2] >= third[0] && third[2] >= third[1])
            {
                flag3 = true;
                return;
            }

            // clear third equation otherwise
            clearBox();
            MessageBox.Show("Hi. I'm sorry but your input is invalid. It's okay.\nThe third coefficient should be the largest.\nI want you to try again, okay?", "ERR", MessageBoxButtons.OK);
            flag3 = false;
        }

        private void btnGaussJacobi_solve_Click(object sender, EventArgs e)
        {
            clearBox();

            // check if all equations were entered
            if (!flag1 || !flag2 || !flag3)
            {
                MessageBox.Show("Hi. A favor, please enter the equations first. Tenk!", "ERR", MessageBoxButtons.OK);
                return;
            }

            // clear counter
            count = 0;

            // initialize variables
            v1 = v2 = v3 = 0;

            do
            {
                // save v temporarily
                temp1 = v1;
                temp2 = v2;
                temp3 = v3;

                // iteration counter
                count++;

                // solve for the new v
                v1 = (first[3] + (-1 * first[1] * v2) + (-1 * first[2] * v3)) / first[0];
                v2 = (second[3] + (-1 * second[0] * v1) + (-1 * second[2] * v3)) / second[1];
                v3 = (third[3] + (-1 * third[0] * v1) + (-1 * third[1] * v2)) / third[2];

                // write the new v
                lBoxGaussJacobi_k.Items.Add(count);
                lBoxGaussJacobi_v1.Items.Add(Math.Round(v1, 5).ToString("0.00000"));
                lBoxGaussJacobi_v2.Items.Add(Math.Round(v2, 5).ToString("0.00000"));
                lBoxGaussJacobi_v3.Items.Add(Math.Round(v3, 5).ToString("0.00000"));

                // check error
                tempf1 = Math.Abs(temp1 - v1);
                tempf2 = Math.Abs(temp2 - v2);
                tempf3 = Math.Abs(temp3 - v3);
            } while (tempf1 > error && tempf2 > error && tempf3 > error && count < 1000);

            if (count == 1000)
            {
                clearBox();
                MessageBox.Show("Hi. I'm sorry but I can't solve it.\nI tried but the iterations were over a thousand!", "ERR", MessageBoxButtons.OK);
                return;
            }

            txtBoxGaussJacobi_x1.Text = Math.Round(v1, 5).ToString("0.00000");
            txtBoxGaussJacobi_x2.Text = Math.Round(v2, 5).ToString("0.00000");
            txtBoxGaussJacobi_x3.Text = Math.Round(v3, 5).ToString("0.00000");

            MessageBox.Show("Yay! The values were solved in " + count + " iterations.\nIt's superbly awesome, yes?", "ANS", MessageBoxButtons.OK);
        }

        private void btnGaussJacobi_clear_Click(object sender, EventArgs e)
        {
            // clear everything
            txtBoxGaussJacobi_e1x1.Text = "E1 X1";
            txtBoxGaussJacobi_e1x2.Text = "+ E1 X2";
            txtBoxGaussJacobi_e1x3.Text = "+ E1 X3";
            txtBoxGaussJacobi_e1x.Text = "= E1 X";

            txtBoxGaussJacobi_e2x1.Text = "E2 X1";
            txtBoxGaussJacobi_e2x2.Text = "+ E2 X2";
            txtBoxGaussJacobi_e2x3.Text = "+ E2 X3";
            txtBoxGaussJacobi_e2x.Text = "= E2 X";

            txtBoxGaussJacobi_e3x1.Text = "E3 X1";
            txtBoxGaussJacobi_e3x2.Text = "+ E3 X2";
            txtBoxGaussJacobi_e3x3.Text = "+ E3 X3";
            txtBoxGaussJacobi_e3x.Text = "= E3 X";

            clearBox();

            flag1 = flag2 = flag3 = false;
        }

        private void clearBox()
        {
            txtBoxGaussJacobi_x1.Text = "X1";
            txtBoxGaussJacobi_x2.Text = "X2";
            txtBoxGaussJacobi_x3.Text = "X3";

            lBoxGaussJacobi_k.Items.Clear();
            lBoxGaussJacobi_v1.Items.Clear();
            lBoxGaussJacobi_v2.Items.Clear();
            lBoxGaussJacobi_v3.Items.Clear();
        }
    }
}
