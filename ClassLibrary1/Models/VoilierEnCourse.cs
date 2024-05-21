using System;
using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public class VoilierEnCourse : Voilier
    {
        private int _numInscription;
        private double _latitude;
        private double _longitude;
        private List<Penalite> _listePenalites;
        private int _tempsBrut;

        public int TempsBrut
        {
            get => _tempsBrut;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Le temps brut ne peut pas être négatif.");
                }
                _tempsBrut = value;
            }
        }


        public int NumInscription
        {
            get => _numInscription;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Le numéro d'inscription doit être supérieur à zéro.");
                }
                _numInscription = value;
            }
        }

        public double Latitude
        {
            get => _latitude;
            private set
            {
                if (value < -90 || value > 90)
                {
                    throw new ArgumentException("La latitude doit être comprise entre -90 et 90 degrés.");
                }
                _latitude = value;
            }
        }

        public double Longitude
        {
            get => _longitude;
            private set
            {
                if (value < -180 || value > 180)
                {
                    throw new ArgumentException("La longitude doit être comprise entre -180 et 180 degrés.");
                }
                _longitude = value;
            }
        }

        public IReadOnlyList<Penalite> ListePenalites => _listePenalites;

        public VoilierEnCourse(int idVoilier, string nom, int longueur, int largeur, int poids, DateTime dateConstruction, string photo, int numInscription, double latitude, double longitude)
            : base(idVoilier, nom, longueur, largeur, poids, dateConstruction, photo)
        {
            NumInscription = numInscription;
            Latitude = latitude;
            Longitude = longitude;
            _listePenalites = new List<Penalite>();
        }

        public void AjouterPenalite(Penalite penalite)
        {
            _listePenalites.Add(penalite);
        }

        public void SupprimerPenalite(Penalite penalite)
        {
            _listePenalites.Remove(penalite);
        }

        public int TempsReel()
        {
            int tempsTotal = _tempsBrut;
            foreach (var penalite in _listePenalites)
            {
                tempsTotal += penalite.Duree;
            }
            return tempsTotal;
        }

        public int Classement()
        {
            // À implémenter en fonction des règles de la course
            throw new NotImplementedException();
        }

        public string Description()
        {
            return $"{base.Description()} (numéro d'inscription : {NumInscription}, latitude : {Latitude}, longitude : {Longitude})";
        }

        public int TempsPenalite()
        {
            int tempsTotal = 0;
            foreach (var penalite in _listePenalites)
            {
                tempsTotal += penalite.Duree;
            }
            return tempsTotal;
        }
        
        public void AfficherDetails()
        {
            Console.WriteLine($"Voilier en course : {Description()}");
            Console.WriteLine($"Temps brut : {TempsBrut}");
            Console.WriteLine($"Temps réel : {TempsReel}");
            Console.WriteLine($"Pénalités : {string.Join(", ", ListePenalites.Select(p => p.Description()))}");
        }
    }
}
