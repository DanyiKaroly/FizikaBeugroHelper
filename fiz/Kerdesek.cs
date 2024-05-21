using fiz;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FizHelp
{
    public class Kerdesek
    {
        List<KerdesClass> kerdesekLista = new List<KerdesClass>();

        public Kerdesek()
        {
            for (int i = 1; i <= 170; i++)
            {
                string resourceName = "_" + i + "kerdes";

                Image image = (Image)fiz.Resource1.ResourceManager.GetObject(resourceName);

                if (image != null)
                {
                    kerdesekLista.Add(new KerdesClass(i, image));
                };
            }

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
