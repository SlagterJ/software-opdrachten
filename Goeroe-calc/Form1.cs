namespace Goeroe_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowResult(float result)
        {
            // display the outcome first, then check whether the label should be red or not
            resultLabel.Text = $"Uitkomst: {result}";

            if (result <= 0)
            {
                resultLabel.ForeColor = Color.Red;
                return;
            }

            resultLabel.ForeColor = Color.Black;
        }

        private float[] GetUserInput()
        {
            // get both the input strings to convert
            string _input1 = inputNum1.Text;
            string _input2 = inputNum2.Text;

            // convert them
            bool input1DidConvert = float.TryParse(_input1, out float input1);
            bool input2DidConvert = float.TryParse(_input2, out float input2);

            // if they aren't floats or ints, crash the program
            if (!(input1DidConvert && input2DidConvert))
            {
                throw new Exception("Don't input anything other than int or float, idiot.");
            }

            float[] output = { input1, input2 };
            return output;
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            float[] input = GetUserInput();
            float result = input[0] + input[1];

            ShowResult(result);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            float[] input = GetUserInput();
            float result = input[0] * input[1];

            ShowResult(result);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            float[] input = GetUserInput();
            float result = input[0] / input[1];

            ShowResult(result);
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            float[] _input = GetUserInput();
            float input = _input[0];
            // cast to float to keep things consistent
            float result = (float)Math.Sqrt(input);

            ShowResult(result);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            float[] input = GetUserInput();
            float result = input[0] - input[1];

            ShowResult(result);
        }
    }
}