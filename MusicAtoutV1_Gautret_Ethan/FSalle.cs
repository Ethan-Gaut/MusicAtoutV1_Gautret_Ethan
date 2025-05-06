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
    public partial class FSalle : Form
    {
        public FSalle()
        {
            InitializeComponent();
        }


        private void bsSalle_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvSalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FSalle_Load_1(object sender, EventArgs e)
        {

            bsSalle.DataSource = ModelProjet.listeSalle();
            dgvSalle.DataSource = bsSalle;

        }
    }
}
