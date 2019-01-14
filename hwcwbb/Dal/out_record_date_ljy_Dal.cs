using hwcwbb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb.Dal
{
   public class out_record_date_ljy_Dal : Base_Dal
    {
        public out_record_date_ljy_Dal(Base_Dal BD):base(BD)
        {
        }

        #region 增加表记录

        /// <summary>
        /// 增加表记录
        /// </summary>
        /// <param name="out_record_date_ljy_list">需要保存的数据</param>
        /// <returns>如果是【OK】说明成功否则返回错误信息</returns>
        public string SaveList(List<Model.out_record_date_ljy> out_record_date_ljy_list)
        {
            try
            {
                foreach (out_record_date_ljy item in out_record_date_ljy_list)
                {


                    db.out_record_date_ljy_Model.Add(item);

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
        /// <param name="out_record_date_ljy_list">需要修改的LIST</param>
        /// <returns>如果是【OK】说明成功否则返回错误信息</returns>
        public string UpdateList(List<out_record_date_ljy> out_record_date_ljy_list)
        {
            ;
            try
            {
                foreach (out_record_date_ljy item in out_record_date_ljy_list)
                {

                    db.Entry<out_record_date_ljy>(item).State = System.Data.Entity.EntityState.Modified;
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

        #region 查询表记录

        /// <summary>
        /// 查询已知日期的数据
        /// </summary>
        /// <param name="date">日期</param>
        /// <returns></returns>
        public List<out_record_date_ljy> GetList(string date)
        {
            List<out_record_date_ljy> out_record_date_ljy_list = new List<out_record_date_ljy>();

            out_record_date_ljy_list = db.out_record_date_ljy_Model.Where(a => a.date == date).ToList();

            return out_record_date_ljy_list;
        }

        /// <summary>
        /// 查询当前账期
        /// </summary>
        /// <returns></returns>
        public out_record_date_ljy GetList_current()
        {
            out_record_date_ljy out_record_date_ljy = new out_record_date_ljy();

            out_record_date_ljy = db.out_record_date_ljy_Model.FirstOrDefault(a => a.state == 0);

            return out_record_date_ljy;
        }

        /// <summary>
        /// 查询当前账期的上一个账期
        /// </summary>
        /// <returns></returns>
        public out_record_date_ljy GetList_current_previous()
        {
            out_record_date_ljy out_record_date_ljy = new out_record_date_ljy();

            out_record_date_ljy = db.out_record_date_ljy_Model.OrderByDescending(s => s.date).FirstOrDefault(a => a.state == 1);
            
            return out_record_date_ljy;
        }

        /// <summary>
        /// 查询当前账期的下一个账期
        /// </summary>
        /// <returns></returns>
        public out_record_date_ljy GetList_current_Next()
        {
            out_record_date_ljy out_record_date_ljy = new out_record_date_ljy();

            out_record_date_ljy = db.out_record_date_ljy_Model.FirstOrDefault(a => a.state == 2);

            return out_record_date_ljy;
        }

        #endregion

    }
}
