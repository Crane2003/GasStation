namespace Gas_Station_App
{
    partial class Add_Operator
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
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 403);
            button1.Name = "button1";
            button1.Size = new Size(800, 47);
            button1.TabIndex = 19;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(592, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(53, 29);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(381, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 29);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(54, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 29);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Aquamarine;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(569, 64);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 13;
            label4.Text = "Номер каси";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Aquamarine;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(413, 64);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 12;
            label3.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Aquamarine;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(171, 64);
            label2.Name = "label2";
            label2.Size = new Size(34, 21);
            label2.TabIndex = 11;
            label2.Text = "ПІБ";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 10;
            label1.Text = "Введіть дані";
            // 
            // Add_Operator
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
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Add_Operator";
            Text = "Додавання нового оператора";
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