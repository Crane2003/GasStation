
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GasStation
{
    public class Client : IPerson, IComparable<Client>
    {
        private string fullName;
        private int paydesk;

        [DisplayName("ПІБ")]
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    fullName = value;
                }
                else { fullName = "Гість"; }
            }
        }

        [DisplayName("Номер каси")]
        public int Paydesk
        {
            get
            {
                return paydesk;
            }
            set
            {
                if (value > 0 && value < 4)
                {
                    paydesk = value;
                }
                else paydesk = 1;
            }
        }

        [DisplayName("Стан замовлення")]
        public bool OrderState { get; set; }

        [DisplayName("Кількість грошей")]
        public double Money { get; set; }

        [DisplayName("Бонусна картка")]
        public bool BonusCard { get; set; }
        public string Password { get; set; }

        public Client(string name, string pass, double money, bool bonusCard, int paydesk = 1)
        {
            FullName = name;
            Password = pass;
            Paydesk = paydesk;
            Money = money;
            BonusCard = bonusCard;
            OrderState = false;
            order = new List<Goods>();
            orderList = new List<Order>();
        }

        [JsonIgnore]
        public List<Goods> order { get; set; }

        [JsonIgnore]
        public List<Order> orderList { get; set; }

        public int CompareTo(Client? other)
        {
            return FullName.CompareTo(other.FullName);
        }

        public bool AddToOrder(Goods goods, int quantity)
        {
            if (goods is Fuel)
            {
                if (goods.Quantity >= quantity)
                {
                    var orderFuel = (Fuel)goods.Clone();
                    orderFuel.Quantity = quantity;
                    order.Add(orderFuel);
                    goods.DecreaseQuantity(quantity);
                }
            }

            if (goods is Product)
            {
                if (goods.Quantity >= quantity)
                {
                    var orderProduct = (Product)goods.Clone();
                    orderProduct.Quantity = quantity;
                    order.Add(orderProduct);
                    goods.DecreaseQuantity(quantity);
                }
            }

            double orderSum = 0;
            foreach (var item in order)
            {
                orderSum += item.Quantity * item.Price;
            }

            orderSum = UseBonusCard(orderSum);

            if (orderSum <= Money)
            {
                orderList.Clear();
                foreach (var item in order)
                {
                    orderList.Add(new Order(item));
                }
                return true;
            }
            order.Remove(goods);

            return false;
        }

        public bool RemoveFromOrder(Order item)
        {

            orderList.Remove(item);
            Product pr = (Product)Station.Instance.products.Find(x => x.Name == item.Name);
            Fuel _f = Station.Instance.fuel.Find(x => x.Name == item.Name);

            if (_f != null)
            {
                _f.Quantity += item.Quantity;
                order.RemoveAll(x => x.Name == item.Name);
                return true;
            }
            if (pr != null)
            {
                pr.Quantity += item.Quantity;
                order.RemoveAll(x => x.Name == item.Name);
                return true;
            }
            return false;
        }
        public bool RateGS(int mark)
        {
            if (mark > 0 && mark <= 5)
            {
                Station.Instance.marks.Add(mark);
                return true;
            }
            return false;
        }

        public double UseBonusCard(double orderSum)
        {
            if (BonusCard)
            {
                if (orderSum >= 200 && orderSum < 500) orderSum -= orderSum * 0.01;
                if (orderSum >= 500 && orderSum < 1000) orderSum -= orderSum * 0.02;
                if (orderSum >= 1000) orderSum -= orderSum * 0.03;
            }
            return orderSum;
        }

        [JsonConstructor]
        public Client(string fullName, int paydesk, bool orderState, double money,
            bool bonusCard, string password, List<Goods> order, List<Order> orderList)
        {
            FullName = fullName;
            Paydesk = paydesk;
            OrderState = orderState;
            Money = money;
            BonusCard = bonusCard;
            Password = password;
            this.order = order;
            this.orderList = orderList;
        }

        public Client()
        {
        }
    }
}
