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
    public partial class FType : Form
    {
        public FType()
        {
            InitializeComponent();
        }

        private void FType_Load(object sender, EventArgs e)
        {
            bsType.DataSource = ModelProjet.listeTypeoeuvre();
            dgvType.DataSource = bsType;
        }
    }
}
