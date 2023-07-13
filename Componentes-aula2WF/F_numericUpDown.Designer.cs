namespace Componentes_aula2WF
{
    partial class F_numericUpDown
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
            nup_1 = new NumericUpDown();
            tb_numero = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nup_1).BeginInit();
            SuspendLayout();
            // 
            // nup_1
            // 
            nup_1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            nup_1.Location = new Point(12, 85);
            nup_1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nup_1.Name = "nup_1";
            nup_1.Size = new Size(150, 27);
            nup_1.TabIndex = 0;
            // 
            // tb_numero
            // 
            tb_numero.BorderStyle = BorderStyle.FixedSingle;
            tb_numero.Location = new Point(241, 85);
            tb_numero.Name = "tb_numero";
            tb_numero.Size = new Size(125, 27);
            tb_numero.TabIndex = 1;
            tb_numero.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(415, 83);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F_numericUpDown
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tb_numero);
            Controls.Add(nup_1);
            MaximizeBox = false;
            Name = "F_numericUpDown";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_numericUpDown";
            ((System.ComponentModel.ISupportInitialize)nup_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nup_1;
        private TextBox tb_numero;
        private Button button1;
    }
}