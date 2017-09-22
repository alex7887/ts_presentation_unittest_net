using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.psit.ms.presentation.test
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow");

            StuffControl stuffControl = new StuffControl();

            Door door = new Door();
            door.Name = "kitchen";

            Command openDoorCommand = new OpenDoorCommand(door);
            stuffControl.setCommand(0, openDoorCommand);
           
            Light light = new Light();
            light.Name = "garage";

            Command lightOnCommand = new LightOnCommand(light);
            stuffControl.setCommand(1, lightOnCommand);

            stuffControl.push(0);
            stuffControl.push(1);

            Console.WriteLine("finish");

        }
    }
}
