namespace Componentes_aula2WF.Properties
{
    partial class F_ProgressBar
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
            progressBar1 = new ProgressBar();
            btn_Valor = new Button();
            tb_valor = new TextBox();
            btn_preencher = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 215);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(759, 29);
            progressBar1.TabIndex = 0;
            progressBar1.Value = 50;
            // 
            // btn_Valor
            // 
            btn_Valor.Location = new Point(12, 76);
            btn_Valor.Name = "btn_Valor";
            btn_Valor.Size = new Size(94, 29);
            btn_Valor.TabIndex = 1;
            btn_Valor.Text = "Valor";
            btn_Valor.UseVisualStyleBackColor = true;
            btn_Valor.Click += btn_Valor_Click;
            // 
            // tb_valor
            // 
            tb_valor.BorderStyle = BorderStyle.FixedSingle;
            tb_valor.Location = new Point(12, 33);
            tb_valor.Name = "tb_valor";
            tb_valor.Size = new Size(125, 27);
            tb_valor.TabIndex = 2;
            tb_valor.Text = "0";
            // 
            // btn_preencher
            // 
            btn_preencher.Location = new Point(3, 180);
            btn_preencher.Name = "btn_preencher";
            btn_preencher.Size = new Size(94, 29);
            btn_preencher.TabIndex = 3;
            btn_preencher.Text = "Preencher";
            btn_preencher.UseVisualStyleBackColor = true;
            btn_preencher.Click += btn_preencher_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "10000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 76);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // F_ProgressBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(btn_preencher);
            Controls.Add(tb_valor);
            Controls.Add(btn_Valor);
            Controls.Add(progressBar1);
            Name = "F_ProgressBar";
            Text = "F_ProgressBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btn_Valor;
        private TextBox tb_valor;
        private Button btn_preencher;
        private TextBox textBox1;
        private Label label1;
    }
}