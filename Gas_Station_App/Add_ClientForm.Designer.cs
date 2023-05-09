namespace Gas_Station_App
{
    partial class Add_ClientForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(316, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Введіть свої дані";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(145, 63);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 1;
            label2.Text = "ПІБ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(367, 63);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Aquamarine;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(509, 63);
            label4.Name = "label4";
            label4.Size = new Size(131, 21);
            label4.TabIndex = 3;
            label4.Text = "Кількість грошей";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Aquamarine;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(667, 63);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 4;
            label5.Text = "Бонусна картка";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(24, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(331, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 29);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(527, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(717, 107);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 401);
            button1.Name = "button1";
            button1.Size = new Size(800, 49);
            button1.TabIndex = 9;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_ClientForm";
            Text = "Додавання нового клієнта";
            FormClosing += AddClientForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private Button button1;
    }
}