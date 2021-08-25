using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIA
{
    public partial class SintomasForm : Form
    {
        Sintomas s = new Sintomas();
        public SintomasForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.ThreeState)
            {
                checkBox1.ThreeState = true;
                int dor = 1;
                s.Dor_de_cabeca(dor);
            }
            else
                checkBox1.ThreeState = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.ThreeState)
            {
                checkBox2.ThreeState = true;
                int febre = 1;
                s.Febre(febre);
            }
            else
                checkBox2.ThreeState = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s.Diagnostico());
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox3.ThreeState)
            {
                checkBox3.ThreeState = true;
                int tosse = 1;
                s.Tosse_seca(tosse);
            }
            else
                checkBox3.ThreeState = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox4.ThreeState)
            {
                checkBox4.ThreeState = true;
                int diarreira = 1;
                s.Diarreia(diarreira);
            }
            else
                checkBox4.ThreeState = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox5.ThreeState)
            {
                checkBox5.ThreeState = true;
                int dor = 1;
                s.Dores(dor);
            }
            else
                checkBox5.ThreeState = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox6.ThreeState)
            {
                checkBox6.ThreeState = true;
                int cansaco = 1;
                s.Cansaco(cansaco);
            }
            else
                checkBox6.ThreeState = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox7.ThreeState)
            {
                checkBox7.ThreeState = true;
                int conjutivite = 1;
                s.Conjutivite(conjutivite);
            }
            else
                checkBox7.ThreeState = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox8.ThreeState)
            {
                checkBox8.ThreeState = true;
                int dor = 1;
                s.Dor_de_garganta(dor);
            }
            else
                checkBox8.ThreeState = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox9.ThreeState)
            {
                checkBox9.ThreeState = true;
                int paladar = 1;
                s.Perda_paladar_respiracao(paladar);
            }
            else
                checkBox9.ThreeState = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox10.ThreeState)
            {
                checkBox10.ThreeState = true;
                int dificil = 1;
                s.Dificuldade_respirar(dificil);
            }
            else
                checkBox10.ThreeState = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox11.ThreeState)
            {
                checkBox11.ThreeState = true;
                int dor = 1;
                s.Dor_no_peito(dor);
            }
            else
                checkBox11.ThreeState = false;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox12.ThreeState)
            {
                checkBox12.ThreeState = true;
                int perda = 1;
                s.Perda_fala(perda);
            }
            else
                checkBox7.ThreeState = false;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox13.ThreeState)
            {
                checkBox13.ThreeState = true;
                int diabete = 1;
                s.Diabetes(diabete);
            }
            else
                checkBox13.ThreeState = false;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox14.ThreeState)
            {
                checkBox14.ThreeState = true;
                int alta = 1;
                s.Hipertensao(alta);
            }
            else
                checkBox14.ThreeState = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void limparcampos()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true ||
               checkBox3.Checked == true || checkBox4.Checked == true ||
               checkBox5.Checked == true || checkBox6.Checked == true ||
               checkBox7.Checked == true || checkBox8.Checked == true ||
               checkBox9.Checked == true || checkBox10.Checked == true ||
               checkBox11.Checked == true || checkBox12.Checked == true ||
               checkBox13.Checked == true || checkBox14.Checked == true)
            {
                //MessageBox.Show(s.Diagnostico());
                limparcampos();
                this.Hide();
                GrupoRiscoForm grupoRisco = new GrupoRiscoForm();
                grupoRisco.Show();
            }
            else
            {
                MessageBox.Show("Nenhum Campo Preenchido");

            }


        }
    }
}
