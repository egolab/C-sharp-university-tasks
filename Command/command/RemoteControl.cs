using System.Collections.Generic;

namespace command
{ 
  
    class RemoteControl // invoker
    {
        private ICommand command;
        private List<ICommand> commands = new List<ICommand>();

        public void SetCommand(ICommand command) 
        {
            this.command = command;
        }

        public void PressButton()
        {
            commands.Add(command);
            command.Execute();
        }
    }
}
