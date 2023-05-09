namespace GasStation
{
    public class Program
    {
        public static void Main()
        {
            Client cl = new Client("Client1", "cl_pass", 20000, true, 2);
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);
            cl.order.Clear();
            cl.orderList.Clear();
            cl.AddToOrder(fuel, 20);

            foreach (var item in cl.orderList)
            {
                Console.WriteLine(item.Name);
            }
            Order order = new Order(fuel);

            Fuel _f = Station.Instance.fuel.Find(x => x.Name == cl.orderList[0].Name);
            Console.WriteLine(_f.Name);

            bool result = cl.RemoveFromOrder(cl.orderList[0]);
            Console.WriteLine(result);
            foreach (var item in cl.order)
            {
                Console.WriteLine(item.Name);
            }
            bool result2 = cl.order.Exists(f => f.Name == "A98");
            Console.WriteLine(result2);
        }
    }
}
