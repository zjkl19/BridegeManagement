using BridegeManagement.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.HomeViewModels
{
    public class BelongToTypeStatisticsViewModel
    {
        public int[] BelongToTypeCountsArray;
        public List<BelongToTypeDamageCombineViewModel> BelongToTypeDamageCombineViewModels { get; set; }

    }

    public enum BelongToType
    {
        [Display(Name = "上部结构")]
        superstructure = 1,
        [Display(Name = "下部结构")]
        suberstructure = 2,
        [Display(Name = "桥面系")]
        bridgedeck = 3,
    }

}
