using GasStation;

namespace Test
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public void RateGs_Test()
        {
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);

            cl.RateGS(2);
            cl.RateGS(4);

            Assert.IsTrue(Station.Instance.marks.Contains(2) && Station.AverageMark() == 3);
            Station.Instance.marks.Clear();
        }

        [TestMethod]
        public void RateGs_WrongMark_Test()
        {
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);

            cl.RateGS(6);

            Assert.IsFalse(Station.Instance.marks.Contains(6) && Station.AverageMark() != 0);
            Station.Instance.marks.Clear();
        }

        [TestMethod]
        public void AddToOrder_Test()
        {
            Client cl = new Client("Client1", "cl_pass", 20000, true, 2);
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);

            cl.AddToOrder(fuel, 20);

            Assert.IsTrue(cl.order.Exists(f => f.Name == "A98" && f.Quantity == 20));
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void AddToOrder_WrongQuantity_Test()
        {
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);

            cl.AddToOrder(fuel, 500);

            Assert.IsFalse(cl.order.Exists(f => f.Name == "A98" && f.Quantity == 500));
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void RemoveFromOrder_Test()
        {
            Client cl = new Client("Client1", "cl_pass", 20000, true, 2);
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);
            cl.order.Clear();
            cl.orderList.Clear();
            cl.AddToOrder(fuel, 20);

            cl.RemoveFromOrder(cl.orderList[0]);

            Assert.IsFalse(cl.order.Exists(f => f.Name == "A98"));
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void UseBonusCard_Test_100()
        {
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            double orderSum = 100;

            Assert.AreEqual(100, cl.UseBonusCard(orderSum));
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void UseBonusCard_Test_200()
        {
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            double orderSum = 200;

            Assert.AreEqual(198, cl.UseBonusCard(orderSum));
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void UseBonusCard_Test_500()
        {
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            double orderSum = 500;

            Assert.AreEqual(490, cl.UseBonusCard(orderSum));
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void UseBonusCard_Test_1000()
        {
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            double orderSum = 1000;

            Assert.AreEqual(970, cl.UseBonusCard(orderSum));
            Station.Instance.fuel.Clear();
        }
    }
}
