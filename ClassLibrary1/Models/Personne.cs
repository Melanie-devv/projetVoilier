using System;

namespace ClassLibrary1.Models
{
    public class Personne
    {
        private int _idPersonne;
        private string _nom;
        private string _prenom;
        private string _adresse;
        private string _email;
        private DateTime _dateNaiss;
        
        public int IdPersonne
        {
            get => _idPersonne;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'identifiant de la personne doit être supérieur à zéro.");
                }
                _idPersonne = value;
            }
        }
        
        public string Nom
        {
            get => _nom;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom de la personne ne peut pas être vide.");
                }
                _nom = value;
            }
        }

        public string Prenom
        {
            get => _prenom;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le prénom de la personne ne peut pas être vide.");
                }
                _prenom = value;
            }
        }

        public string Adresse
        {
            get => _adresse;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("L'adresse de la personne ne peut pas être vide.");
                }
                _adresse = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("L'email de la personne ne peut pas être vide.");
                }
                _email = value;
            }
        }

        public DateTime DateNaiss
        {
            get => _dateNaiss;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La date de naissance de la personne ne peut pas être dans le futur.");
                }
                _dateNaiss = value;
            }
        }

        public Voilier Voilier { get; set; }
        
        public Personne(int idPersonne, string nom, string prenom, string adresse, string email, DateTime dateNaiss)
        {
            IdPersonne = idPersonne;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Email = email;
            DateNaiss = dateNaiss;
        }

        public string Description()
        {
            return $"{Nom} {Prenom} - {Email}";
        }
    }
}
