using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizHelp
{
    internal class ValaszClass
    {
        int sorszam;
        string url;

        public ValaszClass(int Sorszam, string URL)
        {
            sorszam = Sorszam;
            url = URL;
        }
        public string getURL()
        {
            return url;
        }
        public int getSorszam()
        {
            return sorszam;
        }
    }
}
