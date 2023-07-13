namespace Componentes_aula2WF
{
    partial class F_Veiculos
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
            tb_listaVeiculos = new TextBox();
            SuspendLayout();
            // 
            // tb_listaVeiculos
            // 
            tb_listaVeiculos.Location = new Point(85, 30);
            tb_listaVeiculos.Multiline = true;
            tb_listaVeiculos.Name = "tb_listaVeiculos";
            tb_listaVeiculos.Size = new Size(351, 407);
            tb_listaVeiculos.TabIndex = 0;
            tb_listaVeiculos.TextChanged += textBox1_TextChanged;
            // 
            // F_Veiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 672);
            Controls.Add(tb_listaVeiculos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "F_Veiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Veiculos";
            FormClosed += F_Veiculos_FormClosed;
            Load += F_Veiculos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_listaVeiculos;
    }
}