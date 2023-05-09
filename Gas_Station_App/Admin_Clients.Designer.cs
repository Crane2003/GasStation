namespace Gas_Station_App
{
    partial class Admin_Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Clients));
            toolStrip1 = new ToolStrip();
            helpToolStripButton = new ToolStripButton();
            dataGridView1 = new DataGridView();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paydeskDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderStateDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            moneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonusCardDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            clientBindingSource1 = new BindingSource(components);
            clientBindingSource = new BindingSource(components);
            label1 = new Label();
            button7 = new Button();
            button1 = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Aquamarine;
            toolStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fullNameDataGridViewTextBoxColumn, paydeskDataGridViewTextBoxColumn, orderStateDataGridViewCheckBoxColumn, moneyDataGridViewTextBoxColumn, bonusCardDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = clientBindingSource1;
            dataGridView1.Location = new Point(0, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 2;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // paydeskDataGridViewTextBoxColumn
            // 
            paydeskDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            paydeskDataGridViewTextBoxColumn.DataPropertyName = "Paydesk";
            paydeskDataGridViewTextBoxColumn.HeaderText = "Номер каси";
            paydeskDataGridViewTextBoxColumn.Name = "paydeskDataGridViewTextBoxColumn";
            paydeskDataGridViewTextBoxColumn.Width = 90;
            // 
            // orderStateDataGridViewCheckBoxColumn
            // 
            orderStateDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            orderStateDataGridViewCheckBoxColumn.DataPropertyName = "OrderState";
            orderStateDataGridViewCheckBoxColumn.HeaderText = "Стан замовлення";
            orderStateDataGridViewCheckBoxColumn.Name = "orderStateDataGridViewCheckBoxColumn";
            orderStateDataGridViewCheckBoxColumn.Width = 97;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            moneyDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            moneyDataGridViewTextBoxColumn.HeaderText = "Кількість грошей";
            moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            moneyDataGridViewTextBoxColumn.Width = 116;
            // 
            // bonusCardDataGridViewCheckBoxColumn
            // 
            bonusCardDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            bonusCardDataGridViewCheckBoxColumn.DataPropertyName = "BonusCard";
            bonusCardDataGridViewCheckBoxColumn.HeaderText = "Бонусна картка";
            bonusCardDataGridViewCheckBoxColumn.Name = "bonusCardDataGridViewCheckBoxColumn";
            bonusCardDataGridViewCheckBoxColumn.Width = 88;
            // 
            // clientBindingSource1
            // 
            clientBindingSource1.DataSource = typeof(GasStation.Client);
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(GasStation.Client);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 35);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 25;
            label1.Text = "Клієнти";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(646, 30);
            button7.Name = "button7";
            button7.Size = new Size(142, 30);
            button7.TabIndex = 40;
            button7.Text = "В головне меню";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 404);
            button1.Name = "button1";
            button1.Size = new Size(800, 46);
            button1.TabIndex = 41;
            button1.Text = "Видалити клієнта";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Admin_Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Admin_Clients";
            Text = "Керування клієнтами";
            FormClosing += Admin_Clients_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton helpToolStripButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paydeskDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn orderStateDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn bonusCardDataGridViewCheckBoxColumn;
        private BindingSource clientBindingSource;
        private Label label1;
        private Button button7;
        private BindingSource clientBindingSource1;
        private Button button1;
    }
}