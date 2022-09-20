namespace Televisie
{
    public partial class Form1 : Form
    {
        private bool tvIsOn = false;
        private List<string> channels;
        private int currentChannel = 0;

        private void AddChannel(string channel)
        {
            if (string.IsNullOrEmpty(channel)) return;

            channels.Add(channel);
            listBoxChannels.Items.Add(channel);
        }

        private void IncreaseChannel()
        {
            int nextChannel = currentChannel + 1;

            if (nextChannel > channels.Count - 1)
            {
                nextChannel = 0;
            }

            currentChannel = nextChannel;
            UpdateChannel();
        }

        private void DecreaseChannel()
        {
            int nextChannel = currentChannel - 1;

            if (nextChannel < 0)
            {
                nextChannel = channels.Count - 1;
            }

            currentChannel = nextChannel;
            UpdateChannel();
        }

        private string GetCurrentChannelName()
        {
            if (currentChannel < 0 || currentChannel >= channels.Count)
            {
                currentChannel = 0;
            };

            return channels[currentChannel];
        }

        private void UpdateChannel()
        {
            labelCurrentChannel.Text = GetCurrentChannelName();
        }

        public Form1()
        {
            InitializeComponent();

            channels = new List<string>()
            {
                "NPO1",
                "NPO2",
                "NPO3"
            };

            listBoxChannels.Items.AddRange(channels.ToArray());
            UpdateChannel();
        }


        private void radioButtonTelevisionOn_CheckedChanged(object sender, EventArgs e)
        {
            tvIsOn = true;
            onOrOffLabel.Text = "Aan";
            labelCurrentChannel.Visible = true;
        }

        private void radioButtonTelevisionOff_CheckedChanged(object sender, EventArgs e)
        {
            tvIsOn = false;
            onOrOffLabel.Text = "Uit";
            labelCurrentChannel.Visible = false;
        }

        private void buttonAddChannel_Click(object sender, EventArgs e)
        {
            AddChannel(textBoxAddChannel.Text);
        }

        private void buttonNextChannel_Click(object sender, EventArgs e)
        {
            if (!tvIsOn) return;
            IncreaseChannel();
        }

        private void buttonPreviousChannel_Click(object sender, EventArgs e)
        {
            if (!tvIsOn) return;
            DecreaseChannel();
        }
    }
}