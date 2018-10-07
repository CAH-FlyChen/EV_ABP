using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EV.Menus.Dto
{
   [AutoMapFrom(typeof(Menu.Menu))]
    public class MenuListDTO : FullAuditedEntityDto
    {
        /// <summary>
        /// 菜单名字
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 菜单代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Url地址
        /// </summary>
        public string UrlAddress { get; set; }
    }
}
