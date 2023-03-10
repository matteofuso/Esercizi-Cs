using System;

namespace Rettangolo
{
    /*
     Scopo : Calcolo dell'area e del perimetro di un rettangolo
    */
    class Rettangolo
    {
        static void Main(string[] args)
        {
            // Variabili e assegnazione costanti
            double baseRettangolo = 0, altezzaRettangolo, area, perimetro;
            Console.Write("Inserisci l'altezza: ");
            altezzaRettangolo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Inserisci la base: ");
            baseRettangolo = Convert.ToDouble(Console.ReadLine());
            if (altezzaRettangolo <= 0 || baseRettangolo <= 0)
            {
                Console.WriteLine("La base e l'altezza devono essere maggiori di 0");
            }
            else
            {
                // Calcolo area e perimetro del rettangolo
                area = baseRettangolo * altezzaRettangolo;
                perimetro = (baseRettangolo + altezzaRettangolo) * 2;
                // Visualizzazione dei risultati
                Console.WriteLine("L'area del rettangolo è di {0:n2} cm^2 e il perimetro di {1:n2} cm", area, perimetro);
            }
            Console.ReadKey();
        }
    }
}