using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14_CartasEspaniolas.Modelo
{
    public class CartasEspaniolas
    {
        public int Numero { get; set; }
        
        public string Palo { get; set;}

        public string Color { get; set; }

        // Carga en el mazo las listas de cartas de cada palo
        public void CargarMazo(List<string> mazo, List<string> cartasPalo)
        {
            for (int i = 0; i < cartasPalo.Count(); i++)
            {
                mazo.Add(cartasPalo[i]);
            }
        }// Fin CargarMazo


        // Intercambia posiciones de las cartas en el mazo a partir de una selección aleatoria de un índice
        // la intercambia por otro índice que recorre toda la lista secuencialmente
        // Algoritmo aleatorio de Fisher-Yates
        public List<string> Barajar(List<string> mazo, int indiceMezcla)
        {
            var cambiador = new Random();    
            
            for (int i = indiceMezcla; i < mazo.Count(); i++)
            {
                var pri = cambiador.Next(i, mazo.Count()); // Limita los numeros aleatorios al "largo de la lista recibida
                string cartaA = mazo[pri];
                mazo[pri] = mazo[mazo.Count() - 1];
                mazo[mazo.Count() - 1] = cartaA;
            }
            return mazo;
        }// Fin Barajar


        // Con referencia a la carta actual (la última que se dió)
        // entregar la carta del siguiente índice de carta actual
        public string SigCarta(List<string> mazo, string cartaActual)
        {
            var cartaSig = "";
            if (cartaActual=="")
            {
                cartaSig = mazo[0];
            }
            else
            {   // Se podría hacer con IndexOf
                //int a = mazo.IndexOf(cartaActual)
                int contador = 0;
                foreach (var item in mazo)
                {
                    if (cartaActual == item)
                    {
                        cartaSig = mazo[contador + 1];

                    }
                    contador++;
                }
            }
            return cartaSig;
        }// Fin SigCarta


        // Mostrar desde índice de carta actual +1 hasta ultimo índice (mazo.Count())
        public int CartasDisponibles(List<string> mazo, string cartaActual)
        {
            int cartasDisponibles = 0;
            List<string> disponibles = new List<string>();
            if (cartaActual == "")
            {
                for (int i = 0; i < mazo.Count(); i++) cartasDisponibles++;
            }
            else
            {   
                int contador = 0;
                foreach (var item in mazo)
                {
                    if (cartaActual == item)
                    {
                        for (int i = contador; i < mazo.Count() - 1; i++) cartasDisponibles++;                        
                    }
                    contador++;
                }
            }
            return cartasDisponibles;
        }// Fin CartasDisponibles

        // Con referencia a la carta actual (la última que se dió) entregar cantidad X
        // a partir del siguiente índice de carta actual
        public List<string> DarCartas(List<string> mazo, int CantX, string cartaActual)
        {
            List<string> cartasQueSeDan = new List<string>();
            if (cartaActual == "")
            {
                for (int i = 0; i < CantX; i++)
                {
                    cartasQueSeDan.Add(mazo[i]);
                }
            }
            else
            {   // Se podría hacer con IndexOf
                //int a = mazo.IndexOf(cartaActual)
                int contador = 0;
                foreach (var item in mazo)
                {
                    if (cartaActual == item)
                    {
                        int dar = 0;
                        while (CantX!=dar)
                        {
                            dar++;
                            cartasQueSeDan.Add(mazo[contador+dar]);                            
                        }                        
                    }
                    contador++;
                }
            }
            return cartasQueSeDan;  // Devuelve una lista con las cartas que se pìdieron
        }// Fin DarCartas

        // Mostrar desde índice de carta actual hasta índice 0
        public List<string> MontonCartas(List<string> mazo, string cartaActual)
        {
            List<string> cartasMonton = new List<string>();
            // Se podría hacer con IndexOf
            //int a = mazo.IndexOf(cartaActual)
            int contador = 0;
            foreach (var item in mazo)
            {
                if (cartaActual == item)
                {
                    for (int i = 0 ; i <= contador; i++)
                    {
                        cartasMonton.Add(mazo[i]);
                    }
                }
                contador++;
            }            
            return cartasMonton;    // Devuelve lista con las cartas ya jugadas
        }// Fin MontonCartas

        // Mostrar la lista de cartas que quedan
        public List<string> MostrarCartas(List<string> mazo, string cartaActual)
        {
            List<string> cartasQuedan = new List<string>();
            if (cartaActual == "")
            {
                foreach (var item in mazo)
                {
                    cartasQuedan.Add(item);
                }
            }
            else
            {   // Se podría hacer con IndexOf
                //int a = mazo.IndexOf(cartaActual)
                int contador = 0;
                foreach (var item in mazo)
                {
                    if (cartaActual == item)
                    {
                        int dar = mazo.Count()-contador-1;
                        
                        while (dar>0)
                        {
                            dar--;
                            contador++;
                            cartasQuedan.Add(mazo[contador]);                            
                        }
                    }
                    contador++;
                }
            }
            return cartasQuedan;    // Devuelve una lista con las cartas disponibles
        }// Fin MostrarCartas
    
        // Administra la última carta que se jugó. Buscando esta carta (ya jugada) en el mazo
        // obtenemos desde su índice "hacia arriba" las cartas disponibles, y "hacia abajo" las ya jugadas
        // La ultima carta (o cartaActual) el la que se encuentra en la última posición de la lista
        // obtenida con la reciente acción realizada
        public string UltimaCarta(List<string> lista)
        {
            string cartaactual = "";
            if (lista.Count() != 0) 
            {
                cartaactual = lista[lista.Count()-1];
            }
            return cartaactual;
        } 

    }// Fin class
}//Fin namespace
