using GasStation;

namespace Test
{
    [TestClass]
    public class OperatorTests
    {
        [TestMethod]
        public void DeleteClient_Test()
        {
            Operator op = new Operator("Operator1", "op_pass", 2);
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            Station.Instance.clients.Add(cl);

            op.DeleteClient(cl);

            Assert.IsFalse(Station.Instance.clients.Contains(cl));
            Station.Instance.clients.Clear();
        }

        [TestMethod]
        public void DeleteClient_StateIsTrue_Test()
        {
            Operator op = new Operator("Operator1", "op_pass", 2);
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);

            cl.OrderState = true;
            Station.Instance.clients.Add(cl);

            op.DeleteClient(cl);

            Assert.IsTrue(Station.Instance.clients.Contains(cl));
            Station.Instance.clients.Clear();
        }

        [TestMethod]
        public void CompleteOrder_Test()
        {
            Station.Instance.clients.Clear();
            Station.Instance.fuel.Clear();

            Operator op = new Operator("Operator1", "op_pass", 2);
            Client cl = new Client("Client1", "cl_pass", 2000, false, 2);
            Station.Instance.clients.Add(cl);
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);
            cl.AddToOrder(fuel, 20);

            op.CompleteOrder(cl);

            Assert.AreEqual(1200, cl.Money);

            cl.order.Clear();
            Station.Instance.clients.Clear();
            Station.Instance.fuel.Clear();

        }

        [TestMethod]
        public void CompleteOrder_BonusCard_Test()
        {
            Station.Instance.clients.Clear();
            Station.Instance.fuel.Clear();

            Operator op = new Operator("Operator1", "op_pass", 2);
            Client cl = new Client("Client1", "cl_pass", 784, true, 2);
            Station.Instance.clients.Add(cl);
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);
            cl.AddToOrder(fuel, 20);

            op.CompleteOrder(cl);

            Assert.AreEqual(0, cl.Money);
            //Assert.IsTrue(op.CompleteOrder(cl));
            Station.Instance.clients.Clear();
            Station.Instance.fuel.Clear();
            cl.order.Clear();
        }

        [TestMethod]
        public void CompleteOrder_WrongName_Test()
        {
            Operator op = new Operator("Operator1", "op_pass", 2);
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            Station.Instance.clients.Add(cl);
            Product pr = new Product("Hot-Dog", 40, 200);
            Product pr2 = new Product("Burger", 40, 200);
            Station.Instance.products.Add(pr);
            cl.AddToOrder(pr2, 20);

            op.CompleteOrder(cl);

            Assert.IsTrue(pr.Quantity == 200 && cl.Money == 2000);
            Station.Instance.clients.Clear();
            Station.Instance.products.Clear();
            cl.order.Clear();
        }

    }
}