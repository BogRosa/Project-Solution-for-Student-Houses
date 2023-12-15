namespace Project_Solution_for_Student_Houses
{
    partial class Complaints
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complaints));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkAnonymous = new RadioButton();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            dateTimeOccurred = new DateTimePicker();
            label5 = new Label();
            panelAside = new Panel();
            bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(components);
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            submitComplaint = new Bunifu.Framework.UI.BunifuThinButton2();
            panelAside.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(120, 63, 142);
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(539, 22);
            label1.Name = "label1";
            label1.Size = new Size(409, 61);
            label1.TabIndex = 0;
            label1.Text = "Complaint form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(272, 215);
            label2.Name = "label2";
            label2.Size = new Size(118, 43);
            label2.TabIndex = 1;
            label2.Text = "Title: *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(272, 290);
            label3.Name = "label3";
            label3.Size = new Size(496, 43);
            label3.TabIndex = 2;
            label3.Text = "Describe your complaints: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(272, 151);
            label4.Name = "label4";
            label4.Size = new Size(813, 40);
            label4.TabIndex = 3;
            label4.Text = "Would you like your complain to be anonymous?";
            // 
            // chkAnonymous
            // 
            chkAnonymous.AutoSize = true;
            chkAnonymous.Font = new Font("Century Gothic", 17F, FontStyle.Regular, GraphicsUnit.Point);
            chkAnonymous.Location = new Point(1091, 147);
            chkAnonymous.Margin = new Padding(3, 4, 3, 4);
            chkAnonymous.Name = "chkAnonymous";
            chkAnonymous.Size = new Size(97, 44);
            chkAnonymous.TabIndex = 4;
            chkAnonymous.TabStop = true;
            chkAnonymous.Text = "Yes";
            chkAnonymous.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(409, 215);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(767, 55);
            txtTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(281, 354);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(895, 264);
            txtDescription.TabIndex = 6;
            // 
            // dateTimeOccurred
            // 
            dateTimeOccurred.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeOccurred.Location = new Point(729, 667);
            dateTimeOccurred.Margin = new Padding(3, 4, 3, 4);
            dateTimeOccurred.Name = "dateTimeOccurred";
            dateTimeOccurred.Size = new Size(447, 52);
            dateTimeOccurred.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(272, 667);
            label5.Name = "label5";
            label5.Size = new Size(444, 43);
            label5.TabIndex = 8;
            label5.Text = "Date and time occured:";
            // 
            // panelAside
            // 
            panelAside.BackColor = Color.FromArgb(120, 63, 142);
            panelAside.Controls.Add(bunifuThinButton23);
            panelAside.Controls.Add(label1);
            panelAside.Dock = DockStyle.Top;
            panelAside.Location = new Point(0, 0);
            panelAside.Margin = new Padding(3, 4, 3, 4);
            panelAside.Name = "panelAside";
            panelAside.Size = new Size(1438, 123);
            panelAside.TabIndex = 12;
            // 
            // bunifuThinButton23
            // 
            bunifuThinButton23.ActiveBorderThickness = 3;
            bunifuThinButton23.ActiveCornerRadius = 20;
            bunifuThinButton23.ActiveFillColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton23.ActiveForecolor = Color.FromArgb(191, 172, 200);
            bunifuThinButton23.ActiveLineColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton23.BackColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton23.BackgroundImage = (Image)resources.GetObject("bunifuThinButton23.BackgroundImage");
            bunifuThinButton23.ButtonText = "Log Out";
            bunifuThinButton23.Cursor = Cursors.SizeAll;
            bunifuThinButton23.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton23.ForeColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton23.IdleBorderThickness = 3;
            bunifuThinButton23.IdleCornerRadius = 20;
            bunifuThinButton23.IdleFillColor = Color.White;
            bunifuThinButton23.IdleForecolor = Color.FromArgb(120, 63, 142);
            bunifuThinButton23.IdleLineColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton23.Location = new Point(1091, 7);
            bunifuThinButton23.Margin = new Padding(8, 7, 8, 7);
            bunifuThinButton23.Name = "bunifuThinButton23";
            bunifuThinButton23.Size = new Size(294, 94);
            bunifuThinButton23.TabIndex = 15;
            bunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bunifuDragControl1
            // 
            bunifuDragControl1.Fixed = true;
            bunifuDragControl1.Horizontal = true;
            bunifuDragControl1.TargetControl = null;
            bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 5;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 3;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton21.BackColor = Color.FromArgb(191, 172, 200);
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Go Back";
            bunifuThinButton21.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton21.IdleBorderThickness = 3;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.FromArgb(120, 63, 142);
            bunifuThinButton21.IdleLineColor = Color.FromArgb(120, 63, 142);
            bunifuThinButton21.Location = new Point(32, 752);
            bunifuThinButton21.Margin = new Padding(8, 7, 8, 7);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(294, 94);
            bunifuThinButton21.TabIndex = 13;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // submitComplaint
            // 
            submitComplaint.ActiveBorderThickness = 3;
            submitComplaint.ActiveCornerRadius = 20;
            submitComplaint.ActiveFillColor = Color.FromArgb(120, 63, 142);
            submitComplaint.ActiveForecolor = Color.White;
            submitComplaint.ActiveLineColor = Color.FromArgb(120, 63, 142);
            submitComplaint.BackColor = Color.FromArgb(191, 172, 200);
            submitComplaint.BackgroundImage = (Image)resources.GetObject("submitComplaint.BackgroundImage");
            submitComplaint.ButtonText = "Submit Complaint";
            submitComplaint.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            submitComplaint.ForeColor = Color.FromArgb(120, 63, 142);
            submitComplaint.IdleBorderThickness = 3;
            submitComplaint.IdleCornerRadius = 20;
            submitComplaint.IdleFillColor = Color.White;
            submitComplaint.IdleForecolor = Color.FromArgb(120, 63, 142);
            submitComplaint.IdleLineColor = Color.FromArgb(120, 63, 142);
            submitComplaint.Location = new Point(473, 752);
            submitComplaint.Margin = new Padding(7, 8, 7, 8);
            submitComplaint.Name = "submitComplaint";
            submitComplaint.Size = new Size(459, 94);
            submitComplaint.TabIndex = 14;
            submitComplaint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Complaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(191, 172, 200);
            ClientSize = new Size(1438, 895);
            Controls.Add(submitComplaint);
            Controls.Add(bunifuThinButton21);
            Controls.Add(label5);
            Controls.Add(dateTimeOccurred);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(chkAnonymous);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panelAside);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Complaints";
            Text = "Complaints";
            panelAside.ResumeLayout(false);
            panelAside.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton chkAnonymous;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private DateTimePicker dateTimeOccurred;
        private Label label5;
        private Panel panelAside;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 submitComplaint;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
    }
}