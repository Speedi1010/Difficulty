using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difficulty
{
    public partial class Form1 : Form
    {
        string difficulty;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void easyButton_Click(object sender, EventArgs e)
        { 
            easyButton.BackColor = Color.LimeGreen;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
            difficulty = "Easy";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string heroname = nameInput.Text;
            if (difficulty == "Easy")
            {
                outputLabel.Location = new Point(48, 313);
                outputLabel.Text = $"Welcome {heroname}\nYou are a truly weak hero about to embark on such a Easy quest";
            }
            if (difficulty == "Normal")
            {
                outputLabel.Location = new Point(3, 313);
                outputLabel.Text = $"Welcome {heroname}\nYou are a truly mediocore hero about to embark on such a Normal quest";
            }
            if (difficulty == "Hard")
            {
                outputLabel.Location = new Point(48, 313);
                outputLabel.Text = $"Welcome {heroname}\nYou are a truly brave hero about to embark on such a Hard quest";
            }
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Yellow;
            hardButton.BackColor = Color.Black;
            difficulty = "Normal";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Black;
            mediumButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Red;
            difficulty = "Hard";
        }
    }
}
