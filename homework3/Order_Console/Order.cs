using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Console
{
    [Serializable]
    public class Order:IComparable<Order>
    {
        private List<OrderDetails> details = new List<OrderDetails>();
        public int Id { set; get; }
        public Customer Customer { set; get; }
        public Order(int orderId,Customer customer)
        {
            Id = orderId;
            Customer = customer;
        }
        public float TotalAmount
        {
            get => details.Sum(d => d.amount);
        }
        public List<OrderDetails> Details
        {
            get => this.details;
        }
        public void AddDetails(OrderDetails orderDetails)
        {
            if (this.Details.Contains(orderDetails))
            {
                throw new Exception($"订单{Id}已存在\"{orderDetails.Goods.Name}\"");
            }
            details.Add(orderDetails);
        }
        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return Id - other.Id;
        }
        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }
        public override int GetHashCode()
        {
            int result = 10;
            return result * 20 + Id.GetHashCode();
        }
        public void RemoveDetails(int num)
        {
            details.RemoveAt(num);
        }
        public override string ToString()
        {
            String result = $"orderId:{Id}, customer:({Customer})";
            details.ForEach(details => result += "\n\t" + details);
            return result;
        }
    }
}
