using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Console
{
    public class Goods
    {
        public uint Id { set; get; }
        public string Name { set; get; }
        private float price;
        public float Price
        {
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("value must >=0");
                price = value;
            }
            get
            {
                return price;
            }
        }
        public Goods(uint id,string name,float price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null && Id == goods.Id;
        }
        public override int GetHashCode()
        {
            int result = 10;
            result = result * 20 + Name.GetHashCode();
            result = (int)(result * 20 + Id);
            return result;
        }
        public override string ToString()
        {
            return $"货物ID：{Id}，货物名：{Name}，货物价值：{Price}";
        }
    }
}
