using System.ComponentModel;
using System.Text.Json.Serialization;

namespace GasStation
{
    public class Operator : IPerson
    {
        private string fullName;

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
                else { fullName = "Оператор"; }
            }
        }

        public string Password { get; set; }

        [DisplayName("Номер каси")]
        public int Paydesk { get; set; }

        [DisplayName("Зайнятість")]
        public bool State { get; set; } = false;

        [JsonConstructor]
        public Operator(string fullName, string password, int paydesk, bool state = false)
        {
            FullName = fullName;
            Password = password;
            Paydesk = paydesk;
            State = state;
        }

        public bool CompleteOrder(Client client)
        {
            bool orderIsNotEmpty = false;
            double orderSum = 0;

            foreach (var goods in Station.Instance.products)
            {
                foreach (var orderItem in client.order)
                {
                    if (goods.Name == orderItem.Name)
                    {
                        orderSum += orderItem.Price * orderItem.Quantity;
                        orderIsNotEmpty = true;
                    }
                }
            }

            foreach (var goods in Station.Instance.fuel)
            {
                foreach (var orderItem in client.order)
                {
                    if (goods.Name.Equals(orderItem.Name))
                    {
                        orderSum += orderItem.Price * orderItem.Quantity;
                        orderIsNotEmpty = true;
                    }
                }
            }

            orderSum = client.UseBonusCard(orderSum);
            client.Money -= orderSum;

            return orderIsNotEmpty;
        }
        public bool DeleteClient(Client client)
        {
            if (Station.Instance.clients.Contains(client))
            {
                if (client.OrderState == false)
                {
                    Station.Instance.clients.Remove(client);
                    return true;
                }
            }
            return false;
        }

        public Operator()
        {

        }
    }
}
