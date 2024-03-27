namespace Subjects.Tests
{
    [TestClass]
    public class SubjectEntityTests
    {
        [TestMethod]
        public void SubjectEntity_Initialization_ShouldSucceed()
        {
            // Arrange
            var subject = new Subjects.Entities.SubjectEntity
            {
                SubjectName = "Математика",
                TeacherName = "Валерія Манік"
            };

            // Act
            string expectedSubjectName = "Математика";
            string expectedTeacherName = "Валерія Манік";

            // Assert
            Assert.AreEqual(expectedSubjectName, subject.SubjectName);
            Assert.AreEqual(expectedTeacherName, subject.TeacherName);
        }
    }
}