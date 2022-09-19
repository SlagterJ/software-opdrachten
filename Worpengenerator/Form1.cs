namespace Worpengenerator
{
    public partial class Form1 : Form
    {
        static bool hasRolledBefore = false;
        static int highestResult = 0;
        static int lowestResult = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private int GetDiceAmount()
        {
            return (int)diceAmountInput.Value;
        }

        private int GetDiceSides()
        {
            return (int)diceSidesInput.Value;
        }

        private int GenerateRoll(int diceSides)
        {
            // generate a dice roll
            Random random = new();
            return random.Next(1, diceSides + 1);
        }

        private List<int> GenerateAmountOfRolls(int amountOfRolls, int diceSides)
        {
            resultsBox.Items.Clear();

            List<int> results = new();

            for (int i = 0; i < amountOfRolls; i++)
            {
                results.Add(GenerateRoll(diceSides));
            }

            return results;
        }

        private void UpdateHighAndLowLabels(int result)
        {
            if (!hasRolledBefore || result > highestResult)
            {
                highestResult = result;
                highestResultLabel.Text = $"Hoogste worp tot nu toe: {highestResult}";
            }

            if (!hasRolledBefore || result < lowestResult)
            {
                lowestResult = result;
                lowestResultLabel.Text = $"Laagste worp tot nu toe: {lowestResult}";
            }

            if (!hasRolledBefore)
            {
                hasRolledBefore = true;
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            int diceAmount = GetDiceAmount();
            int diceSides = GetDiceSides();

            List<int> results = GenerateAmountOfRolls(diceAmount, diceSides);

            results.ForEach((int result) => {
                resultsBox.Items.Add(result);
                UpdateHighAndLowLabels(result);
            });

            int total = results.Sum();
            resultTotal.Text = $"Totaal aantal ogen: {total}";
        }
    }
}