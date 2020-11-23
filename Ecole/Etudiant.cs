using System;

namespace Ecole
{
    //Heritage de Personne et IPersonneAction
    public class Etudiant : Personne, IPersonneAction
    {
        private double moyenne;

        public double Moyenne
        {
            get => moyenne;
            set => moyenne = value;
        }

        //Lance l'exception classePleineException si la classe est pleine
        public void RentrerSalle(Salle _salle)
        {
            if (_salle.PlaceDisponible == 0)
            {
                throw  new ExceptionCustom.classePleineException();
            }
            _salle.Presents.Add(this);
            _salle.PlaceDisponible--;
            Console.WriteLine("L'Eleve " + this.Nom + " " + this.Prenom + " est rentré dans la salle " + _salle.Nom);
        }

        public void QuitterSalle(Salle _salle)
        {
            _salle.Presents.Remove(this);
            _salle.PlaceDisponible++;
            Console.WriteLine("L'Eleve " + this.Nom + " " + this.Prenom + " est sortis de la salle " + _salle.Nom);
        }

        public string afficherPersonne()
        {
            return "Il s'agît de l'élève " + this.Nom + " " + this.Prenom + " dont la moyenne est de " + this.moyenne;
        }

        public Etudiant(string _nom, string _prenom) : base(_nom, _prenom)
        {
        }
    }
}