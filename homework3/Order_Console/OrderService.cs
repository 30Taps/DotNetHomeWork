using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Order_Console
{
    public class OrderService
    {
        private List<Order> orderList;
        public OrderService()
        {
            orderList = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            if (orderList.Contains(order))
            {
                throw new ApplicationException($"{order.Id}号订单已包含一个该订单");
            }
            orderList.Add(order);
        }
        public void Update(Order order)
        {
            RemoveOrder(order.Id);
            orderList.Add(order);
        }
        public Order GetById(int orderId)
        {
            return orderList.FirstOrDefault(o => o.Id == orderId);
        }
        public void RemoveOrder(int orderId)
        {
            orderList.RemoveAll(o => o.Id == orderId);
        }
        public List<Order> QueryAll()
        {
            return orderList;
        }
        public List<Order> QueryByGoodsName(string goodsName)
        {
            var query = orderList.Where(
              o => o.Details.Exists(
                d => d.Goods.Name == goodsName));
            return query.ToList();
        }
        public List<Order> QueryByTotalAmount(float totalAmount)
        {
            var query = orderList.Where(o => o.TotalAmount >= totalAmount);
            return query.ToList();
        }
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderList
                .Where(o => o.Customer.Name == customerName);
            return query.ToList();
        }
        public void Sort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }

        public void Export(String fileName)
        {
            if (Path.GetExtension(fileName) != ".xml")
                throw new ArgumentException("不是.xml类型文件");
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, this.orderList);
            }
        }
        public List<Order> Import(string path)
        {
            if (Path.GetExtension(path) != ".xml")
                throw new ArgumentException($"{path} 不是.xml文件");
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            List<Order> result = new List<Order>();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    return (List<Order>)xs.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("import error:" + e.Message);
            }

        }

    }
}
