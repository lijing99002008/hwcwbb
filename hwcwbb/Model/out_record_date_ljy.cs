using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb.Model
{
   public class out_record_date_ljy
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
        /// 日期
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string date { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public Int16 state { get; set; }

        #endregion

    }
}
