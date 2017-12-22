using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHMoneyLendType
    {
        客户,
        厂家
    }

    /// <summary>
    /// 资金管理
    /// </summary>
    public class AHMoneyLend : BaseEntity
    {
        /// <summary>
        /// 资金量
        /// </summary>
        public double RMBQuantity { set; get; }

        /// <summary>
        /// 资金类型
        /// </summary>
        public int RMBType { set; get; }

        /// <summary>
        /// 出借人名称
        /// </summary>
        public string LendName { set; get; }

        /// <summary>
        /// 出借客户ID
        /// </summary>
        public int LendClientId { set; get; }


        /// <summary>
        /// 出借厂家id
        /// </summary>
        public int LendCompanyId { set; get; }
    }
}
