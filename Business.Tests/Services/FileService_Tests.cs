using Business.Models;
using Business.Services;

namespace Business.Tests.Services;

public class FileService_Tests
{
    [Fact]
    public void LoadUsersFromFile_ShouldReturnEmptyList__WhenFileIsMissingOrEmpty()
    {

        // Arrange
        string filePath = "users.json";

        // Act
        if (File.Exists(filePath)) 
        {
            File.Delete("users.json");
        }
        var fileService = new FileService();

        List<User> result = fileService.LoadUsersFromFile();
        
        // Assert
        Assert.Empty(result);
    }

    /* 
    Tried to also test the SaveUsersToFile method, validating saving correct data to the file. 
    But i couldn't quite come around how to do it, atleast not in time for turning in the assignment. 
    Gotta work more on that.
    */
}
