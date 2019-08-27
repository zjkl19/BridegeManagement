using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.Models
{
    public class Damage
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// 长度
        /// </summary>
        public decimal Length { get; set; }
        /// <summary>
        /// 宽度
        /// </summary>
        public decimal Width { get; set; }
        /// <summary>
        /// 面积
        /// </summary>
        public decimal Area { get; set; }
        /// <summary>
        /// 最大裂缝宽度
        /// </summary>
        public decimal MaxCrackWidth { get; set; }

        public string Comment { get; set; }
        /// <summary>
        /// 部件<<=病害
        /// </summary>
        [ForeignKey("Component")]
        public Guid ComponentId { get; set; }
        // 所属构件ID
        public virtual Component Component { get; set; }
    }
}
