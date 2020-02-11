﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JustEat.Models;

namespace JustEat.Repository
{
    public class OrderRepository : Repository<Order>
    {
        public OrderRepository(JustEatEntities entity)
            : base(entity)
        {
    
        }
    

    }
}