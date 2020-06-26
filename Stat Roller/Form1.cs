using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stat_Roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image[] imagesOfDice;
        int[] dice;
        Random rand;


        private void Form1_Load(object sender, EventArgs e)
        {
            imagesOfDice = new Image[7];
            imagesOfDice[0] = null;

            imagesOfDice[1] = Properties.Resources.Dice_1;
            imagesOfDice[2] = Properties.Resources.Dice_2;
            imagesOfDice[3] = Properties.Resources.Dice_3;
            imagesOfDice[4] = Properties.Resources.Dice_4;
            imagesOfDice[5] = Properties.Resources.Dice_5;
            imagesOfDice[6] = Properties.Resources.Dice_6;

            dice = new int[4] { 0, 0, 0, 0,};

            rand = new Random();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dice.Length; i++) //For loop to roll all the dice
                dice[i] = rand.Next(1, 7);

            dice1.Image = imagesOfDice[dice[0]];
            dice2.Image = imagesOfDice[dice[1]];
            dice3.Image = imagesOfDice[dice[2]];
            dice4.Image = imagesOfDice[dice[3]];

            

            int sum = dice.Sum();
            int stat = sum - dice.Min();
            statLabel.Text = stat.ToString();
        }

        private void dice2_Click(object sender, EventArgs e)
        {

        }
    }
}
