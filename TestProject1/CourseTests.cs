using ClassLibrary1.Models;

namespace TestProject1
{
    public class CourseTests
    {
        [Fact]
        public void TestCourseProperties()
        {
            var course = new Course(1, "Test Course", "Paris", "New York", DateTime.Now, DateTime.Now.AddDays(7));

            Assert.Equal(1, course.IdCourse);
            Assert.Equal("Test Course", course.Nom);
            Assert.Equal("Paris", course.VilleDepart);
            Assert.Equal("New York", course.VilleArrivee);
            Assert.True(course.DateDebut <= DateTime.Now);
            Assert.True(course.DateFin > DateTime.Now);
            Assert.Empty(course.Epreuves);
            Assert.Empty(course.VoiliersInscrits);
            Assert.Empty(course.VoiliersEnCourse);
        }

        [Fact]
        public void TestCourseInvalidArguments()
        {
            Assert.Throws<ArgumentException>(() => new Course(0, "Test Course", "Paris", "New York", DateTime.Now, DateTime.Now.AddDays(7)));
            Assert.Throws<ArgumentException>(() => new Course(1, "", "Paris", "New York", DateTime.Now, DateTime.Now.AddDays(7)));
            Assert.Throws<ArgumentException>(() => new Course(1, "Test Course", "", "New York", DateTime.Now, DateTime.Now.AddDays(7)));
            Assert.Throws<ArgumentException>(() => new Course(1, "Test Course", "Paris", "", DateTime.Now, DateTime.Now.AddDays(7)));
            Assert.Throws<ArgumentException>(() => new Course(1, "Test Course", "Paris", "New York", DateTime.Now.AddDays(7), DateTime.Now));
        }
    }
}
