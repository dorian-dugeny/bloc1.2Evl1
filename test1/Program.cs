/**
 * titre : moyenne note 
 * author : dorian dugeny 
 * date : 22/10/2020
 * */

using System;

namespace Dorian
{
    class Program
    {
        static void Main(string[] args)
        {
            int note, compteur;
            int inferieur = 0, superieur = 0;
            for (compteur = 0; compteur <= 10; compteur++)
            {
                bool correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.WriteLine("Donnez vos notes");
                        note = int.Parse(Console.ReadLine());
                        if (note > 20)
                        {
                            correct = false;
                            Console.WriteLine("Réessayez");
                        }
                        if (note >= 10 && note < 20)
                        {
                            superieur = superieur + 1;
                            Console.WriteLine(superieur + " notes supérieur à 10");
                        }
                        if (note < 10)
                        {
                            inferieur = inferieur + 1;
                            Console.WriteLine(inferieur + " note(s) inférieur à 10");
                        }
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Entrez une note comprise entre 0 et 20");
                    }
                }
                Console.ReadLine();
            }


        }
    }
}
