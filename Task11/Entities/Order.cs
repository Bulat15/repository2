using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public char CustomerID { get; set; }
        public char EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public double Freight { get; set; }
        public char ShipName { get; set; }
        public char ShipAddress { get; set; }
        public char ShipCity { get; set; }
        public char ShipRegion { get; set; }
        public char ShipPostalCode { get; set; }
        public char ShipCountry { get; set; }
        private enum Enum { New = 1, InWork, Executed };
        public int status;

        public Order(int id, DateTime OrDate, DateTime ShipDate)
        {
            OrderID = id;
            OrderDate = OrDate;
            ShippedDate = ShippedDate;
            status = (int)Enum.Executed;
        }

        public void SetStatus()
        {
            if (OrderDate == null && ShippedDate == null)
            {
                status = (int)Enum.New;
            }
            else if (ShippedDate == null && OrderDate != null)
            {
                status = (int)Enum.InWork;
            }
            else
            {
                status = (int)Enum.Executed;
            }
        }

        }
}
