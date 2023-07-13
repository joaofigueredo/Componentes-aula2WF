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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void lv_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_Produtos.SelectedIndices.Count > 0)
            {
                obter();
            }
           
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_Produtos.Items.RemoveAt(lv_Produtos.SelectedIndices[0]);
        }

        private void limpar()
        {
            tb_Id.Clear();
            tb_produto.Clear();
            tb_qtd.Clear();
            tb_preco.Clear();
            tb_Id.Focus();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {

            if (tb_Id.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio!");
                tb_Id.Focus();
                return;
            }
            if (tb_produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser vazio!");
                tb_Id.Focus();
                return;
            }
            if (tb_preco.Text == "")
            {
                MessageBox.Show("Preço não pode ser vazio!");
                tb_Id.Focus();
                return;
            }
            if (tb_qtd.Text == "")
            {
                MessageBox.Show("ID não pode ser vazio!");
                tb_Id.Focus();
                return;
            }
            string[] pr = new string[4];
            pr[0] = tb_Id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtd.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_Produtos.Items.Add(l);

            limpar();
        }

        private void obter()
        {
            tb_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtd.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_Id.Text = lv_Produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_Produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtd.Text = lv_Produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_Produtos.SelectedItems[0].SubItems[3].Text;
        }
    }
}
