using BridegeManagement.ViewModels.ComponentViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.HomeViewModels
{
    public class MainViewModel
    {
        public IEnumerable<CombineViewModel> CombineViewModels { get; set; }

        public int[] DamageArray;

        public string[] DamageArrayName= {"磨耗","坑槽","网裂","碎裂","裂缝","开裂","破损","剥落、掉角","空洞","露筋锈蚀","断裂、错位"
        ,"伸缩缝病害","白华、析白","砌缝脱落","渗水、水迹","塌陷","挡块密贴","钢垫板锈蚀","混凝土离析","滋生草木、青苔","勾缝脱落","位移","砌石缺失"
        ,"支座剪切","麻面","支座脱空","其它"
        };

        public int[] DamageCounts;
    }

    public enum DamageType
    {
        [Display(Name = "磨损")]
        wearout = 1,
        [Display(Name = "坑槽")]
        potholes = 2,
        [Display(Name = "网裂")]
        netcrack = 3,
        [Display(Name = "碎裂")]
        craze = 4

    }
}
