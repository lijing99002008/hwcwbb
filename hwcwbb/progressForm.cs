using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hwcwbb
{
    public delegate int addProgress(int i);
    public partial class progressForm : Form
    {
        public progressForm()
        {
            InitializeComponent();
        }
        public void Addprogess()
        {
            progressBar1.Value++;
        }
        public void labletxt(int value)
        {
            progressBar1.Value = value;
        }
    }
}
