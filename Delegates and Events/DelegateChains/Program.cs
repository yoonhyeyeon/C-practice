using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChains
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }
    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }
        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");   // +=를 이용해 체인 만들기
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail.");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;    // -= 를 이용해 체인 끊기
            notifier.EventOccured("Download complete");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend) ;   //Delegate.Combie() 메소드를 이용해 체인 만들기
            notifier.EventOccured("Nuclear launch detected");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured =
                (Notify)Delegate.Remove(notifier.EventOccured, notify2);             notifier.EventOccured("RPG!");     //Delegate.Remove() 메소드를 이용해 체인 끊기
        }
    }
}
