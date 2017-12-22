using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Model
{
    public enum AHProductType
    {
        化肥,
        种子,
        农药
    }

    public class AHProduct : BaseEntity
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { set; get; }

        /// <summary>
        /// 产品类型 0：化肥 1：种子 2：农药
        /// </summary>
        public int ProductType { set; get; }

        /// <summary>
        /// 产品公司
        /// </summary>
        public int CompanyID { set; get; }

        /// <summary>
        /// 产品图片文件夹
        /// </summary>
        public string PictruePath { set; get; }

        /// <summary>
        /// 建议售价
        /// </summary>
        public double SuggestedPrice { set; get; }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { set; get; }

        /// <summary>
        /// 备注
        /// </summary>
        public string ReMarks { set; get; }

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
