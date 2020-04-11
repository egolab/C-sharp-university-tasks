using System;
using System.Collections.Generic;
using System.Text;

namespace command
{
    class SwitchOffCommand : ICommand
    {

        private ISwitchableItem switchableItem;

        public SwitchOffCommand(ISwitchableItem switchableItem)
        {
            this.switchableItem = switchableItem;
        }
        public void Execute()
        {
            switchableItem.SwitchOff();
        }
    }
}
