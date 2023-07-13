namespace Componentes_aula2WF
{
    partial class F_TabControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tab_componentes = new TabPage();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            tb_nomeNovaPagina = new TextBox();
            btn_novaTab = new Button();
            btn_removerTabAtual = new Button();
            numericUpDown1 = new NumericUpDown();
            btn_posicionarTab = new Button();
            tabControl1.SuspendLayout();
            tab_componentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_componentes);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 92);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(795, 355);
            tabControl1.TabIndex = 0;
            // 
            // tab_componentes
            // 
            tab_componentes.Controls.Add(textBox1);
            tab_componentes.Controls.Add(button1);
            tab_componentes.Controls.Add(label1);
            tab_componentes.Location = new Point(4, 29);
            tab_componentes.Name = "tab_componentes";
            tab_componentes.Padding = new Padding(3);
            tab_componentes.Size = new Size(787, 322);
            tab_componentes.TabIndex = 0;
            tab_componentes.Text = "Componentes";
            tab_componentes.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(41, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(41, 120);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 64);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(787, 322);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_nomeNovaPagina
            // 
            tb_nomeNovaPagina.BorderStyle = BorderStyle.FixedSingle;
            tb_nomeNovaPagina.Location = new Point(12, 22);
            tb_nomeNovaPagina.Name = "tb_nomeNovaPagina";
            tb_nomeNovaPagina.Size = new Size(150, 27);
            tb_nomeNovaPagina.TabIndex = 1;
            // 
            // btn_novaTab
            // 
            btn_novaTab.Location = new Point(190, 20);
            btn_novaTab.Name = "btn_novaTab";
            btn_novaTab.Size = new Size(171, 29);
            btn_novaTab.TabIndex = 2;
            btn_novaTab.Text = "Nova Aba";
            btn_novaTab.UseVisualStyleBackColor = true;
            btn_novaTab.Click += btn_novaTab_Click;
            // 
            // btn_removerTabAtual
            // 
            btn_removerTabAtual.Location = new Point(382, 22);
            btn_removerTabAtual.Name = "btn_removerTabAtual";
            btn_removerTabAtual.Size = new Size(171, 29);
            btn_removerTabAtual.TabIndex = 3;
            btn_removerTabAtual.Text = "Remover Aba Atual";
            btn_removerTabAtual.UseVisualStyleBackColor = true;
            btn_removerTabAtual.Click += btn_removerTabAtual_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 57);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // btn_posicionarTab
            // 
            btn_posicionarTab.Location = new Point(190, 57);
            btn_posicionarTab.Name = "btn_posicionarTab";
            btn_posicionarTab.Size = new Size(171, 29);
            btn_posicionarTab.TabIndex = 5;
            btn_posicionarTab.Text = "Posicionar na tab";
            btn_posicionarTab.UseVisualStyleBackColor = true;
            btn_posicionarTab.Click += btn_posicionarTab_Click;
            // 
            // F_TabControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_posicionarTab);
            Controls.Add(numericUpDown1);
            Controls.Add(btn_removerTabAtual);
            Controls.Add(btn_novaTab);
            Controls.Add(tb_nomeNovaPagina);
            Controls.Add(tabControl1);
            Name = "F_TabControl";
            Text = " ";
            Load += F_TabControl_Load;
            tabControl1.ResumeLayout(false);
            tab_componentes.ResumeLayout(false);
            tab_componentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab_componentes;
        private TabPage tabPage2;
        private TextBox tb_nomeNovaPagina;
        private Button btn_novaTab;
        private Button btn_removerTabAtual;
        private NumericUpDown numericUpDown1;
        private Button btn_posicionarTab;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
    }
}