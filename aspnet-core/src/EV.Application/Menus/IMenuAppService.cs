using Abp.Application.Services;
using Abp.Application.Services.Dto;
using EV.Menus.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EV.Menus
{
    public interface IMenuAppService : IApplicationService
    {
        /// <summary>
        /// 获取菜单列表
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<PagedResultDto<MenuListDTO>> GetMenuList(GetMenuListInput data);
    }
}
