namespace command
{
    class SwitchOnCommand : ICommand
    {

        private ISwitchableItem switchableItem;

        public SwitchOnCommand(ISwitchableItem switchableItem)
        {
            this.switchableItem = switchableItem;
        }
        public void Execute()
        {
            switchableItem.SwitchOn();
        }
    }
}
