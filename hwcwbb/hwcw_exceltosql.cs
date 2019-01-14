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
using System.Threading;

namespace hwcwbb
{
    public partial class hwcw_exceltosql : Form
    {
        public List<int> Sum = new List<int>();
        public delegate int addProgress(int i);
        public hwcw_exceltosql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";   //@是取消转义字符的意思  
            fdlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
            /* 
             * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项 
             * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个. 
             */
            fdlg.FilterIndex = 2;
            /* 
             *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录， 
             *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的   
             */
            fdlg.RestoreDirectory = true;
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            Thread progressthread = new Thread(new ParameterizedThreadStart(thread));

            progressthread.Start();

            //DataTable dt_Excel1 = new DataTable();
            //DataTable dt_Excel2 = new DataTable();

            //dt_Excel1 = Helper.Excel.Excel_Export.ExcelToDataTable("出库明细账$");
            //dt_Excel2 = Helper.Excel.Excel_Export.ExcelToDataTable("入库明细账$");

            //Bll.out_record_ljy_bll out_record_ljy_bll = new Bll.out_record_ljy_bll();

            //if (out_record_ljy_bll.exceltodatatable(dt_Excel1, dt_Excel2)=="ok")
            //{

            //}
            label1.Text = Sum.Count().ToString();
        }
        public void thread(object length)
        {
            bool a = true;
            progressForm progress = new progressForm();

            progress.Show();
            addProgress pro = add;

            for (int i = 0; i < 100; i++)
            {
                IAsyncResult asyncResult = pro.BeginInvoke(i, null, null);
                while (!asyncResult.IsCompleted)
                {
                    Thread.Sleep(100);
                }
                //progress.Addprogess();
                progress.labletxt(pro.EndInvoke(asyncResult));
            }

        }
        public int add(int i)
        {
            Sum.Add(i);

            return Sum.Count();
        }

    }
}
