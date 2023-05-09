namespace Gas_Station_App
{
    partial class StartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
            label1 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            tabPage2 = new TabPage();
            dataGridView1 = new DataGridView();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            paydeskDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            operatorBindingSource = new BindingSource(components);
            tabPage3 = new TabPage();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            fullNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            paydeskDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            orderStateDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            moneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bonusCardDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            clientBindingSource = new BindingSource(components);
            operatorListBindingSource = new BindingSource(components);
            helpToolStripButton = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)operatorBindingSource).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)operatorListBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 35);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 2;
            label1.Text = "Оберіть роль:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 409);
            button1.Name = "button1";
            button1.Size = new Size(800, 41);
            button1.TabIndex = 3;
            button1.Text = "Підтвердити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 261);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.PaleTurquoise;
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 227);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Адміністратор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 0;
            label2.Text = "Admin";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 227);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Оператори";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.PaleTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fullNameDataGridViewTextBoxColumn, stateDataGridViewCheckBoxColumn, paydeskDataGridViewTextBoxColumn });
            dataGridView1.DataSource = operatorBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(762, 221);
            dataGridView1.TabIndex = 0;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            stateDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stateDataGridViewCheckBoxColumn.DataPropertyName = "State";
            stateDataGridViewCheckBoxColumn.HeaderText = "Зайнятість";
            stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            stateDataGridViewCheckBoxColumn.ReadOnly = true;
            stateDataGridViewCheckBoxColumn.Width = 92;
            // 
            // paydeskDataGridViewTextBoxColumn
            // 
            paydeskDataGridViewTextBoxColumn.DataPropertyName = "Paydesk";
            paydeskDataGridViewTextBoxColumn.HeaderText = "Номер каси";
            paydeskDataGridViewTextBoxColumn.Name = "paydeskDataGridViewTextBoxColumn";
            paydeskDataGridViewTextBoxColumn.ReadOnly = true;
            paydeskDataGridViewTextBoxColumn.Width = 120;
            // 
            // operatorBindingSource
            // 
            operatorBindingSource.DataSource = typeof(GasStation.Operator);
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 227);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Клієнти";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(269, 194);
            button2.Name = "button2";
            button2.Size = new Size(253, 33);
            button2.TabIndex = 1;
            button2.Text = "Новий клієнт";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = Color.PaleTurquoise;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { fullNameDataGridViewTextBoxColumn1, paydeskDataGridViewTextBoxColumn1, orderStateDataGridViewCheckBoxColumn, moneyDataGridViewTextBoxColumn, bonusCardDataGridViewCheckBoxColumn });
            dataGridView2.DataSource = clientBindingSource;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(765, 191);
            dataGridView2.TabIndex = 0;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            fullNameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn1.HeaderText = "ПІБ";
            fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // paydeskDataGridViewTextBoxColumn1
            // 
            paydeskDataGridViewTextBoxColumn1.DataPropertyName = "Paydesk";
            paydeskDataGridViewTextBoxColumn1.HeaderText = "Номер каси";
            paydeskDataGridViewTextBoxColumn1.Name = "paydeskDataGridViewTextBoxColumn1";
            paydeskDataGridViewTextBoxColumn1.ReadOnly = true;
            paydeskDataGridViewTextBoxColumn1.Width = 60;
            // 
            // orderStateDataGridViewCheckBoxColumn
            // 
            orderStateDataGridViewCheckBoxColumn.DataPropertyName = "OrderState";
            orderStateDataGridViewCheckBoxColumn.HeaderText = "Стан замовлення";
            orderStateDataGridViewCheckBoxColumn.Name = "orderStateDataGridViewCheckBoxColumn";
            orderStateDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            moneyDataGridViewTextBoxColumn.HeaderText = "Кількість грошей";
            moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            moneyDataGridViewTextBoxColumn.ReadOnly = true;
            moneyDataGridViewTextBoxColumn.Width = 80;
            // 
            // bonusCardDataGridViewCheckBoxColumn
            // 
            bonusCardDataGridViewCheckBoxColumn.DataPropertyName = "BonusCard";
            bonusCardDataGridViewCheckBoxColumn.HeaderText = "Бонусна картка";
            bonusCardDataGridViewCheckBoxColumn.Name = "bonusCardDataGridViewCheckBoxColumn";
            bonusCardDataGridViewCheckBoxColumn.ReadOnly = true;
            bonusCardDataGridViewCheckBoxColumn.Width = 70;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(GasStation.Client);
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
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Aquamarine;
            toolStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "StartWindow";
            RightToLeft = RightToLeft.No;
            Text = "Експрес-АЗС";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)operatorBindingSource).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)operatorListBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private BindingSource operatorBindingSource;
        private Button button2;
        private BindingSource operatorListBindingSource;
        private BindingSource clientBindingSource;
        public DataGridView dataGridView2;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn paydeskDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn paydeskDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn orderStateDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn bonusCardDataGridViewCheckBoxColumn;
        private ToolStripButton helpToolStripButton;
        private ToolStrip toolStrip1;
    }
}