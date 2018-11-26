using hwcwbb.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb.Bll
{
   public  class out_record_ljy_bll : Base_Bll
    {
        #region 声明数据访问层的类

        private Out_record_ljy_Dal out_record_ljy_dal;

        #endregion 

        #region 建立连接

        public out_record_ljy_bll()
        {
            out_record_ljy_dal = new Out_record_ljy_Dal(base.base_dal);
        }

        #endregion

        #region 数据操作后存储

        /// <summary>
        /// 数据操作后存储
        /// </summary>
        public void save()
        {

            //cp_style_dal.save();
            List<Base_Dal> bd = new List<Base_Dal>();
            bd.Add(out_record_ljy_dal);
            DataBase_Dal.Trans(bd);
        }
        #endregion

    }
}
