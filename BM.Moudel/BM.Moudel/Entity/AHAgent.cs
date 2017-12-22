using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public class AHAgent : BaseEntity
    {
        /// <summary>
        /// 公司名
        /// </summary>
        public string ShopName { set; get; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string Contact { set; get; }

        /// <summary>
        /// 手机号（id）
        /// </summary>
        public string PhoneNum { set; get; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { set; get; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// 客户备注
        /// </summary>
        public string ReMarks { set; get; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
    }
}
