using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Channel : IChannel
    {
        private List<Subscriber> observers = new List<Subscriber>();
        private int _int;

        public int Inventory
        {
            get
            {
                return _int;
            }
            set
            {
                if (value > _int)
                {
                    Notify();
                }
                _int = value;
            }
        }

        public void Subscribe(Subscriber observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(Subscriber observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
