using System;
using System.Collections.Generic;
using System.Linq;

namespace Example2_Args_
{
    class Program
    {
        static void Main()
        {
            EventsExample e1 = new EventsExample();
            e1.MathActionHandler += Sum;//Кто (какой метод) подписывается на событие и, соответственно, реагирует на него
            e1.MathActionHandler += Multiple;
            e1.InputNumbers();
            

        }

        static void Sum (object sender, MathActionEventArgs e)
        {
            Console.WriteLine($"Сложили {e.A} и {e.B}. Получилось {e.A+e.B}");
        }

        static void Multiple(object sender, MathActionEventArgs e)
        {
            Console.WriteLine($"Умножали {e.A} и {e.B}. Получилось {e.A * e.B}");
        }
    }

    class EventsExample
    {
        public delegate void MathAction (object sender, MathActionEventArgs e);
        public event MathAction MathActionHandler;

        public void InputNumbers ()
        {
            MathActionHandler.Invoke(this/*Кто вызвал событие*/, new MathActionEventArgs(4, 5)/*Класс с аргументами события*/);
        }
    }

    class MathActionEventArgs
    {
        public int A { get; }
        public int B { get; }

        public MathActionEventArgs(int a, int b)
        {
            A = a;
            B = b;
        }
    } 
}
