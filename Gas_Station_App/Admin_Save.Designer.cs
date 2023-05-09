namespace Gas_Station_App
{
    partial class Admin_Save
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Save));
            label1 = new Label();
            button7 = new Button();
            toolStrip1 = new ToolStrip();
            helpToolStripButton = new ToolStripButton();
            button1 = new Button();
            button4 = new Button();
            button8 = new Button();
            button9 = new Button();
            button2 = new Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Aquamarine;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(331, 49);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 41;
            label1.Text = "Збереження";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(646, 44);
            button7.Name = "button7";
            button7.Size = new Size(142, 30);
            button7.TabIndex = 39;
            button7.Text = "В головне меню";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
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
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(108, 94);
            button1.Name = "button1";
            button1.Size = new Size(185, 30);
            button1.TabIndex = 43;
            button1.Text = "Зберегти клієнтів";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(108, 146);
            button4.Name = "button4";
            button4.Size = new Size(185, 30);
            button4.TabIndex = 44;
            button4.Text = "Зберегти операторів";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Aquamarine;
            button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(503, 94);
            button8.Name = "button8";
            button8.Size = new Size(183, 30);
            button8.TabIndex = 45;
            button8.Text = "Зберегти паливо";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Aquamarine;
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(503, 146);
            button9.Name = "button9";
            button9.Size = new Size(183, 30);
            button9.TabIndex = 46;
            button9.Text = "Зберегти товари";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(311, 205);
            button2.Name = "button2";
            button2.Size = new Size(176, 33);
            button2.TabIndex = 47;
            button2.Text = "Зберегти оцінки";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Admin_Save
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = Properties.Resources.backgroundOkko;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Admin_Save";
            Text = "Збереження даних";
            FormClosing += Admin_Save_FormClosing;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button7;
        private ToolStrip toolStrip1;
        private ToolStripButton helpToolStripButton;
        private Button button1;
        private Button button4;
        private Button button8;
        private Button button9;
        private Button button2;
    }
}