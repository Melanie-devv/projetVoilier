using ClassLibrary1.Models;

namespace TestProject1
{
    public class VoilierEnCourseTests
    {
        [Fact]
        public void TestVoilierEnCourseProperties()
        {
            var voilier = new VoilierEnCourse(1, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 1, 48.8566, 2.3522);

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
            Assert.Equal(48.8566, voilier.Latitude);
            Assert.Equal(2.3522, voilier.Longitude);
            Assert.Empty(voilier.ListePenalites);
        }

        [Fact]
        public void TestVoilierEnCourseInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(0, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 1, 48.8566, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "", 10, 3, 2000, DateTime.Now, "test.jpg", 1, 48.8566, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "Test Voilier", 0, 3, 2000, DateTime.Now, "test.jpg", 1, 48.8566, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "Test Voilier", 10, 0, 2000, DateTime.Now, "test.jpg", 1, 48.8566, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "Test Voilier", 10, 3, -2000, DateTime.Now, "test.jpg", 1, 48.8566, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "Test Voilier", 10, 3, 2000, DateTime.Now.AddYears(1), "test.jpg", 1, 48.8566, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 0, 48.8566, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 1, 91, 2.3522));
            Assert.Throws<ArgumentException>(() => new VoilierEnCourse(1, "Test Voilier", 10, 3, 2000, DateTime.Now, "test.jpg", 1, 48.8566, 181));
        }
    }
}
