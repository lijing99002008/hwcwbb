using hwcwbb.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb.Bll
{
    public class Base_Bll
    {
        protected internal Base_Dal base_dal;

        public Base_Bll()
        {
            base_dal = new Base_Dal();
        }
    }
}
