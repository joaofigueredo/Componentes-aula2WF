namespace Componentes_aula2WF
{
    partial class F_Timer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
            timer1 = new System.Windows.Forms.Timer(components);
            btn_iniciar_t = new Button();
            btn_parar_t = new Button();
            label1 = new Label();
            btn_reiniciar_t1 = new Button();
            img_carro = new PictureBox();
            btn_iniciarCarro = new Button();
            timer_carro = new System.Windows.Forms.Timer(components);
            btn_pararCarro = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)img_carro).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btn_iniciar_t
            // 
            btn_iniciar_t.Location = new Point(12, 27);
            btn_iniciar_t.Name = "btn_iniciar_t";
            btn_iniciar_t.Size = new Size(94, 29);
            btn_iniciar_t.TabIndex = 0;
            btn_iniciar_t.Text = "Iniciar";
            btn_iniciar_t.UseVisualStyleBackColor = true;
            btn_iniciar_t.Click += btn_iniciar_t_Click;
            // 
            // btn_parar_t
            // 
            btn_parar_t.Location = new Point(151, 27);
            btn_parar_t.Name = "btn_parar_t";
            btn_parar_t.Size = new Size(94, 29);
            btn_parar_t.TabIndex = 1;
            btn_parar_t.Text = "Parar";
            btn_parar_t.UseVisualStyleBackColor = true;
            btn_parar_t.Click += btn_parar_t_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 59);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // btn_reiniciar_t1
            // 
            btn_reiniciar_t1.Location = new Point(307, 32);
            btn_reiniciar_t1.Name = "btn_reiniciar_t1";
            btn_reiniciar_t1.Size = new Size(94, 29);
            btn_reiniciar_t1.TabIndex = 3;
            btn_reiniciar_t1.Text = "Reiniciar";
            btn_reiniciar_t1.UseVisualStyleBackColor = true;
            btn_reiniciar_t1.Click += btn_reiniciar_t1_Click;
            // 
            // img_carro
            // 
            img_carro.Image = (Image)resources.GetObject("img_carro.Image");
            img_carro.Location = new Point(12, 227);
            img_carro.Name = "img_carro";
            img_carro.Size = new Size(125, 62);
            img_carro.SizeMode = PictureBoxSizeMode.StretchImage;
            img_carro.TabIndex = 4;
            img_carro.TabStop = false;
            // 
            // btn_iniciarCarro
            // 
            btn_iniciarCarro.Location = new Point(12, 157);
            btn_iniciarCarro.Name = "btn_iniciarCarro";
            btn_iniciarCarro.Size = new Size(151, 29);
            btn_iniciarCarro.TabIndex = 5;
            btn_iniciarCarro.Text = "Iniciar carro";
            btn_iniciarCarro.UseVisualStyleBackColor = true;
            btn_iniciarCarro.Click += btn_iniciarCarro_Click;
            // 
            // timer_carro
            // 
            timer_carro.Interval = 10;
            timer_carro.Tick += timer_carro_Tick;
            // 
            // btn_pararCarro
            // 
            btn_pararCarro.Location = new Point(192, 157);
            btn_pararCarro.Name = "btn_pararCarro";
            btn_pararCarro.Size = new Size(94, 29);
            btn_pararCarro.TabIndex = 6;
            btn_pararCarro.Text = "Parar Carro";
            btn_pararCarro.UseVisualStyleBackColor = true;
            btn_pararCarro.Click += btn_pararCarro_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(349, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(528, 157);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 8;
            button1.Text = "Definir tempo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F_Timer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btn_pararCarro);
            Controls.Add(btn_iniciarCarro);
            Controls.Add(img_carro);
            Controls.Add(btn_reiniciar_t1);
            Controls.Add(label1);
            Controls.Add(btn_parar_t);
            Controls.Add(btn_iniciar_t);
            Name = "F_Timer";
            Load += F_Timer_Load;
            ((System.ComponentModel.ISupportInitialize)img_carro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button btn_iniciar_t;
        private Button btn_parar_t;
        private Label label1;
        private Button btn_reiniciar_t1;
        private PictureBox img_carro;
        private Button btn_iniciarCarro;
        private System.Windows.Forms.Timer timer_carro;
        private Button btn_pararCarro;
        private TextBox textBox1;
        private Button button1;
    }
}