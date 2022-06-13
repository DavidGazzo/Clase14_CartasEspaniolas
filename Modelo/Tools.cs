using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14_CartasEspaniolas.Modelo
{   // Metodos para impresion y control de errores
    internal class Tools
    {
        public string PresentationPoster(string legend)
        {
            // Genera cartel adaptandose al texto recibido
            int longer = legend.Length;
            string tittle = "";
            //string space = " ";
            string horizBar = new string('─', longer + 8);
            string vertBar = "│";
            string supIzq = "┌";
            string supDer = "┐";
            string infIzq = "└";
            string infDer = "┘";
            string margenSpace = new string(' ', 4);
            string prefix = vertBar + margenSpace;
            string suffix = margenSpace + vertBar;

            tittle = supIzq + horizBar + supDer + "\n";
            tittle += prefix + legend + suffix + "\n";
            tittle += infIzq + horizBar + infDer + "\n";

            return tittle;
        }   //  End PresentationPoster      

        public string MenuCartas()
        {
            var lineMenu = new String('─', 30);
            var opcMenu = $"┌{lineMenu}┐\n";
            opcMenu += "│1 - Barajar                   │\n│2 - Mostrar siguiente carta   │\n│3 - Cuántas cartas disponibles│\n│4 - Dar cartas                │\n"
                + "│5 - Mostrar cartas del montón │\n│6 - Mostrar baraja            │\n│7 - Salir                     │\n";
            opcMenu += $"└{lineMenu}┘\n";
            return opcMenu;
        }//Fin MenuCartas

        public bool ctrlNumber(string fact)
        {   // Controla que el valor recibido por parámetro sea numérico
            bool inNumber = Int32.TryParse(fact, out _);
            return inNumber;
        }   // End CtrlNumber

        public void PausaContinuar(string aviso, int posX, int posY)
        {            
            Console.SetCursorPosition(posX,posY);
            Console.WriteLine($"{aviso} Presione una tecla para continuar...");
            Console.ReadKey();         
        }
    }// Fin class
}// Fin namespace