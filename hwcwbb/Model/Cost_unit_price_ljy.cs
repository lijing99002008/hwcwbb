using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb.Model
{
   public class Cost_unit_price_ljy
    {

        #region 字段信息

        /// <summary>
        /// 年
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string year { get; set; }

        /// <summary>
        /// 月
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string moon { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        public string item { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Price { get; set; }

        /// <summary>        /// 录入时间        /// </summary>
        public DateTime? in_time { get; set; }

        /// <summary>        /// 更改时间        /// </summary>
        public DateTime? mod_time { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Number { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Amount { get; set; }

        #endregion

    }
}
