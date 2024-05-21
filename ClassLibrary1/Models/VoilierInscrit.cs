using System;

namespace ClassLibrary1.Models
{
    public class VoilierInscrit : Voilier
    {
        private int _numInscription;
        private Course _course;

        public int NumInscription
        {
            get => _numInscription;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Le numéro d'inscription doit être supérieur à zéro.");
                }
                _numInscription = value;
            }
        }

        public Course Course
        {
            get => _course;
            set => _course = value;
        }

        public VoilierInscrit(int idVoilier, string nom, int longueur, int largeur, int poids, DateTime dateConstruction, string photo, int numInscription, Course course = null)
            : base(idVoilier, nom, longueur, largeur, poids, dateConstruction, photo)
        {
            NumInscription = numInscription;
            Course = course;
        }
    }
}