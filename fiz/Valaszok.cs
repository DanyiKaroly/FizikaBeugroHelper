using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizHelp
{
    public class Valaszok
    {   
		
        List<ValaszClass> ValaszLista = new List<ValaszClass>();


        public Valaszok()
        {
            ValaszLista.Add(new ValaszClass(0, "AZelmozdulas.PNG"));
            ValaszLista.Add(new ValaszClass(1, "gyorsulas.PNG"));
            ValaszLista.Add(new ValaszClass(2, "sebesseg.PNG"));
        }
        public int getVL()
        {
            return ValaszLista.Count();
        }
        public void removeV(int Sorszam)
        {
            for (int i = 0; i < ValaszLista.Count; i++)
            {
                if ((ValaszLista[i].getSorszam())==Sorszam)
                {
                    ValaszLista.Remove(ValaszLista[i]);
                }
            }
        }
        public string getV(int i)
        {
            return ValaszLista[i].getURL();
        }
        public int getID(int i)
        {
            return ValaszLista[i].getSorszam();
        }

    }
}
