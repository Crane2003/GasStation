using GasStation;

namespace Gas_Station_App
{
    public partial class Add_ClientForm : Form
    {
        private StartWindow _startWindow;
        public Add_ClientForm(StartWindow sw)
        {
            InitializeComponent();
            _startWindow = sw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double money;
            string name = textBox1.Text;
            string password = textBox2.Text;
            bool hasBonusCard = checkBox1.Checked;
            if (!double.TryParse(textBox3.Text, out money))
                MessageBox.Show("Некоректні дані");
            else
            {
                Station.Instance.clients.Add(new Client(name, password, money, hasBonusCard));

                MessageBox.Show("Клієнта додано");
                RefreshBS(_startWindow);

                this.Close();
            }
        }
        public void RefreshBS(StartWindow sw)
        {
            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            sw.dataGridView2.DataSource = null;
            sw.dataGridView2.DataSource = Station.Instance.clients;
            sw.dataGridView2.ResetBindings();
        }
        private void AddClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
