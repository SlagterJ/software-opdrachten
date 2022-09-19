using static TrafficLight.LazyFunctions;

namespace TrafficLight
{
    class Program
    {
        static void Main()
        {
            TrafficLight tl = new TrafficLight();
            // Red
            Wl(tl.GetCurrentColor());
            tl.NextState();

            // Green
            Wl(tl.GetCurrentColor());
            tl.NextState();

            // Orange
            Wl(tl.GetCurrentColor());
            tl.NextState();

            // Red
            Wl(tl.GetCurrentColor());
        }
    }
}
