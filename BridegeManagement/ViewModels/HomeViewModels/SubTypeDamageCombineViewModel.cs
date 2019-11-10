using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.HomeViewModels
{
    public class SubTypeDamageCombineViewModel
    {
        [Display(Name = "桥梁类型")]
        public BridgeSubType SubType { get; set; }
        [Display(Name = "病害代码")]
        public int DamageNum { get; set; }
        [Display(Name = "病害名称")]
        public DamageType DamageType { get; set; }
        [Display(Name = "病害数量")]
        public int DamageCounts { get; set; }


    }
}
