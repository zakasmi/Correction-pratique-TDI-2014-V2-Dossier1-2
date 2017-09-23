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
    public partial class Q3ListeCheque : Form
    {
        public Q3ListeCheque()
        {
            InitializeComponent();
        }

        private void Q3ListeCheque_Load(object sender, EventArgs e)
        {
            try
            {
                Provider.RemplirTable("select * from MotifsRejet", "MotifsRejet");
                Provider.RemplirTable("select * from Magasin", "Magasin");

                if (Provider.ds.Tables.Contains("Magasin"))
                {
                    CB_Numero_Magazine.DataSource = Provider.ds.Tables["Magasin"];
                    CB_Numero_Magazine.DisplayMember = @"Libelle_Magasin";
                    CB_Numero_Magazine.ValueMember = @"Numero_Magasin";
                }
                if (Provider.ds.Tables.Contains("MotifsRejet"))
                {
                    CB_Code_Motif.DataSource = Provider.ds.Tables["MotifsRejet"];
                    CB_Code_Motif.DisplayMember = @"Libelle_Motif";
                    CB_Code_Motif.ValueMember = @"Code_Motif";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Afficher_Click(object sender, EventArgs e)
        {

            try
            {
                if (CB_Numero_Magazine.SelectedIndex != -1 && CB_Code_Motif.SelectedIndex != -1)
                {
                    Provider.RemplirTable("select * from Cheque where Code_Motif='" + CB_Code_Motif.SelectedValue.ToString() + "' and Numero_Magasin='" + CB_Numero_Magazine.SelectedValue.ToString() + "' ", "Cheque");

                    if (Provider.ds.Tables.Contains("MotifsRejet"))
                    {
                        DGV_Liste_Cheque.DataSource = Provider.ds.Tables["Cheque"];
                    }

                }
                else MessageBox.Show("Selectionner Magazine est Motif depuis la liste !!!");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
