using Business.Interfaces;
using Business.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Business.Services;

public class FileService : IFileService
{
    private const string _filePath = "users.json";

    public void SaveUsersToFile(List<User> users)
    {
        string jsonString = JsonSerializer.Serialize(users);

        File.WriteAllText(_filePath, jsonString);
    }

    public List<User> LoadUsersFromFile()
    {
        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath, "[]");
        }

        string jsonString = File.ReadAllText(_filePath);
        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString)!;

        return users ?? new List<User>();
    }
}
 