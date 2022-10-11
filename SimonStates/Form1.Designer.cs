namespace SimonStates
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.labelGenerations = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonRed.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRed.FlatAppearance.BorderSize = 2;
            this.buttonRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRed.Location = new System.Drawing.Point(319, 82);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(75, 75);
            this.buttonRed.TabIndex = 0;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonYellow.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonYellow.FlatAppearance.BorderSize = 2;
            this.buttonYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYellow.Location = new System.Drawing.Point(400, 82);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(75, 75);
            this.buttonYellow.TabIndex = 1;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBlue.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonBlue.FlatAppearance.BorderSize = 2;
            this.buttonBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBlue.Location = new System.Drawing.Point(319, 163);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(75, 75);
            this.buttonBlue.TabIndex = 2;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGreen.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonGreen.FlatAppearance.BorderSize = 2;
            this.buttonGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGreen.Location = new System.Drawing.Point(400, 163);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(75, 75);
            this.buttonGreen.TabIndex = 3;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // labelGenerations
            // 
            this.labelGenerations.AutoSize = true;
            this.labelGenerations.Location = new System.Drawing.Point(262, 317);
            this.labelGenerations.Name = "labelGenerations";
            this.labelGenerations.Size = new System.Drawing.Size(82, 15);
            this.labelGenerations.TabIndex = 4;
            this.labelGenerations.Text = "Generations: 0";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(488, 317);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(119, 15);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Please start the game";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(262, 335);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(75, 23);
            this.buttonStartGame.TabIndex = 6;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(488, 343);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(76, 15);
            this.labelHighScore.TabIndex = 7;
            this.labelHighScore.Text = "High score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelGenerations);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonRed);
            this.Name = "Form1";
            this.Text = "Simon States";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonRed;
        private Button buttonYellow;
        private Button buttonBlue;
        private Button buttonGreen;
        private Label labelGenerations;
        private Label labelStatus;
        private Button buttonStartGame;
        private Label labelHighScore;
    }
}