using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public class AHDepot : BaseEntity
    {
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string DepotName { set; get; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        public string DepotAddress { set; get; }

        /// <summary>
        /// 地区
        /// </summary>
        public string Department { set; get; }

        /// <summary>
        /// 面积
        /// </summary>
        public double DepotArea { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string ReMarks { set; get; }

        /// <summary>
        /// 租金
        /// </summary>
        public double DepotRent { set; get; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Delete { set; get; }

        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime CreatTime { set; get; }

        /// <summary>
        /// 创建者
        /// </summary>
        public int UserId { set; get; }
    }
}
