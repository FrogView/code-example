﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactor
{
    public class SqlServerDepartment:IBaseDepartment
    {
        public void Insert(Department user)
        {
            Console.WriteLine("在SqlServer 中给Department表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SqlServer 中根据ID得到Department表一条记录");
            return null;
        }
    }
}
