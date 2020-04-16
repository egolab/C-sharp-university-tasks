using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObservable
    {
        void Add(Observer observer);

        void Remove(Observer observer);

        void Notify();
    }
}
