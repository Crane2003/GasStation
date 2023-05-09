using GasStation;

namespace Gas_Station_App
{
    public partial class Admin_Load : Form
    {
        Admin_MainWindow mainWindow;
        public Admin_Load(Admin_MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Admin_Load current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Client> backupList = new List<Client>();
            backupList.AddRange(Station.Instance.clients);
            try
            {
                OpenFileDialog loadClients = new OpenFileDialog();
                if (loadClients.ShowDialog() == DialogResult.OK)
                {
                    Station.Instance.clients_path = loadClients.FileName;

                    Station.Instance.ReadClients();

                    Station.Instance.clients.Sort();
                    Station.Instance.products.Sort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильний формат данних у файлі");
                Station.Instance.clients = backupList;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Operator> backupList = new List<Operator>();
            backupList.AddRange(Station.Instance.operators);
            try
            {
                OpenFileDialog loadOperators = new OpenFileDialog();
                if (loadOperators.ShowDialog() == DialogResult.OK)
                {
                    Station.Instance.operators_path = loadOperators.FileName;

                    Station.Instance.ReadOperators();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильний формат данних у файлі");
                Station.Instance.operators = backupList;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Product> backupList = new List<Product>();
            backupList.AddRange(Station.Instance.products);
            try
            {
                OpenFileDialog loadProducts = new OpenFileDialog();
                if (loadProducts.ShowDialog() == DialogResult.OK)
                {
                    Station.Instance.products_path = loadProducts.FileName;

                    Station.Instance.ReadProducts();
                    Station.Instance.clients.Sort();
                    Station.Instance.products.Sort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильний формат данних у файлі");
                Station.Instance.products = backupList;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<Fuel> backupList = new List<Fuel>();
            backupList.AddRange(Station.Instance.fuel);
            try
            {
                OpenFileDialog loadFuel = new OpenFileDialog();
                if (loadFuel.ShowDialog() == DialogResult.OK)
                {
                    Station.Instance.fuel_path = loadFuel.FileName;

                    Station.Instance.ReadFuel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильний формат данних у файлі");
                Station.Instance.fuel = backupList;
            }
        }

        private void Admin_Load_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            List<int> backupList = new List<int>();
            backupList.AddRange(Station.Instance.marks);
            try
            {
                OpenFileDialog loadMarks = new OpenFileDialog();
                if (loadMarks.ShowDialog() == DialogResult.OK)
                {
                    Station.Instance.marks_path = loadMarks.FileName;

                    Station.Instance.ReadMarks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильний формат данних у файлі");
                Station.Instance.marks = backupList;
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В діалоговому вікні потрібно вказати файл, у якому зберігаються дані");
        }
    }
}
