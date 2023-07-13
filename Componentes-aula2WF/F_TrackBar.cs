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
    public partial class F_TrackBar : Form
    {
        public F_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tb_valor.Text = trackBar1.Value.ToString();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tb_valor.Text) <= trackBar1.Maximum && Convert.ToInt32(tb_valor.Text) >= trackBar1.Minimum)
            {
                trackBar1.Value = Convert.ToInt32(tb_valor.Text);
                tb_valor.Clear();
                tb_valor.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Valor fora do intervalo permitido!");
                tb_valor.Clear();
                tb_valor.Focus();
                return;
            }

        }

        
    }
}
