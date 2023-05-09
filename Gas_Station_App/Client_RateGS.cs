using GasStation;

namespace Gas_Station_App
{
    public partial class Client_RateGS : Form
    {
        Client_MainWindow mainWindow;
        Client client;
        Client_RateGS current;
        public Client_RateGS(Client_MainWindow main, Client cl)
        {
            InitializeComponent();

            mainWindow = main;
            client = cl;
            current = this;

            label3.Text = "Середня оцінка: " + Station.AverageMark();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Client_RateGS current = this;
            current.Close();
            mainWindow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mark;
            if (!int.TryParse(textBox1.Text, out mark) || mark < 1 || mark > 5)
            {
                MessageBox.Show("Некоректні дані");
            }
            else
            {
                Station.Instance.marks.Add(mark);
                label3.Text = "Середня оцінка: " + Station.AverageMark();
                textBox1.Enabled = false;
            }
        }

        private void Client_RateGS_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Visible = true;
        }
    }
}
