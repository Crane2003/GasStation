namespace Gas_Station_App
{
    partial class Client_RateGS
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
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(646, 18);
            button7.Name = "button7";
            button7.Size = new Size(142, 30);
            button7.TabIndex = 53;
            button7.Text = "В головне меню";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 18);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 52;
            label1.Text = "Оцінити АЗС";
            // 
            // label2
            // 
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(210, 29);
            label2.TabIndex = 54;
            label2.Text = "Введіть оцінку (від 1 до 5):";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(0, 419);
            button1.Name = "button1";
            button1.Size = new Size(800, 31);
            button1.TabIndex = 55;
            button1.Text = "Оцінити";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(236, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(323, 356);
            label3.Name = "label3";
            label3.Size = new Size(130, 21);
            label3.TabIndex = 57;
            label3.Text = "Середня оцінка: ";
            // 
            // Client_RateGS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Client_RateGS";
            Text = "Оцінювання АЗС";
            FormClosing += Client_RateGS_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
    }
}