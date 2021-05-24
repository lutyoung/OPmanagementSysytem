using Microsoft.EntityFrameworkCore;
using OPManagementSystem.Data.Context;
using OPManagement.Core.Interfaces.Domain.Repositories;
using OPManagement.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagementSystem.Domain.Domain.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
        {
            DbContext = context;
        }

        public async  Task<User> GetUser(Guid id)
        {
            return await Query().SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetUserAsync(string userName)
        {
            return await Query().SingleOrDefaultAsync(u => u.UserName == userName);
        }
    }
}
