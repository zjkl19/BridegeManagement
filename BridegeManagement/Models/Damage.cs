using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.Models
{
    public class Damage
    {
        public Guid Id { get; set; }
        // 病害ID
 
        public string DamageName { get; set; }
        // 病害名称
  
        public int DamageAmount { get; set; }
        // 病害数量

        public decimal DamageLength { get; set; }
        // 长度

        public decimal DamageArea { get; set; }
        // 面积

        public decimal MaxWidth { get; set; }
        //最大裂缝宽度

        /// <summary>
        /// 部件<<=病害
        /// </summary>
        [ForeignKey("Component")]
        public Guid ComponentId { get; set; }
        // 所属构件ID
        public virtual Component Component { get; set; }
    }
}
