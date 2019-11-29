using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.HomeViewModels
{
    public class BelongToTypeDamageCombineViewModel
    {
        [Display(Name = "归属部位")]
        public BelongToType BelongToType { get; set; }
        [Display(Name = "病害代码")]
        public int DamageNum { get; set; }
        [Display(Name = "病害名称")]
        public DamageType DamageType { get; set; }
        [Display(Name = "病害数量")]
        public int DamageCounts { get; set; }

    }
}
