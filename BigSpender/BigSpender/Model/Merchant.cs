﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigSpender.Model
{
    public class Merchant
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
    }
}
