﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;

namespace TP4.Logic
{
    public class ShippersLogic : BaseLogic<Shippers>
    {
        public override List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public override void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }

        public override void Delete(int id)
        {
            var shipperToDelete = context.Shippers.Find(id);
            context.Shippers.Remove(shipperToDelete);
            context.SaveChanges();
        }

        public override void Update(Shippers existingShipper)
        {
            var shipperToUpdate = context.Shippers.Find(existingShipper.ShipperID);
            shipperToUpdate.CompanyName = existingShipper.CompanyName;
            shipperToUpdate.Phone = existingShipper.Phone;
            context.SaveChanges();
        }
    }
}
