using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compareNumber
{
    public partial class Form2 : Form
    {

        int playerNumber;
        int computerNumber;
        Random random = new Random();

        public Form2()
        {
            InitializeComponent();
            initializeGame();
        }

        void initializeGame()
        {
            playerNumber = generateNumber();
            computerNumber = generateNumber();
            playerNumberTextBox.Text = playerNumber.ToString();
        }
        
        int generateNumber()
        {
            return Convert.ToInt32(random.Next(0, 10));
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            if(playerNumber > computerNumber)
            {
                resultLabel.Text = "猜對了!，電腦的數字是: " + computerNumber;
            }
            else
            {
                resultLabel.Text = "真遺憾，電腦的數字是: " + computerNumber;
            }

            disalbeButton();
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            if (playerNumber < computerNumber)
            {
                resultLabel.Text = "猜對了!，電腦的數字是: " + computerNumber;
            }
            else
            {
                resultLabel.Text = "真遺憾，電腦的數字是: " + computerNumber;
            }

            disalbeButton();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (playerNumber == computerNumber)
            {
                resultLabel.Text = "猜對了!，電腦的數字是: " + computerNumber;
            }
            else
            {
                resultLabel.Text = "真遺憾，電腦的數字是: " + computerNumber;
            }

            disalbeButton();
        }

        void disalbeButton()
        {
            smallButton.Enabled = false;
            bigButton.Enabled = false;
            equalButton.Enabled = false;
        }

        void enableButton()
        {
            smallButton.Enabled = true;
            bigButton.Enabled = true;
            equalButton.Enabled = true;
        }

        private void replayButton_Click(object sender, EventArgs e)
        {
            initializeGame();
            resultLabel.Text = " ";
            enableButton();
        }

        private void backToForm1Button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            this.Visible = false;
            f1.Visible = true;
        }
    }



}
