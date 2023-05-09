using GasStation;
using Microsoft.VisualBasic;

namespace Gas_Station_App
{
    public partial class Admin_Products : Form
    {
        Admin_MainWindow mainWindow;
        Admin_Products curr;
        public Admin_Products(Admin_MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            curr = this;


            Station.Instance.clients.Sort();
            Station.Instance.products.Sort();
            dataGridView1.DataSource = Station.Instance.products;
            dataGridView1.Columns[2].ReadOnly = true;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Admin_Products current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int number;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Product selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                string input = Interaction.InputBox("Введіть кількість:", "Кількість товару", "0");
                if (int.TryParse(input, out number))
                {
                    if (selectedItem.Quantity + number <= 150 && number >= 30)
                    {
                        Station.Instance.Admin.OrderGoods(selectedItem, number);
                        Station.Instance.clients.Sort();
                        Station.Instance.products.Sort();
                        curr.dataGridView1.DataSource = null;
                        curr.dataGridView1.DataSource = Station.Instance.products;
                        curr.dataGridView1.ResetBindings();
                    }
                    else MessageBox.Show("Неправильне число, значення повинно бути більше 30 і нова кількість не повинна пперевищувати 150");
                }
                else
                {
                    MessageBox.Show("Некоректні дані");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Product addProduct = new Add_Product(curr);
            addProduct.Show();
        }

        private void Admin_Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                double newValue = 0;
                if ((!double.TryParse(e.FormattedValue.ToString(), out newValue)) || newValue < 0)
                {
                    MessageBox.Show("Некоректні дані");
                    dataGridView1.CancelEdit();
                    e.Cancel = true;
                    return;
                }
            }
            if (e.ColumnIndex == 0)
            {
                string newValue = e.FormattedValue.ToString();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Index != e.RowIndex && row.Cells[e.ColumnIndex].Value != null && row.Cells[e.ColumnIndex].Value.ToString() == newValue)
                    {
                        dataGridView1.CancelEdit();
                        e.Cancel = true;
                        MessageBox.Show("Товар з такою назвою вже існує");
                        return;
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кількість можна збільшити за допомогою кнопки 'Поповнити запаси'. Введене число повинно бути більше 30. " +
                "Назви товарів мають бути унікальними");
        }
    }

}
