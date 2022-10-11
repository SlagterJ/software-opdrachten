
namespace SimonStates
{
    public partial class Form1 : Form
    {
        private List<int> sequence = new();
        private int index;
        private int generations;
        private int highScore;

        private void Sleep(int ms)
        {
            Application.DoEvents();
            Thread.Sleep(ms);
        }

        // updates the generation count
        private void UpdateGenerations()
        {
            generations++;
            labelGenerations.Text = $"Generations: {generations}";
        }

        private string GetHighScoreText()
        {
            return $"High score: {highScore}";
        }

        // updates the high score
        private void UpdateHighScore()
        {
            if (generations <= highScore) return;

            highScore = generations;
            labelHighScore.Text = GetHighScoreText();
        }

        // sets all buttons to a specified colour
        private void SetAllButtonsToColor(Color color)
        {
            buttonRed.BackColor = color;
            buttonYellow.BackColor = color;
            buttonBlue.BackColor = color;
            buttonGreen.BackColor = color;
        }

        // sets all buttons either enabled or disabled
        private void SetAllButtonsEnabled(bool enabled)
        {
            buttonRed.Enabled = enabled;
            buttonYellow.Enabled = enabled;
            buttonBlue.Enabled = enabled;
            buttonGreen.Enabled = enabled;

            SetAllButtonsToColor(Color.WhiteSmoke); // also set all to whitesmoke
        }

        // add a new colour to the sequence
        private void AddToSequence()
        {
            Random random = new();
            // Add a random number between 0 and 3 to the sequence
            // 0 = red, 1 = yellow, 2 = blue, 3 = green 
            int nextInSequence = random.Next(0, 4);
            Console.WriteLine(nextInSequence);

            sequence.Add(nextInSequence);
        }

        // shows the sequence to the user that they afterwards have to put in
        private void ShowSequence()
        {
            labelStatus.Text = "Showing sequence...";

            // first disable the buttons so that we can use them for showing the sequence
            SetAllButtonsEnabled(false);

            // loop through the list
            sequence.ForEach((color) =>
            {
                SetAllButtonsToColor(Color.WhiteSmoke);

                Sleep(200);

                switch (color)
                {
                    // red
                    case 0:
                        buttonRed.BackColor = Color.Red;
                        break;

                    // yellow
                    case 1:
                        buttonYellow.BackColor = Color.Yellow;
                        break;

                    // blue
                    case 2:
                        buttonBlue.BackColor = Color.Blue;
                        break;

                    // green
                    case 3:
                        buttonGreen.BackColor = Color.Lime;
                        break;
                }

                Sleep(400);
            });

            // enable all buttons again for the user's turn
            SetAllButtonsEnabled(true);

            labelStatus.Text = "Your turn!";
        }

        // method to use over the application to maintain the loop
        private void GameLoop()
        {
            AddToSequence();
            UpdateGenerations();
            ShowSequence();
        }

        // generic method that gets called by all buttons when they're pressed,
        private void PressButton(int color)
        {
            // is the user pressing the wrong button?
            if (sequence[index] != color)
            {
                // disable the buttons, set them to grey, and show that it's game over
                SetAllButtonsEnabled(false);
                SetAllButtonsToColor(Color.Gray);
                UpdateHighScore();

                labelStatus.Text = "Game Over!";

                buttonStartGame.Enabled = true;
                
                return;
            }

            index++;

            if (index != sequence.Count) return;

            // if we're done with this generation, show the sequence for the next one
            index = 0;
            GameLoop();
        }

        public Form1()
        {
            InitializeComponent();
            SetAllButtonsEnabled(false);
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            sequence = new List<int>();
            index = 0;
            generations = 0;

            buttonStartGame.Enabled = false;

            SetAllButtonsToColor(Color.WhiteSmoke);
            GameLoop();
        }

        // refer all the buttons to the PressButton method
        private void buttonRed_Click(object sender, EventArgs e) { PressButton(0); }
        private void buttonYellow_Click(object sender, EventArgs e) { PressButton(1); }
        private void buttonBlue_Click(object sender, EventArgs e) { PressButton(2); }
        private void buttonGreen_Click(object sender, EventArgs e) { PressButton(3); }
    }
}