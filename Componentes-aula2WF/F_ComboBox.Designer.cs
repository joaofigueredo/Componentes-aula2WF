namespace Componentes_aula2WF
{
    partial class F_ComboBox
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
            cb_transportes = new ComboBox();
            btn_mostrarSelecionado = new Button();
            btn_Limpar = new Button();
            btn_resetar = new Button();
            btn_adicionar = new Button();
            tb_transporte = new TextBox();
            SuspendLayout();
            // 
            // cb_transportes
            // 
            cb_transportes.FormattingEnabled = true;
            cb_transportes.Items.AddRange(new object[] { "Carro", "Avião", "Navio", "Onibus", "Trem" });
            cb_transportes.Location = new Point(12, 44);
            cb_transportes.Name = "cb_transportes";
            cb_transportes.Size = new Size(316, 28);
            cb_transportes.TabIndex = 0;
            cb_transportes.SelectedIndexChanged += cb_transportes_SelectedIndexChanged;
            // 
            // btn_mostrarSelecionado
            // 
            btn_mostrarSelecionado.Location = new Point(352, 44);
            btn_mostrarSelecionado.Name = "btn_mostrarSelecionado";
            btn_mostrarSelecionado.Size = new Size(252, 29);
            btn_mostrarSelecionado.TabIndex = 1;
            btn_mostrarSelecionado.Text = "Mostrar  selecionado";
            btn_mostrarSelecionado.UseVisualStyleBackColor = true;
            btn_mostrarSelecionado.Click += btn_mostrarSelecionado_Click;
            // 
            // btn_Limpar
            // 
            btn_Limpar.Location = new Point(352, 79);
            btn_Limpar.Name = "btn_Limpar";
            btn_Limpar.Size = new Size(252, 29);
            btn_Limpar.TabIndex = 2;
            btn_Limpar.Text = "Limpar";
            btn_Limpar.UseVisualStyleBackColor = true;
            btn_Limpar.Click += btn_Limpar_Click;
            // 
            // btn_resetar
            // 
            btn_resetar.Location = new Point(352, 114);
            btn_resetar.Name = "btn_resetar";
            btn_resetar.Size = new Size(252, 29);
            btn_resetar.TabIndex = 3;
            btn_resetar.Text = "Resetar";
            btn_resetar.UseVisualStyleBackColor = true;
            btn_resetar.Click += btn_resetar_Click;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(352, 271);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(252, 29);
            btn_adicionar.TabIndex = 6;
            btn_adicionar.Text = " Adicionar";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += btn_adicionar_Click;
            // 
            // tb_transporte
            // 
            tb_transporte.BorderStyle = BorderStyle.FixedSingle;
            tb_transporte.Location = new Point(352, 238);
            tb_transporte.Name = "tb_transporte";
            tb_transporte.Size = new Size(252, 27);
            tb_transporte.TabIndex = 7;
            // 
            // F_ComboBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 643);
            Controls.Add(tb_transporte);
            Controls.Add(btn_adicionar);
            Controls.Add(btn_resetar);
            Controls.Add(btn_Limpar);
            Controls.Add(btn_mostrarSelecionado);
            Controls.Add(cb_transportes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "F_ComboBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_transportes;
        private Button btn_mostrarSelecionado;
        private Button btn_Limpar;
        private Button btn_resetar;
        private ComboBox comboBox2;
        private Button btn_adicionar;
        private TextBox tb_transporte;
    }
}