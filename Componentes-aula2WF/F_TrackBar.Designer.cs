namespace Componentes_aula2WF
{
    partial class F_TrackBar
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
            trackBar1 = new TrackBar();
            tb_valor = new TextBox();
            label1 = new Label();
            btn_definir = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 24);
            trackBar1.Maximum = 50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(776, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 25;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // tb_valor
            // 
            tb_valor.BorderStyle = BorderStyle.FixedSingle;
            tb_valor.Location = new Point(12, 173);
            tb_valor.Name = "tb_valor";
            tb_valor.Size = new Size(125, 27);
            tb_valor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 223);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // btn_definir
            // 
            btn_definir.Location = new Point(167, 173);
            btn_definir.Name = "btn_definir";
            btn_definir.Size = new Size(67, 29);
            btn_definir.TabIndex = 3;
            btn_definir.Text = "Definir";
            btn_definir.UseVisualStyleBackColor = true;
            btn_definir.Click += btn_definir_Click;
            // 
            // F_TrackBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_definir);
            Controls.Add(label1);
            Controls.Add(tb_valor);
            Controls.Add(trackBar1);
            Name = "F_TrackBar";
            Text = "F_TrackBar";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private TextBox tb_valor;
        private Label label1;
        private Button btn_definir;
    }
}