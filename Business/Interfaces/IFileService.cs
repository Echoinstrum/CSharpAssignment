using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IFileService
    {
        void SaveUsersToFile(IEnumerable<User> users, string filepath);

        IEnumerable<User> LoadUsersFromFile(string filepath);
    }
}
