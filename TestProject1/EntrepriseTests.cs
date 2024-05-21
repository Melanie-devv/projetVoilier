using ClassLibrary1.Models;

namespace TestProject1
{
    public class EntrepriseTests
    {
        [Fact]
        public void TestEntrepriseProperties()
        {
            var entreprise = new Entreprise(1, "Test Entreprise", "123 Rue de Paris", 123456789, "test@example.com", "www.example.com");

            Assert.Equal(1, entreprise.NumeroSiret);
            Assert.Equal("Test Entreprise", entreprise.Nom);
            Assert.Equal("123 Rue de Paris", entreprise.Adresse);
            Assert.Equal(123456789, entreprise.Telephone);
            Assert.Equal("test@example.com", entreprise.Mail);
            Assert.Equal("www.example.com", entreprise.SiteWeb);
            Assert.Empty(entreprise.VoiliersSponsorises);
        }

        [Fact]
        public void TestEntrepriseInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new Entreprise(0, "Test Entreprise", "123 Rue de Paris", 123456789, "test@example.com", "www.example.com"));
            Assert.Throws<ArgumentException>(() => new Entreprise(1, "", "123 Rue de Paris", 123456789, "test@example.com", "www.example.com"));
            Assert.Throws<ArgumentException>(() => new Entreprise(1, "Test Entreprise", "", 123456789, "test@example.com", "www.example.com"));
            Assert.Throws<ArgumentException>(() => new Entreprise(1, "Test Entreprise", "123 Rue de Paris", 0, "test@example.com", "www.example.com"));
            Assert.Throws<ArgumentException>(() => new Entreprise(1, "Test Entreprise", "123 Rue de Paris", 123456789, "", "www.example.com"));
        }
    }
}