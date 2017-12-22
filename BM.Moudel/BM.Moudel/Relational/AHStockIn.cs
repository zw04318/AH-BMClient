using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{

    /// <summary>
    /// 入库
    /// </summary>
    public class AHStockIn : BaseEntity
    {
        /// <summary>
        /// 入库时间
        /// </summary>
        public DateTime StockInTime { set; get; }

        /// <summary>
        /// 仓库id
        /// </summary>
        public int DepotId { set; get; }

        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 货物数量
        /// </summary>
        public double ProductQuantity { set; get; }

        /// <summary>
        /// 单价
        /// </summary>
        public double BuyingPrice { set; get; }

        /// <summary>
        /// 运费
        /// </summary>
        public double TransportationCost { set; get; }

        /// <summary>
        /// 装卸费
        /// </summary>
        public double HandlingCost { set; get; }

        /// <summary>
        /// 操作员
        /// </summary>
        public int UserId { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string ReMarks { set; get; }

    }
}
