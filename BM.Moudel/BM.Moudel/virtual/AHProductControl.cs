using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHProductPosition
    {
        厂家,
        途中,
        仓库,
        待送货,
        送货中,
        客户,
        待退货
    }

    public class AHProductControl : BaseEntity
    {
        /// <summary>
        /// 位置 0:厂家 1：途中 2：仓库 3：待发货 4:客户 5:客户
        /// </summary>
        public int ProductPosition { set; get; }

        /// <summary>
        /// 仓库id
        /// </summary>
        public int DepotId { set; get; }

        /// <summary>
        /// 客户ID
        /// </summary>
        public int ClientId { set; get; }

        /// <summary>
        /// 客户ID
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 产品数量
        /// </summary>
        public double ProductQuantity{ set; get; }

        /// <summary>
        /// 进货时间
        /// </summary>
        public DateTime BuyingTime { set; get; }

        /// <summary>
        /// 平均进价
        /// </summary>
        public double BuyingPrice { set; get; }
    }
}
