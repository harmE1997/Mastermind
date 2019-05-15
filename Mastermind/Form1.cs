using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{  
    public partial class Form1 : Form
    {
        private Player player;
        private Number Number;
        private List<Player> players;
        public Form1()
        {
            InitializeComponent();
            players = new List<Player>();
        }

        private void btnPlayer_Click(object sender, EventArgs e)
        {
            foreach (Player player in players)
            {
                if (player.Name == tbName.Text)
                {
                    MessageBox.Show("That name already exists. Choose another one");
                    return;
                }
            }

            try
            {
                player = new Player(tbName.Text);
                players.Add(player);
                SwitchGroupBoxes(false, true, false);
                UpdateLists();
            }

            catch (ArgumentException) { MessageBox.Show("invalid name"); }

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (cbDifficulty.SelectedItem == null)
            {
                MessageBox.Show("Select difficulty.");
            }

            else
            {
                Number = new Number(cbDifficulty.SelectedItem.ToString());
                SwitchGroupBoxes(false, false, true);
                lblAttempts.Text = Number.Attempts.ToString();
            }
        }

        private void btnguess_Click(object sender, EventArgs e)
        {
            string result = "";
            decimal[] guess = new decimal[4];
            decimal[] reading = new decimal[4];
            reading[0] = nudZero.Value;
            reading[1] = nudOne.Value;
            reading[2] = nudTwo.Value;
            reading[3] = nudThree.Value;
            for (int i = 0; i < 4; i++)
            {
                if (!guess.Contains(reading[i]))
                {
                    guess[i] = reading[i];
                    result += guess[i].ToString();
                }

                else
                {
                MessageBox.Show("Select four different numbers");
                return;
                }
            }

            result = result + ": " + Number.check(guess);
            lbGame.Items.Add(result);
            Number.Attempts--;
            lblAttempts.Text = Number.Attempts.ToString();      
            if (Number.Guessed)
            {
                SwitchGroupBoxes(false, false, false);
                Victory();
            }

            else if (Number.Attempts == 0)
            {
                SwitchGroupBoxes(false, false, false);
                Loss();
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            SwitchGroupBoxes(true, false, false);
        }
        private void Loss()
        {
            gbGame.BackColor = Color.Red;
            MessageBox.Show("You didn't guess it. Shame on you");
            MessageBox.Show("Je total score is: " + player.Score + " punten.");
            SwitchGroupBoxes(true, false, false);
            gbGame.BackColor = SystemColors.Control;
        }

        private void Victory()
        {
            gbGame.BackColor = Color.Green;
            player.NrVictories++;
            player.calculateScore(Number.Attempts, Number.DifficultyMultiplier);          
            UpdateLists();
            SwitchGroupBoxes(false, true, false);
            btnStop.Enabled = true;
            MessageBox.Show("DING DONG, you did it. Nice job");
            MessageBox.Show("Now your score is: " + player.Score + " punten.");
            gbGame.BackColor = SystemColors.Control;

        }
        private void UpdateLists()
        {
            lbPlayers.Items.Clear();
            foreach (Player player in players)
            {
                lbPlayers.Items.Add(player);
            }

            lbGame.Items.Clear();
        }

        private void SwitchGroupBoxes(bool player, bool difficulty, bool game)
        {
            gbDifficulty.Enabled = difficulty;
            gbGame.Enabled = game;
            gbPlayer.Enabled = player;
        }
    }
}
