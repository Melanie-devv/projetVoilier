namespace ClassLibrary1.Models
{
    public class EpreuveVoilier
    {
        private int _id;
        private int _voilierId;
        private int _epreuveId;
        private TimeSpan _duree;

        public int Id
        {
            get { return _id; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'ID de l'épreuve voilier doit être supérieur ou égal à 1");
                }
                _id = value;
            }
        }

        public int VoilierId
        {
            get { return _voilierId; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'identifiant du voilier doit être supérieur à zéro.");
                }
                _voilierId = value;
            }
        }

        public int EpreuveId
        {
            get { return _epreuveId; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("L'identifiant de l'épreuve doit être supérieur à zéro.");
                }
                _epreuveId = value;
            }
        }

        public TimeSpan Duree
        {
            get { return _duree; }
            set
            {
                if (value <= TimeSpan.Zero)
                {
                    throw new ArgumentException("La durée de l'épreuve ne peut pas être négative.");
                }
                _duree = value;
            }
        }

        public VoilierEnCourse Voilier { get; set; }
        public Epreuve Epreuve { get; set; }

        public EpreuveVoilier(int id, int voilierId, int epreuveId, TimeSpan duree)
        {
            Id = id;
            VoilierId = voilierId;
            EpreuveId = epreuveId;
            Duree = duree;
        }
    }
}