using Abp.Authorization;
using EV.Authorization.Roles;
using EV.Authorization.Users;

namespace EV.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
