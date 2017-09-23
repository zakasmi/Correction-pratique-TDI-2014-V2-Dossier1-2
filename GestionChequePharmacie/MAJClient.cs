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
    public partial class Q2MAJClient : Form
    {
        public Q2MAJClient()
        {
            InitializeComponent();
        }
        int Pos = 0;

        private void Q2MAJClient_Load(object sender, EventArgs e)
        {
            try
            {
                Provider.RemplirTable("select * from Client", "Client");
                Provider.RemplirTable("select * from Magasin", "Magasin");

                if (Provider.ds.Tables.Contains("Magasin"))
                {
        CB_Numero_Magazine.DataSource = Provider.ds.Tables["Magasin"];
        CB_Numero_Magazine.DisplayMember = @"Libelle_Magasin";
        CB_Numero_Magazine.ValueMember = @"Numero_Magasin";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = Provider.ds.Tables["Client"].NewRow();
                dr[0] = TB_CIN.Text;
                dr[1] = TB_Genre.Text;
                dr[2] = TB_Nom.Text;
                dr[3] = TB_Prenom.Text;
                dr[4] = TB_Tel.Text;
                dr[5] = TB_Adresse.Text;
                dr[6] = TB_Ville.Text;
                dr[7] = CB_Numero_Magazine.SelectedValue;
                Provider.Ajouter(dr, "Client");
                MessageBox.Show("Client a ete Ajoute avec succes");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
             
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TB_CIN.Text))
                {
 DataRow dr = Provider.ds.Tables["Client"].Rows.Find(TB_CIN.Text);

 dr[0] = TB_CIN.Text;
 dr[1] = TB_Genre.Text;
 dr[2] = TB_Nom.Text;
 dr[3] = TB_Prenom.Text;
 dr[4] = TB_Tel.Text;
 dr[5] = TB_Adresse.Text;
 dr[6] = TB_Ville.Text;
 dr[7] = CB_Numero_Magazine.SelectedValue;
 MessageBox.Show("Le Clienta ete Modifie avec succes");
                }
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Provider.Enregistrer("Client");

                MessageBox.Show("Les Modification sont Enregistres ");
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Provider.ds.Tables["Client"].Rows.Find(TB_CIN.Text).Delete();
                MessageBox.Show("Le Client a ete supprimé avec succes");


            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Client"].Rows.Count;
            if (count>0) {
                Pos = 0;
                Navig();
            }
        }

        public void Navig()
        {
            // Te9der dir 2 dyal les tables wa7Ed dir fih les modification o wa7ed b9a tnaviguer bih
            // Fo9ach ma derti chi modification khasak t3awad t3amar la table dyal navigation  
            // f exam makayanch lwe9t bzaf  donc .dir ri had test bach t eviter exception 
            if (Provider.ds.Tables["Client"].Rows[Pos].RowState != DataRowState.Deleted)
            {
                
                DataRow dr = Provider.ds.Tables["Client"].Rows[Pos];
                TB_CIN.Text = dr[0].ToString();
                TB_Genre.Text=  dr[1].ToString();
                TB_Nom.Text=   dr[2].ToString();
                TB_Prenom.Text=  dr[3].ToString();
                TB_Tel.Text= dr[4].ToString();
                TB_Adresse.Text= dr[5].ToString();
                TB_Ville.Text  =dr[6].ToString();
                CB_Numero_Magazine.SelectedValue = dr[7].ToString();
                
            }


        }

        private void BTN_Fin_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Client"].Rows.Count;
            if (count > 0)
            {
                Pos = count-1;
                Navig();
            }
        }

        private void BTN_prec_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Client"].Rows.Count;
            if (count > 0 && Pos>0)
            {
                Pos--;
                Navig();
            }
        }

        private void BTN_Suiv_Click(object sender, EventArgs e)
        {
            int count = Provider.ds.Tables["Client"].Rows.Count;
            if (count > 0 && Pos < count-1)
            {
                Pos++;
                Navig();
            }
        }
    }
}
