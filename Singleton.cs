using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_pruebin
{
    class Singleton
    {
        public static Singleton Instancia { get; } = new Singleton();
        public List<int> modoDispensacion { get; set; } = new List<int>() { 100, 200, 500, 1000 };
        public List<int> cantidadAhorros { get;  set; } = new List<int>() { 100000 };
        public Singleton()
        {
        }
    }
}
