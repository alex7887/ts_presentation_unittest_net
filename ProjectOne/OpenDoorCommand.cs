using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ru.psit.ms.presentation.test
{
    public class OpenDoorCommand: Command
    {
        public OpenDoorCommand(Door door)
        {
            this.door = door;
        }

        private Door door;

        void Command.execute()
        {
            if (door.Name.Equals("kitchen") || door.Name.Equals("hall"))
               Console.Write("Open door named " + door.Name + "\r\n");
            else
            {
                throw new Exception("error");
            }
        }
    
    }
}
