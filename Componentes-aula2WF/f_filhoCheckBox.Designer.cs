namespace Componentes_aula2WF
{
    partial class f_filhoCheckBox
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
            cb_Onibus = new CheckBox();
            cb_Navio = new CheckBox();
            cb_Aviao = new CheckBox();
            cb_Carro = new CheckBox();
            SuspendLayout();
            // 
            // cb_Onibus
            // 
            cb_Onibus.AutoSize = true;
            cb_Onibus.Location = new Point(35, 150);
            cb_Onibus.Name = "cb_Onibus";
            cb_Onibus.Size = new Size(77, 24);
            cb_Onibus.TabIndex = 7;
            cb_Onibus.Text = "Onibus";
            cb_Onibus.UseVisualStyleBackColor = true;
            cb_Onibus.CheckedChanged += cb_Onibus_CheckedChanged;
            // 
            // cb_Navio
            // 
            cb_Navio.AutoSize = true;
            cb_Navio.Location = new Point(35, 120);
            cb_Navio.Name = "cb_Navio";
            cb_Navio.Size = new Size(70, 24);
            cb_Navio.TabIndex = 6;
            cb_Navio.Text = "Navio";
            cb_Navio.UseVisualStyleBackColor = true;
            cb_Navio.CheckedChanged += cb_Navio_CheckedChanged;
            // 
            // cb_Aviao
            // 
            cb_Aviao.AutoSize = true;
            cb_Aviao.Location = new Point(35, 90);
            cb_Aviao.Name = "cb_Aviao";
            cb_Aviao.Size = new Size(69, 24);
            cb_Aviao.TabIndex = 5;
            cb_Aviao.Text = "Avião";
            cb_Aviao.UseVisualStyleBackColor = true;
            cb_Aviao.CheckedChanged += cb_Aviao_CheckedChanged;
            // 
            // cb_Carro
            // 
            cb_Carro.AutoSize = true;
            cb_Carro.Location = new Point(35, 60);
            cb_Carro.Name = "cb_Carro";
            cb_Carro.Size = new Size(67, 24);
            cb_Carro.TabIndex = 4;
            cb_Carro.Text = "Carro";
            cb_Carro.UseVisualStyleBackColor = true;
            cb_Carro.CheckedChanged += cb_Carro_CheckedChanged;
            // 
            // f_filhoCheckBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 312);
            Controls.Add(cb_Onibus);
            Controls.Add(cb_Navio);
            Controls.Add(cb_Aviao);
            Controls.Add(cb_Carro);
            Name = "f_filhoCheckBox";
            Text = "f_filhoCheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cb_Onibus;
        private CheckBox cb_Navio;
        private CheckBox cb_Aviao;
        private CheckBox cb_Carro;
    }
}