﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSales.Models.EF;

namespace WebSales.Models.DAO
{
    public class BaseDAO
    {
        protected T3H_K34_L1_DemoEntities1 _context;

        public BaseDAO()
        {
            _context = new T3H_K34_L1_DemoEntities1();
        }
    }
}