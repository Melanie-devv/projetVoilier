using ClassLibrary1.Models;

namespace TestProject1
{
    public class VoilierInscritTests
    {
        [Fact]
        public void TestVoilierInscritProperties()
        {
            var voilier = new VoilierInscrit(1, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 1);

            Assert.Equal(1, voilier.IdVoilier);
            Assert.Equal("Test Voilier", voilier.Nom);
            Assert.Equal(10, voilier.Longueur);
            Assert.Equal(3, voilier.Largeur);
            Assert.Equal(2000, voilier.Poids);
            Assert.True(voilier.DateConstruction <= DateTime.Now);
            Assert.Equal("test.jpg", voilier.Photo);
            Assert.Empty(voilier.Equipage);
            Assert.Empty(voilier.Sponsors);
            Assert.Equal(1, voilier.NumInscription);
            Assert.Null(voilier.Course);
        }

        [Fact]
        public void TestVoilierInscritInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new VoilierInscrit(0, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 1));
            Assert.Throws<ArgumentException>(() => new VoilierInscrit(1, "", 10, 3, 2000, DateTime.Now, "test.jpg", 1));
            Assert.Throws<ArgumentException>(() => new VoilierInscrit(1, "Test Voilier", 0, 3, 2000, DateTime.Now, "test.jpg", 1));
            Assert.Throws<ArgumentException>(() => new VoilierInscrit(1, "Test Voilier", 10, 0, 2000, DateTime.Now, "test.jpg", 1));
            Assert.Throws<ArgumentException>(() => new VoilierInscrit(1, "Test Voilier", 10, 3, -2000, DateTime.Now, "test.jpg", 1));
            Assert.Throws<ArgumentException>(() => new VoilierInscrit(1, "Test Voilier", 10, 3, 2000, DateTime.Now.AddYears(1), "test.jpg", 1));
            Assert.Throws<ArgumentException>(() => new VoilierInscrit(1, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 0));
        }
    }
}