using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHMoneyOutType
    {
        运费,
        装卸费,
        还款,
        订货费,
        退货费,
        厂家货款,
        油费,
        饭费,
        人工费,
        工资支出,
        保险支出,
        物资购买,
        税费,
        出借,
    }
    /// <summary>
    /// 出款
    /// </summary>
    public class AHMoneyOut : BaseEntity
    {
        /// <summary>
        /// 出钱时间
        /// </summary>
        public DateTime MoneyOutTime { set; get; }

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
        public int MoneyOutType { set; get; }

        /// <summary>
        /// 出钱数量
        /// </summary>
        public double MoneyOutNum { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string ReMarks { set; get; }
    }
}
