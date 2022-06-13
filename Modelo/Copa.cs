﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14_CartasEspaniolas.Modelo
{
    public class Copa : CartasEspaniolas
    {
        public Copa()
        {
            Color = "Red";
            Palo = "Copa";
        }

        public List<string> CartasCopa()
        {
            var listaCopa = new List<string>();
            for (int i = 0; i < 12; i++)
            {
                if (i != 7 && i != 8)
                {
                    listaCopa.Add($"{i + 1} de {Palo}");
                }
            }
            return listaCopa;
        }
    }
}
