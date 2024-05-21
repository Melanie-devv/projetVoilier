using ClassLibrary1.Models;

namespace TestProject1
{
    public class EpreuveVoilierTests
    {
        [Fact]
        public void TestEpreuveVoilierProperties()
        {
            var epreuveVoilier = new EpreuveVoilier(1, 1, 1, TimeSpan.FromHours(1));

            Assert.Equal(1, epreuveVoilier.Id);
            Assert.Equal(1, epreuveVoilier.VoilierId);
            Assert.Equal(1, epreuveVoilier.EpreuveId);
            Assert.Equal(TimeSpan.FromHours(1), epreuveVoilier.Duree);
        }

        [Fact]
        public void TestEpreuveVoilierInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new EpreuveVoilier(0, 1, 1, TimeSpan.FromHours(1)));
            Assert.Throws<ArgumentException>(() => new EpreuveVoilier(1, 0, 1, TimeSpan.FromHours(1)));
            Assert.Throws<ArgumentException>(() => new EpreuveVoilier(1, 1, 0, TimeSpan.FromHours(1)));
            Assert.Throws<ArgumentException>(() => new EpreuveVoilier(1, 1, 1, TimeSpan.Zero));
        }
    }
}