using System;
using System.Collections.Generic;

namespace Ecole
{
    //Heritage de Personne et IPersonneAction
    public class Professeur : Personne, IPersonneAction
    {
        private List<Etudiant> etudiantACharge;
        private bool estDeBonneHumeur;
        
        //Création de l'événement et de son délégué
        public delegate void DelegueControleSurprise();
        public event DelegueControleSurprise OnControleSurprise;

        public bool EstDeBonneHumeur
        {
            get => estDeBonneHumeur;
            set
            {
                estDeBonneHumeur = value;
                
                //Condition d'appel de l'événement
                if (estDeBonneHumeur && OnControleSurprise != null)
                {
                    OnControleSurprise();
                }
            }
        }

        public List<Etudiant> EtudiantACharge
        {
            get => etudiantACharge;
            set => etudiantACharge = value;
        }

        public void RentrerSalle(Salle _salle)
        {
            if (_salle.PlaceDisponible == 0)
            {
                throw  new ExceptionCustom.classePleineException();
            }
            _salle.PlaceDisponible--;
            Console.WriteLine("Le Professeur " + this.Nom + " " + this.Prenom + " est rentré dans la salle " + _salle.Nom);
        }

        public void QuitterSalle(Salle _salle)
        {
            _salle.PlaceDisponible++;
            Console.WriteLine("Professeur :" + this.Nom + " " + this.Prenom + " est sortis de la salle " + _salle.Nom);
        }
        
        public string afficherPersonne()
        {
            String str = "Il s'agît de l'élève " + this.Nom + " " + this.Prenom + " responsable des élèves  suivants:\n";

            foreach (var eleve in etudiantACharge)
            {
                str += " \t" + eleve.afficherPersonne() + "\n";
            }

            return str;
        }
        
        //Lance l'exception InvalideMoyenneHorsIntervalException si la moyenne donner est incomplète
        public void noterEtudiant(Etudiant _etudiant, double _moyenne)
        {
            if (_moyenne < 0 || _moyenne > 20)
            {
                throw new ExceptionCustom.InvalideMoyenneHorsIntervalException(_moyenne);
            }
            _etudiant.Moyenne = _moyenne;
        }


        public Professeur(string _nom, string _prenom, List<Etudiant> _etudiants, bool _estDeBonneHumeur = false) : base(_nom, _prenom)
        {
            this.etudiantACharge = _etudiants;

            if (_estDeBonneHumeur)
            {
                this.EstDeBonneHumeur = true;
            }
        }
    }
}