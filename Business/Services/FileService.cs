using Business.Interfaces;
using Business.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Business.Services;

public class FileService : IFileService
{
    public void SaveUsersToFile(List<User> users, string filepath)
    {
        string jsonString = JsonSerializer.Serialize(users);

        File.WriteAllText(filepath, jsonString);
    }

    public List<User> LoadUsersFromFile(string filepath)
    {
        if (!File.Exists(filepath))
        {
            File.WriteAllText(filepath, "[]");
        }

        string jsonString = File.ReadAllText(filepath);
        List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString)!;

        return users ?? new List<User>();
    }
}
