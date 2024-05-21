namespace ClassLibrary1.Models
{
    public class Entreprise
    {
        private int _numeroSiret;
        private string _nom;
        private string _adresse;      
        private int _telephone;
        private string _mail;
        private string _siteWeb;
        private List<Voilier> _voiliersSponsorises;

        public int NumeroSiret
        {
            get { return _numeroSiret; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Le numéro SIRET doit être positif.");
                }
                _numeroSiret = value;
            }
        }
        public string Nom
        {
            get { return _nom; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Le nom de l'entreprise ne peut pas être vide.");
                }
                _nom = value;
            }
        }
        
        public string Adresse
        {
            get { return _adresse; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("L'adresse de l'entreprise ne peut pas être vide.");
                }
                _adresse = value;
            }
        }

        public int Telephone
        {
            get { return _telephone; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Le numéro de téléphone doit être positif.");
                }
                _telephone = value;
            }
        }

        public string Mail
        {
            get { return _mail; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("L'adresse e-mail de l'entreprise ne peut pas être vide.");
                }
                _mail = value;
            }
        }

        public string SiteWeb
        {
            get { return _siteWeb; }
            set { _siteWeb = value; }
        }

        public List<Voilier> VoiliersSponsorises
        {
            get { return _voiliersSponsorises; }
            set { _voiliersSponsorises = value; }
        }

        public string Description()
        {
            return $"{Nom} - {Mail}";
        }

        public string Sponsoree()
        {
            if (!VoiliersSponsorises.Any())
            {
                return "Cette entreprise ne sponsorise aucun voilier.";
            }

            var nomsVoiliers = string.Join(", ", VoiliersSponsorises.Select(v => v.Nom));
            return $"Cette entreprise sponsorise les voiliers suivants : {nomsVoiliers}.";
        }
        
        public Entreprise(int numeroSiret, string nom, string adresse, int telephone, string mail, string siteWeb)
        {
            NumeroSiret = numeroSiret;
            Nom = nom;
            Adresse = adresse;
            Telephone = telephone;
            Mail = mail;
            SiteWeb = siteWeb;
            VoiliersSponsorises = new List<Voilier>();
        }
    }
}
