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
            kerdesekLista.Add(new KerdesClass(0, "Kelmozdulas.PNG"));
            kerdesekLista.Add(new KerdesClass(1, "Kgyorsulas.PNG"));
            kerdesekLista.Add(new KerdesClass(2, "Ksebesseg.PNG"));
        }

        public int getKL()
        {
            return kerdesekLista.Count();
        }
        public void removeK(int Sorszam)
        {
            for (int i = 0; i < kerdesekLista.Count; i++)
            {
                if ((kerdesekLista[i].getSorszam()) == Sorszam)
                {
                    kerdesekLista.Remove(kerdesekLista[i]);
                }
            }
        }

        public string getKerdes(int i)
        {
            return kerdesekLista[i].getURL();
        }
        public int getID(int i)
        {
            return kerdesekLista[i].getSorszam();
        }

    }
}
