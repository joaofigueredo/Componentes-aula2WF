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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            try
            {
                foreach (var i in clb_transportes.CheckedItems)
                {
                    txt += i + ", ";
                }

                MessageBox.Show(txt);
            }
            catch
            {
                MessageBox.Show("Nenhum item selecionado!");
            }


        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_novoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
            else
            {
                MessageBox.Show("Item vazio!");
            }
            
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Onibus");
            tr.Add("Trem");
            clb_transportes.Items.AddRange(tr.ToArray());

        }
    }
}