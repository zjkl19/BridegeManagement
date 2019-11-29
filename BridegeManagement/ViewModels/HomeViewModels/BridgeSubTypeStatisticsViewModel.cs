using BridegeManagement.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.HomeViewModels
{
    public class BridgeSubTypeStatisticsViewModel
    {
        public int[] BridgeSubTypeCountsArray;
        public List<SubTypeDamageCombineViewModel> SubTypeDamageCombineViewModels { get; set; }

    }

    public enum BridgeSubType
    {
        [Display(Name = "板梁")]
        banliang = 11,
        [Display(Name = "空心板梁")]
        kongxinbanliang = 12,
        [Display(Name = "T梁")]
        tliang = 13,
        [Display(Name = "小箱梁")]
        xiaoxiangliang = 14,
        [Display(Name = "箱梁")]
        xiangliang = 15,
        [Display(Name = "石拱桥")]
        shigongqiao = 21,
        [Display(Name = "圬工拱桥")]
        wugonggongqiao = 22,
        [Display(Name = "板拱")]
        bangong = 23,
        [Display(Name = "刚构桥")]
        ganggouqiao = 26,

    }

}
