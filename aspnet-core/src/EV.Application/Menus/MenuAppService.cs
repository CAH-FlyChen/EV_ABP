using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using EV.Menus.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace EV.Menus
{
    public class MenuAppService : EVAppServiceBase, IMenuAppService
    {
        private readonly IRepository<Menu.Menu,Guid> _menuRepository;

        public MenuAppService(IRepository<Menu.Menu, Guid> menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<PagedResultDto<MenuListDTO>> GetMenuList(GetMenuListInput data)
        {
            try
            {
                IQueryable<Menu.Menu> q = null;
                if (!string.IsNullOrEmpty(data.FilterText))
                {
                    q = _menuRepository.GetAll().Where(t => t.Name.Contains(data.FilterText) && t.IsDeleted == false);
                }
                else
                {
                    q = _menuRepository.GetAll().Where(t => t.IsDeleted == false);
                }
                var c = await q.CountAsync();
                var x = await q.OrderBy(data.Sorting).PageBy(data).ToListAsync();

                var r = new PagedResultDto<MenuListDTO>(c, x.MapTo<List<MenuListDTO>>());
                return r;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
