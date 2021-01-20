using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Murat");
            isimler.Add("Turan");
            isimler.Add("Halil");

            
        }
    }
}
