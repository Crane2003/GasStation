using System.ComponentModel;

namespace GasStation
{
    public class Order
    {
        public Order(Goods goods)
        {
            Name = goods.Name;
            Price = goods.Price;
            Quantity = goods.Quantity;
            Cost = goods.Price * goods.Quantity;
        }
        [DisplayName("Назва")]
        public virtual string Name { get; set; }

        [DisplayName("Ціна, грн")]
        public double Price { get; set; } = 0;

        [DisplayName("Кількість")]
        public int Quantity { get; set; } = 0;

        [DisplayName("Вартість")]
        public double Cost { get; set; }

    }
}
