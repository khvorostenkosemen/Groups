using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GroupEntityTests
{
    [TestMethod]
    public void GroupEntity_Initialization_ShouldSucceed()
    {
        // Arrange
        string id = "0";
        string name = "Група 1";

        // Act
        var group = new GroupEntity(id, name);

        // Assert
        Assert.IsNotNull(group);
        Assert.AreEqual(id, group.ID);
  
    }
}
