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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {

            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            cb_transportes.Text = "";
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Avião");
            cb_transportes.Items.Add("Navio");
            cb_transportes.Items.Add("Onibus");
            cb_transportes.Items.Add("Trem");

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            if(tb_transporte.Text != "")
            {
                //Verificar se o item ja existe, se resultado for 0 ou maior q 0 é true
                if (cb_transportes.FindString(tb_transporte.Text) < 0)
                {
                    cb_transportes.Items.Add(tb_transporte.Text);
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                else
                {
                    MessageBox.Show("Item já existente");
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Texto Vazio!");
            }
            
        }
    }
}
