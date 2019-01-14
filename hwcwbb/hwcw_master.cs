using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helper;

namespace hwcwbb
{
    public partial class hwcw_master : Form
    {
        public hwcw_master()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            //OpenFileDialog fdlg = new OpenFileDialog();
            //fdlg.Title = "C# Corner Open File Dialog";
            //fdlg.InitialDirectory = @"c:\";   //@是取消转义字符的意思  
            //fdlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
            ///* 
            // * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项 
            // * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个. 
            // */
            //fdlg.FilterIndex = 2;
            ///* 
            // *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录， 
            // *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的   
            // */
            //fdlg.RestoreDirectory = true;
            //if (fdlg.ShowDialog() == DialogResult.OK)
            //{
            //    DataSet ds = new DataSet();
            //    Helper.Excel.ExcelHelper ExcelHelper = new Helper.Excel.ExcelHelper(System.IO.Path.GetFullPath(fdlg.FileName));
            //    ds = ExcelHelper.exceltoDataSet();
            //    //DataColumn col = new DataColumn();
            //    //col.ColumnName = "id";
            //    //col.DefaultValue = 0;
            //    //ds.Tables[0].Columns.Add(col);



            //}

            hwcw_exceltosql hwcw_exceltosql = new hwcw_exceltosql();


            hwcw_exceltosql.ShowDialog();



        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
