using System;
using System.Collections.Generic;
using System.Text;

namespace command
{
    class UpCommand : ICommand
    {
        private ISwitchableItem switchableItem;

        public UpCommand(ISwitchableItem switchableItem)
        {
            this.switchableItem = switchableItem;
        }
        public void Execute()
        {
            switchableItem.Up();
        }
    }
}
