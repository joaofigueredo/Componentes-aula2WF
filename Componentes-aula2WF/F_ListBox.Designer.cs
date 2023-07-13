namespace Componentes_aula2WF
{
    partial class F_ListBox
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
            lb_carros = new ListBox();
            tb_carro = new TextBox();
            label1 = new Label();
            btn_add = new Button();
            btn_remover = new Button();
            btn_obter = new Button();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // lb_carros
            // 
            lb_carros.FormattingEnabled = true;
            lb_carros.ItemHeight = 20;
            lb_carros.Location = new Point(23, 27);
            lb_carros.Name = "lb_carros";
            lb_carros.Size = new Size(150, 304);
            lb_carros.TabIndex = 0;
            // 
            // tb_carro
            // 
            tb_carro.BorderStyle = BorderStyle.FixedSingle;
            tb_carro.Location = new Point(243, 50);
            tb_carro.Name = "tb_carro";
            tb_carro.Size = new Size(394, 27);
            tb_carro.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 27);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 2;
            label1.Text = "Carros";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(243, 103);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 3;
            btn_add.Text = "Adicionar";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_remover
            // 
            btn_remover.Location = new Point(343, 103);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(94, 29);
            btn_remover.TabIndex = 4;
            btn_remover.Text = "Remover";
            btn_remover.UseVisualStyleBackColor = true;
            btn_remover.Click += btn_remover_Click;
            // 
            // btn_obter
            // 
            btn_obter.Location = new Point(443, 103);
            btn_obter.Name = "btn_obter";
            btn_obter.Size = new Size(94, 29);
            btn_obter.TabIndex = 5;
            btn_obter.Text = "Obter";
            btn_obter.UseVisualStyleBackColor = true;
            btn_obter.Click += btn_obter_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(543, 103);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(94, 29);
            btn_limpar.TabIndex = 6;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // F_ListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_limpar);
            Controls.Add(btn_obter);
            Controls.Add(btn_remover);
            Controls.Add(btn_add);
            Controls.Add(label1);
            Controls.Add(tb_carro);
            Controls.Add(lb_carros);
            Name = "F_ListBox";
            Text = "ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lb_carros;
        private TextBox tb_carro;
        private Label label1;
        private Button btn_add;
        private Button btn_remover;
        private Button btn_obter;
        private Button btn_limpar;
    }
}