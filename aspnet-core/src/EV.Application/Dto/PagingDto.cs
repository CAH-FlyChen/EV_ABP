using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EV.Dto
{
    public class PagingDto : IPagedAndSortedResultRequest
    {
        /// <summary>
        /// 跳过条目数量
        /// </summary>
        [Range(0, Int32.MaxValue)]
        public int SkipCount { get; set; } = 0;
        /// <summary>
        /// 返回条目数量
        /// </summary>
        [Range(1, 100)]
        public int MaxResultCount { get; set; } = 50;
        /// <summary>
        /// 排序字段
        /// </summary>
        public string Sorting { get; set; }
    }
}
