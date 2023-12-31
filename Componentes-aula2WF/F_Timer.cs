﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_aula2WF
{
    public partial class F_Timer : Form
    {
        int num;
        int px, py;
        public F_Timer()
        {
            InitializeComponent();
        }

        private void F_Timer_Load(object sender, EventArgs e)
        {
            num = 0;
            px = img_carro.Location.X;
            py = img_carro.Location.Y;
        }

        private void btn_iniciar_t_Click(object sender, EventArgs e)
        {
            //timer1.Interval = 500;
            timer1.Start();
        }

        private void btn_parar_t_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
            num++;

        }

        private void btn_reiniciar_t1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            num = 0;
            timer1.Start();
        }

        private void btn_iniciarCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Start();
        }

        private void timer_carro_Tick(object sender, EventArgs e)
        {
            px++;
            img_carro.Location = new Point(px, py);
            px = img_carro.Location.X;
            if (px == 663)
            {
                px = 12;
            }
        }

        private void btn_pararCarro_Click(object sender, EventArgs e)
        {
            timer_carro.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_carro.Interval = Convert.ToInt32(textBox1.Text);
        }
    }
}
