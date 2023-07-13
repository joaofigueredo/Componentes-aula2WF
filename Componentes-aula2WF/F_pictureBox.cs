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
    public partial class F_pictureBox : Form
    {
        public F_pictureBox()
        {
            InitializeComponent();
        }

        private void F_pictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCanal;
            label2.Text = Properties.Resources.EndereçoCanal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.torcida_flamengojpg;
        }
    }
}
