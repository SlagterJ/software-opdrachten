namespace Software_baas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetHeight()
        {
            return (int) heightInput.Value;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int height = GetHeight();

            MessageBox.Show("Your height is " + height + " cm");
        }
    }
}