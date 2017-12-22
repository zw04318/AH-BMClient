using BM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model.Nancy
{
    public class User : BaseEntity
    {

        /// <summary>
        /// 用户名(电话名)
        /// </summary>
        public string PhoneNum { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Guid
        /// </summary>
        public string Guid { get; set; }
    }

    public class UserChangPwd : BaseEntity
    {
        /// <summary>
        /// 用户名(电话名)
        /// </summary>
        public string PhoneNum { get; set; }
        /// <summary>
        /// 老密码
        /// </summary>
        public string OldPassword { get; set; }

        /// 新密码
        /// </summary>
        public string NewPassword { get; set; }
    }
}
