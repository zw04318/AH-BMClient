using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model.Nancy
{
    public class AHRespond :BaseEntity
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Result { set; get; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { set; get; }

        /// <summary>
        /// 详细信息
        /// </summary>
        public string Detail { set; get; }

        /// <summary>
        /// 内容
        /// </summary>
        public dynamic Obj { set; get; }
    }
}
