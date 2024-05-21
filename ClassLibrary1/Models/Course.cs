namespace ClassLibrary1.Models
{
    public class Course
    {
        private int _idCourse;
        private string _nom;
        private string _villeDepart;
        private string _villeArrivee;
        private DateTime _dateDebut;
        private DateTime _dateFin;

        public int IdCourse
        {
            get { return _idCourse; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'ID de la course doit être supérieur ou égal à 1");
                }
                _idCourse = value;
            }
        }

        public string Nom
        {
            get { return _nom; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le nom de la course ne peut pas être vide");
                }
                _nom = value;
            }
        }

        public string VilleDepart
        {
            get { return _villeDepart; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("La ville de départ ne peut pas être vide");
                }
                _villeDepart = value;
            }
        }

        public string VilleArrivee
        {
            get { return _villeArrivee; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("La ville d'arrivée ne peut pas être vide");
                }
                _villeArrivee = value;
            }
        }

        public DateTime DateDebut
        {
            get { return _dateDebut; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La date de début ne peut pas être dans le futur");
                }
                _dateDebut = value;
            }
        }

        public DateTime DateFin
        {
            get { return _dateFin; }
            set
            {
                if (value < DateDebut)
                {
                    throw new ArgumentException("La date de fin ne peut pas être avant la date de début");
                }
                _dateFin = value;
            }
        }

        public List<Epreuve> Epreuves { get; private set; }
        public List<VoilierInscrit> VoiliersInscrits { get; private set; }
        public List<VoilierEnCourse> VoiliersEnCourse { get; private set; }

        public List<Epreuve> ListeDeroule()
        {
            return Epreuves.OrderBy(e => e.DureeEstimee).ToList();
        }

        public List<VoilierEnCourse> ListeClassement()
        {
            var voiliers = VoiliersEnCourse.ToList();
            voiliers.Sort((v1, v2) => v1.TempsReel().CompareTo(v2.TempsReel()));
            return voiliers;
        }

        public List<VoilierInscrit> ListeVoiliers()
        {
            return VoiliersInscrits.ToList();
        }
        
        public Course(int idCourse, string nom, string villeDepart, string villeArrivee, DateTime dateDebut, DateTime dateFin)
        {
            IdCourse = idCourse;
            Nom = nom;
            VilleDepart = villeDepart;
            VilleArrivee = villeArrivee;
            DateDebut = dateDebut;
            DateFin = dateFin;
            Epreuves = new List<Epreuve>();
            VoiliersInscrits = new List<VoilierInscrit>();
            VoiliersEnCourse = new List<VoilierEnCourse>();
        }
        
        public void AjouterEpreuve(Epreuve epreuve)
        {
            Epreuves.Add(epreuve);
        }

        public void SupprimerEpreuve(Epreuve epreuve)
        {
            Epreuves.Remove(epreuve);
        }
    }
}
