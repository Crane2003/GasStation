using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GasStation
{
    public abstract class Goods : ICloneable
    {
        private string name;

        [DisplayName("Назва")]
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else name = "Невідомий товар";
            }
        }

        [DisplayName("Ціна, грн")]
        public double Price { get; set; } = 0;

        [DisplayName("Кількість")]
        public int Quantity { get; set; } = 0;
        public abstract int IncreaseQuantity(int quantity);

        public int DecreaseQuantity(int quantity)
        {
            if (Quantity - quantity >= 0)
            {
                Quantity -= quantity;
                return Quantity;
            }
            return Quantity;
        }

        public abstract object Clone();

        [JsonConstructor]
        public Goods(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Goods()
        {

        }
    }

}
