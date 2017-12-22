using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public class AHCompany : BaseEntity
    {
        /// <summary>
        /// 厂家名字
        /// </summary>
        public string CompanyName{ set; get; }

        /// <summary>
        /// 业务员电话
        /// </summary>
        public string SalesManName { set; get; }

        /// <summary>
        /// 地区
        /// </summary>		
        public string Department { get; set; }

        /// <summary>
        /// 厂家介绍
        /// </summary>
        public string CompanyIntroduce { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string ReMarks { get; set; }
        

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Delete { set; get; }

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
