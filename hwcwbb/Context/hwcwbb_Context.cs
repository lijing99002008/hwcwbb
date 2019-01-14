using hwcwbb.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb.Context
{
   public class hwcwbb_Context : DbContext
    {
        public hwcwbb_Context() : base(GetConnStr())
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Configurations.Add(new LectraPLM_PicMonitor_Service_ConfigurationMapping());

        }
        public DbSet<out_record_jg_ljy> out_record_jg_ljy_Model { get; set; }

        public DbSet<out_record_ljy> out_record_ljy_Model { get; set; }

        public DbSet<out_record_date_ljy> out_record_date_ljy_Model { get; set; }

        public DbSet<Cost_unit_price_ljy> cost_unit_price_ljy_model { get; set; }


        #region 解密后得到连接字符串
        /// <summary>
        /// 得到解密后的连接字符串
        /// </summary>
        /// <returns>返回解密后的连接字符串</returns>
        private static string GetConnStr()
        {

            //Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ////根据Key读取<connectionString>元素的Value
            //string name = config.AppSettings.Settings["connectionString"].Value;

            //string name=ConfigurationSettings.AppSettings["connectionString"];

            string name = System.Configuration.ConfigurationManager.AppSettings["MesStationErpContext"];
            string connstr = Helper.DEncrypt.Security.DecryptDES(name);

            return connstr;

        }
        #endregion


    }
}
