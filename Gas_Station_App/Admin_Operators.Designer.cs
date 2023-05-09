namespace Gas_Station_App
{
    partial class Admin_Operators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Operators));
            helpToolStripButton = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            dataGridView1 = new DataGridView();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            paydeskDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            operatorBindingSource = new BindingSource(components);
            label1 = new Label();
            button7 = new Button();
            button1 = new Button();
            button2 = new Button();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)operatorBindingSource).BeginInit();
            SuspendLayout();
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
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
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
            dataGridView1.Location = new Point(0, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "ПІБ";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            stateDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            stateDataGridViewCheckBoxColumn.DataPropertyName = "State";
            stateDataGridViewCheckBoxColumn.HeaderText = "Зайнятість";
            stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            stateDataGridViewCheckBoxColumn.Width = 71;
            // 
            // paydeskDataGridViewTextBoxColumn
            // 
            paydeskDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            paydeskDataGridViewTextBoxColumn.DataPropertyName = "Paydesk";
            paydeskDataGridViewTextBoxColumn.HeaderText = "Номер каси";
            paydeskDataGridViewTextBoxColumn.Name = "paydeskDataGridViewTextBoxColumn";
            paydeskDataGridViewTextBoxColumn.Width = 98;
            // 
            // operatorBindingSource
            // 
            operatorBindingSource.DataSource = typeof(GasStation.Operator);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 41);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 24;
            label1.Text = "Оператори";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(646, 36);
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
            button1.Location = new Point(0, 405);
            button1.Name = "button1";
            button1.Size = new Size(800, 45);
            button1.TabIndex = 41;
            button1.Text = "Додати оператора";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Dock = DockStyle.Bottom;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 360);
            button2.Name = "button2";
            button2.Size = new Size(800, 45);
            button2.TabIndex = 42;
            button2.Text = "Видалити оператора";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Admin_Operators
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
            Name = "Admin_Operators";
            Text = "Керування операторами";
            FormClosing += Admin_Operators_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)operatorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripButton helpToolStripButton;
        private ToolStrip toolStrip1;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn paydeskDataGridViewTextBoxColumn;
        private BindingSource operatorBindingSource;
        private Label label1;
        private Button button7;
        private Button button1;
        private Button button2;
        public DataGridView dataGridView1;
    }
}