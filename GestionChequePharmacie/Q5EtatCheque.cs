using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionChequePharmacie
{
    public partial class Q5EtatCheque : Form
    {
        public Q5EtatCheque()
        {
            InitializeComponent();
        }

        private void Q5EtatCheque_Load(object sender, EventArgs e)
        {
            CrystalReportQ5 q5 = new CrystalReportQ5();
            crystalReportViewer1.ReportSource = q5;
        }
    }
}
