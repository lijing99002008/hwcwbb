using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hwcwbb.Context;
using System.Transactions;

namespace hwcwbb.Dal
{
   public static class DataBase_Dal
    {
        static hwcwbb_Context db = new hwcwbb_Context();

        #region 提交数据库事务

        /// <summary>
        /// 将数据一起提交更新
        /// </summary>
        /// <param name="LBD">要一起提交的Dal对象</param>
        public static void Trans(List<Base_Dal> ListBD)
        {
            try
            {
                //开始手工事务，必须要运行到Complete才会提交事务，否则就会回滚
                using (TransactionScope ts = new TransactionScope())
                {

                    foreach (Base_Dal item in ListBD)
                    {
                        item.db.SaveChanges();
                    }

                    ts.Complete();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
