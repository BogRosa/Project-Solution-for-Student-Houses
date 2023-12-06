namespace Project_Solution_for_Student_Houses
{
    partial class Calendar_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar_admin));
            comboBox1 = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(344, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 28);
            comboBox1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(392, 223);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "add event";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(580, 135);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 19;
            label4.Text = "List of events:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(580, 179);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(277, 204);
            listBox1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(223, 51);
            label3.Name = "label3";
            label3.Size = new Size(219, 46);
            label3.TabIndex = 17;
            label3.Text = "Add an event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 179);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 16;
            label2.Text = "Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 135);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 15;
            label1.Text = "Type of event";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(monthCalendar1);
            groupBox1.Location = new Point(249, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 250);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calendar";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 32);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 568);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label4;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
    }
}