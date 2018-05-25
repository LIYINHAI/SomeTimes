﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using IDAL;
using System.Data.Entity;

namespace DAL
{
   public class SqlFoodReply:IFoodReply
    {
        FoodsEntities db = DbContextFactory.CreateDbContext();

        public void AddFoodReply(FoodReply foodReply)
        {
            db.FoodReply.Add(foodReply);
            db.SaveChanges();
        }
    }
}
