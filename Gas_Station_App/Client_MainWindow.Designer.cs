namespace Gas_Station_App
{
    partial class Client_MainWindow
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
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.Aquamarine;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(493, 68);
            button6.Name = "button6";
            button6.Size = new Size(115, 30);
            button6.TabIndex = 24;
            button6.Text = "Товари";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(118, 68);
            button2.Name = "button2";
            button2.Size = new Size(115, 30);
            button2.TabIndex = 23;
            button2.Text = "Замовлення";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(799, 12);
            button1.Name = "button1";
            button1.Size = new Size(152, 33);
            button1.TabIndex = 22;
            button1.Text = "Змінити роль";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 21;
            label1.Text = "Клієнт";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.Aquamarine;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(304, 68);
            button3.Name = "button3";
            button3.Size = new Size(115, 30);
            button3.TabIndex = 25;
            button3.Text = "Паливо";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(683, 68);
            button4.Name = "button4";
            button4.Size = new Size(194, 30);
            button4.TabIndex = 26;
            button4.Text = "Оцінити роботу АЗС";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Client_MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(963, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Client_MainWindow";
            Text = "Головне вікно клієнта";
            FormClosing += Client_MainWindow_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}