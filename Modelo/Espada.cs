using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14_CartasEspaniolas.Modelo
{
    public class Espada : CartasEspaniolas
    {
        public int MyProperty { get; set; }
        public Espada()
        {
            Color = "Blue";
            Palo = "Espada";
        }

        public List<string> CartasEspada()
        {
            var listaEspada = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                if (i != 7 && i != 8)
                {
                    listaEspada.Add($"{i + 1} de {Palo}");
                }
            }
            return listaEspada;
        }
    }
}
