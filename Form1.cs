using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflexGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        Random r = new Random();
        Random r2 = new Random();
        int Time = 0;
        int Shot = 0;
        int Kill = 0;

        void ActKill()
        {

            VoiceKill();


            Kill++;
            Shot++;
            label3.Text = "Kill=" + Kill;
            label4.Text = "Shot=" +Shot;
            

        }
        void ActShot()
        {
            VoiceMiss();
            Shot++;
            label4.Text = "Shot=" + Shot;
            
        }
        
        void VoiceKill()
        {
            
            System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\CAHİT BARKIN ÖZER\Desktop\ReflexGame\Visual\SoundEffects\Kill.wav");
            player1.Play();

        }
        void VoiceMiss()
        {
            System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(@"C:\Users\CAHİT BARKIN ÖZER\Desktop\ReflexGame\Visual\SoundEffects\Miss.wav");
            player2.Play();

        }
        void Reset()
        {
             Time = 0;
             Shot = 0;
             Kill = 0;
            label3.Text = "Kill=" + Kill;
            label4.Text = "Shot=" + Shot;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        


        private void timer1_Tick(object sender, EventArgs e)
        {
            Time++;
            
            int x, x2,x3,z;
            x = r.Next(200,300);
            x2 = r.Next(93,263);
            x3 = r.Next(691, 852);
            z = r.Next(3,6);
            if (z % 3== 0) { pictureBox1.Location = new Point(x, 50); }
            if (z % 4 == 0) { pictureBox1.Location = new Point(x2, 263); }
            if (z % 5 == 0) { pictureBox1.Location = new Point(x3, 64); }
            
            label5.Text = "Time=" + Time +".0s";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ActKill();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            ActShot();
        }
    }
}
