using Business.Interfaces;
using Business.Models;

namespace Business.Services;

public class UserService : IUserService
{
    private List<User> _users;
    private readonly IFileService _fileService;

    public UserService()
    {
        _fileService = new FileService();
        _users = _fileService.LoadUsersFromFile().ToList();
    }

    public void AddUser(User user)
    {
        _users.Add(user);
        _fileService.SaveUsersToFile(_users);
    }

    public List<User> GetAllUsers()
    {
        return _users;
    }
}
