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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Q2MAJClient M = new Q2MAJClient();
            M.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Q3ListeCheque Q3 = new Q3ListeCheque();
            Q3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Q4RechercheMulticritere q4 = new Q4RechercheMulticritere();
            q4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Q5EtatCheque q5 = new Q5EtatCheque();
            q5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Q6EtatHistograme q6 = new Q6EtatHistograme();
            q6.ShowDialog();
        }
    }
}
