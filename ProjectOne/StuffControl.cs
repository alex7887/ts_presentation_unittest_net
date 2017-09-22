using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.psit.ms.presentation.test
{
    public class StuffControl
    {

        Dictionary<int, Command> commands;

        public StuffControl(){

            commands = new Dictionary<int, Command>();

        }

        public void setCommand(int value, Command command)
        {
            commands.Add(value, command);

        }


        public void push(int signal)
        {
           
           commands[signal].execute();
            
        }

        
    }
}
