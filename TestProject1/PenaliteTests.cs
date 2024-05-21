using ClassLibrary1.Models;

namespace TestProject1
{
    public class PenaliteTests
    {
        [Fact]
        public void TestPenaliteProperties()
        {
            var penalite = new Penalite(1, 10, "Test Penalite", 48, 2);

            Assert.Equal(1, penalite.CodeP);
            Assert.Equal(10, penalite.Duree);
            Assert.Equal("Test Penalite", penalite.Libelle);
            Assert.Equal(48, penalite.Longitude);
            Assert.Equal(2, penalite.Latitude);
            Assert.Empty(penalite.VoiliersPenalises);
        }

        [Fact]
        public void TestPenaliteInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new Penalite(1, -10, "Test Penalite", 48, 2));
            Assert.Throws<ArgumentException>(() => new Penalite(1, 10, "", 48, 2));
        }
    }
}