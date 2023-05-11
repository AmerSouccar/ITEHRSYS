using Abp.Authorization;
using HRSystem.Authorization.Roles;
using HRSystem.Authorization.Users;

namespace HRSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
