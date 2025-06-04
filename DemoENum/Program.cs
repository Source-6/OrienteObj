using DemoENum.Models;

namespace DemoENum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight feu1 = new TrafficLight() { currentColor = Enums.TrafficLightColors.vert};

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" le feu est {feu1.currentColor}");
                feu1.ChangeColor(); 
            }

        }
    }
}
