using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.psit.ms.presentation.test
{
    public class LightOnCommand : Command
    {
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        private Light light;
 
         void Command.execute()
        {
            Console.Write("Light on named "+light.Name+"\r\n");
        }

    }
}
