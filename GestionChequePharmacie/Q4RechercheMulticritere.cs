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
    public partial class Q4RechercheMulticritere : Form
    {
        public Q4RechercheMulticritere()
        {
            InitializeComponent();
        }
        string req = "";
        private void Q4RechercheMulticritere_Load(object sender, EventArgs e)
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
                Provider.RemplirTable("select * from Banque", "Banque");

                if (Provider.ds.Tables.Contains("Banque"))
                {
                    CB_Banque.DataSource = Provider.ds.Tables["Banque"];
                    CB_Banque.DisplayMember = @"Libelle_Banque";
                    CB_Banque.ValueMember = @"Code_Banque";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

       

        private void BTN_Afficher_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count >0)
            {
                int x = 0;
                bool vide = false; ;
                string erreur = "";
                req = "";
                for(x=0;x < checkedListBox1.CheckedItems.Count;x++) {
                    switch (checkedListBox1.CheckedItems[x].ToString())
                    {
                        case "Date Emission":
                            req += "and Dtae_Emission= '" + DTP_DateEmission.Value.ToString() + "' ";
                            break;
                        case "Montant":
                            if (!string.IsNullOrEmpty(TB_Montant.Text))
                            {
                                req += "and Montant= '" + TB_Montant.Text + "' ";
                            }
                            else { vide = true;erreur += "Montant"; }
                          
                            break;
                        case "Motif de Rejet":
                            if (CB_Code_Motif.SelectedIndex != -1)
                            {
                                req += "and Code_Motif= '" + CB_Code_Motif.SelectedValue.ToString() + "' ";
                            }
                            else { vide = true; erreur += " ,Motif de Rejet"; }
                            break;
                        case "CIN":
                            if (!string.IsNullOrEmpty(TB_CIN.Text))
                            {
                                req += "and CIN= '" + TB_CIN.Text + "' ";

                            }
                            else { vide = true; erreur += " ,CIN"; }
                            break;
                        case "Client Banque":
                            if (CB_Banque.SelectedIndex != -1)
                            {
                                req += "and Code_Banque= '" + CB_Banque.SelectedValue.ToString() + "' ";

                            }
                            else { vide = true; erreur += " ,Client Banque"; }
                            break;
                        case "Magasin":
                            if (CB_Numero_Magazine.SelectedIndex != -1)
                            {
                                req += "and Numero_Magasin= '" + CB_Numero_Magazine.SelectedValue.ToString() + "' ";
                            }
                            else { vide = true; erreur += " ,Magasin"; }
                            break;
                    }

                }
                if (vide) { MessageBox.Show("Remplir "+erreur); }
                else
                {
                    char[] req2 = req.ToCharArray();
                    for (int j = 0; j < 4; j++) req2[j] = ' ';
                    req = new string(req2);
                    MessageBox.Show(req);
                    Provider.RemplirTable("select * from Cheque where "+req+"", "Cheque");
                    dataGridView1.DataSource = Provider.ds.Tables["Cheque"];
                }


            }
            else { MessageBox.Show("cocher un critere"); }
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            int x = 0;
            foreach (DataGridViewRow R in dataGridView1.Rows)
            {
                if (R.Cells[0].Value != null && R.Cells[0].Value.ToString() == "T")
                {
                    Provider.ds.Tables["Cheque"].Rows.Find(R.Cells[1].Value.ToString()).Delete();
                    Provider.Enregistrer("Cheque");
                    x++;
                }
            }
            if (x>0) { MessageBox.Show("Les Cheques supprimée avec succes"); }
        }
    }
}
