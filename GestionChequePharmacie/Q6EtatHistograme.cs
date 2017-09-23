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
    public partial class Q6EtatHistograme : Form
    {
        public Q6EtatHistograme()
        {
            InitializeComponent();
        }

        private void Q6EtatHistograme_Load(object sender, EventArgs e)
        {
            CrystalReportQ6 q5 = new CrystalReportQ6();
            crystalReportViewer1.ReportSource = q5;
        }
    }
}
