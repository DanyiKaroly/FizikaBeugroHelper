using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizHelp
{
    internal class KerdesClass
    {
        int sorszam;
        string url;

        public KerdesClass(int Sorszam, string URL)
        {
            sorszam = Sorszam;
            url= URL;
        }
        public string getURL()
        {
            return url;
        }
        public int getSorszam()
        {
            return sorszam;
        }
        public void setSorszam(int id)
        {
            sorszam = id;
        }
    }
}
