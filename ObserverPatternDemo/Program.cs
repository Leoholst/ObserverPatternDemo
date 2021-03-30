using System;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel();

            Subscriber Subscriber1 = new Subscriber("Alfonso");
            channel.Subscribe(Subscriber1);

            Subscriber Subscriber2 = new Subscriber("Ricardo");
            channel.Subscribe(Subscriber2);

            channel.Inventory++;

            Subscriber Subscriber3 = new Subscriber("Gustavo");
            channel.Subscribe(Subscriber3);

            channel.Inventory++;

            Console.ReadLine();
        }
    }
}
