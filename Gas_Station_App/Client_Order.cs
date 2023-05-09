using GasStation;

namespace Gas_Station_App
{
    public partial class Client_Order : Form
    {
        Client_MainWindow mainWindow;
        Client client;
        Client_Order current;
        public Client_Order(Client_MainWindow main, Client cl)
        {
            InitializeComponent();

            mainWindow = main;
            client = cl;
            current = this;

            dataGridView1.DataSource = client.orderList;

            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            if (client.OrderState)
            {
                button2.Enabled = false;
                button1.Enabled = false;
                dataGridView1.Enabled = false;
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 1 || e.ColumnIndex == 2))
            {
                double secondValue = 0;
                int thirdValue = 0;

                if (dataGridView1.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), out secondValue);
                }
                if (dataGridView1.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    int.TryParse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), out thirdValue);
                }

                double newValue = secondValue * thirdValue;

                dataGridView1.Rows[e.RowIndex].Cells[3].Value = newValue;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Client_Order current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Order selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Order;
                client.RemoveFromOrder(selectedItem);

                current.dataGridView1.DataSource = null;
                current.dataGridView1.DataSource = client.orderList;
                current.dataGridView1.ResetBindings();

                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.OrderState = true;

            int desk1 = 0;
            int desk2 = 0;
            int desk3 = 0;
            foreach (var item in Station.Instance.clients)
            {
                if (item.Paydesk == 1) desk1++;
                if (item.Paydesk == 2) desk2++;
                if (item.Paydesk == 3) desk3++;
            }
            int clDesk = Math.Min(Math.Min(desk1, desk2), desk3);
            if (clDesk == desk1) client.Paydesk = 1;
            if (clDesk == desk2) client.Paydesk = 2;
            if (clDesk == desk3) client.Paydesk = 3;

            foreach (var item in Station.Instance.operators)
            {
                if (item.Paydesk == client.Paydesk)
                {
                    item.State = true;
                }
            }
            button2.Enabled = false;
            button1.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void Client_Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int newValue = 0;
                if (!int.TryParse(e.FormattedValue.ToString(), out newValue) || newValue < 0)
                {
                    MessageBox.Show("Некоректні дані");
                    dataGridView1.CancelEdit();
                    e.Cancel = true;
                    return;
                }
            }
            if (e.ColumnIndex == 2)
            {
                Product pr = (Product)Station.Instance.products.Find(
                    x => x.Name == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Fuel _f = (Fuel)Station.Instance.fuel.Find(
                    x => x.Name == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                int newValue = 0;
                int.TryParse(e.FormattedValue.ToString(), out newValue);
                if (_f != null)
                {
                    if (newValue > _f.Quantity)
                    {
                        MessageBox.Show("Недостатньо товару");
                        dataGridView1.CancelEdit();
                        e.Cancel = true;
                        return;
                    }
                }
                if (pr != null)
                {
                    if (newValue > pr.Quantity)
                    {
                        MessageBox.Show("Недостатньо товару");
                        dataGridView1.CancelEdit();
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Після підтвердження замовлення зміни може вносити тільки оператор. " +
                "Номер каси изначиться автоматично (обереться найменш завантаженна каса).");
        }
    }
}
