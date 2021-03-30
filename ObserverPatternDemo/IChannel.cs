using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    interface IChannel
    {
        void Subscribe(Subscriber observer);
        void Unsubscribe(Subscriber observer);
        void Notify();
    }
}
