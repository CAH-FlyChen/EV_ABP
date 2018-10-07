using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EV.Menu
{
    [Table("ev_menubutton")]
    public class MenuButton: FullAuditedEntity<Guid>
    {
        /// <summary>
        /// 按钮名字
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        /// <summary>
        /// 按钮代码
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Code { get; set; }

        /// <summary>
        /// 外键，所属菜单
        /// </summary>
        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }
        //public string ParentId { get; set; }
        //public int? Layers { get; set; }
        //public string Icon { get; set; }
        //public int? Location { get; set; }
        //public string JsEvent { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [Required]
        [MaxLength(500)]
        public string UrlAddress { get; set; }
        /// <summary>
        /// 是否是分隔符
        /// </summary>
        public bool Split { get; set; } = false;
        /// <summary>
        /// 是否共有
        /// </summary>
        public bool IsPublic { get; set; } = true;
    }
}
