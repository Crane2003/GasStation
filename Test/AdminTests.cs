using GasStation;
namespace Test
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void AddOperator_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            admin.AddOperator("Operator1", "op_pass", 2);

            Assert.IsTrue(Station.Instance.operators.Exists(o => o.FullName == "Operator1"));
            Station.Instance.operators.Clear();
        }

        [TestMethod]
        public void AddOperator_WrongPaydesk_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            admin.AddOperator("Operator1", "op_pass", 4);

            Assert.IsFalse(Station.Instance.operators.Exists(o => o.FullName == "Operator1"));
            Station.Instance.operators.Clear();
        }

        [TestMethod]
        public void DeleteOperator_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            Operator op = new Operator("Operator1", "op_pass", 2);
            Station.Instance.operators.Add(op);
            admin.DeleteOperator(op);

            Assert.IsFalse(Station.Instance.operators.Contains(op));
            Station.Instance.operators.Clear();
        }

        [TestMethod]
        public void DeleteOperator_StateIsTrue_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            Operator op = new Operator("Operator1", "op_pass", 2);
            op.State = true;
            Station.Instance.operators.Add(op);
            admin.DeleteOperator(op);

            Assert.IsTrue(Station.Instance.operators.Contains(op));
            Station.Instance.operators.Clear();
        }

        [TestMethod]
        public void DeleteClient_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            Client cl = new Client("Client1", "cl_pass", 2000, true, 2);
            Station.Instance.clients.Add(cl);
            admin.DeleteClient(cl);

            Assert.IsFalse(Station.Instance.clients.Contains(cl));
            Station.Instance.clients.Clear();
        }

        [TestMethod]
        public void AddProduct_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            admin.AddProduct("Hot-dog", 40, 150);

            Assert.IsTrue(Station.Instance.products.Exists(pr => pr.Name == "Hot-dog"));
            Station.Instance.products.Clear();
        }

        [TestMethod]
        public void AddProduct_WrongQuantity_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            admin.AddProduct("Hot-dog", 40, 1520);

            Assert.IsFalse(Station.Instance.products.Exists(pr => pr.Name == "Hot-dog"));
            Station.Instance.products.Clear();
        }

        [TestMethod]
        public void AddProduct_WrongPrice_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            admin.AddProduct("Hot-dog", -2, 120);

            Assert.IsFalse(Station.Instance.products.Exists(pr => pr.Name == "Hot-dog"));
            Station.Instance.products.Clear();
        }

        [TestMethod]
        public void OrderGoods_Fuel_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);
            admin.OrderGoods(fuel, 200);

            Assert.AreEqual(fuel.Quantity, 400);
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void OrderGoods_Fuel_WrongQuantity_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            Fuel fuel = new Fuel(FuelTypes.A98, 40, 200);
            Station.Instance.fuel.Add(fuel);
            admin.OrderGoods(fuel, 1200);

            Assert.AreEqual(fuel.Quantity, 200);
            Station.Instance.fuel.Clear();
        }

        [TestMethod]
        public void OrderGoods_Product_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            Product pr = new Product("Hot-dog", 40, 100);
            Station.Instance.products.Add(pr);
            admin.OrderGoods(pr, 40);

            Assert.AreEqual(pr.Quantity, 140);
            Station.Instance.products.Clear();
        }

        [TestMethod]
        public void OrderGoods_Product_WrongQuantity_Test()
        {
            Admin admin = new Admin("Admin", "ad_pass");
            Product pr = new Product("Hot-dog", 40, 100);
            Station.Instance.products.Add(pr);
            admin.OrderGoods(pr, 1200);

            Assert.AreEqual(pr.Quantity, 100);
            Station.Instance.products.Clear();
        }
    }
}