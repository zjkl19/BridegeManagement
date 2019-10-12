using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.ViewModels.ComponentViewModels
{
    public class ComponentViewModel
    {
        [Display(Name = "部件名称")]
        public string Name { get; set; }
        /// <summary>
        ///  构件从属部位1：上部结构；2：下部结构；3：桥面系
        /// </summary>
        [Display(Name = "部件从属部位")]
        public string BelongTo { get; set; }
        /// <summary>
        /// 权重
        /// </summary>
        public decimal Weight { get; set; }
        /// <summary>
        /// 重要性（1.主要构件；2.次要构件）
        /// </summary>
        public string Importance { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 平均分
        /// </summary>
        public decimal AvgScore { get; set; }
        /// <summary>
        /// 最小评分
        /// </summary>
        public decimal MinScore { get; set; }

        /// <summary>
        /// 系数t
        /// </summary>
        public decimal Coefft { get; set; }
        /// <summary>
        /// 评分
        /// </summary>
        public decimal Score { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int Grade { get; set; }

        /// <summary>
        /// 部位评分
        /// </summary>
        public decimal PartScore { get; set; }
        /// <summary>
        /// 部位等级
        /// </summary>
        public int PartGrade { get; set; }

    }
}
