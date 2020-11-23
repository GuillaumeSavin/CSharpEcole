using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecole
{
    class Program
    {
        static void ilFaitBeau()
        {
            Console.WriteLine("Je me sens d'attaque aujourd'hui, voici un peit contrôle surprise à ne pas piquer des hannetons");
        }
        static void Main(string[] args)
        {
            //Creation des differents objets
            Etudiant Guillaume = new Etudiant("Savin", "Guillaume");
            Etudiant Peggy = new Etudiant("Calderon", "Peggy");
            Professeur Rosa = new Professeur("Lecat", "Rosa", new List<Etudiant>(){Guillaume, Peggy});
            Professeur Kanade = new Professeur("Tachibana", "Kanade", new List<Etudiant>() { Guillaume, Peggy });
            Salle VOE = new Salle("503", 18, 3, new List<Professeur>() {Rosa, Kanade});

            Console.WriteLine(Peggy.afficherPersonne());
            Console.WriteLine(Kanade.afficherPersonne());
            //Delegation de la méthode il fait beau qui sera déclenché par l'event controle surprise
            Rosa.OnControleSurprise += ilFaitBeau;
            //Teste exception de la classe pleine
            try
            {
                Guillaume.RentrerSalle(VOE);
                Peggy.RentrerSalle(VOE);
                Rosa.RentrerSalle(VOE);
                Kanade.RentrerSalle(VOE);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Condition d'execution de l'event remplie, enclenche la methode abonné ilFaitBeau
            Rosa.EstDeBonneHumeur = true;
            
            Peggy.QuitterSalle(VOE);
            //Teste l'exception de la moyenne invalide
            try
            {
                Rosa.noterEtudiant(Guillaume, -1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                Rosa.noterEtudiant(Guillaume, 30);
                Guillaume.afficherPersonne();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Rosa.noterEtudiant(Guillaume, 15);
                Guillaume.afficherPersonne();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Guillaume.afficherPersonne();
            }
        }
    }
}