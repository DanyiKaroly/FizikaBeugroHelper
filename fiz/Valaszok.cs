using fiz;
using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace FizHelp
{
    public class Valaszok
    {

        List<ValaszClass> ValaszLista = new List<ValaszClass>();


        public int getVL()
        {
            return ValaszLista.Count();
        }
        public void removeV(int Sorszam)
        {
            for (int i = 0; i < ValaszLista.Count; i++)
            {
                if (i == Sorszam)
                {
                    ValaszLista.Remove(ValaszLista[i]);
                    break;
                }
            }
        }
        public Image getV(int i)
        {
            return ValaszLista[i].getIMG();
        }
        public int getID(int i)
        {
            return ValaszLista[i].getSorszam();
        }
        public void addV(int i, Image Image)
        {
            ValaszLista.Add(new ValaszClass(i, Image));
        }
        public void feltoltV()
        {
            for (int i = 0; i <= 170; i++)
            {
                string resourceName = "_" + i + "valasz";

                Image image = (Image)fiz.Resource1.ResourceManager.GetObject(resourceName);

                if (image != null)
                {
                    ValaszLista.Add(new ValaszClass(i, image));
                };
            }
        }
    }
}
