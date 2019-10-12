using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.HomeViewModels
{
    public class CombineViewModel
    {
        [Display(Name = "桥梁名称")]
        public string BridgeName { get; set; }

        [Display(Name = "部件名称")]
        public string ComponentName { get; set; }
        /// <summary>
        ///  构件从属部位1：上部结构；2：下部结构；3：桥面系
        /// </summary>
        [Display(Name = "部件从属部位")]
        public string ComponentBelongTo { get; set; }

        [Display(Name = "病害代码")]
        public int DamageNum { get; set; }


    }
}
