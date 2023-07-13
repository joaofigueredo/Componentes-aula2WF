namespace Componentes_aula2WF
{
    partial class F_CheckBox
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
            cb_Carro = new CheckBox();
            cb_Aviao = new CheckBox();
            cb_Navio = new CheckBox();
            cb_Onibus = new CheckBox();
            btn_TransportesMarcados = new Button();
            cb_Patinete = new CheckBox();
            btn_filho = new Button();
            SuspendLayout();
            // 
            // cb_Carro
            // 
            cb_Carro.AutoSize = true;
            cb_Carro.Location = new Point(39, 47);
            cb_Carro.Name = "cb_Carro";
            cb_Carro.Size = new Size(67, 24);
            cb_Carro.TabIndex = 0;
            cb_Carro.Text = "Carro";
            cb_Carro.UseVisualStyleBackColor = true;
            cb_Carro.CheckedChanged += cb_Carro_CheckedChanged;
            // 
            // cb_Aviao
            // 
            cb_Aviao.AutoSize = true;
            cb_Aviao.Location = new Point(39, 77);
            cb_Aviao.Name = "cb_Aviao";
            cb_Aviao.Size = new Size(69, 24);
            cb_Aviao.TabIndex = 1;
            cb_Aviao.Text = "Avião";
            cb_Aviao.UseVisualStyleBackColor = true;
            cb_Aviao.CheckedChanged += cb_Aviao_CheckedChanged;
            // 
            // cb_Navio
            // 
            cb_Navio.AutoSize = true;
            cb_Navio.Location = new Point(39, 107);
            cb_Navio.Name = "cb_Navio";
            cb_Navio.Size = new Size(70, 24);
            cb_Navio.TabIndex = 2;
            cb_Navio.Text = "Navio";
            cb_Navio.UseVisualStyleBackColor = true;
            // 
            // cb_Onibus
            // 
            cb_Onibus.AutoSize = true;
            cb_Onibus.Location = new Point(39, 137);
            cb_Onibus.Name = "cb_Onibus";
            cb_Onibus.Size = new Size(77, 24);
            cb_Onibus.TabIndex = 3;
            cb_Onibus.Text = "Onibus";
            cb_Onibus.UseVisualStyleBackColor = true;
            // 
            // btn_TransportesMarcados
            // 
            btn_TransportesMarcados.Location = new Point(209, 87);
            btn_TransportesMarcados.Name = "btn_TransportesMarcados";
            btn_TransportesMarcados.Size = new Size(214, 29);
            btn_TransportesMarcados.TabIndex = 4;
            btn_TransportesMarcados.Text = "Transportes Marcados";
            btn_TransportesMarcados.UseVisualStyleBackColor = true;
            btn_TransportesMarcados.Click += btn_TransportesMarcados_Click;
            // 
            // cb_Patinete
            // 
            cb_Patinete.AutoSize = true;
            cb_Patinete.Location = new Point(39, 232);
            cb_Patinete.Name = "cb_Patinete";
            cb_Patinete.Size = new Size(84, 24);
            cb_Patinete.TabIndex = 5;
            cb_Patinete.Text = "Patinete";
            cb_Patinete.UseVisualStyleBackColor = true;
            cb_Patinete.CheckedChanged += cb_Patinete_CheckedChanged;
            // 
            // btn_filho
            // 
            btn_filho.Location = new Point(119, 301);
            btn_filho.Name = "btn_filho";
            btn_filho.Size = new Size(172, 29);
            btn_filho.TabIndex = 6;
            btn_filho.Text = "Chamar filho";
            btn_filho.UseVisualStyleBackColor = true;
            btn_filho.Click += btn_filho_Click;
            // 
            // F_CheckBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 643);
            Controls.Add(btn_filho);
            Controls.Add(cb_Patinete);
            Controls.Add(btn_TransportesMarcados);
            Controls.Add(cb_Onibus);
            Controls.Add(cb_Navio);
            Controls.Add(cb_Aviao);
            Controls.Add(cb_Carro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckBox";
            Text = "CheckBox";
            Load += F_CheckBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_TransportesMarcados;
        private CheckBox cb_Patinete;
        public CheckBox cb_Carro;
        public CheckBox cb_Aviao;
        public CheckBox cb_Navio;
        public CheckBox cb_Onibus;
        private Button btn_filho;
    }
}