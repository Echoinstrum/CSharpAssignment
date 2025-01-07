using Business.Models;

namespace Business.Services;

public class UserService
{
    private List<User> _users = new List<User>();

    public void AddUser(string firstName, string lastName, string email, string phoneNumber, string streetAddress, string postalCode, string placeOfResidence)
    {
        var user = new User(firstName, lastName, email, phoneNumber, streetAddress, postalCode, placeOfResidence);
        _users.Add(user);
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _users;
    }

    public User? FindUserById(Guid id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }
}
