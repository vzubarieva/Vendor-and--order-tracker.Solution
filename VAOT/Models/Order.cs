using System.Collections.Generic;

namespace VAOT.Models
{
    public class Order
    {
        private static List<Order> _instances = new List<Order> { };
        public string Title { get; set; }
        public string OrderDescription { get; set; }
        public double Price { get; set; }
        public string Date { get; set; }
        public int Id { get; }

        public Order(string title, string orderDescription, double price, string date)
        {
            Title = title;
            OrderDescription = orderDescription;
            Price = price;
            Date = date;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int num)
        {
            return _instances[num - 1];
        }
    }
}
