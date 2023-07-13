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
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");
            carros.Add("HB20");

            lb_carros.DataSource = carros;
        }

        private void atualizaLb(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                atualizaLb(lb_carros, carros);
            }

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.Remove(tb_carro.Text);
            atualizaLb(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = lb_carros.Text;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizaLb(lb_carros, carros);
        }
    }
}
