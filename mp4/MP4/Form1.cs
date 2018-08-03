using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    LUKE CLARK M. ANDRADA
    
    ENGR. CARLOS HORTINELA IV
    COE60 C1
 
    MP4
    CURVE FITTING TECHNIQUES x LINEAR REGRESSION
    INTERPOLATION x NEWTON'S DIVIDED DIFFERENCE INTERPOLATING POLYNOMIAL
    NUMERICAL INTEGRATION x TRAPEZOIDAL RULE
    NUMERICAL DIFFERENTIATION x CENTERED FINITE DIVIDED DIFFERENCE
 
    REFERENCES
    lundin.info/mathparser
    stackoverflow.com
    msdn.microsoft.com
    existing applications
*/

namespace MP4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLinear_Click(object sender, EventArgs e)
        {
            MP4.frmLinear form = new MP4.frmLinear();
            form.ShowDialog();
        }

        private void btnNewton_Click(object sender, EventArgs e)
        {
            MP4.frmNewton form = new MP4.frmNewton();
            form.ShowDialog();
        }

        private void btnTrapezoidal_Click(object sender, EventArgs e)
        {
            MP4.frmTrapezoidal form = new MP4.frmTrapezoidal();
            form.ShowDialog();
        }

        private void btnCentered_Click(object sender, EventArgs e)
        {
            MP4.frmCenter form = new MP4.frmCenter();
            form.ShowDialog();
        }
    }
}
