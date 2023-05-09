namespace GasStation
{
    public class Station
    {
        public string Name { get; } = "Експрес-АЗС";
        public List<int> marks;
        public List<Fuel> fuel;
        public List<Product> products;
        public List<Operator> operators;
        public List<Client> clients;
        public Admin Admin;
        private Station()
        {
            Admin = new Admin("Оксенчук Юліана Максимівна", "admin");
            marks = new List<int>();
            fuel = new List<Fuel>();
            products = new List<Product>();
            operators = new List<Operator>();
            clients = new List<Client>();
        }

        public static Station Instance { get; } = new Station();

        public static double AverageMark()
        {
            double sum = 0;

            if (Instance.marks.Count > 0)
            {
                foreach (int mark in Instance.marks)
                {
                    sum += mark;
                }
                return Math.Round(sum / Instance.marks.Count, 2);
            }
            return 0;
        }
        public static int ProductSum(List<Product> products)
        {
            int productSum = 0;
            foreach (var item in products)
            {
                productSum += item.Quantity;
            }
            return productSum;
        }

        public string clients_path;
        public string operators_path;
        public string fuel_path;
        public string products_path;
        public string marks_path;
        public bool SaveClients() => JsonLogic.SaveToJson(clients, clients_path);
        public bool SaveOperators() => JsonLogic.SaveToJson(operators, operators_path);
        public bool SaveFuel() => JsonLogic.SaveToJson(fuel, fuel_path);
        public bool SaveProducts() => JsonLogic.SaveToJson(products, products_path);
        public bool SaveMarks() => JsonLogic.SaveToJson(marks, marks_path);

        public void ReadClients()
        {
            clients.Clear();
            if (JsonLogic.ReadFromJson(clients_path, out List<Client> clientList))
                clients = clientList;
        }
        public void ReadOperators()
        {
            operators.Clear();
            if (JsonLogic.ReadFromJson(operators_path, out List<Operator> operatorsList))
                operators = operatorsList;
        }
        public void ReadFuel()
        {
            fuel.Clear();
            if (JsonLogic.ReadFromJson(fuel_path, out List<Fuel> fuelList))
                fuel = fuelList;
        }
        public void ReadProducts()
        {
            products.Clear();
            if (JsonLogic.ReadFromJson(products_path, out List<Product> productList))
                products = productList;
        }
        public void ReadMarks()
        {
            marks.Clear();
            if (JsonLogic.ReadFromJson(marks_path, out List<int> markList))
                marks = markList;
        }
    }
}

