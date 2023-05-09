using GasStation;
using Microsoft.VisualBasic;

namespace Gas_Station_App
{
    public partial class Admin_Fuel : Form
    {
        Admin_MainWindow mainWindow;
        Admin_Fuel _fuel;
        public Admin_Fuel(Admin_MainWindow main)
        {
            InitializeComponent();

            mainWindow = main;
            _fuel = this;

            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.DataSource = Station.Instance.fuel;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Fuel current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Fuel selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Fuel;
                string input = Interaction.InputBox("Введіть кількість:", "Кількість товару", "0");
                if (int.TryParse(input, out number))
                {
                    if (selectedItem.Quantity + number <= 1000 && number >= 50)
                    {
                        Station.Instance.Admin.OrderGoods(selectedItem, number);

                        Station.Instance.clients.Sort();
                        Station.Instance.products.Sort();
                        _fuel.dataGridView1.DataSource = null;
                        _fuel.dataGridView1.DataSource = Station.Instance.fuel;
                        _fuel.dataGridView1.ResetBindings();
                    }
                    else
                    {
                        MessageBox.Show("Неправильне число, значення повинно бути більше 50 і нова кількість не повинна перевищувати 1000");
                    }
                }
                else
                {
                    MessageBox.Show("Некоректні дані");
                }
            }
        }

        private void Admin_Fuel_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                double newValue = 0;
                if (!double.TryParse(e.FormattedValue.ToString(), out newValue))
                {
                    MessageBox.Show("Некоректні дані");
                    dataGridView1.CancelEdit();
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кількість можна збільшити за допомогою кнопки 'Поповнити запаси'. Введене число повинно бути більше 50");
        }
    }
}
