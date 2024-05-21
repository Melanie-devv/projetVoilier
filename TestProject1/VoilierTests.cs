using ClassLibrary1.Models;

namespace TestProject1
{
    public class VoilierTests
    {
        [Fact]
        public void TestVoilierProperties()
        {
            var voilier = new Voilier(1, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg");

            Assert.Equal(1, voilier.IdVoilier);
            Assert.Equal("Test Voilier", voilier.Nom);
            Assert.Equal(10, voilier.Longueur);
            Assert.Equal(3, voilier.Largeur);
            Assert.Equal(2000, voilier.Poids);
            Assert.True(voilier.DateConstruction <= DateTime.Now);
            Assert.Equal("test.jpg", voilier.Photo);
            Assert.Empty(voilier.Equipage);
            Assert.Empty(voilier.Sponsors);
        }

        [Fact]
        public void TestVoilierInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new Voilier(0, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg"));
            Assert.Throws<ArgumentException>(() => new Voilier(1, "", 10, 3, 2000, DateTime.Now, "test.jpg"));
            Assert.Throws<ArgumentException>(() => new Voilier(1, "Test Voilier", 0, 3, 2000, DateTime.Now, "test.jpg"));
            Assert.Throws<ArgumentException>(() => new Voilier(1, "Test Voilier", 10, 0, 2000, DateTime.Now, "test.jpg"));
            Assert.Throws<ArgumentException>(() => new Voilier(1, "Test Voilier", 10, 3, -2000, DateTime.Now, "test.jpg"));
            Assert.Throws<ArgumentException>(() => new Voilier(1, "Test Voilier", 10, 3, 2000, DateTime.Now.AddYears(1), "test.jpg"));
        }
    }
}