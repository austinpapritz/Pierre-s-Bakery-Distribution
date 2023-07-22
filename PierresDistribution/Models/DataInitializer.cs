// DEVELOPMENT DATA ONLY, DELETE IN PRODUCTION
using System;
using System.Collections.Generic;

namespace PierresDistribution.Models
{
    public static class DataInitializer
    {
        public static void InitializeData()
        {
            // Test products.
            Bread bread1 = new Bread("Pumpernickel Bread", 4.5m);
            Bread bread2 = new Bread("Whole Wheat Bread", 5.0m);
            Bread bread3 = new Bread("White Bread", 3.5m);

            Pastry pastry1 = new Pastry("Croissant", 2.5m);
            Pastry pastry2 = new Pastry("Cannoli", 3.0m);
            Pastry pastry3 = new Pastry("Eclaire", 4.0m);

            // Test vendors.
            Vendor vendor1 = new("Billy's Bakery");
            Vendor vendor2 = new("Crazy Croissants");
            Vendor vendor3 = new("Bread-O-Rama");

            // Create 5 different orders and add to vendor1's order list.
            for (int i = 0; i < 5; i++)
            {
                // Different date for each order.
                int orderDate = 71023 + i*100;

                // Vary the quantity for each item.
                int quantity = 10 * (i + 1);

                OrderItem orderItem1 = new OrderItem(bread1, quantity);
                OrderItem orderItem2 = new OrderItem(pastry2, quantity);
                OrderItem orderItem3 = new OrderItem(bread3, quantity);
                OrderItem orderItem4 = new OrderItem(pastry1, quantity);
                OrderItem orderItem5 = new OrderItem(bread2, quantity);
                OrderItem orderItem6 = new OrderItem(pastry3, quantity);

                Order order = new Order(orderDate, orderItem1, orderItem2, orderItem3, orderItem4, orderItem5, orderItem6);

                vendor1.AddOrder(order);
            }

            // Create 5 different orders and add to vendor2's order list.
            for (int i = 1; i < 6; i++)
            {
                // Different date for each order.
                int orderDate = 71323 + i*100;

                // Vary the quantity for each item.
                int quantity = 10 * (i + 2);

                OrderItem orderItem1 = new OrderItem(bread1, quantity);
                OrderItem orderItem2 = new OrderItem(pastry2, quantity);
                OrderItem orderItem3 = new OrderItem(bread3, quantity);
                OrderItem orderItem4 = new OrderItem(pastry1, quantity);
                OrderItem orderItem5 = new OrderItem(bread2, quantity);
                OrderItem orderItem6 = new OrderItem(pastry3, quantity);

                Order order = new Order(orderDate, orderItem1, orderItem2, orderItem3, orderItem4, orderItem5, orderItem6);

                vendor2.AddOrder(order);
            }

            // Create 5 different orders and add to vendor3's order list.
            for (int i = 2; i < 7; i++)
            {
                // Different date for each order.
                int orderDate = 71523 + i*1000;

                // Vary the quantity for each item.
                int quantity = 10 * (i + 3);

                OrderItem orderItem1 = new OrderItem(bread1, quantity);
                OrderItem orderItem2 = new OrderItem(pastry2, quantity);
                OrderItem orderItem3 = new OrderItem(bread3, quantity);
                OrderItem orderItem4 = new OrderItem(pastry1, quantity);
                OrderItem orderItem5 = new OrderItem(bread2, quantity);
                OrderItem orderItem6 = new OrderItem(pastry3, quantity);

                Order order = new Order(orderDate, orderItem1, orderItem2, orderItem3, orderItem4, orderItem5, orderItem6);

                vendor3.AddOrder(order);
            }

            
        }
    }
}
