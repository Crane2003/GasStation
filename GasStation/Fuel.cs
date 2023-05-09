using System.Text.Json.Serialization;

namespace GasStation
{
    public class Fuel : Goods
    {
        public void SetFuelName(FuelTypes fuelType)
        {
            Name = fuelType.ToString();
        }

        public FuelTypes Type { get; set; }

        [JsonConstructor]
        public Fuel(FuelTypes type, double price, int quantity)
        {
            Type = type;
            SetFuelName(type);
            Price = price;
            Quantity = quantity;
        }

        public override int IncreaseQuantity(int quantity)
        {
            if (quantity > 50 && Quantity + quantity <= 1000)
            {
                Quantity += quantity;
                return quantity;
            }
            return Quantity;
        }
        public override object Clone()
        {
            return new Fuel(Type, Price, Quantity);
        }
        public Fuel()
        {
        }
    }
}
