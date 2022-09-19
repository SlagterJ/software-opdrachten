namespace TrafficLight
{
    public class TrafficLight
    {
        private string color;

        public TrafficLight()
        {
            this.color = "red";
        }

        public void NextState()
        {
            this.color = this.color switch
            {
                "red" => "green",
                "green" => "orange",
                "orange" => "red",
                _ => "red",
            };
        }

        public string GetCurrentColor() { return this.color; }
    }
}
