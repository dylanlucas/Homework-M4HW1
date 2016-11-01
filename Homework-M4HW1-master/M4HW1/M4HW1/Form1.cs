using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M4HW1
{
    public partial class Form1 : Form
    {
        //Create Player Object
        Player playerOne = new M4HW1.Player();

        //Create an Opponent Object
        Monster opponent = new Monster();

        //Create NPC object
        NPC npc = new NPC();

        int playerResult, opponentResult;

        public Form1()
        {
            InitializeComponent();

            //Initialize the back color of the display rich text box
            displayRichTextBox.BackColor = Color.White;

            //Initialize the back color and other things of the faction reputation rich text box
            factionDisplayRTB.BackColor = Color.White;
            factionDisplayRTB.Text = playerOne.factionRep() + "\n";


            //Display Player Stats
            healthDisplayLabel.Text = playerOne.health.ToString();
            attackDamageDisplayLabel.Text = playerOne.attackDamage.ToString();

            //Display Opponent Stats
            opponentHealthLabelDisplay.Text = opponent.health.ToString();
            opponentAttackDamageLabel.Text = opponent.attackDamage.ToString();
            opponentFactionDisplayLabel.Text = opponent.getFaction();

            //Display NPC Stats
            npcHealthLabelDisplay.Text = npc.health.ToString();
            npcAttackDamageLabel.Text = npc.attackDamage.ToString();
            npcFactionLabelDisplay.Text = npc.getFaction();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            playerResult = playerOne.onCombatStart();
            opponentResult = opponent.onCombatStart();

            if (playerOne.health > 0)
            {
                displayRichTextBox.Text += "Player One attacked for " + playerResult.ToString() + "\n" +
                                           "Opponent attacked for " + opponentResult.ToString() + "\n";

                if (playerOne.health <= 0)
                {
                    healthDisplayLabel.Text = "0";
                    attackButton.Enabled = false;
                }
                else if (playerOne.health > 0)
                {
                    playerOne.health = playerOne.health - opponentResult;
                    healthDisplayLabel.Text = playerOne.health.ToString();
                }

                if (opponent.health <= 0)
                {
                    opponentHealthLabelDisplay.Text = "0";
                    attackButton.Enabled = false;
                }
                else if (opponent.health > 0)
                {
                    opponent.health = opponent.health - playerResult;
                    opponentHealthLabelDisplay.Text = opponent.health.ToString();
                }
            }

            if (playerOne.health < 0)
            {
                healthDisplayLabel.Text = "0";
            }
            else if (opponent.health < 0)
            {
                opponentHealthLabelDisplay.Text = "0";
            }

            if (playerOne.health <= 0)
            {
                MessageBox.Show("Player One has died.");
                attackDamageDisplayLabel.Text = "0";
                playerOne.onDeath();
                MessageBox.Show("The game is now over.");
                attackButton.Visible = false;
                MessageBox.Show("Please close the game.");
            }

            if (opponent.health <= 0)
            {
                attackButton.Enabled = false;

                if (opponentFactionDisplayLabel.Text == Faction.REBEL.ToString())
                {
                    playerOne.rebel -= 100;
                    playerOne.empire += 100;
                    playerOne.unaff += 50;
                    factionDisplayRTB.Text = playerOne.factionRep() + "\n";

                    if (playerOne.rebel >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.empire >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.unaff >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                }
                else if (opponentFactionDisplayLabel.Text == Faction.EMPIRE.ToString())
                {
                    playerOne.empire -= 100;
                    playerOne.rebel += 100;
                    playerOne.unaff += 50;
                    factionDisplayRTB.Text = playerOne.factionRep() + "\n";

                    if (playerOne.rebel >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.empire >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.unaff >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                }
                else if (opponentFactionDisplayLabel.Text == Faction.UNAFFILIATED.ToString())
                {
                    playerOne.unaff -= 100;
                    playerOne.empire += 50;
                    playerOne.rebel -= 50;
                    factionDisplayRTB.Text = playerOne.factionRep() + "\n";

                    if (playerOne.rebel >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.empire >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                    else if (playerOne.unaff >= 500)
                    {
                        opponent.attackDamage = 50;
                    }
                }

                opponentAttackDamageLabel.Text = "";
                opponentFactionDisplayLabel.Text = "";
                opponent.onDeath();

                displayRichTextBox.Text += "Opponent has died. \n";
            }

            if (attackButton.Enabled == false)
            {
                // Restore values / create new objects
                MessageBox.Show("Let's you heal you up after that intense battle.\n");

                //Player One health
                playerOne.health = 100;
                healthDisplayLabel.Text = playerOne.health.ToString();

                MessageBox.Show ("A NEW OPPONENT HAS APPROACHED YOU!");

                //Create an Opponent Object
                opponent.onSpawn();

                //Display Opponent Stats
                opponentHealthLabelDisplay.Text = opponent.health.ToString();
                opponentAttackDamageLabel.Text = opponent.attackDamage.ToString();
                opponentFactionDisplayLabel.Text = opponent.getFaction();

                attackButton.Enabled = true;
            }

            displayRichTextBox.SelectionStart = displayRichTextBox.Text.Length;
            displayRichTextBox.ScrollToCaret();
        }
    }
}
