using MusicAtoutV1_Gautret_Ethan.Models;

namespace MusicAtoutV1_Gautret_Ethan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bsVille.DataSource = ModelProjet.listeVille();
            dgvVille.DataSource = bsVille;
            dgvVille.Columns[0].Visible = false;
            dgvVille.Columns[1].HeaderText = "Nom de la ville";
            dgvVille.Columns[2].HeaderText = "N°Département";
            dgvVille.Columns[3].Visible = false;
        }

        private void dgvVille_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsVille_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
