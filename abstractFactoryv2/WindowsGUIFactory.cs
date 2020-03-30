using System;
using System.Collections.Generic;
using System.Text;

namespace GUIFactory
{
    class WindowsGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public IDialog CreateDialog()
        {
            return new WindowsDialog();
        }
    }
}
