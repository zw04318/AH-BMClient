using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHProductInType
    {
        厂家订货,
        客户退货
    }
    /// <summary>
    /// 向厂家订货（进货）
    /// </summary>
    public class AHProductIn : BaseEntity
    {
        /// <summary>
        /// 进货时间
        /// </summary>
        public DateTime ProductInTime { set; get; }

        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { set; get; }


        /// <summary>
        /// 订货图片(路径)
        /// </summary>
        public string ProductInImage { set; get; }

        /// <summary>
        /// 客户ID
        /// </summary>
        public int ClientId { set; get; }

        /// <summary>
        /// 进货类型
        /// </summary>
        public int ProductInType { set; get; }

        /// <summary>
        /// 出钱id
        /// </summary>
        public int MoneyOutId { set; get; }

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
        /// 垫资
        /// </summary>
        public double BorrowPrice { set; get; }

        /// <summary>
        /// 付款
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
