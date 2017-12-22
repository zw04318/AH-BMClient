using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHSex
    {
        男,
        女
    }
    public class AHClient : BaseEntity
    {
       

        /// <summary>
        /// 性别 0：男 1：女
        /// </summary>
        public int Sex { set; get; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Delete { set; get; }


        /// <summary>
        /// 客户电话
        /// </summary>
        public int PhoneNum { set; get; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        public string ClientName { set; get; }

        /// <summary>
        /// 客户备注
        /// </summary>
        public string ReMarks { set; get; }

        /// <summary>
        /// 登记时间
        /// </summary>
        public DateTime CreatTime { set; get; }

        /// <summary>
        /// 创建者
        /// </summary>
        public int UserId { set; get; }
    }
}
