using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHProductOutType
    {
        客户订货,
        厂家退货
    }
    /// <summary>
    /// 客户订货（出货）
    /// </summary>
    public class AHProductOut : BaseEntity
    {
        /// <summary>
        /// 进货时间
        /// </summary>
        public DateTime ProductOutTime { set; get; }

        /// <summary>
        /// 出货类型
        /// </summary>
        public int ProductOutType { set; get; }

        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 入款id
        /// </summary>
        public int MoneyInId { set; get; }

        /// <summary>
        /// 客户ID
        /// </summary>
        public int ClientId { set; get; }

        /// <summary>
        /// 货物数量
        /// </summary>
        public double ProductQuantity { set; get; }

        /// <summary>
        /// 单价
        /// </summary>
        public double BuyingPrice { set; get; }

        /// <summary>
        /// 总价
        /// </summary>
        public double TotalPrice { set; get; }

        /// <summary>
        /// 自己垫资
        /// </summary>
        public double LendPrice { set; get; }

        /// <summary>
        /// 买家付款
        /// </summary>
        public double PaidPrice { set; get; }

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
