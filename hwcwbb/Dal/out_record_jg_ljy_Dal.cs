using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hwcwbb.Model;
namespace hwcwbb.Dal
{
   public class Out_record_jg_ljy_Dal : Base_Dal
    {
        public Out_record_jg_ljy_Dal(Base_Dal BD):base(BD)
        {
        }

        #region 增加表记录

        /// <summary>
        /// 增加表记录
        /// </summary>
        /// <param name="out_record_jg_ljy_list">需要保存的数据</param>
        /// <returns>如果是【OK】说明成功否则返回错误信息</returns>
        public string SaveList(List<Model.out_record_jg_ljy> out_record_jg_ljy_list)
        {
            try
            {
                foreach (out_record_jg_ljy item in out_record_jg_ljy_list)
                {


                    db.out_record_jg_ljy_Model.Add(item);

                    db.Entry(item).State = System.Data.Entity.EntityState.Added;

                    //db.Entry(item).Property("input_date").IsModified = false; //如果修改时不修改这个字段，不过在新建时没有用
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        #endregion 增加状态子表记录

        #region 修改表记录

        /// <summary>
        /// 修改状态子表记录
        /// </summary>
        /// <param name="out_record_jg_ljy_list">需要修改的LIST</param>
        /// <returns>如果是【OK】说明成功否则返回错误信息</returns>
        public string UpdateList(List<out_record_jg_ljy> out_record_jg_ljy_list)
        {
            ;
            try
            {
                foreach (out_record_jg_ljy item in out_record_jg_ljy_list)
                {

                    db.Entry<out_record_jg_ljy>(item).State = System.Data.Entity.EntityState.Modified;
                    //db.Entry(item).Property("input_date").IsModified = false; //如果修改时不修改这个字段，不过在新建时没有用
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        #endregion 修改打印中间表记录
    }
}
