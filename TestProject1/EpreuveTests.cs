using ClassLibrary1.Models;
using Xunit;

namespace TestProject1
{
    public class EpreuveTests
    {
        [Fact]
        public void TestEpreuveProperties()
        {
            var epreuve = new Epreuve(1, "Test Epreuve", TimeSpan.FromHours(1), TimeSpan.FromHours(2));

            Assert.Equal(1, epreuve.IdEpreuve);
            Assert.Equal("Test Epreuve", epreuve.Libelle);
            Assert.Equal(TimeSpan.FromHours(1), epreuve.DureeEstimee);
            Assert.Equal(TimeSpan.FromHours(2), epreuve.DureeTheorique);
            Assert.Empty(epreuve.EpreuvesVoilier);
        }

        [Fact]
        public void TestEpreuveInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new Epreuve(0, "Test Epreuve", TimeSpan.FromHours(1), TimeSpan.FromHours(2)));
            Assert.Throws<ArgumentException>(() => new Epreuve(1, "", TimeSpan.FromHours(1), TimeSpan.FromHours(2)));
            Assert.Throws<ArgumentException>(() => new Epreuve(1, "Test Epreuve", TimeSpan.Zero, TimeSpan.FromHours(2)));
            Assert.Throws<ArgumentException>(() => new Epreuve(1, "Test Epreuve", TimeSpan.FromHours(1), TimeSpan.Zero));
        }
    }
}