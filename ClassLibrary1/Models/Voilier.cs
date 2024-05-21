namespace ClassLibrary1.Models
{
    public class Voilier
    {
        private int _idVoilier;
        private string _nom;
        private int _longueur;
        private int _largeur;
        private int _poids;
        private DateTime _dateConstruction;
        private string _photo;
        private ICollection<Personne> _equipage;
        private ICollection<Entreprise> _sponsors;

        public int IdVoilier
        {
            get => _idVoilier;
        }

        public string Nom
        {
            get => _nom; 
            set => _nom = value;
        }

        public int Longueur
        {
            get => _longueur; 
            set => _longueur = value > 0 
                ? value 
                : throw new ArgumentException("La longueur doit être positive");
        }

        public int Largeur
        {
            get => _largeur; 
            set => _largeur = value > 0 
                ? value 
                : throw new ArgumentException("La largeur doit être positive");
        }

        public int Poids
        {
            get => _poids; 
            set => _poids = value;
        }

        public DateTime DateConstruction
        {
            get => _dateConstruction; 
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La date de construction ne peut pas être dans le futur");
                }
                _dateConstruction = value;
            }
        }

        public string Photo
        {
            get => _photo; 
            set => _photo = value;
        }

        public ICollection<Personne> Equipage
        {
            get => _equipage; 
            set => _equipage = value ?? throw new ArgumentNullException(nameof(Equipage));
        }

        public ICollection<Entreprise> Sponsors
        {
            get => _sponsors; 
            set => _sponsors = value ?? throw new ArgumentNullException(nameof(Sponsors));
        }

        public string Description()
        {
            return $"{Nom} - {Longueur}m de long, {Largeur}m de large, {Poids}kg";
        }

        public List<Personne> ListeEquipage()
        {
            return Equipage.ToList();
        }

        public List<Entreprise> ListeSponsor()
        {
            return Sponsors.ToList();
        }

        public Voilier(int idVoilier, string nom, int longueur, int largeur, int poids, DateTime dateConstruction, string photo)
        {
            if (idVoilier <= 0)
            {
                throw new ArgumentException("L'ID du voilier doit être positif");
            }
            if (string.IsNullOrWhiteSpace(nom))
            {
                throw new ArgumentException("Le nom du voilier ne peut pas être vide");
            }
            if (longueur <= 0 || largeur <= 0)
            {
                throw new ArgumentException("La longueur et la largeur doivent être positives");
            }
            if (poids < 0)
            {
                throw new ArgumentException("Le poids ne peut pas être négatif");
            }

            _idVoilier = idVoilier;
            Nom = nom;
            Longueur = longueur;
            Largeur = largeur;
            Poids = poids;
            DateConstruction = dateConstruction;
            Photo = photo;
            Equipage = new HashSet<Personne>();
            Sponsors = new HashSet<Entreprise>();
        }

        public void AjouterPersonne(Personne personne)
        {
            if (personne == null)
            {
                throw new ArgumentNullException(nameof(personne));
            }
            if (_equipage.Count >= 10)
            {
                throw new InvalidOperationException("L'équipage ne peut pas comporter plus de 10 personnes");
            }
            _equipage.Add(personne);
        }

        public void SupprimerPersonne(Personne personne)
        {
            if (personne == null)
            {
                throw new ArgumentNullException(nameof(personne));
            }
            _equipage.Remove(personne);
        }
        
        public void AjouterEquipier(Personne equipier)
        {
            Equipage.Add(equipier);
        }

        public void SupprimerEquipier(Personne equipier)
        {
            Equipage.Remove(equipier);
        }

        public void AjouterSponsor(Entreprise sponsor)
        {
            Sponsors.Add(sponsor);
        }

        public void SupprimerSponsor(Entreprise sponsor)
        {
            Sponsors.Remove(sponsor);
        }
    }
}
