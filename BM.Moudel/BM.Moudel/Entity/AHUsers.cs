using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHUserType
    {
        管理员,
        老板,
        员工,
        客户
    }
    public class AHUsers : BaseEntity
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 手机号（id）
        /// </summary>
        public string PhoneNum { set; get; }


        /// <summary>
        /// 所属商店id
        /// </summary>
        public string AgentId { set; get; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { set; get; }

        /// <summary>
        /// 类型 0:管理员 1：BOSS 2：员工 3：客户
        /// </summary>
        public int UserType { set; get; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { set; get; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// 身份证
        /// </summary>
        public string IdentitCards { set; get; }

        /// <summary>
        /// 地区
        /// </summary>		
        public string Department { get; set; }
        /// <summary>
        /// IP
        /// </summary>		
        public string IP { get; set; }

        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
    }
}
