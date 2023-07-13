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
    public partial class F_numericUpDown : Form
    {
        public F_numericUpDown()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Decimal.Parse(tb_numero.Text) > nup_1.Maximum || Decimal.Parse(tb_numero.Text) < nup_1.Minimum)
            {
                MessageBox.Show("Valor fora do maximo e minimo!");
                tb_numero.Clear();
                tb_numero.Focus();
            }
            else 
            {
                nup_1.Value = Decimal.Parse(tb_numero.Text);
                tb_numero.Focus(); 
            }
            
        }
    }
}