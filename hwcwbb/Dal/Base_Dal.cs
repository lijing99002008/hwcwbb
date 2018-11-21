using hwcwbb.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwcwbb.Dal
{
   public class Base_Dal
    {

        protected internal hwcwbb_Context db;

        public Base_Dal()
        {
            db = new hwcwbb_Context();
        }

        public Base_Dal(Base_Dal bd)
        {
            db = bd.db;
        }


    }
}
