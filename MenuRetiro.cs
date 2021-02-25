using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_pruebin
{
    class MenuRetiro : Imenu
    {
        public MenuRetiro()
        { }

        public void startMenu()
        {
            try
            {
                Console.WriteLine("Escribe la cantidad de dinerro que quieres retirar");
                int cantidadDinero = int.Parse(Console.ReadLine());

               bool verificacion = verificarCantidadDinero(cantidadDinero);

                if (verificacion)
                {
                    if (cantidadDinero % 100 == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Solo puedes retirar candidades sin decenas, es decir, no puedes rerirar dinero que terminen los dos ultimos digitos iguales a 99 para abajo.\n Ejemplo de cantidad erronea: $1010\n Vuelve a intentarlo...");
                        this.startMenu();

                    }

                }
                else
                {
                    if (Singleton.Instancia.cantidadAhorros[0] < 100) 
                    {
                        Console.WriteLine("No tiene saldo suficiente para retirar... Vaya al banco mas cercano y deposite dinero...\n Terminando transaccion, gracias por usar nuestro servicio...Fin de la simulacion del Cajero");
                        Console.ReadKey();
                    }
                    
                    if(cantidadDinero > Singleton.Instancia.cantidadAhorros[0])
                    {
                        Console.WriteLine("La cantidad que estas tratando de retirar es mayor a la cantidad en tu cuenta de ahorro...Intenta otra vez...");
                        this.startMenu();

                    }

                    if (cantidadDinero < 100)
                    {
                        Console.WriteLine("La cantidad que estas tratando de retirar es menor  a la cantidad  minima permitida a retirar...Intenta otra vez...");
                        this.startMenu();

                    }
                }
            }
            catch 
            {
                Console.WriteLine("Solo escribe numeros enteros...Vuelve a intentarlo...");
                this.startMenu();
            }
          
        }

       private bool verificarCantidadDinero(int cantidad)
        {
            if (cantidad >= 100 && cantidad <= Singleton.Instancia.cantidadAhorros[0])
            {
                return true;
         
            }
            return false;

        }
    }
}
