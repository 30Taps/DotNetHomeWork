using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Console
{
    public interface OrderOperation//订单操作接口
    {
        void AddOrder();//增
        void DelOrder();//删
        void ModOrder();//改
        void RefOrder();//查
    }
    public class Order
    {
        public static int OrderNum;//订单号
        public void InitOrderNum()
        {
            OrderNum = 0;
        }
    }
    public class OrderDetails : Order
    {
        public string MerchandiseName { get; set; }//商品名
        public string ClientName { get; set; }//客户名
        public string Money { get; set; }//订单价格
            
    }
    public class OrderService : OrderDetails, OrderOperation
    {
        OrderDetails[] OrderData = new OrderDetails[OrderDetails.OrderNum];
        public void RefOrder()
        {
            OrderDetails[] OrderData = new OrderDetails[Order.OrderNum];

            int i = 1;
            if (OrderDetails.OrderNum == 0)
            {
                Console.WriteLine("订单为空"); return;
            }
            while (i <= OrderDetails.OrderNum)
            {
                Console.WriteLine($"商品名：{OrderData[i-1].MerchandiseName}\t客户名：{OrderData[i-1].ClientName}\t金额：{OrderData[i-1].Money}\n");
                i++;
            }
        }

        public void AddOrder()
        {

        }
        public void DelOrder()
        {

        }
        public void ModOrder()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
