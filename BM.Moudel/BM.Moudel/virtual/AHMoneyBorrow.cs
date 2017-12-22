using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHMoneyBorrowType
    {
        客户,
        厂家,
        个人
    }

    /// <summary>
    /// 资金管理
    /// </summary>
    public class AHMoneyBorrow : BaseEntity
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
        /// 债主名称
        /// </summary>
        public string BorrowName { set; get; }

        /// <summary>
        /// 借款客户ID
        /// </summary>
        public int BorrowClientId { set; get; }

        /// <summary>
        /// 借款厂家id
        /// </summary>
        public int BorrowCompanyId { set; get; }

    }
}
