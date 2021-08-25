using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoIA
{
    public partial class GrupoRiscoForm : Form
    {
        Sintomas s = new Sintomas();
        public GrupoRiscoForm()
        {
            InitializeComponent();
        }

        private void btnSimGrupoRisco_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.Diagnostico());
        }

        private void btnNaoGrupoRisco_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.Diagnostico());
        }
    }
}
