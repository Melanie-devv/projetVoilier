using ClassLibrary1.Models;

namespace TestProject1
{
    public class PersonneTests
    {
        [Fact]
        public void TestPersonneProperties()
        {
            var personne = new Personne(1, "Dupont", "Jean", "123 Rue de Paris", "jean.dupont@example.com", DateTime.Now.AddYears(-30));

            Assert.Equal(1, personne.IdPersonne);
            Assert.Equal("Dupont", personne.Nom);
            Assert.Equal("Jean", personne.Prenom);
            Assert.Equal("123 Rue de Paris", personne.Adresse);
            Assert.Equal("jean.dupont@example.com", personne.Email);
            Assert.True(personne.DateNaiss < DateTime.Now);
        }

        [Fact]
        public void TestPersonneInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new Personne(0, "Dupont", "Jean", "123 Rue de Paris", "jean.dupont@example.com", DateTime.Now.AddYears(-30)));
            Assert.Throws<ArgumentException>(() => new Personne(1, "", "Jean", "123 Rue de Paris", "jean.dupont@example.com", DateTime.Now.AddYears(-30)));
            Assert.Throws<ArgumentException>(() => new Personne(1, "Dupont", "", "123 Rue de Paris", "jean.dupont@example.com", DateTime.Now.AddYears(-30)));
            Assert.Throws<ArgumentException>(() => new Personne(1, "Dupont", "Jean", "", "jean.dupont@example.com", DateTime.Now.AddYears(-30)));
            Assert.Throws<ArgumentException>(() => new Personne(1, "Dupont", "Jean", "123 Rue de Paris", "", DateTime.Now.AddYears(-30)));
            Assert.Throws<ArgumentException>(() => new Personne(1, "Dupont", "Jean", "123 Rue de Paris", "jean.dupont@example.com", DateTime.Now.AddYears(1)));
        }
    }
}