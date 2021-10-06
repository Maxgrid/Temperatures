/**
 * températures au dessus de la moyenne des températures saisies
 * author : Emds
 * date : 01/06/2020
 */
using System;

namespace Temperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            // taille du tableau
            int taille = 365;
            // tableau des températures
            float[] t = new float[taille];
            // saisie des températures et cumul
            float moyenne = 0;
            for (int k=0; k < taille; k++)
            {
                Console.Write("Entrez la température n°" + (k + 1) + " = ");
                t[k] = float.Parse(Console.ReadLine());
                moyenne += t[k];
            }
            // calcul de la moyenne
            moyenne = moyenne / taille;
            // calcul du nombre de températures au dessus de la moyenne
            int nbsup = 0;
            for (int k = 0; k < taille; k++)
            {
                if (t[k] > moyenne)
                {
                    nbsup++;
                }
            }
            // affichage du résultat
            Console.WriteLine("nbre de t° au-dessus de la moyenne = " + nbsup);
            Console.ReadLine();
        }
    }
}
