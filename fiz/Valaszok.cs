using fiz;
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


        public int getVL()
        {
            return ValaszLista.Count();
        }
        public void removeV(int Sorszam)
        {
            for (int i = 0; i < ValaszLista.Count; i++)
            {
                if (i==Sorszam)
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
        public void addV(int i,Image Image)
        {
            ValaszLista.Add(new ValaszClass(i, Image));
        }
        public void feltoltV()
        {
            ValaszLista.Add(new ValaszClass(1, Resource1._1valasz));
            ValaszLista.Add(new ValaszClass(2, Resource1._2valasz));
            ValaszLista.Add(new ValaszClass(3, Resource1._3valasz));
            ValaszLista.Add(new ValaszClass(4, Resource1._4valasz));
            ValaszLista.Add(new ValaszClass(5, Resource1._5valasz));
            ValaszLista.Add(new ValaszClass(6, Resource1._6valasz));
            ValaszLista.Add(new ValaszClass(7, Resource1._7valasz));
            ValaszLista.Add(new ValaszClass(8, Resource1._8valasz));
            ValaszLista.Add(new ValaszClass(9, Resource1._9valasz));
            ValaszLista.Add(new ValaszClass(10, Resource1._10valasz));
            ValaszLista.Add(new ValaszClass(11, Resource1._11valasz));
        }
    }
}
