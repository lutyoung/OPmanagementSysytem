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
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context)
        {
            DbContext = context;
        }

        /*public Task<PaginatedList<RoleDto>> LoadRoleAsync(string? filter,
                                                                  int page,
                                                                  int limit) =>
         DbContext.Roles
                   .Where(r => filter == null || r.Name.Contains(filter))
                   .Select(r => new RoleDto
                   {
                       Id = r.Id,
                       Name = r.Name,
                       Description = r.Description
                   })
                   .AsNoTracking()
                   .ToPaginatedListAsync(page,
                                         limit);*/
    }
}
