using GasStation;

namespace Gas_Station_App
{
    public partial class Client_MainWindow : Form
    {
        StartWindow start;
        Client_MainWindow current;
        Client cl;
        public Client_MainWindow(Client client, StartWindow sw)
        {
            InitializeComponent();
            start = sw;
            cl = client;
            current = this;

            label1.Text = "Клієнт " + client.FullName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client_MainWindow main = this;
            main.Close();
            start.dataGridView2.DataSource = null;
            start.dataGridView2.DataSource = Station.Instance.clients;
            start.dataGridView2.ResetBindings();

            start.dataGridView1.DataSource = null;
            start.dataGridView1.DataSource = Station.Instance.operators;
            start.dataGridView1.ResetBindings();
            start.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Client_Order orderList = new Client_Order(current, cl);
            orderList.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client_Fuel fuelList = new Client_Fuel(current, cl);
            fuelList.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Client_Products productList = new Client_Products(current, cl);
            productList.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Client_RateGS rateGS_Window = new Client_RateGS(current, cl);
            rateGS_Window.Show();
            this.Visible = false;
        }

        private void Client_MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Visible = true;
        }
    }
}
