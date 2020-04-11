using System;
using System.Collections.Generic;
using System.Text;

namespace command
{
    class DownCommand : ICommand
    {
        private ISwitchableItem switchableItem;

        public DownCommand(ISwitchableItem switchableItem)
        {
            this.switchableItem = switchableItem;
        }
        public void Execute()
        {
            switchableItem.Down();
        }
    }
}
