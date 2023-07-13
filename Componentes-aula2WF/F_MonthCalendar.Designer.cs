namespace Componentes_aula2WF
{
    partial class F_MonthCalendar
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
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_pegarData = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(-1, 0);
            monthCalendar1.MaxSelectionCount = 30;
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.ShowToday = false;
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(297, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(297, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 2;
            // 
            // btn_pegarData
            // 
            btn_pegarData.Location = new Point(297, 180);
            btn_pegarData.Name = "btn_pegarData";
            btn_pegarData.Size = new Size(94, 29);
            btn_pegarData.TabIndex = 3;
            btn_pegarData.Text = "Obter data";
            btn_pegarData.UseVisualStyleBackColor = true;
            btn_pegarData.Click += btn_pegarData_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(297, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(237, 27);
            textBox3.TabIndex = 4;
            // 
            // F_MonthCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(btn_pegarData);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(monthCalendar1);
            Name = "F_MonthCalendar";
            Text = "F_MonthCalendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_pegarData;
        private TextBox textBox3;
    }
}