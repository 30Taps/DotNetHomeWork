using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Console
{
    public class OrderDetails
    {
        public Goods Goods { set; get; }
        public uint Quantity { set; get; }
        public OrderDetails(Goods goods,uint quantity)
        {
            this.Goods = goods;
            this.Quantity = quantity;
        }
        public float amount
        {
            get => Goods.Price * Quantity;
        }
        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetails;
            return detail != null &&
                   EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods);
        }
        public override int GetHashCode()
        {
            int result = 10;
            result = result * 20 + Goods.GetHashCode();
            result = (int)(result * 20 + Quantity);
            return result;
        }
        public override string ToString()
        {
            return $"货物明细：{Goods}，{Quantity}";
        }
    }
}
