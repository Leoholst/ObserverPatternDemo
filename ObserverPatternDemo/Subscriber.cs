using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    public class Subscriber : ISubscriber
    {
        public string SubscriberName { get; private set; }

        public Subscriber(string name)
        {
            SubscriberName = name;
        }

        public void Update()
        {
            Console.WriteLine(SubscriberName + ": A new Subscriber has subscribed");
        }
    }
}
