using OPManagement.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPManagement.Core.Interfaces.Domain.Repositories
{
    public interface IUserRepository :IRepository<User>
    {
        Task<User> GetUserAsync(string userName);

        Task<User> GetUser(Guid id);
    }
}
