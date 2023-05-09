using GasStation;
using Microsoft.VisualBasic;

namespace Gas_Station_App
{
    public partial class Client_Products : Form
    {
        Client_MainWindow mainWindow;
        Client client;
        Client_Products current;
        public Client_Products(Client_MainWindow main, Client cl)
        {
            InitializeComponent();

            mainWindow = main;
            client = cl;
            current = this;

            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            dataGridView1.DataSource = Station.Instance.products;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;

            if (client.OrderState)
            {
                button1.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Client_Products current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Product selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                string input = Interaction.InputBox("Введіть кількість:", "Кількість товару", "0");
                if (int.TryParse(input, out number))
                {
                    if (number > selectedItem.Quantity)
                    {
                        MessageBox.Show("Недостатньо товару");
                        return;
                    }
                    bool result = client.AddToOrder(selectedItem, number);
                    if (result)
                    {
                        current.dataGridView1.DataSource = null;
                        current.dataGridView1.DataSource = Station.Instance.products;
                        current.dataGridView1.ResetBindings();
                    }
                    else MessageBox.Show("Недостатньо грошей, щоб замовити таку кількість товару");
                }
                else
                {
                    MessageBox.Show("Некоректні дані");
                }
            }
        }

        private void Client_Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загальна сума замовлення не може перевищувати кількість грошей клієнта. " +
                "Не можна замовити більше продуктів, ніж доступно на АЗС.");
        }
    }
}
