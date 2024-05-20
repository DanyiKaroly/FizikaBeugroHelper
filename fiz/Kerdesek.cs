using fiz;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizHelp
{
    public class Kerdesek
    {
        List<KerdesClass> kerdesekLista = new List<KerdesClass>();

        public Kerdesek()
        {
            kerdesekLista.Add(new KerdesClass(1, Resource1._1kerdes));
            kerdesekLista.Add(new KerdesClass(2, Resource1._2kerdes));
            kerdesekLista.Add(new KerdesClass(3, Resource1._3kerdes));
            kerdesekLista.Add(new KerdesClass(4, Resource1._4kerdes));
            kerdesekLista.Add(new KerdesClass(5, Resource1._5kerdes));
            kerdesekLista.Add(new KerdesClass(6, Resource1._6kerdes));
            kerdesekLista.Add(new KerdesClass(7, Resource1._7kerdes));
            kerdesekLista.Add(new KerdesClass(8, Resource1._8kerdes));
            kerdesekLista.Add(new KerdesClass(9, Resource1._9kerdes));
            kerdesekLista.Add(new KerdesClass(10, Resource1._10kerdes));
            kerdesekLista.Add(new KerdesClass(11, Resource1._11kerdes));
        }

        public int getKL()
        {
            return kerdesekLista.Count();
        }
        public void removeK(int Sorszam)
        {
            for (int i = 0; i < kerdesekLista.Count; i++)
            {
                if (i == Sorszam)
                {
                    kerdesekLista.Remove(kerdesekLista[i]);
                    break;
                }
            }
        }

        public Image getKerdes(int i)
        {
            return kerdesekLista[i].getIMG();
        }
        public int getID(int i)
        {
            return kerdesekLista[i].getSorszam();
        }

    }
}
