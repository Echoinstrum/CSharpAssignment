using Business.Interfaces;
using Business.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Business.Services;

public class FileService : IFileService
{
    public void SaveUsersToFile(IEnumerable<User> users, string filepath)
    {
        string jsonString = JsonSerializer.Serialize(users);

        File.WriteAllText(filepath, jsonString);
    }

    public IEnumerable<User> LoadUsersFromFile(string filepath)
    {
        string jsonString = File.ReadAllText(filepath);
        IEnumerable<User> users = JsonSerializer.Deserialize<IEnumerable<User>>(jsonString)!;

        return users ?? new List<User>();
    }
}
