using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQ9_Personnage_Aléatoire
{
    public partial class Form1 : Form
    {
        List<string> vocations = new List<string>();
        List<string> persos = new List<string>();

        public Form1()
        {
            InitializeComponent();
            
            cbVocations.Checked = true;
            cbPersonnages.Checked = true;

            cbSommite.Checked = true;
            cbRanger.Checked = true;
            cbArmagicien.Checked = true;
            cbGladiateur.Checked = true;
            cbPaladin.Checked = true;
            cbTroubadour.Checked = true;
            cbVoleur.Checked = true;
            cbArtisteMartial.Checked = true;
            cbMage.Checked = true;
            cbPretre.Checked = true;
            cbGuerrier.Checked = true;

            cbPerso1.Checked = true;
            cbPerso2.Checked = true;
            cbPerso3.Checked = true;
            cbPerso4.Checked = true;

            checkBox1.Checked = true;

            resultat.Text = String.Empty;
            perso.Text = String.Empty;

            btnVocation.Visible = false;
        }

        /*
         * Boutons
         */
        private void btnVocation_Click(object sender, EventArgs e)
        {
            /*debug.Text = "debug : (" + vocations.Count() + ") ";
            foreach (string s in vocations)
            {
                debug.Text += s + " - ";
            }*/

            if (vocations.Count() > 0)
            {
                var rand = new Random();
                int x = rand.Next(vocations.Count());
                resultat.Text = vocations[x];
                btnVocation.Enabled = false;
            }                

            if ((perso.Text != String.Empty || checkBox1.Checked == false) && resultat.Text != String.Empty)
                btnReset.Visible = true;

        }

        private void btnPerso_Click(object sender, EventArgs e)
        {           
            if (persos.Count() > 0)
            {
                var rand = new Random();
                int x = rand.Next(persos.Count());
                perso.Text = "Perso " + persos[x];
                btnPerso.Enabled = false;
                btnVocation.Visible = true;
            }                

            if (perso.Text != String.Empty && resultat.Text != String.Empty)
                btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if ((perso.Text != String.Empty || checkBox1.Checked == false) && resultat.Text != String.Empty)
            {
                resultat.Text = String.Empty;
                perso.Text = String.Empty;
                btnVocation.Enabled = true;
                btnPerso.Enabled = true;
                btnReset.Visible = false;
                if (checkBox1.Checked)
                {
                    btnPerso.Visible = true;
                    btnVocation.Visible = false;
                }
                else
                {
                    btnVocation.Visible = true;
                    btnPerso.Visible = false;
                }
            }
        }

        /*
        * Vocations
        */
        private void cbGuerrier_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGuerrier.Checked) vocations.Add(cbGuerrier.Text);
            else vocations.Remove(cbGuerrier.Text);
        }

        private void cbPretre_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPretre.Checked) vocations.Add(cbPretre.Text);
            else vocations.Remove(cbPretre.Text);
        }

        private void cbMage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMage.Checked) vocations.Add(cbMage.Text);
            else vocations.Remove(cbMage.Text);
        }

        private void cbArtisteMartial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArtisteMartial.Checked) vocations.Add(cbArtisteMartial.Text);
            else vocations.Remove(cbArtisteMartial.Text);
        }

        private void cbVoleur_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVoleur.Checked) vocations.Add(cbVoleur.Text);
            else vocations.Remove(cbVoleur.Text);
        }

        private void cbTroubadour_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTroubadour.Checked) vocations.Add(cbTroubadour.Text);
            else vocations.Remove(cbTroubadour.Text);
        }

        private void cbGladiateur_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGladiateur.Checked) vocations.Add(cbGladiateur.Text);
            else vocations.Remove(cbGladiateur.Text);
        }

        private void cbPaladin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPaladin.Checked) vocations.Add(cbPaladin.Text);
            else vocations.Remove(cbPaladin.Text);
        }

        private void cbArmagicien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbArmagicien.Checked) vocations.Add(cbArmagicien.Text);
            else vocations.Remove(cbArmagicien.Text);
        }

        private void cbRanger_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRanger.Checked) vocations.Add(cbRanger.Text);
            else vocations.Remove(cbRanger.Text);
        }

        private void cbSommite_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSommite.Checked) vocations.Add(cbSommite.Text);
            else vocations.Remove(cbSommite.Text);
        }


        /*
         * Persos
         */
        private void cbPerso1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPerso1.Checked) persos.Add(cbPerso1.Text);
            else persos.Remove(cbPerso1.Text);
        }

        private void cbPerso2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPerso2.Checked) persos.Add(cbPerso2.Text);
            else persos.Remove(cbPerso2.Text);
        }

        private void cbPerso3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPerso3.Checked) persos.Add(cbPerso3.Text);
            else persos.Remove(cbPerso3.Text);
        }

        private void cbPerso4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPerso4.Checked) persos.Add(cbPerso4.Text);
            else persos.Remove(cbPerso4.Text);
        }

        private void cbPersonnages_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPersonnages.Checked)
            {
                cbPerso1.Checked = true;
                cbPerso2.Checked = true;
                cbPerso3.Checked = true;
                cbPerso4.Checked = true;
            }
            else
            {
                cbPerso1.Checked = false;
                cbPerso2.Checked = false;
                cbPerso3.Checked = false;
                cbPerso4.Checked = false;               
            }

        }

        private void cbVocations_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVocations.Checked)
            {
                cbSommite.Checked = true;
                cbRanger.Checked = true;
                cbArmagicien.Checked = true;
                cbGladiateur.Checked = true;
                cbPaladin.Checked = true;
                cbTroubadour.Checked = true;
                cbVoleur.Checked = true;
                cbArtisteMartial.Checked = true;
                cbMage.Checked = true;
                cbPretre.Checked = true;
                cbGuerrier.Checked = true;
            }
            else
            {
                cbSommite.Checked = false;
                cbRanger.Checked = false;
                cbArmagicien.Checked = false;
                cbGladiateur.Checked = false;
                cbPaladin.Checked = false;
                cbTroubadour.Checked = false;
                cbVoleur.Checked = false;
                cbArtisteMartial.Checked = false;
                cbMage.Checked = false;
                cbPretre.Checked = false;
                cbGuerrier.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnPerso.Visible = true;
                btnVocation.Visible = false;
            }
            else
            {
                btnVocation.Visible = true;
                btnPerso.Visible = false;
            }
            
        }



    }

}
