using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserService
    {
        void AddUser(User user); 

        IEnumerable<User> GetAllUsers();

        User? FindUserById(Guid id);
    }
}
