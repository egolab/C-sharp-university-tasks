using System;
using System.Collections.Generic;
using System.Text;

namespace GUIFactory
{
    class LinuxGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }
        public IDialog CreateDialog()
        {
            return new LinuxDialog();
        }
    }
}
