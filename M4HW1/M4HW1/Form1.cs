﻿using System;
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
        Player playerOne = new M4HW1.Player(100, 25, true);

        //Create an Opponent Object
        Monster opponent = new Monster(100, 20, true);

        //Create NPC object
        NPC npc = new M4HW1.NPC(100, 0, false);

        int playerResult, opponentResult;

        public Form1()
        {
            InitializeComponent();

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
            
            playerResult = playerOne.playerCombatStart();
            opponentResult = opponent.mobCombatStart();

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
                displayRichTextBox.Text += "Player One has died. \n";
                attackDamageDisplayLabel.Text = "0";
                playerOne.onDeath();
                this.Close();
            }
            else if (opponent.health <= 0)
            {
                bool factionPoints = false;

                attackButton.Enabled = false;

                opponentAttackDamageLabel.Text = "";
                opponentFactionDisplayLabel.Text = "";
                opponent.onDeath();

                displayRichTextBox.Text += "Opponent has died. \n";
                if (factionPoints == false)
                {
                    if (opponent.getFaction() == "REBEL")
                    {
                        factionPoints = true;
                        playerOne.rebel -= 100;
                        playerOne.empire += 100;
                        displayRichTextBox.Text += playerOne.factionRep() + "\n";
                    }
                    else if (opponent.getFaction() == "EMPIRE")
                    {
                        factionPoints = false;
                        playerOne.empire -= 100;
                        playerOne.rebel += 100;
                        displayRichTextBox.Text += playerOne.factionRep() + "\n";
                    }
                    else
                    {
                        factionPoints = false;
                        playerOne.unaff -= 100;
                        playerOne.empire += 50;
                        playerOne.rebel -= 50;
                        displayRichTextBox.Text += playerOne.factionRep() + "\n";
                    }
                }
            }

            if(attackButton.Enabled == false)
            {
                // Restore values / create new objects
                displayRichTextBox.Text += "Let's you heal you up after that intense battle.\n";

                //Player One health
                playerOne.health = 100;
                healthDisplayLabel.Text = playerOne.health.ToString();

                MessageBox.Show ("A NEW OPPONENT HAS APPROACHED YOU!");

                //Create an Opponent Object
                opponent.health = 100;
                opponent.attackDamage = 20;
                opponent.getFaction();

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