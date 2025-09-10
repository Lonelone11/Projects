using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphical_Hangman
{
    public partial class Form1 : Form
    {
        int lives = 7;
        const char BLANK = '•';
        string word;
        int hints = 0;
        List<char> mask = new List<char>();

        public Form1()
        {
            InitializeComponent();
            word = getWord();

            for (int i = 0; i < word.Length; i++)
            {
                mask.Add(BLANK);
                display.Text += mask[i];
            }
            //label1.Text = word;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void livesLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownHandler);
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Textboxenter();
            }

        }


        static protected string getWord()
        {
            FileStream dictionaryFile = new FileStream("dictionary.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(dictionaryFile);
            List<string> words = new List<string>();

            while (!sr.EndOfStream)
            {
                words.Add(sr.ReadLine());
            }

            Random random = new Random();
            int num = random.Next(0, words.Count);
            return words[num];
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            bool checker = false;
            Random random = new Random();
            while (!checker)
            {
                int ind = random.Next(word.Length);
                if (!mask.Contains(word[ind]))
                {
                    checker = true;
                    textBox.Text = Convert.ToString(word[ind]);
                    Textboxenter();
                    hints++;
                    RemoveLives();
                    livesLabel.Text = Convert.ToString(lives);
                }
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void livesText_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Textboxenter();
        }
        private void RemoveLives()
        {
            lives--;
            if (lives == 0)
            {
                DialogResult result = MessageBox.Show("Would You Like To Play Again", "You Lose", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else { Environment.Exit(0); }
            }
        }

        private void Textboxenter()
        {
            if (textBox.Text.Length > 1) { MessageBox.Show("Please Enter Only 1 Character"); textBox.Text = ""; }
            else if (display.Text.Contains(BLANK) & lives > 0)
            {
                try
                {
                    char guess = Convert.ToChar(textBox.Text);
                    if (word.Contains(guess))
                    {
                        for (int i = 0; mask.Count > i; i++)
                        {
                            if (guess == word[i])
                            {
                                mask[i] = word[i];

                            }
                        }
                        display.Text = "";
                        for (int i = 0; i < mask.Count; i++)
                        {
                            display.Text += Convert.ToString(mask[i]);
                        }
                        if (!display.Text.Contains(BLANK))
                        {
                            DialogResult result = MessageBox.Show("Would You Like To Play Again", "WINNER", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                Application.Restart();
                                Environment.Exit(0);
                            }
                            else { Environment.Exit(0); }
                        }

                    }
                    else
                    {
                        RemoveLives();
                        livesLabel.Text = Convert.ToString(lives);
                        if (!label1.Text.Contains(guess))
                        {
                            label1.Text += guess;
                            label1.Text += " ";
                        }

                    }


                    textBox.Text = "";
                }
                catch { Console.WriteLine("Enter One Character"); }
            }
        }
    }

    
}


