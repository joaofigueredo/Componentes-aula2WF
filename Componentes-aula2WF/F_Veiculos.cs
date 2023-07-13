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
    public partial class F_Veiculos : Form
    {
        //Criamos uma variavel do tipo F_Principal para ser acessada por toda pagina
        F_Principal fp;
        public F_Veiculos(String v, F_Principal f)
        {
            InitializeComponent();
            tb_listaVeiculos.Text = tb_listaVeiculos.Text + v;
            //Para que fp tenha as propriedades do f que foi passado por parametro
            fp = f;
            f.num = 10;

        }

        private void F_Veiculos_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text;
        }
    }
}
