using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class UserService : IUserService
{
    private List<User> _users;
    private readonly IFileService _fileService;
    private const string FilePath = "users.json";

    public UserService()
    {
        _fileService = new FileService();
        _users = _fileService.LoadUsersFromFile(FilePath).ToList();
    }

    public void SaveUsers(List<User> users)
    {
        _fileService.SaveUsersToFile(users, FilePath);
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public List<User> GetAllUsers()
    {
        return _users;
    }
}
