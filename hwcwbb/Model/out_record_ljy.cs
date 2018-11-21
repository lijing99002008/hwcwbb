using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb
{
   public class out_record_ljy
    {

        #region 字段信息

        /// <summary>        /// 单号（主键）        /// </summary>        [Required, MaxLength(200)]//必填项
        public string billno { get; set; }

        /// <summary>        /// 登记时间        /// </summary>        //[Required, MaxLength(30)]//必填项
        public DateTime? dj_time { get; set; }

        /// <summary>        /// 审核时间        /// </summary>        //[Required, MaxLength(30)]//必填项
        public DateTime? sh_time { get; set; }

        /// <summary>        /// 出库 - 店铺  入库 - 供应商        /// </summary>        [Required, MaxLength(200)]//必填项
        public string shop { get; set; }

        /// <summary>
        /// 仓库
        /// </summary>
        [Required, MaxLength(200)]//必填项
        public string Warehouse { get; set; }

        /// <summary>
        /// 货品编号
        /// </summary>
        [Required, MaxLength(200)]//必填项
        public string item { get; set; }

        /// <summary>
        /// 货品名称
        /// </summary>
        [Required, MaxLength(200)]//必填项
        public string item_name { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [Required, MaxLength(200)]//必填项
        public string Specifications { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Number { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Price { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Amount { get; set; }

        /// <summary>
        /// 出库-货品成本价 入库-货款合计
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Cost_price { get; set; }

        /// <summary>
        /// 货品批发价
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Wholesale_price { get; set; }

        /// <summary>
        /// 出库-出库方式 入库-入库原因
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string Outbound { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string Abstract { get; set; }

        /// <summary>
        /// 出库-原始单号 入库-关联业务单号
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string Original_number { get; set; }

        /// <summary>
        /// 类别
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string category { get; set; }

        /// <summary>
        /// 出库-出库单标记   入库-入库单标记
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string Single_label { get; set; }

        /// <summary>
        /// 经办人
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string Manager { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string bar_code { get; set; }

        /// <summary>
        /// 品牌
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string brand { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string Company { get; set; }

        /// <summary>
        /// 处理天
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string Handle_time { get; set; }

        /// <summary>
        /// 物流方式
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string logistics { get; set; }

        /// <summary>
        /// 录入日期
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public DateTime? in_time { get; set; }

        /// <summary>
        /// 属性 0-未锁定 1-已锁定
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public Int16 state { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string BZ { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public string source { get; set; }

        /// <summary>
        /// 含税单价
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Price_HS { get; set; }

        /// <summary>
        /// 含税金额
        /// </summary>
        //[Required, MaxLength(200)]//必填项
        public decimal Amount_HS { get; set; }

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

        #endregion

    }
}
