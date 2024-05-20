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
        Image img;

        public ValaszClass(int Sorszam, Image Img)
        {
            sorszam = Sorszam;
            img = Img;
        }
        public Image getIMG()
        {
            return img;
        }
        public int getSorszam()
        {
            return sorszam;
        }
    }
}
