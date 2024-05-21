namespace ClassLibrary1.Models
{
    public class Epreuve
    {
        private int _idEpreuve;
        private string _libelle;
        private TimeSpan _dureeEstimee;
        private TimeSpan _dureeTheorique;



        public int IdEpreuve
        {
            get { return _idEpreuve; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'ID de l'épreuve doit être supérieur ou égal à 1");
                }
                _idEpreuve = value;
            }
        }

        public string Libelle
        {
            get { return _libelle; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le libellé de l'épreuve ne peut pas être vide");
                }
                _libelle = value;
            }
        }

        public TimeSpan DureeEstimee
        {
            get { return _dureeEstimee; }
            set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentException("La durée estimée de l'épreuve doit être supérieure à zéro");
                }
                _dureeEstimee = value;
            }
        }

        public TimeSpan DureeTheorique
        {
            get { return _dureeTheorique; }
            set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentException("La durée théorique de l'épreuve doit être supérieure à zéro");
                }
                _dureeTheorique = value;
            }
        }

        public Course Course { get; set; }
        public ICollection<EpreuveVoilier> EpreuvesVoilier { get; set; }

        public Epreuve(int idEpreuve, string libelle, TimeSpan dureeEstimee, TimeSpan dureeTheorique)
        {
            IdEpreuve = idEpreuve;
            Libelle = libelle;
            DureeEstimee = dureeEstimee;
            DureeTheorique = dureeTheorique;
            EpreuvesVoilier = new HashSet<EpreuveVoilier>();
        }
    }
}