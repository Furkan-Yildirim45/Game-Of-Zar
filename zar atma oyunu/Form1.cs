﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zar_atma_oyunu
{
    public partial class Form1 : Form
    {
        public String nicknameOne;
        public String nicknameTwo;
        public Form1()
        {            
            InitializeComponent();
        }
        FunctionOfZar fonksiyon = new FunctionOfZar();
        private void Form1_Load(object sender, EventArgs e)
        {
            fonksiyon.SetNames(nicknameOne, nicknameTwo);
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#acbed1");
            int zar1baslangic, zar2baslangic;
            Random random = new Random();
            zar1baslangic = random.Next(0, 6);
            zar2baslangic = random.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[zar1baslangic];
            pictureBox2.Image = ımageList1.Images[zar2baslangic];
            button1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");//textlerin rengini değiştiricem
            label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
            label2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
            button1.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#acbed1");
            button1.BackColor = System.Drawing.ColorTranslator.FromHtml("#e9d5cf");
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.ColorTranslator.FromHtml("#c7b8ac"); //burası 1 satır ustteki kod renginin biraz daha kalın rengi
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.ColorTranslator.FromHtml("");
            nameone.Text = nicknameOne;
            nametwo.Text = nicknameTwo;
            keepOfScore.BackColor = System.Drawing.ColorTranslator.FromHtml("#acbed1");
            keepOfScore.ForeColor = System.Drawing.ColorTranslator.FromHtml("#600ca8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            fonksiyon.FunctionOfTimerone(pictureBox1,pictureBox2,ımageList1,timer1,button1,skorone,skortwo,keepOfScore);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fonksiyon.gameOfPlayed = 0;
            fonksiyon.scoreOne = 0;
            fonksiyon.scoreTwo = 0;
            
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Functions functions = new Functions();
            functions.AppClose(e);
        }
        
    }
}

