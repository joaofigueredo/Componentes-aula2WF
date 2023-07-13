using Componentes_aula2WF.Properties;

namespace Componentes_aula2WF
{
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "")
            {
                MessageBox.Show("Veiculo Invalido");
                tb_veiculo.Focus();
                //Return sai do evento if
                return;
            }

            tb_listaVeiculos.Text += tb_veiculo.Text + ", ";

            tb_veiculo.Clear();
            tb_veiculo.Focus();


        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaVeiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_Veiculos f_veiculos = new F_Veiculos(tb_listaVeiculos.Text, this);
            f_veiculos.Show();
        }

        private void btn_valNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void tb_listaVeiculos_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_checkBox = new F_CheckBox();
            f_checkBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_checkedListBox = new F_CheckedListBox();
            f_checkedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_Combo = new F_ComboBox();
            f_Combo.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_date = new F_DateTimePicker();
            f_date.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_linkLabel = new F_LinkLabel();
            f_linkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_listBox = new F_ListBox();
            f_listBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_listView = new F_ListView();
            f_listView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_masked = new F_MaskedTextBox();
            f_masked.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_monthCalendar = new F_MonthCalendar();
            f_monthCalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsmi_Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_Mensagem")
            {
                MessageBox.Show("Curso de Windows Forms");
            }
        }

        private void numericUpDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_numericUpDown f_numericUpDown = new F_numericUpDown();
            f_numericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_pictureBox f_picture = new F_pictureBox();
            f_picture.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_progressBar = new F_ProgressBar();
            f_progressBar.ShowDialog();

        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButton f_radioButton = new F_RadioButton();
            f_radioButton.ShowDialog();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TrackBar f_trackBar = new F_TrackBar();
            f_trackBar.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView f_treeView = new F_TreeView();
            f_treeView.ShowDialog();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SplitContainer f_splitContainer = new F_SplitContainer();
            f_splitContainer.ShowDialog();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TabControl f_tabControl = new F_TabControl();
            f_tabControl.ShowDialog();
        }

        private void tableLayoutPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TableLayoutPanel f_TableLayout = new F_TableLayoutPanel();
            f_TableLayout.ShowDialog();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ToolStripContainer f_toolStripContainer = new F_ToolStripContainer();
            f_toolStripContainer.ShowDialog();
        }

        private void backgroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BackgroundWorker f_backgroundWorker = new F_BackgroundWorker();
            f_backgroundWorker.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Timer f_timer = new F_Timer();
            f_timer.ShowDialog();
        }
    }
}