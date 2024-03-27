namespace Students.Tests
{
    [TestClass]
    public class StudentEntityTests
    {
        [TestMethod]
        public void StudentEntity_Initialization_ShouldSucceed()
        {
            // Arrange
            var student = new Students.Entities.StudentEntity
            {
                Name = "Jane Ja",
                Age = 19,
                StID = 21312312,
                Major = "Computer Science"
            };

            // Act
            string expectedName = "Jane Ja";
            int expectedAge = 19;
            int expectedStudentID = 21312312;
            string expectedMajor = "Computer Science";

            // Assert
            Assert.AreEqual(expectedName, student.Name);
            Assert.AreEqual(expectedAge, student.Age);
           
        }
    }
}