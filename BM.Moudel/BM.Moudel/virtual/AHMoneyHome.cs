using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHMoneyType
    {
        现金,
        客户货款,
        厂家货款
    }
    /// <summary>
    /// 资金管理
    /// </summary>
    public class AHMoneyHome : BaseEntity
    {
        /// <summary>
        /// 资金量
        /// </summary>
        public double RMBQuantity { set; get; }

        /// 客户ID
        /// </summary>
        public int ClientId { set; get; }

        /// 厂家id
        /// </summary>
        public int CompanyId { set; get; }

        /// 资金类型
        /// </summary>
        public int MoneyType { set; get; }
    }  
}
