using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    /// <summary>
    /// 出库
    /// </summary>
    public class AHStockOut : BaseEntity
    {
        /// <summary>
        /// 出库时间
        /// </summary>
        public DateTime StockOutTime { set; get; }

        /// <summary>
        /// 仓库id
        /// </summary>
        public int DepotId { set; get; }

        /// <summary>
        /// 客户id
        /// </summary>
        public int ClientId { set; get; }

        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 货物数量
        /// </summary>
        public double ProductQuantity { set; get; }

        /// <summary>
        /// 平均价格
        /// </summary>
        public double BuyingPrice { set; get; }

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
