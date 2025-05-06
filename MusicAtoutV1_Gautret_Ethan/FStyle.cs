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
    public partial class FStyle : Form
    {
        public FStyle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FStyle_Load(object sender, EventArgs e)
        {
            cboStyle.ValueMember = "idStyle";//permet de stocker l'identifiant
            cboStyle.DisplayMember = "libStyle";
            bsStyle.DataSource = ModelProjet.listeStyle();
            cboStyle.DataSource = bsStyle;
        }

        private void bsStyle_CurrentChanged(object sender, EventArgs e)
        {
            Style leStyleChoisie = (Style)bsStyle.Current;
            bsCompo.DataSource = leStyleChoisie.Compositeurs.Select(x => new { x.NomCompositeur, x.PrenomCompositeur, x.IdStyleNavigation.LibStyle, x.AnNais, x.AnMort, x.Remarque, x.IdCompositeur }).OrderBy(x => x.NomCompositeur).ToList(); ;
            dgvCompositeur.DataSource = bsCompo;
            dgvCompositeur.Columns[0].HeaderText = "NOM";
            dgvCompositeur.Columns[1].HeaderText = "PRENOM";
            dgvCompositeur.Columns[2].Visible = false;
            dgvCompositeur.Columns[3].HeaderText = "Né le";
            dgvCompositeur.Columns[4].HeaderText = "Mort le";
            dgvCompositeur.Columns[5].HeaderText = "Informations";
            dgvCompositeur.Columns[6].Visible = false;
            txtDebut.Text = leStyleChoisie.DateDebut.ToString();
            txtFin.Text = leStyleChoisie.DateFin.ToString();
            dgvCompositeur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}