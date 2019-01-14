using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hwcwbb.Model;

namespace hwcwbb.Dal
{
   public class Cost_unit_price_ljy_Dal : Base_Dal
    {
        public Cost_unit_price_ljy_Dal(Base_Dal BD):base(BD)
        {
        }

        #region 增加表记录

        /// <summary>
        /// 增加表记录
        /// </summary>
        /// <param name="cost_unit_price_ljy_list">需要保存的数据</param>
        /// <returns>如果是【OK】说明成功否则返回错误信息</returns>
        public string SaveList(List<Model.Cost_unit_price_ljy> cost_unit_price_ljy_list)
        {
            try
            {
                foreach (Cost_unit_price_ljy item in cost_unit_price_ljy_list)
                {


                    db.cost_unit_price_ljy_model.Add(item);

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
        /// <param name="cost_unit_price_ljy_list">需要修改的LIST</param>
        /// <returns>如果是【OK】说明成功否则返回错误信息</returns>
        public string UpdateList(List<Cost_unit_price_ljy> cost_unit_price_ljy_list)
        {
            ;
            try
            {
                foreach (Cost_unit_price_ljy item in cost_unit_price_ljy_list)
                {

                    db.Entry<Cost_unit_price_ljy>(item).State = System.Data.Entity.EntityState.Modified;
                    //db.Entry(item).Property("input_date").IsModified = false; //如果修改时不修改这个字段，不过在新建时没有用
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        #endregion 修改记录

        #region 删除表记录

        /// <summary>
        /// 按照给定的List删除数据
        /// </summary>
        /// <param name="out_record_jg_ljy_list"></param>
        public void DeleteList(List<Cost_unit_price_ljy> cost_unit_price_ljy_list)
        {

            foreach (Cost_unit_price_ljy item in cost_unit_price_ljy_list)
            {
                db.cost_unit_price_ljy_model.Remove(item);

                db.Entry(item).State = System.Data.Entity.EntityState.Deleted;

                //db.Entry(item).Property("input_date").IsModified = false; //如果修改时不修改这个字段，不过在新建时没有用
            }

        }

        #endregion

        #region 查询表记录

        /// <summary>
        /// 按账期查询表记录
        /// </summary>
        /// <returns></returns>
        public List<Cost_unit_price_ljy> GetList(string year, string moon)
        {
            List<Cost_unit_price_ljy> cost_unit_price_ljy_list = new List<Cost_unit_price_ljy>();

            cost_unit_price_ljy_list = db.cost_unit_price_ljy_model.Where(p => p.year == year && p.moon == moon).ToList();

            return cost_unit_price_ljy_list;
        }

        #endregion


    }
}
