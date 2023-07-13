using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes_aula2WF.Properties
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_Valor_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(tb_valor.Text) <= progressBar1.Maximum) && (Convert.ToInt32(tb_valor.Text) >= progressBar1.Minimum))
            {
                progressBar1.Value = Convert.ToInt32(tb_valor.Text);
            }
            else
            {
                MessageBox.Show("Valor invalido!");
            }
        }

        private void btn_preencher_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox1.Text);
            for (int i = 0; i <= int.Parse(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i;
                //Thread.Sleep(200);
            }

        }
    }
}
