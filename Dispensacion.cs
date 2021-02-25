using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_pruebin
{
    class Dispensacion
    {

        public Dispensacion()
        { 
        }

        public void primeraOpcion()
        {
            Singleton.Instancia.modoDispensacion = new List<int>() { 200, 1000 };
            Console.WriteLine("Listo!...");
            Console.ReadKey();

            MenuDispensacion menu = new MenuDispensacion();
            menu.startMenu();
        }

        public void segundaOpcion()
        {
            Singleton.Instancia.modoDispensacion = new List<int>() { 100, 500 };
            Console.WriteLine("Listo!...");
            Console.ReadKey();

            MenuDispensacion menu = new MenuDispensacion();
            menu.startMenu();
        }

        public void terceraOpcion()
        {
            Singleton.Instancia.modoDispensacion = new List<int>() { 100, 200, 500, 1000 };
            Console.WriteLine("Listo!...");
            Console.ReadKey();

            MenuDispensacion menu = new MenuDispensacion();
            menu.startMenu();
        }
    }
}
