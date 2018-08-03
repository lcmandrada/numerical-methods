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
 
    MP1
    BRACKETING METHOD x REGULA-FALSI METHOD
 
    REFERENCES
    lundin.info/mathparser
    stackoverflow.com
    msdn.microsoft.com
    existing applications
*/

namespace MP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegula_Click(object sender, EventArgs e)
        {
            MP1.frmRegula form = new MP1.frmRegula();
            form.ShowDialog();
        }
    }
}
