using GasStation;

namespace Gas_Station_App
{
    public partial class Admin_Operators : Form
    {
        Admin_MainWindow mainWindow;
        Admin_Operators current;
        public Admin_Operators(Admin_MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            current = this;

            dataGridView1.DataSource = Station.Instance.operators;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Operators current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Operator addOp = new Add_Operator(current);
            addOp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Operator selectedItem = dataGridView1.SelectedRows[0].DataBoundItem as Operator;
                if (!selectedItem.State)
                {
                    Station.Instance.Admin.DeleteOperator(selectedItem);

                    current.dataGridView1.DataSource = null;
                    current.dataGridView1.DataSource = Station.Instance.operators;
                    current.dataGridView1.ResetBindings();
                }
                else MessageBox.Show("Не можна видалити оператора з активним замовленням");

            }
        }

        private void Admin_Operators_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                int newValue = 0;
                if (int.TryParse(e.FormattedValue.ToString(), out newValue))
                {
                    if (newValue > 0 && newValue < 4)
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Index != e.RowIndex && row.Cells[2].Value != null && (int)row.Cells[2].Value == newValue)
                            {
                                dataGridView1.CancelEdit();
                                e.Cancel = true;
                                MessageBox.Show("Номер каси повинен бути унікальним");
                                return;
                            }
                        }
                    }
                }
                else
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
            MessageBox.Show("Номер каси має бути унікальним і приймати одне зі значень: 1, 2, 3.");
        }
    }
}
