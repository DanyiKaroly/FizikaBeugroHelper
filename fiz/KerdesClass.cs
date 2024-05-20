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
        Image img;
        public KerdesClass(int Sorszam, Image Img)
        {
            sorszam = Sorszam;
            img=Img;
        }
        public Image getIMG()
        {
            return img;
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
