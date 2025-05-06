using MusicAtoutV1_Gautret_Ethan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1_Gautret_Ethan
{
    public partial class FChangementMdp : Form
    {
        public FChangementMdp()
        {
            InitializeComponent();
        }

        private void btn_valid_Click(object sender, EventArgs e)
        {
            string ancien = tbAncienMdp.Text;
            string nouveau = tbNouveauMdp.Text;
            string confirmation = tbConfirmMdp.Text;

            if (ModelProjet.ChangeMdp(ancien, nouveau, confirmation))
            {
                MessageBox.Show("Mot de passe modifié avec succès !");
                this.Close();
            }
        }

        private void FChangementMdp_Load(object sender, EventArgs e)
        {

        }
    }
}
