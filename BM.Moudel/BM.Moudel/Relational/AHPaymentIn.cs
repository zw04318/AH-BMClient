using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHPaymentInType
    {
        客户预付款,
        厂家预付款
    }

    /// <summary>
    /// 入款
    /// </summary>
    public class AHPaymentIn : BaseEntity
    {
        /// <summary>
        /// 入款时间
        /// </summary>
        public DateTime PaymentInTime { set; get; }

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
        /// 入钱数量
        /// </summary>
        public double PaymentInNum { set; get; }


        /// <summary>
        /// 入款类型
        /// </summary>
        public int PaymentInType { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string ReMarks { set; get; }
    }
}
