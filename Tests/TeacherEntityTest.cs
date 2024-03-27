namespace Teachers.Tests
{
    [TestClass]
    public class TeacherEntityTests
    {
        [TestMethod]
        public void TeacherEntity_Initialization_ShouldSucceed()
        {
            // Arrange
            var teacher = new Teachers.Entities.TeacherEntity
            {
                Name = "Василь Миколайович",
                Age = 55,
                Department = "Фізика"
            };

            // Act
            string expectedName = "Василь Миколайович";
            int expectedAge = 55;
            string expectedDepartment = "Фізика";

            // Assert
            Assert.AreEqual(expectedName, teacher.Name);
            Assert.AreEqual(expectedAge, teacher.Age);
            Assert.AreEqual(expectedDepartment, teacher.Department);
        }
    }
}