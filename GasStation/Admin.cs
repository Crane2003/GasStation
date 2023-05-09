namespace GasStation
{
    public class Admin : IPerson
    {
        private string fullName = "Адміністратор";

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = "Оксенчук Юліана Максимівна";
            }
        }

        public string Password { get; set; } = "admin";

        public Admin(string name, string pass)
        {
            FullName = name;
            Password = pass;
        }

        public bool AddOperator(string name, string pass, int paydesk)
        {
            if (paydesk > 0 && paydesk < 4)
            {
                Station.Instance.operators.Add(new Operator(name, pass, paydesk));
                return true;
            }
            return false;
        }
        public bool DeleteOperator(Operator _operator)
        {
            if (Station.Instance.operators.Contains(_operator))
            {
                if (_operator.State == false)
                {
                    Station.Instance.operators.Remove(_operator);
                    return true;
                }
            }
            return false;
        }
        public bool DeleteClient(Client client)
        {
            if (Station.Instance.clients.Contains(client))
            {
                if (client.OrderState == false)
                {
                    List<Order> copyOfOrderList = new List<Order>(client.orderList);
                    foreach (var orderItem in copyOfOrderList)
                    {
                        client.RemoveFromOrder(orderItem);
                    }
                    Station.Instance.clients.Remove(client);
                    return true;
                }
            }
            return false;
        }
        public bool AddProduct(string name, double price, int quantity)
        {
            if (price > 0 && quantity > 0 && quantity <= 150)
            {
                Station.Instance.products.Add(new Product(name, price, quantity));
                return true;
            }
            return false;
        }
        public bool OrderGoods(Goods goods, int quantity)
        {
            if (goods is Fuel)
            {
                if (goods.Quantity + quantity > 1000)
                {
                    return false;
                }
                if (Station.Instance.fuel.Contains(goods))
                {
                    goods.IncreaseQuantity(quantity);
                    return true;
                }
            }

            if (goods is Product)
            {
                if (goods.Quantity + quantity > 150)
                {
                    return false;
                }
                if (Station.Instance.products.Contains(goods))
                {
                    goods.IncreaseQuantity(quantity);
                    return true;
                }
            }
            return false;
        }
    }
}
