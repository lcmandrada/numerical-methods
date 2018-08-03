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
 
    MP3
    POLYNOMIAL TECHNIQUE x MULLER'S METHOD
    MATRIX DECOMPOSITION TECHNIQUE x CHOLESKY'S METHOD
    LINEAR ITERATIVE TECHNIQUE x GAUSS-JACOBI METHOD
 
    REFERENCES
    stackoverflow.com
    msdn.microsoft.com
    existing applications
*/

namespace MP3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMuller_Click(object sender, EventArgs e)
        {
            MP3.frmMuller form = new MP3.frmMuller();
            form.ShowDialog();
        }

        private void btnCholesky_Click(object sender, EventArgs e)
        {
            MP3.frmCholesky form = new MP3.frmCholesky();
            form.ShowDialog();
        }

        private void btnGaussJacobi_Click(object sender, EventArgs e)
        {
            MP3.frmGaussJacobi form = new MP3.frmGaussJacobi();
            form.ShowDialog();
        }
    }
}
