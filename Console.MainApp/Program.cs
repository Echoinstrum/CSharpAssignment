using Business.Services;
using MainApp.Services;

class Program
{
    static void Main(string[] args)
    {
        var userService = new UserService();
        var menuService = new MenuService(userService);

        menuService.MenuStart();
    }
}