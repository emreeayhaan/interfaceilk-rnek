using System;
using System.Collections.Generic;
using System.Text;

namespace interfaceilkörnek
{
     public  interface IArabasur
    {
        void calistir();
        void vitesarttır();
        void parket();  
        void stopet();
    }
    public class Araba : IArabasur
    { 
        public void calistir()
        {
            Console.WriteLine("araba çalıştı");
        }
        public void vitesarttır()

        {
            Console.WriteLine("vites arttırıldı");
        }
        public void parket()
        {
            Console.WriteLine("park edildi");
        }
        public void stopet()
        {
            Console.WriteLine("stop");
        }
        
    }
        
    
}

