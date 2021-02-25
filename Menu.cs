using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_pruebin
{
    class Menu : Imenu
    {

        public Menu() 
        { 
        }

        public void startMenu()
        {
            Imenu menu = new MenuRetiro();
            try
            {
                Console.WriteLine("1 -***Bienvenido al ATM***\n1. Modo dispensacion\n 2.Retirar dinero\n3.Salir");
                int seleccion = int.Parse(Console.ReadLine());
                
                switch (seleccion) 
                { 
                    case 1:
                        menu = new MenuDispensacion();
                        menu.startMenu();
                        break;
                    case 2:
                        menu.startMenu();
                        break;
                    case 3:
                        Console.WriteLine("Gracias por usar la red RedATM");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Escribe solo las opciones dadas");
                        this.startMenu();
                        break;
                }
            }
            catch {
                Console.WriteLine("Escribe solo numeros y las opciones dadas");
                this.startMenu();
            }

        }

    }
}
