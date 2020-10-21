using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order_Console;
using System.Collections.Generic;
using System.IO;

namespace OrderServiceTest
{
    [TestClass]
    public class OrderServiceTest
    {
        OrderService orderService = new OrderService();

        [TestInitialize()]
        public void init()
        {
            Customer customer1 = new Customer(1, "liuwang");
            Customer customer2 = new Customer(2, "jams");

            Goods milk = new Goods(1, "milk", 69.9f);
            Goods eggs = new Goods(2, "eggs", 4.99f);
            Goods apple = new Goods(3, "apple", 5.59f);

            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetails(apple, 8));
            order1.AddDetails(new OrderDetails(eggs, 10));
            order1.AddDetails(new OrderDetails(milk, 10));

            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetails(eggs, 10));
            order2.AddDetails(new OrderDetails(milk, 10));

            Order order3 = new Order(3, customer2);
            order3.AddDetails(new OrderDetails(milk, 100));

            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Goods milk = new Goods(1, "milk", 69.9f);
            Customer customer2 = new Customer(2, "jams");
            Order order4 = new Order(4, customer2);
            order4.AddDetails(new OrderDetails(milk, 1));
            orderService.AddOrder(order4);
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(4, allOrders.Count);
            CollectionAssert.Contains(allOrders, order4);
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void AddDuplicateOrderTest()
        {
            Goods milk = new Goods(1, "milk", 69.9f);
            Customer customer2 = new Customer(2, "jams");
            Order order3 = new Order(3, customer2);
            order3.AddDetails(new OrderDetails(milk, 1));
            orderService.AddOrder(order3);
        }


        [TestMethod()]
        public void RemoveOrderTest()
        {
            orderService.RemoveOrder(3);
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(allOrders.Count, 2);
            Assert.IsNull(orderService.GetById(3));

        }

        [TestMethod()]
        public void RemoveNotExistOrderTest()
        {
            orderService.RemoveOrder(100);
            List<Order> allOrders = orderService.QueryAll();
            Assert.AreEqual(allOrders.Count, 3);
        }

        [TestMethod()]
        public void QueryOrderByIdTest()
        {
            Assert.IsNotNull(orderService.GetById(2));
            Assert.IsNull(orderService.GetById(100));
        }

        [TestMethod()]
        public void QueryOrdersByGoodsNameTest()
        {
            Assert.AreEqual(orderService.QueryByGoodsName("apple").Count, 1);
            Assert.AreEqual(orderService.QueryByGoodsName("eggs").Count, 2);
            Assert.AreEqual(orderService.QueryByGoodsName("milk").Count, 3);
            Assert.AreEqual(orderService.QueryByGoodsName("orange").Count, 0);
        }

        [TestMethod()]
        public void QueryOrdersByCustomerNameTest()
        {
            Assert.AreEqual(orderService.QueryByCustomerName("liuwang").Count, 1);
            Assert.AreEqual(orderService.QueryByCustomerName("jams").Count, 2);
            Assert.AreEqual(orderService.QueryByCustomerName("Lysa").Count, 0);
        }

        [TestMethod()]
        public void ExportTest()
        {
            String expectXMLFile = "../../ordersTarget.xml";
            String outputXMLFile = "../../ordersTarget2.xml";
            orderService.Export(outputXMLFile);
            Assert.IsTrue(File.Exists(outputXMLFile));
            string[] expectStr = File.ReadAllLines(expectXMLFile);
            string[] outputStr = File.ReadAllLines(outputXMLFile);
            Assert.AreEqual(expectStr.Length, outputStr.Length);
            for (int i = 0; i < expectStr.Length; i++)
            {
                Assert.AreEqual(expectStr[i].Trim(), outputStr[i].Trim());
            }

        }

        [TestMethod()]
        public void ImportTest1()
        {
            OrderService os = new OrderService();
            List<Order> list = os.Import("../../ordersTarget.xml");
            Assert.IsNotNull(list);
            Assert.AreEqual(list.Count, 3);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ImportTest2()
        {
            OrderService os = new OrderService();
            os.Import("../../OrderServiceTests.cs");
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void ImportTest3()
        {
            OrderService os = new OrderService();
            os.Import("../../ordersNotExist.xml");
        }

        [TestMethod()]
        [ExpectedException(typeof(ApplicationException))]
        public void ImportTest4()
        {
            OrderService os = new OrderService();
            os.Import("../../ordersErrorContain.xml");
        }
    }
}
