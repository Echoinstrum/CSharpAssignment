using Business.Interfaces;
using Business.Models;

namespace MainApp.Services;

public class MenuService
{
    private readonly IUserService _userService;

    public MenuService(IUserService userService)
    {
        _userService = userService;
    }

    public void MenuStart()
    {
        bool exitMenu = false;

        while (!exitMenu)
        {
            Console.Clear();
            Console.WriteLine("=== User Management Menu ===");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. List all users");
            Console.WriteLine("3. Exit program");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddUserDialog();
                    break;
                case "2":
                    ListAllUsersDialog();
                    break;
                case "":
                    exitMenu = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void AddUserDialog()
    {
        Console.Clear();
        Console.WriteLine("Add a new user");

        Console.Write("Enter first name: ");
        string firstName = Console.ReadLine()!;

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine()!;

        Console.Write("Enter email: ");
        string email = Console.ReadLine()!;

        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine()!;

        Console.Write("Enter street address: ");
        string streetAddress = Console.ReadLine()!;

        Console.Write("Enter postal code: ");
        string postalCode = Console.ReadLine()!;

        Console.Write("Enter place of residence: ");
        string placeOfResidence = Console.ReadLine()!;

        var newUser = new User(firstName, lastName, email, phoneNumber, streetAddress, postalCode, placeOfResidence);
        _userService.AddUser(newUser);

        Console.WriteLine("User added");

        _userService.SaveUsers(_userService.GetAllUsers());
    }

    private void ListAllUsersDialog()
    {
        Console.Clear();
        Console.WriteLine("All users");

        var users = _userService.GetAllUsers();

        if (!users.Any())
        {
            Console.WriteLine("No users found");
        }
        else
        {
            foreach (var user in users) 
            {
                Console.WriteLine($"Firstname: {user.FirstName}");
                Console.WriteLine($"Lastname: {user.LastName}");
                Console.WriteLine($"Email: {user.Email}");
                Console.WriteLine($"Phone number: {user.PhoneNumber}");
                Console.WriteLine($"Address: {user.StreetAddress}, {user.PostalCode}, {user.PlaceOfResidence}");
                Console.WriteLine("----------", 30);
            }
        }

        Console.WriteLine("Press enter to return to the menu");
        Console.ReadLine();
    }

}
