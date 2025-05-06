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
    public partial class FBatiment : Form
    {
        public FBatiment()
        {
            InitializeComponent();
        }

        private void FBatiment_Load(object sender, EventArgs e)
        {
            bsBatiment.DataSource = ModelProjet.listeBatiment();
            dgvBatiment.DataSource = bsBatiment;
        }
    }
}
