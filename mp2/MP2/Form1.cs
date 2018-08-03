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
 
    MP2
    OPEN METHOD x SECANT METHOD
 
    REFERENCES
    lundin.info/mathparser
    stackoverflow.com
    msdn.microsoft.com
    existing applications
*/

namespace MP2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSecant_Click(object sender, EventArgs e)
        {
            MP2.frmSecant form = new MP2.frmSecant();
            form.ShowDialog();
        }
    }
}
