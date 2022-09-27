using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP4.Entities;
using TP4.Logic;

namespace ControlAplicacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ShippersLogic shippersLogic=new ShippersLogic();
            SuppliersLogic supliersLogic=new SuppliersLogic();
            
            foreach (Shippers shippers in shippersLogic.GetAll()) 
            {
                Console.WriteLine($"{shippers.ShipperID}");
                Console.WriteLine($"{shippers.CompanyName}");
                Console.WriteLine($"{shippers.Phone}");
            }

            Console.WriteLine();

            shippersLogic.Add(new Shippers
            {
                ShipperID = 20,
                CompanyName = "Company Prueba Borrado",
                Phone = "(503) 555-9832"
            });
            
            foreach (Shippers shippers in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shippers.ShipperID}");
                Console.WriteLine($"{shippers.CompanyName}");
                Console.WriteLine($"{shippers.Phone}");
            }
 
            shippersLogic.Update(new Shippers
            {
                ShipperID = 8,
                CompanyName = "Company Prueba Modificado",
                Phone = "(503) 666-9832"
            });

            foreach (Shippers shippers in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shippers.ShipperID}");
                Console.WriteLine($"{shippers.CompanyName}");
                Console.WriteLine($"{shippers.Phone}");
            }
            
            foreach (Shippers shippers in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shippers.ShipperID}");
                Console.WriteLine($"{shippers.CompanyName}");
                Console.WriteLine($"{shippers.Phone}");
            }

            Console.WriteLine();
            
            shippersLogic.Delete(9);
            foreach (Shippers shippers in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shippers.ShipperID}");
                Console.WriteLine($"{shippers.CompanyName}");
                Console.WriteLine($"{shippers.Phone}");
            }
            
            
            var shipperAMostrar = shippersLogic.GetOne(3);
            Console.WriteLine($"{shipperAMostrar.ShipperID}");
            Console.WriteLine($"{shipperAMostrar.CompanyName}");
            Console.WriteLine($"{shipperAMostrar.Phone}");
            

            foreach (Suppliers suppliers in supliersLogic.GetAll())
            {
                Console.WriteLine($"{suppliers.SupplierID}");
                Console.WriteLine($"{suppliers.CompanyName}");
                Console.WriteLine($"{suppliers.Phone}");
            }

            Console.WriteLine();

            supliersLogic.Add(new Suppliers
            {
                SupplierID = 30,
                CompanyName = "Supplier de Prueba",
                Phone = "(503) 555-9832"
            });
            
            foreach (Suppliers suppliers in supliersLogic.GetAll())
            {
                Console.WriteLine($"{suppliers.SupplierID}");
                Console.WriteLine($"{suppliers.CompanyName}");
                Console.WriteLine($"{suppliers.Phone}");
            }
           
            supliersLogic.Update(new Suppliers
            {
                SupplierID = 30,
                CompanyName = "Company Prueba Modificado",
                Phone = "(503) 666-9832"
            });

            foreach (Suppliers suppliers in supliersLogic.GetAll())
            {
                Console.WriteLine($"{suppliers.SupplierID}");
                Console.WriteLine($"{suppliers.CompanyName}");
                Console.WriteLine($"{suppliers.Phone}");
            } 
            
            foreach (Suppliers suppliers in supliersLogic.GetAll())
            {
                Console.WriteLine($"{suppliers.SupplierID}");
                Console.WriteLine($"{suppliers.CompanyName}");
                Console.WriteLine($"{suppliers.Phone}");
            }

            Console.WriteLine();
            
            supliersLogic.Delete(30);
            foreach (Suppliers suppliers in supliersLogic.GetAll())
            {
                Console.WriteLine($"{suppliers.SupplierID}");
                Console.WriteLine($"{suppliers.CompanyName}");
                Console.WriteLine($"{suppliers.Phone}");
            }
            
            
            var supplierAMostrar = supliersLogic.GetOne(3);
            Console.WriteLine($"{supplierAMostrar.SupplierID}");
            Console.WriteLine($"{supplierAMostrar.CompanyName}");
            Console.WriteLine($"{supplierAMostrar.Phone}");
            
            Console.ReadKey();
            */
        }
    }
}
