using Abp;
using Abp.Runtime.Validation;
using EV.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EV.Menus.Dto
{
    public class GetMenuListInput: PagingDto,IShouldNormalize
    {
        /// <summary>
        /// 父节点，若想选择全部节点，则传入空即可
        /// </summary>
        public string ParentId { get; set; }
        /// <summary>
        /// 过滤文本
        /// </summary>
        public string FilterText { get; set; }

        public void Normalize()
        {
            if(string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
