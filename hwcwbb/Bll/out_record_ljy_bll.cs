using hwcwbb.Dal;
using hwcwbb.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwcwbb.Bll
{
   public  class out_record_ljy_bll : Base_Bll
    {
        #region 声明数据访问层的类

        private Out_record_ljy_Dal out_record_ljy_dal;
        private out_record_date_ljy_Dal out_record_date_ljy_dal;
        private Out_record_jg_ljy_Dal out_record_jg_ljy_dal;
        private Cost_unit_price_ljy_Dal cost_unit_price_ljy_dal;

        #endregion 

        #region 建立连接

        public out_record_ljy_bll()
        {
            out_record_ljy_dal = new Out_record_ljy_Dal(base.base_dal);
            out_record_date_ljy_dal = new out_record_date_ljy_Dal(base.base_dal);
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
            bd.Add(out_record_date_ljy_dal);
            bd.Add(out_record_jg_ljy_dal);
            bd.Add(cost_unit_price_ljy_dal);
            DataBase_Dal.Trans(bd);
        }
        #endregion

        #region 导入表格并存储

        public string exceltodatatable(DataTable dt1, DataTable dt2)
        {
            string ss = "";
            try
            {
                Model.out_record_date_ljy out_record_date_ljy = new Model.out_record_date_ljy();
                out_record_date_ljy = out_record_date_ljy_dal.GetList_current();

                List<out_record_ljy> out_record_ljy_list = new List<out_record_ljy>();

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (dt1.Rows[i]["仓库"].ToString() == "样品库内仓" || dt1.Rows[i]["仓库"].ToString() == "渠道2组【展厅代销】")
                    {

                    }
                    else
                    {
                        out_record_ljy out_record_ljy = new out_record_ljy();
                        out_record_ljy.year = out_record_date_ljy.year;
                        out_record_ljy.moon = out_record_date_ljy.moon;
                        out_record_ljy.billno = dt1.Rows[i]["出库单号"].ToString();
                        out_record_ljy.dj_time = Convert.ToDateTime(dt1.Rows[i]["登记时间"]);
                        out_record_ljy.sh_time = Convert.ToDateTime(dt1.Rows[i]["审核时间"]);
                        out_record_ljy.Warehouse = dt1.Rows[i]["仓库"].ToString();
                        out_record_ljy.item = dt1.Rows[i]["货品编号"].ToString();
                        out_record_ljy.item_name = dt1.Rows[i]["货品名称"].ToString();
                        out_record_ljy.Specifications = dt1.Rows[i]["规格"].ToString();
                        out_record_ljy.Number = Convert.ToDecimal(dt1.Rows[i]["数量"].ToString());
                        out_record_ljy.Price = Convert.ToDecimal(dt1.Rows[i]["单价"].ToString());
                        out_record_ljy.Amount = Convert.ToDecimal(dt1.Rows[i]["金额"].ToString());
                        out_record_ljy.Cost_price = Convert.ToDecimal(dt1.Rows[i]["货品成本价"].ToString());
                        out_record_ljy.Wholesale_price = Convert.ToDecimal(dt1.Rows[i]["货品批发价"].ToString());
                        out_record_ljy.Outbound = dt1.Rows[i]["出库方式"].ToString();
                        out_record_ljy.Abstract = dt1.Rows[i]["摘要"].ToString();
                        out_record_ljy.Original_number = dt1.Rows[i]["原始单号"].ToString();
                        out_record_ljy.category = dt1.Rows[i]["类别"].ToString();
                        out_record_ljy.Single_label = dt1.Rows[i]["出库单标记"].ToString();
                        out_record_ljy.Manager = dt1.Rows[i]["经办人"].ToString();
                        out_record_ljy.bar_code = dt1.Rows[i]["条码"].ToString();
                        out_record_ljy.brand = dt1.Rows[i]["品牌"].ToString();
                        out_record_ljy.Company = dt1.Rows[i]["单位"].ToString();
                        out_record_ljy.Handle_time = dt1.Rows[i]["处理天"].ToString();
                        out_record_ljy.in_time = DateTime.Now;
                        out_record_ljy.BZ = dt1.Rows[i]["备注"].ToString();
                        out_record_ljy.source = "出库";
                        out_record_ljy.Price_HS = Convert.ToDecimal(dt1.Rows[i]["单价"].ToString());
                        out_record_ljy.Amount_HS = Convert.ToDecimal(dt1.Rows[i]["单价"].ToString()) * Convert.ToDecimal(dt1.Rows[i]["数量"].ToString());

                        out_record_ljy_list.Add(out_record_ljy);
                    }

                }

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (dt2.Rows[i]["仓库"].ToString() == "样品库内仓" || dt2.Rows[i]["仓库"].ToString() == "渠道2组【展厅代销】")
                    {

                    }
                    else
                    {
                        out_record_ljy out_record_ljy = new out_record_ljy();
                        out_record_ljy.year = out_record_date_ljy.year;
                        out_record_ljy.moon = out_record_date_ljy.moon;
                        out_record_ljy.billno = dt2.Rows[i]["入库单号"].ToString();
                        out_record_ljy.dj_time = Convert.ToDateTime(dt2.Rows[i]["登记时间"]);
                        out_record_ljy.sh_time = Convert.ToDateTime(dt2.Rows[i]["审核时间"]);
                        out_record_ljy.shop = dt2.Rows[i]["供应商"].ToString();
                        out_record_ljy.Warehouse = dt2.Rows[i]["仓库"].ToString();
                        out_record_ljy.item = dt2.Rows[i]["货品编号"].ToString();
                        out_record_ljy.item_name = dt2.Rows[i]["货品名称"].ToString();
                        out_record_ljy.Specifications = dt2.Rows[i]["规格"].ToString();
                        out_record_ljy.Number = Convert.ToDecimal(dt2.Rows[i]["数量"].ToString());
                        out_record_ljy.Price = Convert.ToDecimal(dt2.Rows[i]["单价"].ToString());
                        out_record_ljy.Amount = Convert.ToDecimal(dt2.Rows[i]["金额"].ToString());
                        out_record_ljy.Cost_price = Convert.ToDecimal(dt2.Rows[i]["货款合计"].ToString());
                        //out_record_ljy.Wholesale_price = Convert.ToDecimal(dt2.Rows[i]["入库原因"].ToString());
                        out_record_ljy.Outbound = dt2.Rows[i]["入库原因"].ToString();
                        //out_record_ljy.Abstract = dt2.Rows[i]["类别"].ToString();
                        out_record_ljy.Original_number = dt2.Rows[i]["入库单备注"].ToString();
                        out_record_ljy.category = dt2.Rows[i]["类别"].ToString();
                        out_record_ljy.Single_label = dt2.Rows[i]["入库单标记"].ToString();
                        out_record_ljy.Manager = dt2.Rows[i]["经办人"].ToString();
                        out_record_ljy.bar_code = dt2.Rows[i]["条码"].ToString();
                        out_record_ljy.brand = dt2.Rows[i]["品牌"].ToString();
                        out_record_ljy.Company = dt2.Rows[i]["单位"].ToString();
                        out_record_ljy.Handle_time = dt2.Rows[i]["处理天"].ToString();
                        out_record_ljy.logistics = dt2.Rows[i]["物流方式"].ToString();
                        out_record_ljy.in_time = DateTime.Now;
                        out_record_ljy.BZ = dt2.Rows[i]["备注"].ToString();
                        out_record_ljy.source = "入库";
                        out_record_ljy.Price_HS = Convert.ToDecimal(dt2.Rows[i]["单价"].ToString());
                        out_record_ljy.Amount_HS = Convert.ToDecimal(dt2.Rows[i]["单价"].ToString()) * Convert.ToDecimal(dt2.Rows[i]["数量"].ToString());

                        out_record_ljy_list.Add(out_record_ljy);
                    }

                }

                ss = out_record_ljy_dal.SaveList(out_record_ljy_list);
                if (ss=="OK")
                {
                    save();
                    return "ok";
                }
                else
                {
                    return ss;
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
           

  

        }

        #endregion

        #region 是否有未结账的单据

        public bool CarryForward_state()
        {
       
            try
            {
                bool state = new bool();
                out_record_date_ljy out_record_date_ljy_list = out_record_date_ljy_dal.GetList_current();
                out_record_ljy out_record_ljy = new out_record_ljy();
                out_record_date_ljy out_record_date_ljy = new out_record_date_ljy();

                out_record_ljy = out_record_ljy_dal.GetLastLineList();
                out_record_date_ljy = out_record_date_ljy_dal.GetList_current();

                if (out_record_ljy.year != out_record_date_ljy.year || out_record_ljy.moon != out_record_date_ljy.moon)
                {
                    state = true;
                }
                else
                {
                    state = false;
                }

                return state;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
           
            }


        }

        #endregion

        #region 按账期清理未结账的单据

        /// <summary>
        /// 按账期清理未结账的单据
        /// </summary>
        /// <param name="year"></param>
        /// <param name="moon"></param>
        /// <returns></returns>
        public string DeleteListNotCarryForward(string year ,string moon)
        {

            try
            {
                List<out_record_ljy> out_record_ljy_list = new List<out_record_ljy>();
                List<out_record_jg_ljy> out_record_jg_ljy_list = new List<out_record_jg_ljy>();
                List<Cost_unit_price_ljy> cost_unit_price_ljy_list = new List<Cost_unit_price_ljy>();

                out_record_ljy_list = out_record_ljy_dal.GetList(year, moon);
                out_record_jg_ljy_list = out_record_jg_ljy_dal.GetList(year, moon);
                cost_unit_price_ljy_list = cost_unit_price_ljy_dal.GetList(year, moon);

                out_record_ljy_dal.DeleteList(out_record_ljy_list);
                out_record_jg_ljy_dal.DeleteList(out_record_jg_ljy_list);
                cost_unit_price_ljy_dal.DeleteList(cost_unit_price_ljy_list);

                save();

                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
   

        }

        #endregion

    }
}
