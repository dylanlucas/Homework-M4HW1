namespace M4HW1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.attackDamageDisplayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.opponentFactionDisplayLabel = new System.Windows.Forms.Label();
            this.opponentAttackDamageLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.npcAttackDamageLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.npcFactionLabelDisplay = new System.Windows.Forms.Label();
            this.attackButton = new System.Windows.Forms.Button();
            this.displayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.healthDisplayLabel = new System.Windows.Forms.Label();
            this.opponentHealthLabelDisplay = new System.Windows.Forms.Label();
            this.npcHealthLabelDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player One";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attack Damage :";
            // 
            // attackDamageDisplayLabel
            // 
            this.attackDamageDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attackDamageDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackDamageDisplayLabel.Location = new System.Drawing.Point(154, 93);
            this.attackDamageDisplayLabel.Name = "attackDamageDisplayLabel";
            this.attackDamageDisplayLabel.Size = new System.Drawing.Size(130, 30);
            this.attackDamageDisplayLabel.TabIndex = 5;
            this.attackDamageDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(531, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Opponent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = ": Health";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = ": Attack Damage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(689, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = ": Faction";
            // 
            // opponentFactionDisplayLabel
            // 
            this.opponentFactionDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opponentFactionDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentFactionDisplayLabel.Location = new System.Drawing.Point(470, 136);
            this.opponentFactionDisplayLabel.Name = "opponentFactionDisplayLabel";
            this.opponentFactionDisplayLabel.Size = new System.Drawing.Size(133, 30);
            this.opponentFactionDisplayLabel.TabIndex = 11;
            this.opponentFactionDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opponentAttackDamageLabel
            // 
            this.opponentAttackDamageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opponentAttackDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentAttackDamageLabel.Location = new System.Drawing.Point(470, 93);
            this.opponentAttackDamageLabel.Name = "opponentAttackDamageLabel";
            this.opponentAttackDamageLabel.Size = new System.Drawing.Size(133, 30);
            this.opponentAttackDamageLabel.TabIndex = 12;
            this.opponentAttackDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "NPC";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Health :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Attack Damage :";
            // 
            // npcAttackDamageLabel
            // 
            this.npcAttackDamageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npcAttackDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcAttackDamageLabel.Location = new System.Drawing.Point(138, 353);
            this.npcAttackDamageLabel.Name = "npcAttackDamageLabel";
            this.npcAttackDamageLabel.Size = new System.Drawing.Size(130, 30);
            this.npcAttackDamageLabel.TabIndex = 18;
            this.npcAttackDamageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Faction : ";
            // 
            // npcFactionLabelDisplay
            // 
            this.npcFactionLabelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npcFactionLabelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcFactionLabelDisplay.Location = new System.Drawing.Point(138, 398);
            this.npcFactionLabelDisplay.Name = "npcFactionLabelDisplay";
            this.npcFactionLabelDisplay.Size = new System.Drawing.Size(130, 30);
            this.npcFactionLabelDisplay.TabIndex = 20;
            this.npcFactionLabelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(325, 218);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(103, 41);
            this.attackButton.TabIndex = 21;
            this.attackButton.Text = "ATTACK";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // displayRichTextBox
            // 
            this.displayRichTextBox.Location = new System.Drawing.Point(460, 280);
            this.displayRichTextBox.Name = "displayRichTextBox";
            this.displayRichTextBox.Size = new System.Drawing.Size(290, 227);
            this.displayRichTextBox.TabIndex = 22;
            this.displayRichTextBox.Text = "";
            // 
            // healthDisplayLabel
            // 
            this.healthDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthDisplayLabel.Location = new System.Drawing.Point(154, 50);
            this.healthDisplayLabel.Name = "healthDisplayLabel";
            this.healthDisplayLabel.Size = new System.Drawing.Size(130, 30);
            this.healthDisplayLabel.TabIndex = 23;
            this.healthDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // opponentHealthLabelDisplay
            // 
            this.opponentHealthLabelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opponentHealthLabelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentHealthLabelDisplay.Location = new System.Drawing.Point(470, 50);
            this.opponentHealthLabelDisplay.Name = "opponentHealthLabelDisplay";
            this.opponentHealthLabelDisplay.Size = new System.Drawing.Size(130, 30);
            this.opponentHealthLabelDisplay.TabIndex = 24;
            this.opponentHealthLabelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // npcHealthLabelDisplay
            // 
            this.npcHealthLabelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npcHealthLabelDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npcHealthLabelDisplay.Location = new System.Drawing.Point(138, 303);
            this.npcHealthLabelDisplay.Name = "npcHealthLabelDisplay";
            this.npcHealthLabelDisplay.Size = new System.Drawing.Size(130, 30);
            this.npcHealthLabelDisplay.TabIndex = 25;
            this.npcHealthLabelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 528);
            this.Controls.Add(this.npcHealthLabelDisplay);
            this.Controls.Add(this.opponentHealthLabelDisplay);
            this.Controls.Add(this.healthDisplayLabel);
            this.Controls.Add(this.displayRichTextBox);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.npcFactionLabelDisplay);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.npcAttackDamageLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.opponentAttackDamageLabel);
            this.Controls.Add(this.opponentFactionDisplayLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.attackDamageDisplayLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label attackDamageDisplayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label opponentFactionDisplayLabel;
        private System.Windows.Forms.Label opponentAttackDamageLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label npcAttackDamageLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label npcFactionLabelDisplay;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.RichTextBox displayRichTextBox;
        private System.Windows.Forms.Label healthDisplayLabel;
        private System.Windows.Forms.Label opponentHealthLabelDisplay;
        private System.Windows.Forms.Label npcHealthLabelDisplay;
    }
}

