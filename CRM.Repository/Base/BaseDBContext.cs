﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class BaseDBContext:DbContext
    {
        public BaseDBContext() : base("name=sqlConnStr") { }
    }
}
