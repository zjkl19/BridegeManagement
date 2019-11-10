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
        mosun = 1,
        [Display(Name = "坑槽")]
        kengcao = 2,
        [Display(Name = "网裂")]
        wanglie = 3,
        [Display(Name = "碎裂")]
        suilie = 4,
        [Display(Name = "裂缝")]
        liefeng = 5,
        [Display(Name = "开裂")]
        kailie = 6,
        [Display(Name = "破损")]
        posun = 7,
        [Display(Name = "剥落、掉角")]
        boluodiaojiao = 8,
        [Display(Name = "空洞")]
        kongdong = 9,
        [Display(Name = "露筋锈蚀")]
        lujinxiushi = 10,
        [Display(Name = "断裂、错位")]
        duanliecuowei = 11,
        [Display(Name = "伸缩缝病害")]
        shensuofeng = 12,
        [Display(Name = "白华、析白")]
        baihuaxibai = 13,
        [Display(Name = "砌缝脱落")]
        qifengtuoluo = 14,
        [Display(Name = "渗水、水迹")]
        shenshuishuiji = 15,
        [Display(Name = "塌陷")]
        taxian = 16,
        [Display(Name = "挡块密贴")]
        dangkuaimitie = 17,
        [Display(Name = "钢垫板锈蚀")]
        gangdianbanxiushi = 18,
        [Display(Name = "混凝土离析")]
        hunningtulixi = 19,
        [Display(Name = "滋生草木、青苔")]
        zishengcaomuqingtai = 20,
        [Display(Name = "勾缝脱落")]
        goufengtuoluo = 22,
        [Display(Name = "位移")]
        weiyi = 23,
        [Display(Name = "砌石缺失")]
        qishiqueshi = 24,
        [Display(Name = "支座剪切")]
        zhizuojianqie = 25,
        [Display(Name = "麻面")]
        mamian = 26,
        [Display(Name = "支座脱空")]
        zhizuotuokong = 27,
        [Display(Name = "其它")]
        qita = 999,
    }
}
