using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using EV.Authorization.Roles;
using EV.Authorization.Users;
using EV.MultiTenancy;
using EV.Menu;

namespace EV.EntityFrameworkCore
{
    public class EVDbContext : AbpZeroDbContext<Tenant, Role, User, EVDbContext>
    {
        /* Define a DbSet for each entity of the application */
        /// <summary>
        /// 系统菜单
        /// </summary>
        public DbSet<Menu.Menu> Menus { get; set; }
        public DbSet<MenuButton> MenuButtons { get; set; }
        
        public EVDbContext(DbContextOptions<EVDbContext> options)
            : base(options)
        {

        }


    }
}
