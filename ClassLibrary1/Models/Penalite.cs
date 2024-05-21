using System.Collections.Generic;

namespace ClassLibrary1.Models
{
    public class Penalite
    {
        private int _codeP;        
        private int _duree;
        private string _libelle;
        private int _longitude;
        private int _latitude;

        public int CodeP
        {
            get { return _codeP; }
            private set { _codeP = value; }
        }

        public int Duree
        {
            get { return _duree; }
            private set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("La durée de la pénalité doit être positive");
                }
                _duree = value;
            }
        }

        public string Libelle
        {
            get { return _libelle; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentException("Le libellé de la pénalité ne peut pas être vide");
                }
                _libelle = value;
            }
        }

        public int Longitude
        {
            get { return _longitude; }
            private set { _longitude = value; }
        }

        public int Latitude
        {
            get { return _latitude; }
            private set { _latitude = value; }
        }

        public List<VoilierEnCourse> VoiliersPenalises { get; private set; }

        public Penalite(int codeP, int duree, string libelle, int longitude, int latitude)
        {
            CodeP = codeP;
            Duree = duree;
            Libelle = libelle;
            Longitude = longitude;
            Latitude = latitude;
            VoiliersPenalises = new List<VoilierEnCourse>();
        }

        public string Description()
        {
            return $"{Libelle} - {Duree} minutes de pénalité";
        }
    }
}