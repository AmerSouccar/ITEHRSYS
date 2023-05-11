using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HRSystem.Authorization.Roles;
using HRSystem.Authorization.Users;
using HRSystem.MultiTenancy;

namespace HRSystem.EntityFrameworkCore
{
    public class HRSystemDbContext : AbpZeroDbContext<Tenant, Role, User, HRSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HRSystemDbContext(DbContextOptions<HRSystemDbContext> options)
            : base(options)
        {
        }
    }
}
