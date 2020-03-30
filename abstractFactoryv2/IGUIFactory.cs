using System;
using System.Collections.Generic;
using System.Text;

namespace GUIFactory
{
    interface IGUIFactory
    {
        abstract IButton CreateButton();
        abstract IDialog CreateDialog();
    }
}
