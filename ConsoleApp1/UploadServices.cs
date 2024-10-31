
using System.Collections.Generic;

namespace ConsoleApp1
{
    class UploadServices
    {
        private static UploadServices instance;
        private static int coutOfInstance = 0;
        private static List<string> menu;
        private UploadServices() 
        {
            menu = new List<string>()
            {
                "Vada",
                "Idly",
                "Puri"
            };
        }

        

        public static UploadServices Intance(int a)
        {
            if (instance == null)
            {
                UploadServices _instance = new UploadServices ();
                instance = _instance;
                coutOfInstance = a;
            }
            return instance;
        }
    }
}
