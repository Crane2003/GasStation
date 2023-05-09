using GasStation;

namespace Gas_Station_App
{
    public partial class Admin_MainWindow : Form
    {
        StartWindow start;
        Admin_MainWindow current;
        public Admin_MainWindow(StartWindow sw)
        {
            InitializeComponent();

            current = this;

            label1.Text = "Адміністратор " + Station.Instance.Admin.FullName;
            start = sw;

            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_MainWindow main = this;
            main.Close();

            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
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
            Admin_Clients clList = new Admin_Clients(current);
            clList.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Operators opList = new Admin_Operators(current);
            opList.Show();
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Admin_Fuel fuelList = new Admin_Fuel(current);
            fuelList.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_Products productList = new Admin_Products(current);
            productList.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Save saveWindow = new Admin_Save(current);
            saveWindow.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Load loadWindow = new Admin_Load(current);
            loadWindow.Show();
            this.Visible = false;
        }

        private void Admin_MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Visible = true;
        }
    }
}