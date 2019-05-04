﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQL_0._0
{
    class Order
    {
        public ObjectId Id { get; set; }
        public ObjectId CustomerId { get; set; }
        public ObjectId EmployeeId { get; set; }
        public List<Item> Items { get; set; }
        public string Date { get; set; }
        public string City { get; set; }
        public int TotalCost { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }

        public Order(ObjectId customerId, ObjectId employeeId, List<Item> items, string date, string City, int totalCost)
        {
            CustomerId = customerId;
            EmployeeId = employeeId;
            Items = items;
            TotalCost = totalCost;
            Items = new List<Item>();
        }

        override
        public string ToString()
        {
            string str = String.Format("Customer ID: {0,0}\nEmployee ID: {1,0}\nItems:\n", CustomerId, EmployeeId);

            //string str = "Order ID: " + Id + "\n" +
            //    "Customer ID: " + CustomerId + "\n" +
            //    "Employee ID: " + EmployeeId + "\n" +
            //    "Items: " + "\n";
            if (Items.Capacity > 0)
            {
                var totCost = 0;
                foreach (Item item in Items)
                {
                    str += String.Format("{0,-25} | {1,5}\n", item.Name, item.Price);
                    totCost += item.Price;
                }
                str += "Total cost: " + totCost;
            }
            //return String.Format("{0,-10} - {1,-10}, {2, 10} - {3,5}"),Name, City, State, ID);
            return str;
        }
    }
}
