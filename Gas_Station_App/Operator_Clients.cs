using GasStation;

namespace Gas_Station_App
{
    public partial class Operator_Clients : Form
    {
        Operator_MainWindow mainWindow;
        Operator_Clients current;
        public Operator_Clients(Operator_MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            current = this;

            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            dataGridView1.DataSource = Station.Instance.clients;

            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Operator_Clients current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void Operator_Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Client selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Client;
                bool result = Station.Instance.Admin.DeleteClient(selectedItem);

                if (!result) { MessageBox.Show("Клієнта з активним замовленням може видалити тільки адміністратор"); }

                current.dataGridView1.DataSource = null;
                current.dataGridView1.DataSource = Station.Instance.clients;
                current.dataGridView1.ResetBindings();
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клієнта з активним замовленням може видалити тільки адміністратор.");
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                double newValue = 0;
                if (!double.TryParse(e.FormattedValue.ToString(), out newValue) || newValue < 0)
                {
                    MessageBox.Show("Некоректні дані");
                    dataGridView1.CancelEdit();
                    e.Cancel = true;
                    return;
                }
            }
        }
    }
}
