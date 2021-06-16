using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Programming_Language_2_Task_3

    
{
    public partial class Form1 : Form
    {
        public int[] numbers;
        public int numberOfGuessed = 0;
        public int numberToGuess;
        const int timeForDigit = 10;
        public int seconds = 0;
        public Form1()
        {
            InitializeComponent();
            numbers = new int[5];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enableDisableControls(true);
            numberOfRightDigits.Maximum = 1;
            timer1.Interval = 1000;
            
        }

        private void numberOfDigits_ValueChanged(object sender, EventArgs e)
        {
            numberOfRightDigits.Maximum = numberOfDigits.Value;
            
        }

        private void disableTextFieldsAndChangeColor()
        {
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox4.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            panel4.BackColor = Color.Gold;
            panel6.BackColor = Color.Gold;
            panel7.BackColor = Color.Gold;
            panel8.BackColor = Color.Gold;
            panel9.BackColor = Color.Gold;
            generateNumbers.Enabled = true;
            repetitive.Enabled = true;
            numberOfDigits.Enabled = true;
            numberOfRightDigits.Enabled = true;

        }

        private void enableDisableControls(bool startOfGame)
        {
            if (startOfGame)
            {
                disableTextFieldsAndChangeColor();
            }
            else
            {
                int numOfDigits = Convert.ToInt32(numberOfDigits.Value);
                if(numOfDigits == 1)
                {
                    textBox4.Enabled = false;
                    textBox6.Enabled = false;
                    textBox7.Enabled = false;
                    textBox8.Enabled = false;
                    textBox9.Enabled = true;
                }
                else if(numOfDigits == 2)
                {
                    textBox4.Enabled = false;
                    textBox6.Enabled = false;
                    textBox7.Enabled = false;
                    textBox8.Enabled = true;
                    textBox9.Enabled = true;
                }
                else if (numOfDigits == 3)
                {
                    textBox4.Enabled = false;
                    textBox6.Enabled = false;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;
                    textBox9.Enabled = true;
                }
                else if (numOfDigits == 4)
                {
                    textBox4.Enabled = false;
                    textBox6.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;
                    textBox9.Enabled = true;
                }
                else if(numOfDigits == 5)
                {
                    textBox4.Enabled = true;
                    textBox6.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;
                    textBox9.Enabled = true;
                }
                generateNumbers.Enabled = false;
                repetitive.Enabled = false;
                numberOfDigits.Enabled = false;
                numberOfRightDigits.Enabled = false;

            }
        }

        private void generateNumbers_Click(object sender, EventArgs e)
        {
            enableDisableControls(false);
            generateRandomNumber();
            timer1.Start();
            
            numberOfDigitsToGuess.Text = (Convert.ToInt32(numberOfRightDigits.Value) - numberOfGuessed).ToString();
            seconds = timeForDigit * Convert.ToInt32(numberOfDigits.Value);

        }

        private void generateRandomNumber()
        {
            Random randNumber = new Random();
            int generatedNumbers = 0;
            numberToGuess = 0;
            int moveNumberByOnePlace = 1;
            while(generatedNumbers < Convert.ToInt32(numberOfDigits.Value))
            {
                int x = randNumber.Next(0, 9);
                if(!numbers.Contains(x) || repetitive.Checked)
                {
                    numbers[4 - generatedNumbers] = x;
                    numberToGuess = numberToGuess + (x * moveNumberByOnePlace);
                    moveNumberByOnePlace *= 10;
                    Console.WriteLine(numberToGuess.ToString());
                    generatedNumbers++;
                }
            }
            foreach(int a in numbers)
            {
                Console.WriteLine("numbers : " + a.ToString());
            }
        }
        
        private void textBoxChanged(TextBox textbox, Panel panel , int numberToGuess)
        {
            int num = Convert.ToInt32(textbox.Text);
            if(num == numberToGuess)
            {
                
                if(panel.BackColor != Color.Blue)
                {
                    numberOfGuessed++;
                }
                panel.BackColor = Color.Blue;
                if(numberOfGuessed == Convert.ToInt32(numberOfRightDigits.Value))
                {
                    endGame();
                }
            }
            else
            {
                if(panel.BackColor == Color.Blue)
                {
                    numberOfGuessed--;
                }
                if (numbers.Contains(num))
                {
                    panel.BackColor = Color.Red;
                }
                else
                {
                    panel.BackColor = Color.Gold;
                }
            }
            numberOfDigitsToGuess.Text = (Convert.ToInt32(numberOfRightDigits.Value) - numberOfGuessed).ToString();
        }

        private void textBoxValueChanged(TextBox textbox, Panel panel, int numberToGuess)
        {
            try
            {
                if(textbox.Text != "")
                {
                    textBoxChanged(textbox, panel, numberToGuess);
                }
                else
                {
                    panel.BackColor = Color.Gold;
                }
            }
            catch
            {
                panel.BackColor = Color.Gold;
                MessageBox.Show("Enter valid number in");
                textbox.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBoxValueChanged(textBox4, panel4, numbers[0]);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBoxValueChanged(textBox6, panel6, numbers[1]);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBoxValueChanged(textBox7, panel7, numbers[2]);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBoxValueChanged(textBox8, panel8, numbers[3]);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBoxValueChanged(textBox9, panel9, numbers[4]);
        }

        private void endGame()
        {
            timer1.Stop();
            enableDisableControls(true);
            
            endGameDialog("CONGRATULATIONS!");
        }

        private void endGameDialog(String message)
        {
            DialogResult result = MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.No)
            {
                Application.Exit();
            }
            numberOfRightDigits.Maximum = 1;
            numberOfGuessed = 0;
        }

       

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            seconds--;
            timeRemaining.Text = "00 : " + seconds.ToString();

            if (seconds == 0)
            {
                timer1.Stop();
                endGameDialog("YOU DID NOT KNOW, GAME OVER - NUMBER: " + currentValue() + " should have been " + numberToGuess.ToString());
                
                enableDisableControls(true);

            }
        }

        String currentValue()
        {
            String currValue = "";
            if(textBox4.Text != "")
            {
                currValue += textBox4.Text;
            }
            if (textBox6.Text != "")
            {
                currValue += textBox6.Text;
            }
            if (textBox7.Text != "")
            {
                currValue += textBox7.Text;
            }
            if (textBox8.Text != "")
            {
                currValue += textBox8.Text;
            }
            if (textBox9.Text != "")
            {
                currValue += textBox9.Text;
            }
            return currValue;
        }
    }
}
