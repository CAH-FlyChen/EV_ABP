using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV.Menu
{
    [Table("ev_menu")]
    public class Menu : FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 菜单名字
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        /// <summary>
        /// 菜单代码
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }

        /// <summary>
        /// 父Id,空则表示根
        /// </summary>
        [MaxLength(32)]
        public string ParentId { get; set; }
        /// <summary>
        /// 层级
        /// </summary>
        public int Layers { get; set; } = 0;
        /// <summary>
        /// 图标
        /// </summary>
        [MaxLength(32)]
        public string Icon { get; set; }
        /// <summary>
        /// 地址路径
        /// </summary>
        [Required(ErrorMessage ="地址路径不能为空")]
        [MaxLength(500)]
        public string UrlAddress { get; set; }
        ///// <summary>
        ///// 目标
        ///// </summary>
        //public string Target { get; set; }
        ///// <summary>
        ///// 是否是菜单
        ///// </summary>
        //public bool IsMenu { get; set; } = 
        /// <summary>
        /// 是否可以展开
        /// </summary>
        public bool IsExpand { get; set; } = false;
        /// <summary>
        /// 是否是共有的
        /// </summary>
        public bool IsPublic { get; set; } = false;
    }
}
