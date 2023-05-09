namespace Gas_Station_App
{
    partial class Operator_MainWindow
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
            SuspendLayout();
            // 
            // button6
            // 
            button6.BackColor = Color.Aquamarine;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(506, 71);
            button6.Name = "button6";
            button6.Size = new Size(115, 30);
            button6.TabIndex = 18;
            button6.Text = "Замовлення";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(333, 71);
            button2.Name = "button2";
            button2.Size = new Size(115, 30);
            button2.TabIndex = 14;
            button2.Text = "Клієнти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(827, 9);
            button1.Name = "button1";
            button1.Size = new Size(152, 33);
            button1.TabIndex = 13;
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
            label1.Size = new Size(98, 25);
            label1.TabIndex = 12;
            label1.Text = "Оператор";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Operator_MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(991, 450);
            Controls.Add(button6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Operator_MainWindow";
            Text = "Головне вікно клієнта";
            FormClosing += Operator_MainWindow_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}