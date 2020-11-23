using System;
using System.Collections.Generic;

namespace Ecole
{
    public class Salle
    {
        private String nom;
        private int surface;
        private int capacité;
        private int placeDisponible;
        private List<Professeur> responsables;
        private List<Etudiant> presents = new List<Etudiant>();

        public Salle(String _nom, int _surface, int _capacité, List<Professeur> _professeurs)
        {
            this.nom = _nom;
            this.surface = _surface;
            this.capacité = _capacité;
            this.placeDisponible = _capacité;
            this.responsables = _professeurs;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public int Surface
        {
            get => surface;
            set => surface = value;
        }

        public int Capacité
        {
            get => capacité;
            set => capacité = value;
        }

        public int PlaceDisponible
        {
            get => placeDisponible;
            set => placeDisponible = value;
        }

        public List<Professeur> Responsables
        {
            get => responsables;
            set => responsables = value;
        }

        public List<Etudiant> Presents
        {
            get => presents;
            set => presents = value;
        }
        
        
    }
}