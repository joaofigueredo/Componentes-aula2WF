namespace Componentes_aula2WF
{
    partial class F_CheckedListBox
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
            clb_transportes = new CheckedListBox();
            btn_mostrarSelecionados = new Button();
            btn_limparLista = new Button();
            btn_resetar = new Button();
            btn_adicionar = new Button();
            tb_novoTransporte = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // clb_transportes
            // 
            clb_transportes.FormattingEnabled = true;
            clb_transportes.Items.AddRange(new object[] { "Carro", "Avião", "Navio", "Onibus", "Trem" });
            clb_transportes.Location = new Point(12, 12);
            clb_transportes.Name = "clb_transportes";
            clb_transportes.Size = new Size(161, 422);
            clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            btn_mostrarSelecionados.Location = new Point(187, 12);
            btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            btn_mostrarSelecionados.Size = new Size(275, 29);
            btn_mostrarSelecionados.TabIndex = 1;
            btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            btn_mostrarSelecionados.Click += button1_Click;
            // 
            // btn_limparLista
            // 
            btn_limparLista.Location = new Point(187, 47);
            btn_limparLista.Name = "btn_limparLista";
            btn_limparLista.Size = new Size(275, 27);
            btn_limparLista.TabIndex = 2;
            btn_limparLista.Text = "Limpar";
            btn_limparLista.UseVisualStyleBackColor = true;
            btn_limparLista.Click += btn_limparLista_Click;
            // 
            // btn_resetar
            // 
            btn_resetar.Location = new Point(187, 80);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(275, 29);
            btn_resetar.TabIndex = 3;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = true;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(105, 530);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(275, 29);
            btn_adicionar.TabIndex = 4;
            btn_adicionar.Text = "Adicionar na lista";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // tb_novoTransporte
            // 
            tb_novoTransporte.BorderStyle = BorderStyle.FixedSingle;
            tb_novoTransporte.Location = new Point(12, 497);
            tb_novoTransporte.Name = "tb_novoTransporte";
            tb_novoTransporte.Size = new Size(482, 27);
            tb_novoTransporte.TabIndex = 5;
            tb_novoTransporte.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 446);
            label1.Name = "label1";
            label1.Size = new Size(309, 35);
            label1.TabIndex = 6;
            label1.Text = "Digite um novo transporte";
            // 
            // F_CheckedListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 642);
            Controls.Add(label1);
            Controls.Add(tb_novoTransporte);
            Controls.Add(btn_adicionar);
            Controls.Add(btn_resetar);
            Controls.Add(btn_limparLista);
            Controls.Add(btn_mostrarSelecionados);
            Controls.Add(clb_transportes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckedListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckedListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clb_transportes;
        private Button btn_mostrarSelecionados;
        private Button btn_limparLista;
        private Button btn_resetar;
        private Button btn_adicionar;
        private TextBox tb_novoTransporte;
        private Label label1;
    }
}