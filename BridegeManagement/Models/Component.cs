using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.Models
{
    public class Component
    {
        public Guid Id { get; set; }
        // 构件ID

        public string ComponentName { get; set; }
        //构件名称

        public int CompBelongTo { get; set; }
        // 构件从属部位1：上部结构；2：下部结构；3：桥面系

        public int CompImportance { get; set; }
        // 构件重要性（1.主要构件；2.次要构件）

        public decimal Weight { get; set; }
        //权重

        public int CompAmount { get; set; }
        // 构件数量

        public decimal CompAvgScore { get; set; }
        // 构件平均分

        public decimal CompMinScore { get; set; }
        // 构件最小评分

        public decimal CoeffT { get; set; }
        // 系数t

        public decimal CompScore { get; set; }
        // 部件评分

        public int CompGrade { get; set;}
        //部件等级



  


        [ForeignKey("Bridge")]
        public Guid BridgeId { get; set; }
        // 所属桥梁ID


        /// <summary>
        /// 桥梁<<=部件映射
        /// </summary>
        public virtual Bridge Bridge { get; set; }
        /// <summary>
        /// 部件=>>病害
        /// </summary>
        public ICollection<Damage> Damages { get; set; }
    }
}
