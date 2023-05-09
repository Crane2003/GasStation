using GasStation;

namespace Gas_Station_App
{
    public partial class Add_Operator : Form
    {
        private Admin_Operators opWindow;
        public Add_Operator(Admin_Operators operators)
        {
            InitializeComponent();
            opWindow = operators;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            int paydesk;
            if (!int.TryParse(textBox3.Text, out paydesk) || Station.Instance.operators.Exists(op => op.Paydesk == paydesk)
                || paydesk < 1 || paydesk > 3)
                MessageBox.Show("Некоректні дані, номер каси повинен бути унікальним числом від 1 до 3");
            else
            {
                Station.Instance.Admin.AddOperator(name, password, paydesk);

                MessageBox.Show("Оператора додано");
                RefreshBS(opWindow);

                this.Close();
            }
        }
        public void RefreshBS(Admin_Operators sw)
        {
            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            sw.dataGridView1.DataSource = null;
            sw.dataGridView1.DataSource = Station.Instance.operators;
            sw.dataGridView1.ResetBindings();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
