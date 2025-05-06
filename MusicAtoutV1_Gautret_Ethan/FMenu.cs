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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        }

        private void villeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Visible = true;
        }

        private void sallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSalle FSalle = new FSalle();
            FSalle.Visible = true;
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void batimentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FBatiment FBatiment = new FBatiment();
            FBatiment.Visible = true;
        }

        private void typesDoeuvreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FType FType = new FType();
            FType.Visible = true;
        }

        private void parNationalitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCompositeurNation FCompositeurNation = new FCompositeurNation();
            FCompositeurNation.Visible = true;
        }

        private void parStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FStyle FStyle = new FStyle();
            FStyle.Visible = true;
        }

        private void oeuvreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChoixOeuvre FChoixOeuvre = new FChoixOeuvre();
            FChoixOeuvre.Visible = true;
        }
    }
}
