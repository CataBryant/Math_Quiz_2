﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace MathQuiz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer player = new SoundPlayer(@"E:\p1.wav");
        SoundPlayer player2 = new SoundPlayer(@"E:\p2.wav");
        int TimeLeft;
        Random Randomizer = new Random();
        int addend1;
        int addend2;
        int addmin1;
        int addmin2;
        int addpro1;
        int addpro2;
        int adddiv1;
        int adddiv2;
        int temporary;
        public void StartTheQuiz()
        {
            addend1 = Randomizer.Next(51);
            addend2 = Randomizer.Next(51);
            addmin1 = Randomizer.Next(1, 51);
            addmin2 = Randomizer.Next(1, addmin1);
            addpro1 = Randomizer.Next(2, 11);
            addpro2 = Randomizer.Next(2, 11);
            adddiv2 = Randomizer.Next(2, 11);
            temporary = Randomizer.Next(2, 11);
            adddiv1 = adddiv2 * temporary;

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            minusLeftLabel.Text = addmin1.ToString();
            minusRightLabel.Text = addmin2.ToString();
            proLeftLabel.Text = addpro1.ToString();
            proRightLabel.Text = addpro2.ToString();
            divLeftLabel.Text = adddiv1.ToString();
            divRightLabel.Text = adddiv2.ToString();
            sum.Value = 0;
            difference.Value = 0;
            div.Value = 0;
            product.Value = 0;
            TimeLeft = 30;
            Time.Text = "30 seconds";
            Time.BackColor = Color.Aqua;
            timer1.Start();
        }

        public void StartTheQuizHard()
        {
            addend1 = Randomizer.Next(51);
            addend2 = Randomizer.Next(51);
            addmin1 = Randomizer.Next(1, 51);
            addmin2 = Randomizer.Next(1, addmin1);
            addpro1 = Randomizer.Next(2, 11);
            addpro2 = Randomizer.Next(2, 11);
            adddiv2 = Randomizer.Next(2, 11);
            temporary = Randomizer.Next(2, 11);
            adddiv1 = adddiv2 * temporary;

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            minusLeftLabel.Text = addmin1.ToString();
            minusRightLabel.Text = addmin2.ToString();
            proLeftLabel.Text = addpro1.ToString();
            proRightLabel.Text = addpro2.ToString();
            divLeftLabel.Text = adddiv1.ToString();
            divRightLabel.Text = adddiv2.ToString();
            sum.Value = 0;
            difference.Value = 0;
            div.Value = 0;
            product.Value = 0;
            TimeLeft = 10;
            Time.Text = "10 seconds";
            Time.BackColor = Color.Red;
            timer1.Start();
        }


        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value && addmin1 - addmin2 == difference.Value
                && product.Value == addpro1 * addpro2 && div.Value == adddiv1 / adddiv2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartTheQuizHard();
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            BackColor = Color.Indigo;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Congratulations! You won a cookie!");
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                player2.Play();
            }
            else
            if (TimeLeft > 0)
            {
                TimeLeft--;
                Time.Text = TimeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                player.Play();
                MessageBox.Show("Too slow.Try again");
                sum.Value = addend1 + addend2;
                difference.Value = addmin1 - addmin2;
                product.Value = addpro1 * addpro2;
                div.Value = adddiv1 / adddiv2;
                button1.Enabled = true;
                button2.Enabled = true;
            }
            if (TimeLeft <= 20)
            {
                Time.BackColor = Color.Yellow;
            }
            if (TimeLeft <= 10)
            {
                Time.BackColor = Color.Red;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            BackColor = Color.Green;
        }

        public void StartTheQuizMedium()
        {
            addend1 = Randomizer.Next(51);
            addend2 = Randomizer.Next(51);
            addmin1 = Randomizer.Next(1, 51);
            addmin2 = Randomizer.Next(1, addmin1);
            addpro1 = Randomizer.Next(2, 11);
            addpro2 = Randomizer.Next(2, 11);
            adddiv2 = Randomizer.Next(2, 11);
            temporary = Randomizer.Next(2, 11);
            adddiv1 = adddiv2 * temporary;

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            minusLeftLabel.Text = addmin1.ToString();
            minusRightLabel.Text = addmin2.ToString();
            proLeftLabel.Text = addpro1.ToString();
            proRightLabel.Text = addpro2.ToString();
            divLeftLabel.Text = adddiv1.ToString();
            divRightLabel.Text = adddiv2.ToString();
            sum.Value = 0;
            difference.Value = 0;
            div.Value = 0;
            product.Value = 0;
            TimeLeft = 20;
            Time.Text = "20 seconds";
            Time.BackColor = Color.Yellow;
            timer1.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StartTheQuizMedium();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            BackColor = Color.SteelBlue;
        }
    }
}
