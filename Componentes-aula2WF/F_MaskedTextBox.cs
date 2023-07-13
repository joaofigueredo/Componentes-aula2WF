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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cb_SomenteTexto.Checked)
            {
                mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                MessageBox.Show(mtb_cpf.Text);
            }
            else
            {
                mtb_cpf.TextMaskFormat = MaskFormat.IncludeLiterals;
                MessageBox.Show(mtb_cpf.Text);
            }
            
        }
    }
}
