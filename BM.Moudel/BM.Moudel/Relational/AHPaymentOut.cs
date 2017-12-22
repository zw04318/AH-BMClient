using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHPaymentOutType
    {
        厂家货款,
        客户货款
    }
    /// <summary>
    /// 出款
    /// </summary>
    public class AHPaymentOut : BaseEntity
    {
        /// <summary>
        /// 出钱时间
        /// </summary>
        public DateTime PaymentOutTime { set; get; }

        /// <summary>
        /// 操作员
        /// </summary>
        public int UserId { set; get; }

        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductId { set; get; }

        /// <summary>
        /// 客户ID
        /// </summary>
        public int ClientId { set; get; }

        /// <summary>
        /// 厂家ID
        /// </summary>
        public int CompanyId { set; get; }

        /// <summary>
        /// 出钱类型
        /// </summary>
        public int PaymentOutType { set; get; }

        /// <summary>
        /// 出钱数量
        /// </summary>
        public double PaymentOutNum { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string ReMarks { set; get; }
    }
}
