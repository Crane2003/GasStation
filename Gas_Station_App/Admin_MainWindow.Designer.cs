namespace Gas_Station_App
{
    partial class Admin_MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button5 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(592, 51);
            button4.Name = "button4";
            button4.Size = new Size(194, 30);
            button4.TabIndex = 34;
            button4.Text = "Зберегти";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Aquamarine;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(155, 51);
            button3.Name = "button3";
            button3.Size = new Size(115, 30);
            button3.TabIndex = 33;
            button3.Text = "Оператори";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Aquamarine;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(448, 51);
            button6.Name = "button6";
            button6.Size = new Size(115, 30);
            button6.TabIndex = 32;
            button6.Text = "Товари";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(12, 51);
            button2.Name = "button2";
            button2.Size = new Size(115, 30);
            button2.TabIndex = 31;
            button2.Text = "Клієнти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(854, 12);
            button1.Name = "button1";
            button1.Size = new Size(152, 33);
            button1.TabIndex = 30;
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
            label1.Size = new Size(180, 25);
            label1.TabIndex = 29;
            label1.Text = "Адміністратор АЗС";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.BackColor = Color.Aquamarine;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(299, 51);
            button5.Name = "button5";
            button5.Size = new Size(115, 30);
            button5.TabIndex = 35;
            button5.Text = "Паливо";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Aquamarine;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(812, 51);
            button7.Name = "button7";
            button7.Size = new Size(194, 30);
            button7.TabIndex = 36;
            button7.Text = "Завантажити";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Admin_MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 450);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Admin_MainWindow";
            Text = "Головне вікно адміністратора";
            FormClosing += Admin_MainWindow_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button6;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button5;
        private Button button7;
    }
}