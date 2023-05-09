using GasStation;

namespace Gas_Station_App
{
    public partial class Operator_Orders : Form
    {
        Operator_MainWindow mainWindow;
        Operator_Orders current;
        Operator _operator;
        Client client;
        public Operator_Orders(Operator_MainWindow main, Operator op)
        {
            InitializeComponent();

            mainWindow = main;
            current = this;
            _operator = op;

            foreach (var cl in Station.Instance.clients)
            {
                if (cl.Paydesk == _operator.Paydesk)
                {
                    client = cl;
                    break;
                }
            }


            label2.Text = client.FullName;

            dataGridView1.DataSource = client.orderList;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            CalculateColumnSumAndSetLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CalculateColumnSumAndSetLabel() > client.Money)
            {
                MessageBox.Show("У клієнта недостатньо грошей");
                return;
            }
            bool orderResult = _operator.CompleteOrder(client);
            if (orderResult)
            {
                Station.Instance.clients.Remove(client);
                if (Station.Instance.clients.Count > 0)
                {
                    bool clientExist = false;
                    foreach (var cl in Station.Instance.clients)
                    {
                        if (cl.Paydesk == _operator.Paydesk && cl.OrderState)
                        {
                            client = cl;
                            label2.Text = client.FullName;
                            current.dataGridView1.DataSource = null;
                            current.dataGridView1.DataSource = client.orderList;
                            current.dataGridView1.ResetBindings();
                            CalculateColumnSumAndSetLabel();
                            clientExist = true;
                            break;
                        }
                    }
                    if (!clientExist)
                    {
                        current.dataGridView1.DataSource = null;
                        label2.Text = "";
                        label3.Text = "Немає активного замовлення";
                    }
                }
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
            CalculateColumnSumAndSetLabel();


        }

        private double CalculateColumnSumAndSetLabel()
        {
            int columnIndex = 3;
            double sum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    object value = row.Cells[columnIndex].Value;

                    if (value != null)
                    {
                        double val;
                        if (double.TryParse(value.ToString(), out val))
                        {
                            sum += val;
                        }
                    }
                }
            }
            label3.Text = "Загальна вартість замовлення =  " + sum.ToString();
            return sum;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Operator_Orders current = this;
            current.Close();
            mainWindow.Visible = true;
        }


        private void Operator_Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int newValue = 0;
                if (!int.TryParse(e.FormattedValue.ToString(), out newValue))
                {
                    MessageBox.Show("Некоректні дані");
                    dataGridView1.CancelEdit();
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це список замовлень клієнтів, які належать до каси цього оператора." +
                "Після виконання замовлення автоматично завантажується наступне.");
        }
    }
}
