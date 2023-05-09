using GasStation;

namespace Gas_Station_App
{
    public partial class Admin_Save : Form
    {
        Admin_MainWindow mainWindow;
        public Admin_Save(Admin_MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Admin_Save current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveClients = new OpenFileDialog();
            if (saveClients.ShowDialog() == DialogResult.OK)
            {
                Station.Instance.clients_path = saveClients.FileName;

                bool result = Station.Instance.SaveClients();

                if (result)
                {
                    MessageBox.Show("Файл збережено успішно!");
                }
                else
                {
                    MessageBox.Show("Під час збереження файлу виникла помилка!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveOperators = new OpenFileDialog();
            if (saveOperators.ShowDialog() == DialogResult.OK)
            {
                Station.Instance.operators_path = saveOperators.FileName;

                bool result = Station.Instance.SaveOperators();

                if (result)
                {
                    MessageBox.Show("Файл збережено успішно!");
                }
                else
                {
                    MessageBox.Show("Під час збереження файлу виникла помилка!");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFuel = new OpenFileDialog();
            if (saveFuel.ShowDialog() == DialogResult.OK)
            {
                Station.Instance.fuel_path = saveFuel.FileName;

                bool result = Station.Instance.SaveFuel();

                if (result)
                {
                    MessageBox.Show("Файл збережено успішно!");
                }
                else
                {
                    MessageBox.Show("Під час збереження файлу виникла помилка!");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveProducts = new OpenFileDialog();
            if (saveProducts.ShowDialog() == DialogResult.OK)
            {
                Station.Instance.products_path = saveProducts.FileName;

                bool result = Station.Instance.SaveProducts();

                if (result)
                {
                    MessageBox.Show("Файл збережено успішно!");
                }
                else
                {
                    MessageBox.Show("Під час збереження файлу виникла помилка!");
                }
            }
        }

        private void Admin_Save_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveMarks = new OpenFileDialog();
            if (saveMarks.ShowDialog() == DialogResult.OK)
            {
                Station.Instance.marks_path = saveMarks.FileName;

                bool result = Station.Instance.SaveMarks();

                if (result)
                {
                    MessageBox.Show("Файл збережено успішно!");
                }
                else
                {
                    MessageBox.Show("Під час збереження файлу виникла помилка!");
                }
            }
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("У діалоговому вікні потрібно вказати текстовий файл, в якому будуть зберігатися дані.");
        }
    }
}
