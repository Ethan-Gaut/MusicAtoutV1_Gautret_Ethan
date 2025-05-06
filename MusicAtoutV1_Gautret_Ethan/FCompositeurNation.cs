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

namespace MusicAtoutV1_Gautret_Ethan
{
    public partial class FCompositeurNation : Form
    {
        public FCompositeurNation()
        {
            InitializeComponent();
        }

        private void FCompositeurNation_Load(object sender, EventArgs e)
        {
            cboNation.ValueMember = "idNation";//permet de stocker l'identifiant
            cboNation.DisplayMember = "libNation";
            bsNation.DataSource = ModelProjet.listeNationalite();
            cboNation.DataSource = bsNation;

        }

        private void bsNation_CurrentChanged(object sender, EventArgs e)
        {
            Nationalite laNationaliteChoisie = (Nationalite)bsNation.Current;
            bsCompo.DataSource = laNationaliteChoisie.Compositeurs.Select(x => new { x.NomCompositeur, x.PrenomCompositeur, x.IdStyleNavigation.LibStyle, x.AnNais, x.AnMort, x.Remarque, x.IdCompositeur }).OrderBy(x => x.NomCompositeur).ToList(); ;
            dgvCompo.DataSource = bsCompo;
            dgvCompo.Columns[0].HeaderText = "NOM";
            dgvCompo.Columns[1].HeaderText = "PRENOM";
            dgvCompo.Columns[2].HeaderText = "STYLE";
            dgvCompo.Columns[3].HeaderText = "Né le";
            dgvCompo.Columns[4].HeaderText = "Mort le";
            dgvCompo.Columns[5].HeaderText = "Informations";
            dgvCompo.Columns[6].Visible = false;
            dgvCompo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

        private void cboNation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red)
            {
                cboNation.Enabled = false;
                button1.BackColor = Color.Green;
                dgvCompo.DataSource = ModelProjet.listeCompositeur();
            }
            else
            {
                cboNation.Enabled = true;
                button1.BackColor = Color.Red;
                dgvCompo.DataSource = bsCompo;
            }
        }

        private void bsCompo_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAjoutModif FAjoutModif = new FAjoutModif();
            FAjoutModif.Visible = true;
            ModelProjet.ActionGestionCompositeur = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Type type = bsCompo.Current.GetType();
            int id = (int)type.GetProperty("IdCompositeur").GetValue(bsCompo.Current, null);
            FAjoutModif FAjoutModif = new FAjoutModif();
            ModelProjet.ActionGestionCompositeur = 2;
            FAjoutModif.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer le compositeur :" + ModelProjet.CompositeurChoisi.PrenomCompositeur.Trim() + " - " + ModelProjet.CompositeurChoisi.NomCompositeur.Trim(), "Suppression", MessageBoxButtons.OKCancel) == DialogResult.OK);
        }
    }
}
