using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order_Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Console.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [ClassInitialize]
        public void InitOrder()
        {
            Order.OrderNum = 3;
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DelOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ModOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RefOrderTest()
        {
            OrderDetails[] OrderTest = new OrderDetails[Order.OrderNum];
            OrderTest[0].MerchandiseName = "toothbrush";
            OrderTest[0].ClientName = "zhangsan";
            OrderTest[0].Money = "100";
            OrderTest[1].MerchandiseName = "bowl";
            OrderTest[1].ClientName = "lisi";
            OrderTest[1].Money = "200";
            OrderTest[2].MerchandiseName = "car";
            OrderTest[2].ClientName = "wangwu";
            OrderTest[2].Money = "300";

        }
        [ClassCleanup]
        public void CleanOrder(OrderDetails[] order)
        {
            if (Order.OrderNum > 0)
            {
                for (int i = (Order.OrderNum - 1); i == 0; i--)
                {
                    order[i].MerchandiseName = order[i].ClientName = order[i].Money = "";
                }
                Order.OrderNum = 0;
            }
        }
    }
}