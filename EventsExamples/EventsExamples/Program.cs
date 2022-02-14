using System;

namespace EventsExamples
{
    class Program
    {
        public delegate void Message();

        public static event Message MessageHandler;


        static void Main(string[] args)
        {

            //Message mes;
            //mes = GoodMorning;
            //mes += GoodEvening;
            //mes();


            MessageHandler += GoodMorning;
            MessageHandler += GoodEvening;

            MessageHandler();
        }
        static void GoodMorning()
        {
            Console.WriteLine("Good morning!");
        }
        static void GoodEvening()
        {
            Console.WriteLine("Good evening!");
        }
    }
}
