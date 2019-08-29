using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridegeManagement.Models
{
    public class Bridge
    {
        public Guid Id { get; set; }

        public string Number { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 桩号Kxxx+xxx
        /// </summary>
        public string PierNum { get; set; }
        /// <summary>
        /// 路线编号（Gxxx)
        /// </summary>
        public string RouteName { get; set; }
        /// <summary>
        /// 路线等级
        /// </summary>
        public int RouteGrade { get; set; }
        /// <summary>
        /// 功能类型
        /// </summary>
        public string FunctionType { get; set; }
        /// <summary>
        /// 设计荷载
        /// </summary>
        public int DesignLoad { get; set; }
        /// <summary>
        /// 桥面铺装
        /// </summary>
        public string Pavement { get; set; }

        //管理单位

        /// <summary>
        /// 修建年代
        /// </summary>
        public DateTime BuildYear { get; set; }
        /// <summary>
        /// 桥梁总长
        /// </summary>
        public decimal TotalLength { get; set; }
        /// <summary>
        /// 最大跨径
        /// </summary>
        public decimal MaxSpan { get; set; }
        /// <summary>
        /// 桥面总宽
        /// </summary>
        public decimal TotalWidth { get; set; }
        /// <summary>
        /// 车行道宽
        /// </summary>
        public decimal RoadWidth { get; set; }
        /// <summary>
        /// 主要桥型
        /// </summary>
        public int MainType { get; set; }
        /// <summary>
        /// 细分桥型
        /// </summary>
        public int SubType { get; set; }
        /// <summary>
        /// 全桥评分
        /// </summary>
        public decimal Score { get; set; }
        /// <summary>
        /// 全桥评定等级
        /// </summary>
        public int Grade { get; set; }

        public DateTime CheckYear { get; set; }

        /// <summary>
        /// 地理环境
        /// </summary>
        public int GeoCondition { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public decimal Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public decimal Latitude { get; set; }
        /// <summary>
        /// 交通量
        /// </summary>
        public int TrafficVolume { get; set; }


        /// <summary>
        /// 桥梁=>>多个部件
        /// </summary>
        public virtual ICollection<Component> Components { get; set; }
    }
}
