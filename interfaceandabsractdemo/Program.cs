using System;

namespace interfaceilkörnek
{
    class Program
    {
        static void Main(string[] args)
        {

            Araba Ford = new Araba();
            Ford.calistir();
            Ford.vitesarttır();
            Ford.parket();
            Ford.stopet();
            Console.ReadKey();

        }       
    }
}
