using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_aula2WF
{
    public partial class F_CheckBox : Form
    {
        List<CheckBox> transp = new List<CheckBox>();

        public F_CheckBox()
        {
            InitializeComponent();

            transp.Add(cb_Carro);
            transp.Add(cb_Aviao);
            transp.Add(cb_Navio);
            transp.Add(cb_Onibus);
        }

        private void F_CheckBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox t in transp)
            {
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

        private void cb_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Patinete.Checked)
            {
                MessageBox.Show("Patinete marcado");
            }
        }

        private void btn_filho_Click(object sender, EventArgs e)
        {
            f_filhoCheckBox fFilho = new f_filhoCheckBox();
            fFilho.ShowDialog();
        }

        private void cb_Carro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_Aviao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
