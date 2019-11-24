using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProgrammerServer.DataContext;
using ProgrammerServer.Entity;
using ProgrammerServer.Repositories.IRe;

namespace ProgrammerServer.Repositories
{
    public class UserRepositories : IUserRepositories
    {
        private readonly ProgammerDbContext _progammerDbContext;

        public UserRepositories(ProgammerDbContext progammerDbContext)
        {
            _progammerDbContext = progammerDbContext;
        }

        public async Task<string> LoginTask(Users users)
        {
            Console.WriteLine(users.UserName);
            if (users.UserName.Trim().Length != 0 && users.PassWord.Trim().Length != 0 && users.IdentityCode.Trim().Length != 0)
            {
                try
                {
                    var result = await _progammerDbContext.Users.FirstOrDefaultAsync(x => x.UserName == users.UserName);
                    Console.WriteLine(result);
                    string ok = "200";
                    if (result != null)
                    {
                        return ok;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public Task<Users> RegistUser(Users user)
        {
            throw new NotImplementedException();
        }
    }
}
