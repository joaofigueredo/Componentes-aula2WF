namespace Componentes_aula2WF
{
    partial class F_MaskedTextBox
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
            mtb_senha = new MaskedTextBox();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            mtb_cpf = new MaskedTextBox();
            label3 = new Label();
            button1 = new Button();
            cb_SomenteTexto = new CheckBox();
            SuspendLayout();
            // 
            // mtb_senha
            // 
            mtb_senha.BorderStyle = BorderStyle.FixedSingle;
            mtb_senha.Location = new Point(85, 103);
            mtb_senha.Name = "mtb_senha";
            mtb_senha.PasswordChar = '*';
            mtb_senha.Size = new Size(318, 27);
            mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 110);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Senha";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Location = new Point(85, 164);
            maskedTextBox1.Mask = "00000-000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(318, 27);
            maskedTextBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 171);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Cep";
            // 
            // mtb_cpf
            // 
            mtb_cpf.BorderStyle = BorderStyle.FixedSingle;
            mtb_cpf.Location = new Point(81, 222);
            mtb_cpf.Mask = "000.000.000-00";
            mtb_cpf.Name = "mtb_cpf";
            mtb_cpf.Size = new Size(322, 27);
            mtb_cpf.TabIndex = 4;
            mtb_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 229);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 5;
            label3.Text = "Cpf";
            // 
            // button1
            // 
            button1.Location = new Point(581, 220);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cb_SomenteTexto
            // 
            cb_SomenteTexto.AutoSize = true;
            cb_SomenteTexto.Location = new Point(438, 225);
            cb_SomenteTexto.Name = "cb_SomenteTexto";
            cb_SomenteTexto.Size = new Size(130, 24);
            cb_SomenteTexto.TabIndex = 7;
            cb_SomenteTexto.Text = "Somente Texto";
            cb_SomenteTexto.UseVisualStyleBackColor = true;
            // 
            // F_MaskedTextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_SomenteTexto);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(mtb_cpf);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Controls.Add(mtb_senha);
            Name = "F_MaskedTextBox";
            Text = "F_MaskedTextBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtb_senha;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private MaskedTextBox mtb_cpf;
        private Label label3;
        private Button button1;
        private CheckBox cb_SomenteTexto;
    }
}