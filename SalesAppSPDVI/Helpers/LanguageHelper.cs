using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAppSPDVI
{
    class LanguageHelper
    {
        public static string[] langNames= new string[] {"English", "French (BETA)"};
        
        public static int lan = 0;
        public static string[,] langs = new string[1, 4] { {
                "Please, log in with your credentials to\n open de management application.",
                "User",
                "Password",
                "Log In"}};
    }
}
