using GasStation;

namespace Gas_Station_App
{
    public partial class StartWindow : Form
    {
        StartWindow sw;
        public StartWindow()
        {
            InitializeComponent();
            sw = this;
            create_db();
            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            dataGridView1.DataSource = Station.Instance.operators;
            dataGridView2.DataSource = Station.Instance.clients;

            label2.Text = Station.Instance.Admin.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть пароль:", "Пароль", "", -1, -1);
                if (input.Equals(Station.Instance.Admin.Password))
                {
                    Admin_MainWindow admin_mainForm = new Admin_MainWindow(sw);
                    admin_mainForm.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Некоректний пароль");
                }
            }
            if (tabControl1.SelectedTab == tabPage2)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Operator selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Operator;
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть пароль:", "Пароль", "", -1, -1);
                    if (input.Equals(selectedItem.Password))
                    {
                        Operator_MainWindow op_mainForm = new Operator_MainWindow(selectedItem, sw);
                        op_mainForm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Некоректний пароль");
                    }
                }
            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    Client selectedItem = dataGridView2.SelectedRows[0].DataBoundItem as Client;
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть пароль:", "Пароль", "", -1, -1);
                    if (input.Equals(selectedItem.Password))
                    {
                        Client_MainWindow cl_mainForm = new Client_MainWindow(selectedItem, sw);
                        cl_mainForm.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Некоректний пароль");
                    }
                }
            }
        }
        public void create_db()
        {
            Station.Instance.operators.Add(new Operator("Грищенко Анна Олександрівна", "1", 1));
            Station.Instance.operators.Add(new Operator("Іванчук Ігор Вікторович", "2", 2));
            Station.Instance.operators.Add(new Operator("Мельник Оксана Ярославівна", "3", 3));

            Station.Instance.clients.Add(new Client("Ковальчук Володимир Миколайович", "1", 2000, true, 1));
            Station.Instance.clients.Add(new Client("Павленко Віталій Олегович", "2", 2560, true, 1));
            Station.Instance.clients.Add(new Client("Ткачук Лілія Михайлівна", "3", 3678, true, 1));
            Station.Instance.clients.Add(new Client("Шевченко Максим Сергійович", "4", 1678, true, 1));

            Station.Instance.products.Add(new Product("Кава", 25, 100));
            Station.Instance.products.Add(new Product("Хот-дог", 35, 101));
            Station.Instance.products.Add(new Product("Мінеральна вода 'Боржомі'", 20, 102));
            Station.Instance.products.Add(new Product("Чипси 'Lays'", 40, 102));
            Station.Instance.products.Add(new Product("Автомобільний шампунь", 30, 102));

            Station.Instance.fuel.Add(new Fuel(FuelTypes.A92, 48, 600));
            Station.Instance.fuel.Add(new Fuel(FuelTypes.A95, 51, 600));
            Station.Instance.fuel.Add(new Fuel(FuelTypes.A98, 49, 600));
            Station.Instance.fuel.Add(new Fuel(FuelTypes.Diesel, 51, 600));
            Station.Instance.fuel.Add(new Fuel(FuelTypes.Gas, 23, 600));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_ClientForm addClientForm = new Add_ClientForm(sw);
            addClientForm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це статрове вікно програми. Потрібно обрати роль і натиснути 'Підтвердити', ввести пароль." +
                " За замовчуванням у адміністратора пароль - admin, у клієнтів та операторів - 1, 2, або 3. " +
                "Щоб обрати клієнта або оператора потрібно натиснути стрілочку поряд з ім'ям.");
        }
    }
}
