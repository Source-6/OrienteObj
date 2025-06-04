using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoENum.Enums;

namespace DemoENum.Models
{
    internal class TrafficLight
    {
        public TrafficLightColors currentColor;

        public void ChangeColor()
        {
            if(currentColor is TrafficLightColors.vert)
            {
                currentColor = TrafficLightColors.orange;
            }
            else if (currentColor is TrafficLightColors.orange)
            {
                currentColor = TrafficLightColors.rouge;
            }
            else
            {
                currentColor = TrafficLightColors.vert;
            }
        }

    }
}
