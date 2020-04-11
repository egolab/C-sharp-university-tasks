using System;
using System.Collections.Generic;
using System.Text;

namespace command
{
    class SetValueCommand : ICommand
    {
        private ISwitchableItem switchableItem;
        private double value;

        public SetValueCommand(ISwitchableItem switchableItem, double value)
        {
            this.switchableItem = switchableItem;
            this.value = value;
        }
        public void Execute()
        {
            switchableItem.SetValue(value);
        }
    }
}
