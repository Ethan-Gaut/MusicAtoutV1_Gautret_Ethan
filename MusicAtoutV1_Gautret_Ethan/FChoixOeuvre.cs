using MusicAtoutV1_Gautret_Ethan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_Gautret_Ethan
{
    public partial class FChoixOeuvre : Form
    {
        public FChoixOeuvre()
        {
            InitializeComponent();
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void FChoixOeuvre_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            bsOeuvre.DataSource = ModelProjet.listeOeuvre();
            cboStyle.DataSource = bsStyle;



        }



        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            Style leStyleChoisie = (Style)bsStyle.Current;
            txtDebut.Text = leStyleChoisie.DateDebut.ToString();
            txtFin.Text = leStyleChoisie.DateFin.ToString();
            txtSty.Text = leStyleChoisie.LibStyle.ToString();
            bsCompo.DataSource = leStyleChoisie.Compositeurs.ToList();
            dgvCompositeur.DataSource = bsCompo;
            dgvCompositeur.Columns[0].Visible = false;
            dgvCompositeur.Columns[1].Visible = false;
            dgvCompositeur.Columns[2].Visible = false;
            dgvCompositeur.Columns[3].HeaderText = "Nom";
            dgvCompositeur.Columns[4].HeaderText = "Prénom";
            dgvCompositeur.Columns[5].Visible = false;
            dgvCompositeur.Columns[6].Visible = false;
            dgvCompositeur.Columns[7].Visible = false;
            dgvCompositeur.Columns[8].Visible = false;
            dgvCompositeur.Columns[9].Visible = false;
            dgvCompositeur.Columns[10].Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsCompo_CurrentChanged(object sender, EventArgs e)
        {
            Compositeur leCompositeurChoisie = (Compositeur)bsCompo.Current;
            txtNP.Text = leCompositeurChoisie.NomCompositeur.Trim() + " " + leCompositeurChoisie.PrenomCompositeur;
            txtNai.Text = leCompositeurChoisie.AnNais.ToString();
            txtdec.Text = leCompositeurChoisie.AnMort.ToString();
            txtRem.Text = leCompositeurChoisie.Remarque.ToString();
            txtNat.Text = leCompositeurChoisie.IdNationNavigation.LibNation;

            if (leCompositeurChoisie.Oeuvres.ToList().Count > 0)
            {
                dgvOeuvre.Visible = true;
                bsOeuvre.DataSource = leCompositeurChoisie.Oeuvres.ToList();
                dgvOeuvre.DataSource = bsOeuvre;
                dgvOeuvre.Columns[3].HeaderText = "Oeuvre";
                dgvOeuvre.Columns[4].HeaderText = "Composition";
                dgvOeuvre.Columns[0].Visible = false;
                dgvOeuvre.Columns[1].Visible = false;
                dgvOeuvre.Columns[2].Visible = false;
                dgvOeuvre.Columns[5].Visible = false;
                dgvOeuvre.Columns[6].Visible = false;
                dgvOeuvre.Columns[7].Visible = false;
            }
            else
            {
                dgvOeuvre.Visible = false;
            }


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bsOeuvre_CurrentChanged(object sender, EventArgs e)
        {



        }

        private void txtNat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCompositeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
