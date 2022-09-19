namespace CalorieTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetCaloriesByGender()
        {
            if (radButMale.Checked)
            {
                return 2500;
            }
            else if (radButFemale.Checked)
            {
                if (checkboxPregnant.Checked)
                {
                    return 2600;
                }
                return 2000;
            }

            throw new Exception();
        }

        private bool GetIsActive()
        {
            if (radButActive.Checked)
            {
                return true;
            }
            else if (radButNotActive.Checked)
            {
                return false;
            }

            throw new Exception();
        }

        private int GetAge()
        {
            string ageText = textBoxAge.Text;
            bool didParse = int.TryParse(ageText, out int age);

            if (!didParse) throw new Exception();

            return age;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int calories = GetCaloriesByGender();
            bool isActive = GetIsActive();
            int age = GetAge();

            if (!isActive) calories -= calories / 10;

            if (checkboxPregnant.Checked)
            {
                if (age > 30) calories -= 100;
            }

            if (age > 50) calories -= 200;
            if (age < 12) calories -= 180;


            labelResult.Text = $"Uitkomst: {calories}";
        }

        private void radButMale_CheckedChanged(object sender, EventArgs e)
        {
            checkboxPregnant.Checked = false;
            checkboxPregnant.Enabled = false;
        }

        private void radButFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkboxPregnant.Enabled = true;
        }
    }
}