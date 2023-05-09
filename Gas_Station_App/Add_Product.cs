using GasStation;

namespace Gas_Station_App
{
    public partial class Add_Product : Form
    {
        private Admin_Products goodsWindow;
        public Add_Product(Admin_Products goods)
        {
            InitializeComponent();
            goodsWindow = goods;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double price;
            int quantity;
            if (!double.TryParse(textBox2.Text, out price) || !int.TryParse(textBox3.Text, out quantity) || price < 0)
            {
                MessageBox.Show("Некоректні дані");
            }
            else if (Station.Instance.products.Exists(pr => pr.Name == name))
            {
                MessageBox.Show("Назва повинна бути унікальна");
            }
            else
            {
                Station.Instance.Admin.AddProduct(name, price, quantity);

                MessageBox.Show("Продукт додано");
                RefreshBS(goodsWindow);

                this.Close();
            }
        }
        public void RefreshBS(Admin_Products sw)
        {
            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            sw.dataGridView1.DataSource = null;
            sw.dataGridView1.DataSource = Station.Instance.products;
            sw.dataGridView1.ResetBindings();
        }
    }
}
