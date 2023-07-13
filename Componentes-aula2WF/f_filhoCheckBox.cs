using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Componentes_aula2WF
{
    public partial class f_filhoCheckBox : Form
    {
        public F_CheckBox fcb;

        public f_filhoCheckBox()
        {
            InitializeComponent();
           
            //Verificar se o formulario foi criado
            try
            {
                //Pegar os dados do formulario "pai" F_CheckBox
                //as é usado para converter do tipo form para o tipo F _CheckBox
                fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                cb_Carro.Checked = fcb.cb_Carro.Checked;
                cb_Aviao.Checked = fcb.cb_Aviao.Checked;
                cb_Navio.Checked = fcb.cb_Navio.Checked;
                cb_Onibus.Checked = fcb.cb_Onibus.Checked;
            }
            catch 
            {
                MessageBox.Show("Erro ao abrir Formulario!");
            }
            
        }

        private void cb_Carro_CheckedChanged(object sender, EventArgs e)
        {
            //usado para o que for marcado no filho tambem ser marcado no form pai
            fcb.cb_Carro.Checked = cb_Carro.Checked;
        }

        private void cb_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            //usado para o que for marcado no filho tambem ser marcado no form pai
            fcb.cb_Aviao.Checked = cb_Aviao.Checked;
        }

        private void cb_Navio_CheckedChanged(object sender, EventArgs e)
        {
            //usado para o que for marcado no filho tambem ser marcado no form pai
            fcb.cb_Navio.Checked = cb_Navio.Checked;
        }

        private void cb_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            //usado para o que for marcado no filho tambem ser marcado no form pai
            fcb.cb_Onibus.Checked = cb_Onibus.Checked;
        }
    }
}
