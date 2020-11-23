using System;

namespace Ecole
{
    //Classe abstraite
    public abstract class Personne
    {
        private String nom;
        private String prenom;

        public Personne(String _nom, String _prenom)
        {
            this.nom = _nom;
            this.prenom = _prenom;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public string Prenom
        {
            get => prenom;
            set => prenom = value;
        }
    }
}
