namespace Componentes_aula2WF
{
    partial class F_DateTimePicker
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
            dtp_data = new DateTimePicker();
            btn_obterData = new Button();
            tb_data = new TextBox();
            tb_dia = new TextBox();
            tb_mes = new TextBox();
            tb_ano = new TextBox();
            btn_alterarData = new Button();
            btn_hoje = new Button();
            SuspendLayout();
            // 
            // dtp_data
            // 
            dtp_data.Location = new Point(12, 12);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(392, 27);
            dtp_data.TabIndex = 0;
            // 
            // btn_obterData
            // 
            btn_obterData.Location = new Point(471, 13);
            btn_obterData.Name = "btn_obterData";
            btn_obterData.Size = new Size(204, 29);
            btn_obterData.TabIndex = 1;
            btn_obterData.Text = "Obter data";
            btn_obterData.UseVisualStyleBackColor = true;
            btn_obterData.Click += btn_obterData_Click;
            // 
            // tb_data
            // 
            tb_data.BorderStyle = BorderStyle.FixedSingle;
            tb_data.Location = new Point(12, 59);
            tb_data.Name = "tb_data";
            tb_data.Size = new Size(392, 27);
            tb_data.TabIndex = 2;
            // 
            // tb_dia
            // 
            tb_dia.BorderStyle = BorderStyle.FixedSingle;
            tb_dia.Location = new Point(16, 113);
            tb_dia.Name = "tb_dia";
            tb_dia.Size = new Size(125, 27);
            tb_dia.TabIndex = 3;
            // 
            // tb_mes
            // 
            tb_mes.BorderStyle = BorderStyle.FixedSingle;
            tb_mes.Location = new Point(147, 113);
            tb_mes.Name = "tb_mes";
            tb_mes.Size = new Size(125, 27);
            tb_mes.TabIndex = 4;
            // 
            // tb_ano
            // 
            tb_ano.BorderStyle = BorderStyle.FixedSingle;
            tb_ano.Location = new Point(279, 113);
            tb_ano.Name = "tb_ano";
            tb_ano.Size = new Size(125, 27);
            tb_ano.TabIndex = 5;
            // 
            // btn_alterarData
            // 
            btn_alterarData.Location = new Point(471, 113);
            btn_alterarData.Name = "btn_alterarData";
            btn_alterarData.Size = new Size(204, 29);
            btn_alterarData.TabIndex = 9;
            btn_alterarData.Text = "Alterar";
            btn_alterarData.UseVisualStyleBackColor = true;
            btn_alterarData.Click += btn_alterarData_Click;
            // 
            // btn_hoje
            // 
            btn_hoje.Location = new Point(12, 167);
            btn_hoje.Name = "btn_hoje";
            btn_hoje.Size = new Size(663, 29);
            btn_hoje.TabIndex = 10;
            btn_hoje.Text = "Hoje";
            btn_hoje.UseVisualStyleBackColor = true;
            btn_hoje.Click += btn_hoje_Click;
            // 
            // F_DateTimePicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 636);
            Controls.Add(btn_hoje);
            Controls.Add(btn_alterarData);
            Controls.Add(tb_ano);
            Controls.Add(tb_mes);
            Controls.Add(tb_dia);
            Controls.Add(tb_data);
            Controls.Add(btn_obterData);
            Controls.Add(dtp_data);
            Name = "F_DateTimePicker";
            Text = "F_DateTimePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_data;
        private Button btn_obterData;
        private TextBox tb_data;
        private TextBox tb_dia;
        private TextBox tb_mes;
        private TextBox tb_ano;
        private Button btn_alterarData;
        private Button btn_hoje;
    }
}