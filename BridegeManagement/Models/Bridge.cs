using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.Models
{
    public class Bridge
    {
        public Guid Id { get; set; }
        // 桥梁ID

        public string Name { get; set; }        
        // 桥梁名称
       
        public string PierNum { get; set; }     
        // 桥梁桩号Kxxx+xxx

        public string RouteName { get; set; }   
        // 路线编号（Gxxx)

        public int RouteGrade { get; set; }     
        // 路线等级

        public string Functions { get; set; }
        // 功能类型

        public int DesignLoad { get; set; }
        // 设计荷载

        public string Pavement { get; set; }
        //桥面铺装

        //管理单位

        public DateTime BuildYear { get; set; }
        // 修建年代

        public decimal TotalLength { get; set; }
        // 桥梁总长

        public decimal MaxSpan { get; set; }
        //最大跨径

        public decimal TotalWidth { get; set; }
        //桥面总宽

        public decimal RoadWidth { get; set; }
        //车行道宽

        public int MainType { get; set; }
        //主要桥型

        public int SubType { get; set; }
        //细分桥型

        public decimal Score { get; set; }
        //全桥评分

        public int Grade { get; set; }
        //全桥评定等级

        public DateTime CheckYear { get; set; }
  
        
        public int GeoCondition { get; set; }
        //地理环境

        public decimal Longitude { get; set; }
        //经度

        public decimal Latitude { get; set; }
        //纬度

        public int TrafficVolume { get; set; }
        //交通量


        /// <summary>
        /// 桥梁=>>多个部件
        /// </summary>
        public virtual ICollection<Component> Components { get; set; }
    }
}
