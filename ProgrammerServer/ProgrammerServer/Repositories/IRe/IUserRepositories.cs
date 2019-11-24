using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgrammerServer.Entity;

namespace ProgrammerServer.Repositories.IRe
{
    public interface IUserRepositories
    {
        Task<string> LoginTask(Users users);
        Task<Users> RegistUser(Users user);
    }
}
