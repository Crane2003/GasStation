namespace GasStation
{
    public class Product : Goods, IComparable<Product>
    {
        public Product(string name, double price, int quantity) : base(name, price, quantity)
        {
        }
        public int CompareTo(Product? other)
        {
            return Name.CompareTo(other.Name);
        }

        public override int IncreaseQuantity(int quantity)
        {
            if (quantity > 30 && Quantity + quantity <= 150 && Station.ProductSum(Station.Instance.products) + quantity <= 15000)
            {
                Quantity += quantity;
                return quantity;
            }
            return Quantity;
        }
        public override object Clone()
        {
            return new Product(Name, Price, Quantity);
        }

        public Product()
        {

        }
    }
}
