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
        public Menu menu = new Menu();
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
                        filtrarConfiguracionRetiro(cantidadDinero);
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

       private void  filtrarConfiguracionRetiro(int cantidadRetirar)
        {
             if (Singleton.Instancia.modoDispensacion[0] == 200 && Singleton.Instancia.modoDispensacion[1] == 1000)
             {
                int ultimosTresDigitos = cantidadRetirar % 1000;

                if (ultimosTresDigitos % 200 == 0)
                {
                    //Complete here
                    iniciaTransaccion(cantidadRetirar);
                }
                else
                {
                    Console.WriteLine("Con esta configuracion no puedes hacer el retiro del monto deseado...Cambia la configuracion a cualquiera diferente a papeletas de 200 y 100...\nRedireccionando a menu...");
                    Console.ReadKey();
                    menu.startMenu();
                }

            }
            else 
            {
                //Complete here
                iniciaTransaccion(cantidadRetirar);
            }           
        }


        private void iniciaTransaccion(int cantitdadRetirar)
        {
            int sumaCantidadRetirar = 0;
            List<int> papeletasUsadas = new List<int>();

            while (sumaCantidadRetirar!= cantitdadRetirar)
            {
                var modoDispensacion = Singleton.Instancia.modoDispensacion;
                for (int i = modoDispensacion.Count; i!=0; i--)
                {
                    if (modoDispensacion[i] == cantitdadRetirar)
                    {
                        sumaCantidadRetirar = modoDispensacion[i];
                        papeletasUsadas.Add(modoDispensacion[i]);
                        break;
                    }

                    else if (modoDispensacion[i] < cantitdadRetirar)
                    {
                        sumaCantidadRetirar += modoDispensacion[i];
                        
                    }

                }
            }
            
        }





    }
}
