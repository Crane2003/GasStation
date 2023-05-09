using GasStation;

namespace Gas_Station_App
{
    public partial class Operator_MainWindow : Form
    {
        StartWindow start;
        Operator_MainWindow current;
        Operator op;
        public Operator_MainWindow(Operator _op, StartWindow sw)
        {
            InitializeComponent();
            start = sw;
            current = this;
            op = _op;

            label1.Text = "Оператор " + op.FullName + ", " + op.Paydesk + " каса";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operator_MainWindow main = this;
            main.Close();
            start.dataGridView2.DataSource = null;
            start.dataGridView2.DataSource = Station.Instance.clients;
            start.dataGridView2.ResetBindings();

            start.dataGridView1.DataSource = null;
            start.dataGridView1.DataSource = Station.Instance.operators;
            start.dataGridView1.ResetBindings();
            start.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operator_Clients clList = new Operator_Clients(current);
            clList.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Operator_Orders clList = new Operator_Orders(current, op);
            clList.Show();
            this.Visible = false;
        }

        private void Operator_MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            start.Visible = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
