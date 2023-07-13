namespace Componentes_aula2WF
{
    partial class F_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            btn_adicionar = new Button();
            tb_veiculo = new TextBox();
            label1 = new Label();
            tb_listaVeiculos = new TextBox();
            btn_limpar = new Button();
            btn_mostrar = new Button();
            btn_valNum = new Button();
            menuStrip1 = new MenuStrip();
            componentesToolStripMenuItem = new ToolStripMenuItem();
            checkBoxToolStripMenuItem = new ToolStripMenuItem();
            checkedListBoxToolStripMenuItem = new ToolStripMenuItem();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            dateTimePickerToolStripMenuItem = new ToolStripMenuItem();
            linkLabelToolStripMenuItem = new ToolStripMenuItem();
            listBoxToolStripMenuItem = new ToolStripMenuItem();
            listViewToolStripMenuItem = new ToolStripMenuItem();
            maskedTextBoxToolStripMenuItem = new ToolStripMenuItem();
            monthCalendarToolStripMenuItem = new ToolStripMenuItem();
            numericUpDToolStripMenuItem = new ToolStripMenuItem();
            pictureBoxToolStripMenuItem = new ToolStripMenuItem();
            progressBarToolStripMenuItem = new ToolStripMenuItem();
            radioButtonToolStripMenuItem = new ToolStripMenuItem();
            trackBarToolStripMenuItem = new ToolStripMenuItem();
            treeViewToolStripMenuItem = new ToolStripMenuItem();
            splitContainerToolStripMenuItem = new ToolStripMenuItem();
            tabControlToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanelToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainerToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorkerToolStripMenuItem = new ToolStripMenuItem();
            notifyIcon1 = new NotifyIcon(components);
            MenuNotificacoes = new ContextMenuStrip(components);
            tsmi_restaurar = new ToolStripMenuItem();
            tsmi_Mensagem = new ToolStripMenuItem();
            tsmi_Fechar = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            MenuNotificacoes.SuspendLayout();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(208, 61);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(91, 27);
            btn_adicionar.TabIndex = 0;
            btn_adicionar.Text = "Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // tb_veiculo
            // 
            tb_veiculo.BorderStyle = BorderStyle.FixedSingle;
            tb_veiculo.Location = new Point(12, 62);
            tb_veiculo.Name = "tb_veiculo";
            tb_veiculo.Size = new Size(170, 27);
            tb_veiculo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 2;
            label1.Text = "Digite um veiculo";
            // 
            // tb_listaVeiculos
            // 
            tb_listaVeiculos.BorderStyle = BorderStyle.FixedSingle;
            tb_listaVeiculos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_listaVeiculos.Location = new Point(12, 117);
            tb_listaVeiculos.Multiline = true;
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.Size = new Size(287, 370);
            tb_listaVeiculos.TabIndex = 3;
            tb_listaVeiculos.TextChanged += tb_listaVeiculos_TextChanged;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(33, 518);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(266, 29);
            btn_limpar.TabIndex = 4;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(33, 574);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(266, 29);
            btn_mostrar.TabIndex = 5;
            btn_mostrar.Text = "Mostrar Veiculos";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // btn_valNum
            // 
            btn_valNum.Location = new Point(33, 626);
            btn_valNum.Name = "btn_valNum";
            btn_valNum.Size = new Size(304, 29);
            btn_valNum.TabIndex = 6;
            btn_valNum.Text = "Valor da variavel Num";
            btn_valNum.UseVisualStyleBackColor = true;
            btn_valNum.Click += btn_valNum_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { componentesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(324, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            componentesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkBoxToolStripMenuItem, checkedListBoxToolStripMenuItem, comboBoxToolStripMenuItem, dateTimePickerToolStripMenuItem, linkLabelToolStripMenuItem, listBoxToolStripMenuItem, listViewToolStripMenuItem, maskedTextBoxToolStripMenuItem, monthCalendarToolStripMenuItem, numericUpDToolStripMenuItem, pictureBoxToolStripMenuItem, progressBarToolStripMenuItem, radioButtonToolStripMenuItem, trackBarToolStripMenuItem, treeViewToolStripMenuItem, splitContainerToolStripMenuItem, tabControlToolStripMenuItem, tableLayoutPanelToolStripMenuItem, toolStripContainerToolStripMenuItem, backgroundWorkerToolStripMenuItem, timerToolStripMenuItem });
            componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            componentesToolStripMenuItem.Size = new Size(115, 24);
            componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(224, 26);
            checkBoxToolStripMenuItem.Text = "CheckBox";
            checkBoxToolStripMenuItem.Click += checkBoxToolStripMenuItem_Click;
            // 
            // checkedListBoxToolStripMenuItem
            // 
            checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            checkedListBoxToolStripMenuItem.Size = new Size(224, 26);
            checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            checkedListBoxToolStripMenuItem.Click += checkedListBoxToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(224, 26);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            comboBoxToolStripMenuItem.Click += comboBoxToolStripMenuItem_Click;
            // 
            // dateTimePickerToolStripMenuItem
            // 
            dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            dateTimePickerToolStripMenuItem.Size = new Size(224, 26);
            dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            dateTimePickerToolStripMenuItem.Click += dateTimePickerToolStripMenuItem_Click;
            // 
            // linkLabelToolStripMenuItem
            // 
            linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            linkLabelToolStripMenuItem.Size = new Size(224, 26);
            linkLabelToolStripMenuItem.Text = "Link \\ LinkLabel";
            linkLabelToolStripMenuItem.Click += linkLabelToolStripMenuItem_Click;
            // 
            // listBoxToolStripMenuItem
            // 
            listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            listBoxToolStripMenuItem.Size = new Size(224, 26);
            listBoxToolStripMenuItem.Text = "ListBox";
            listBoxToolStripMenuItem.Click += listBoxToolStripMenuItem_Click;
            // 
            // listViewToolStripMenuItem
            // 
            listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            listViewToolStripMenuItem.Size = new Size(224, 26);
            listViewToolStripMenuItem.Text = "ListView";
            listViewToolStripMenuItem.Click += listViewToolStripMenuItem_Click;
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            maskedTextBoxToolStripMenuItem.Size = new Size(224, 26);
            maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            maskedTextBoxToolStripMenuItem.Click += maskedTextBoxToolStripMenuItem_Click;
            // 
            // monthCalendarToolStripMenuItem
            // 
            monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            monthCalendarToolStripMenuItem.Size = new Size(224, 26);
            monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            monthCalendarToolStripMenuItem.Click += monthCalendarToolStripMenuItem_Click;
            // 
            // numericUpDToolStripMenuItem
            // 
            numericUpDToolStripMenuItem.Name = "numericUpDToolStripMenuItem";
            numericUpDToolStripMenuItem.Size = new Size(224, 26);
            numericUpDToolStripMenuItem.Text = "NumericUpDown";
            numericUpDToolStripMenuItem.Click += numericUpDToolStripMenuItem_Click;
            // 
            // pictureBoxToolStripMenuItem
            // 
            pictureBoxToolStripMenuItem.Name = "pictureBoxToolStripMenuItem";
            pictureBoxToolStripMenuItem.Size = new Size(224, 26);
            pictureBoxToolStripMenuItem.Text = "PictureBox";
            pictureBoxToolStripMenuItem.Click += pictureBoxToolStripMenuItem_Click;
            // 
            // progressBarToolStripMenuItem
            // 
            progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            progressBarToolStripMenuItem.Size = new Size(224, 26);
            progressBarToolStripMenuItem.Text = "ProgressBar";
            progressBarToolStripMenuItem.Click += progressBarToolStripMenuItem_Click;
            // 
            // radioButtonToolStripMenuItem
            // 
            radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            radioButtonToolStripMenuItem.Size = new Size(224, 26);
            radioButtonToolStripMenuItem.Text = "RadioButton";
            radioButtonToolStripMenuItem.Click += radioButtonToolStripMenuItem_Click;
            // 
            // trackBarToolStripMenuItem
            // 
            trackBarToolStripMenuItem.Name = "trackBarToolStripMenuItem";
            trackBarToolStripMenuItem.Size = new Size(224, 26);
            trackBarToolStripMenuItem.Text = "TrackBar";
            trackBarToolStripMenuItem.Click += trackBarToolStripMenuItem_Click;
            // 
            // treeViewToolStripMenuItem
            // 
            treeViewToolStripMenuItem.Name = "treeViewToolStripMenuItem";
            treeViewToolStripMenuItem.Size = new Size(224, 26);
            treeViewToolStripMenuItem.Text = "TreeView";
            treeViewToolStripMenuItem.Click += treeViewToolStripMenuItem_Click;
            // 
            // splitContainerToolStripMenuItem
            // 
            splitContainerToolStripMenuItem.Name = "splitContainerToolStripMenuItem";
            splitContainerToolStripMenuItem.Size = new Size(224, 26);
            splitContainerToolStripMenuItem.Text = "SplitContainer";
            splitContainerToolStripMenuItem.Click += splitContainerToolStripMenuItem_Click;
            // 
            // tabControlToolStripMenuItem
            // 
            tabControlToolStripMenuItem.Name = "tabControlToolStripMenuItem";
            tabControlToolStripMenuItem.Size = new Size(224, 26);
            tabControlToolStripMenuItem.Text = "TabControl";
            tabControlToolStripMenuItem.Click += tabControlToolStripMenuItem_Click;
            // 
            // tableLayoutPanelToolStripMenuItem
            // 
            tableLayoutPanelToolStripMenuItem.Name = "tableLayoutPanelToolStripMenuItem";
            tableLayoutPanelToolStripMenuItem.Size = new Size(224, 26);
            tableLayoutPanelToolStripMenuItem.Text = "TableLayoutPanel";
            tableLayoutPanelToolStripMenuItem.Click += tableLayoutPanelToolStripMenuItem_Click;
            // 
            // toolStripContainerToolStripMenuItem
            // 
            toolStripContainerToolStripMenuItem.Name = "toolStripContainerToolStripMenuItem";
            toolStripContainerToolStripMenuItem.Size = new Size(224, 26);
            toolStripContainerToolStripMenuItem.Text = "ToolStripContainer";
            toolStripContainerToolStripMenuItem.Click += toolStripContainerToolStripMenuItem_Click;
            // 
            // backgroundWorkerToolStripMenuItem
            // 
            backgroundWorkerToolStripMenuItem.Name = "backgroundWorkerToolStripMenuItem";
            backgroundWorkerToolStripMenuItem.Size = new Size(224, 26);
            backgroundWorkerToolStripMenuItem.Text = "BackgroundWorker";
            backgroundWorkerToolStripMenuItem.Click += backgroundWorkerToolStripMenuItem_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ContextMenuStrip = MenuNotificacoes;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Aprendendo Windows Forms";
            notifyIcon1.Visible = true;
            // 
            // MenuNotificacoes
            // 
            MenuNotificacoes.ImageScalingSize = new Size(20, 20);
            MenuNotificacoes.Items.AddRange(new ToolStripItem[] { tsmi_restaurar, tsmi_Mensagem, tsmi_Fechar });
            MenuNotificacoes.Name = "contextMenuStrip1";
            MenuNotificacoes.Size = new Size(152, 76);
            MenuNotificacoes.ItemClicked += MenuNotificacoes_ItemClicked;
            // 
            // tsmi_restaurar
            // 
            tsmi_restaurar.Name = "tsmi_restaurar";
            tsmi_restaurar.Size = new Size(151, 24);
            tsmi_restaurar.Text = "Restaurar";
            // 
            // tsmi_Mensagem
            // 
            tsmi_Mensagem.Name = "tsmi_Mensagem";
            tsmi_Mensagem.Size = new Size(151, 24);
            tsmi_Mensagem.Text = "Mensagem";
            // 
            // tsmi_Fechar
            // 
            tsmi_Fechar.Name = "tsmi_Fechar";
            tsmi_Fechar.Size = new Size(151, 24);
            tsmi_Fechar.Text = "Fechar";
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.Size = new Size(224, 26);
            timerToolStripMenuItem.Text = "Timer";
            timerToolStripMenuItem.Click += timerToolStripMenuItem_Click;
            // 
            // F_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 667);
            Controls.Add(btn_valNum);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_limpar);
            Controls.Add(tb_listaVeiculos);
            Controls.Add(label1);
            Controls.Add(tb_veiculo);
            Controls.Add(btn_adicionar);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "F_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Componentes";
            Load += F_Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            MenuNotificacoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private TextBox tb_veiculo;
        private Label label1;
        private Button btn_limpar;
        private Button btn_mostrar;
        private Button btn_valNum;
        public TextBox tb_listaVeiculos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private ToolStripMenuItem linkLabelToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private ToolStripMenuItem monthCalendarToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip MenuNotificacoes;
        private ToolStripMenuItem tsmi_restaurar;
        private ToolStripMenuItem tsmi_Mensagem;
        private ToolStripMenuItem tsmi_Fechar;
        private ToolStripMenuItem numericUpDToolStripMenuItem;
        private ToolStripMenuItem pictureBoxToolStripMenuItem;
        private ToolStripMenuItem progressBarToolStripMenuItem;
        private ToolStripMenuItem radioButtonToolStripMenuItem;
        private ToolStripMenuItem trackBarToolStripMenuItem;
        private ToolStripMenuItem treeViewToolStripMenuItem;
        private ToolStripMenuItem splitContainerToolStripMenuItem;
        private ToolStripMenuItem tabControlToolStripMenuItem;
        private ToolStripMenuItem tableLayoutPanelToolStripMenuItem;
        private ToolStripMenuItem toolStripContainerToolStripMenuItem;
        private ToolStripMenuItem backgroundWorkerToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
    }
}