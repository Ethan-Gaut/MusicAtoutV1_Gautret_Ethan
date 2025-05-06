using Microsoft.IdentityModel.Tokens;
using MusicAtoutV1_Gautret_Ethan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MusicAtoutV1_Gautret_Ethan
{
    public partial class FAjoutModif : Form
    {
        public FAjoutModif()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FAjoutModif_Load(object sender, EventArgs e)
        {
            cboNation.ValueMember = "idNation";//permet de stocker l'identifiant
            cboNation.DisplayMember = "libNation";
            bsNation.DataSource = ModelProjet.listeNationalite();
            cboNation.DataSource = bsNation;



            cboStyle.ValueMember = "idSyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DataSource = bsStyle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((test()) && (ModelProjet.ActionGestionCompositeur == 1))
            {
                ModelProjet.AjoutCompositeur((txtNom.Text),(txtPrenom.Text),(txtRemarque.Text),int.Parse(txtNaiss.Text), int.Parse(txtMort.Text),((Nationalite)bsNation.Current).IdNation,((Style)bsStyle.Current).IdStyle);
                MessageBox.Show("ajout réussi");
                this.Close();
            }
            else if((test()) && (ModelProjet.ActionGestionCompositeur== 2))
            {
                ModelProjet.ModifCompositeur((txtNom.Text), (txtPrenom.Text), (txtRemarque.Text), int.Parse(txtNaiss.Text), int.Parse(txtMort.Text), ((Nationalite)bsNation.Current).IdNation, ((Style)bsStyle.Current).IdStyle);
                MessageBox.Show("modification réussi");
                this.Close();
            }
        }


        private bool test()
        {
            bool vretour = true;
            error1.Clear();
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                error1.SetError(txtNom, "Le nom du compositeur doit être renseigné.");
                vretour = false;
            }
            if (string.IsNullOrEmpty(txtPrenom.Text))
            {
                error1.SetError(txtPrenom, "Le prénom du compositeur doit être renseigné.");
                vretour = false;
            }
            if (string.IsNullOrEmpty(txtRemarque.Text))
            {
                error1.SetError(txtRemarque, "La remarque du compositeur doit être renseigné.");
                vretour = false;
            }
            if (!txtNaiss.Text.IsNullOrEmpty())
            {
                int date;
                if (int.TryParse(txtNaiss.Text, out date))
                {
                }
                else
                {
                    error1.SetError(txtNaiss, "La naissance du compositeur doit être renseigné.");
                    vretour = false;
                }
            }
            if (!txtMort.Text.IsNullOrEmpty())
            {
                int date1;
                if (int.TryParse(txtMort.Text, out date1))
                {
                    if (int.Parse(txtMort.Text) < int.Parse(txtNaiss.Text))
                    {
                        error1.SetError(txtMort, "La mort du compositeur doit être renseigné.");
                        vretour = false;
                    }
                    else
                    {
                    }
                }
                else
                {
                    error1.SetError(txtMort, "La mort du compositeur doit être renseigné.");
                    vretour = false;
                }


            }

            return vretour;
        }

        private void bsCompo_CurrentChanged(object sender, EventArgs e)
        {
            System.Type type = bsCompo.Current.GetType();
            int id = (int)type.GetProperty("idCompositeur").GetValue(bsCompo.Current, null);
            /* txtNaiss.Text = ModelProjet.CompositeurChoisi.AnNais.ToString();
             txtMort.Text = ModelProjet.CompositeurChoisi.AnMort.ToString();
             txtRemarque.Text = ModelProjet.CompositeurChoisi.Remarque.ToString();
             txtNom.Text = ModelProjet.CompositeurChoisi.NomCompositeur.ToString();
             txtPrenom.Text = ModelProjet.CompositeurChoisi.PrenomCompositeur.ToString();*/
        }
    }
}
