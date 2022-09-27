using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Data;

namespace TP4.Logic
{
    public class SuppliersLogic : BaseLogic<Suppliers>
    {
        public override Suppliers GetOne(int id)
        {
            return context.Suppliers.Find(id);
        }

        public override List<Suppliers> GetAll() 
        {
            return context.Suppliers.ToList();
        }

        public override void Add(Suppliers newSupplier) 
        {
            context.Suppliers.Add(newSupplier);
            context.SaveChanges();
        }

        public override void Delete(int id) 
        {
            var supplierToDelete = context.Suppliers.Find(id);
            context.Suppliers.Remove(supplierToDelete);
            context.SaveChanges();
        }

        public override void Update(Suppliers existingSupplier) 
        {
            var supplierToUpdate = this.GetOne(existingSupplier.SupplierID);
            supplierToUpdate.CompanyName = existingSupplier.CompanyName;
            supplierToUpdate.ContactName = existingSupplier.ContactName;
            supplierToUpdate.ContactTitle = existingSupplier.ContactTitle;
            supplierToUpdate.Address = existingSupplier.Address;
            supplierToUpdate.City = existingSupplier.City;
            supplierToUpdate.Region = existingSupplier.Region;
            supplierToUpdate.PostalCode = existingSupplier.PostalCode;
            supplierToUpdate.Country = existingSupplier.Country;
            supplierToUpdate.Phone = existingSupplier.Phone;
            supplierToUpdate.Fax = existingSupplier.Fax;
            supplierToUpdate.HomePage = existingSupplier.HomePage;
            context.SaveChanges();
        }
    }
}
