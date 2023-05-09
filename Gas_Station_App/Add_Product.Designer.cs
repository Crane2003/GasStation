namespace Gas_Station_App
{
    partial class Add_Product
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 417);
            button1.Name = "button1";
            button1.Size = new Size(800, 33);
            button1.TabIndex = 27;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(535, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(327, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 29);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(36, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 29);
            textBox1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Aquamarine;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(547, 64);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 23;
            label4.Text = "Кількість";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(376, 64);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 22;
            label3.Text = "Ціна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(116, 64);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 21;
            label2.Text = "Назва";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(344, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 20;
            label1.Text = "Введіть дані";
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_Product";
            Text = "Додавання нового продукту";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}