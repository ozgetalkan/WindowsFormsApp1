using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random= new Random();
        string secretKey;
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] secretKeys = { "dolap", "bilgisayar", "fare", "kalem" };
            secretKey = secretKeys[random.Next(0, 4)];
            txtGuessed.Enabled = true;
            btnGuessed.Enabled = true;
            txtGuessed.Text = "";
        }
        private void btnGuessed_Click(object sender, EventArgs e)
        {
            string guess = txtGuessed.Text;
            if (guess == secretKey)
            {
                MessageBox.Show("Kazandiniz");
            }
            else
            {
                char[] letters = guess.ToCharArray();
                string matchedLetters = "";
                foreach (char letter in letters) 
                {
                    if (secretKey.Contains(letter) && !matchedLetters.Contains(letter))
                    {
                        matchedLetters += $"{letter},";

                    }
                }
                if (matchedLetters != "")
                {
                    matchedLetters = matchedLetters.TrimEnd(',');
                    listBox1.Items.Add(matchedLetters);
                }
            }
        }


    }
}
