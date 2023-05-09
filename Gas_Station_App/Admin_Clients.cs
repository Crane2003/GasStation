using GasStation;

namespace Gas_Station_App
{
    public partial class Admin_Clients : Form
    {
        Admin_MainWindow mainWindow;
        Admin_Clients current;
        public Admin_Clients(Admin_MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            current = this;

            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();

            dataGridView1.DataSource = Station.Instance.clients;
            dataGridView1.Columns[2].ReadOnly = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Clients current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Client selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Client;
                selectedItem.OrderState = false;
                Station.Instance.Admin.DeleteClient(selectedItem);

                Station.Instance.clients.Sort();
                Station.Instance.products.Sort();
                current.dataGridView1.DataSource = null;
                current.dataGridView1.DataSource = Station.Instance.clients;
                current.dataGridView1.ResetBindings();
            }
        }

        private void Admin_Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стан замволення і номер каси змінюються автоматично, після того, як клієнт підтвердить замовлення.");
        }
    }
}
