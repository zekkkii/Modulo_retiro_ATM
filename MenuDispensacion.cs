using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_pruebin
{
    class MenuDispensacion : Imenu
    {

        public MenuDispensacion()
        {
        }

        public Dispensacion dispensacion = new Dispensacion();
        public void startMenu()
        {
            Console.WriteLine("1 -***Elige la forma de dispensacion***\n1- 200 y 1000\n2- 100 y 500\n3- Modo eficiente(Defecto) 100, 200, 500, 1000 \n4- volver al menu principal");
            int seleccion = int.Parse(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    dispensacion.primeraOpcion();
                    break;
                case 2:
                    dispensacion.segundaOpcion();
                    break;
                case 3:
                    dispensacion.terceraOpcion();
                    break;
                case 4:
                    Menu menu = new Menu();
                    menu.startMenu();
                    break;
                default:
                    Console.WriteLine("Escribe solo las opciones dadas");
                    this.startMenu();
                    break;
            }
        }

    }
}
