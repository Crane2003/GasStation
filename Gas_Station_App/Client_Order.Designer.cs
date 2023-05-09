namespace Gas_Station_App
{
    partial class Client_Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Order));
            button7 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            helpToolStripButton = new ToolStripButton();
            client_order_bs = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)client_order_bs).BeginInit();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(646, 63);
            button7.Name = "button7";
            button7.Size = new Size(142, 30);
            button7.TabIndex = 50;
            button7.Text = "В головне меню";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 63);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 49;
            label1.Text = "Замовлення";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Aquamarine;
            toolStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 47;
            toolStrip1.Text = "toolStrip1";
            // 
            // helpToolStripButton
            // 
            helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            helpToolStripButton.Image = (Image)resources.GetObject("helpToolStripButton.Image");
            helpToolStripButton.ImageTransparentColor = Color.Magenta;
            helpToolStripButton.Name = "helpToolStripButton";
            helpToolStripButton.Size = new Size(23, 22);
            helpToolStripButton.Text = "He&lp";
            helpToolStripButton.Click += helpToolStripButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 411);
            button1.Name = "button1";
            button1.Size = new Size(800, 39);
            button1.TabIndex = 51;
            button1.Text = "Прибрати із замовлення";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Dock = DockStyle.Bottom;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 374);
            button2.Name = "button2";
            button2.Size = new Size(800, 37);
            button2.TabIndex = 52;
            button2.Text = "Підтвердити замовлення";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Client_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Client_Order";
            Text = "Замовлення клієнта";
            FormClosing += Client_Order_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)client_order_bs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Label label1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton helpToolStripButton;
        private BindingSource client_order_bs;
        private Button button1;
        private Button button2;
    }
}