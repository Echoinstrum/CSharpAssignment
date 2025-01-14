﻿using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IFileService
    {
        void SaveUsersToFile(List<User> users);

        List<User> LoadUsersFromFile();
    }
}
