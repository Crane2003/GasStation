namespace Gas_Station_App
{
    partial class Admin_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Load));
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            helpToolStripButton = new ToolStripButton();
            button9 = new Button();
            button8 = new Button();
            button4 = new Button();
            button1 = new Button();
            button7 = new Button();
            button2 = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 49);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 41;
            label1.Text = "Завантаження";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Aquamarine;
            toolStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 36;
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
            // button9
            // 
            button9.BackColor = Color.Aquamarine;
            button9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(470, 119);
            button9.Name = "button9";
            button9.Size = new Size(217, 28);
            button9.TabIndex = 50;
            button9.Text = "Завантажити товари";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Aquamarine;
            button8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(470, 165);
            button8.Name = "button8";
            button8.Size = new Size(217, 28);
            button8.TabIndex = 49;
            button8.Text = "Завантажити паливо";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(122, 165);
            button4.Name = "button4";
            button4.Size = new Size(217, 28);
            button4.TabIndex = 48;
            button4.Text = "Завантажити операторів";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(122, 119);
            button1.Name = "button1";
            button1.Size = new Size(217, 28);
            button1.TabIndex = 47;
            button1.Text = "Завантажити клієнтів";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(646, 44);
            button7.Name = "button7";
            button7.Size = new Size(142, 30);
            button7.TabIndex = 51;
            button7.Text = "В головне меню";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(306, 217);
            button2.Name = "button2";
            button2.Size = new Size(183, 37);
            button2.TabIndex = 52;
            button2.Text = "Завантажити оцінки";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Admin_Load
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button7);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Admin_Load";
            Text = "Завантаження даних";
            FormClosing += Admin_Load_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripButton helpToolStripButton;
        private Button button9;
        private Button button8;
        private Button button4;
        private Button button1;
        private Button button7;
        private Button button2;
    }
}