using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Console
{
    public class Customer
    {
        public uint Id { set; get; }
        public string Name { set; get; }

        public Customer(uint id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return $"客户ID：{Id}，客户名：{Name}";
        }
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null && Id == customer.Id;
        }
        public override int GetHashCode()
        {
            int result = 10;
            result = result * 20 + Name.GetHashCode();
            result = (int)(result * 20 + Id);
            return result;
        }

    }
}
