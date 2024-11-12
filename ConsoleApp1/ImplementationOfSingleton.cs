
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ImplementationOfSingleton
    {
        private static ImplementationOfSingleton instance;
        private static int coutOfInstance = 0;
        private static List<string> menu;
        private ImplementationOfSingleton() 
        {
            menu = new List<string>()
            {
                "Vada",
                "Idly",
                "Puri"
            };
        }

        

        public static ImplementationOfSingleton Intance(int a)
        {
            if (instance == null)
            {
                ImplementationOfSingleton _instance = new ImplementationOfSingleton ();
                instance = _instance;
                coutOfInstance = a;
            }
            return instance;
        }
    }
}
