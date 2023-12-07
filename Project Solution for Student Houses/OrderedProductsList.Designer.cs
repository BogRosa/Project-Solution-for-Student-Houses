namespace Project_Solution_for_Student_Houses
{
    partial class OrderedProductsList
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
            label5 = new Label();
            listView1 = new ListView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            complaintsToolStripMenuItem = new ToolStripMenuItem();
            calendarToolStripMenuItem = new ToolStripMenuItem();
            itemCatalogToolStripMenuItem = new ToolStripMenuItem();
            itemListToolStripMenuItem = new ToolStripMenuItem();
            myOrderToolStripMenuItem = new ToolStripMenuItem();
            vScrollBar1 = new VScrollBar();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 215);
            label5.Name = "label5";
            label5.Size = new Size(1036, 40);
            label5.TabIndex = 11;
            label5.Text = "This is your order:\r\nDisclaimer: Please note that once you've confirmed and add the item to your order you'll recieve it even if you decide you don't need it nor want it anymore";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 258);
            listView1.Name = "listView1";
            listView1.Size = new Size(1861, 791);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1861, 125);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "User details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 81);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "XXXXX";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 41);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "PietPompies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 1;
            label2.Text = "Housing Adress:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Candara", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1861, 44);
            textBox1.TabIndex = 8;
            textBox1.Text = "My Ordered Products";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, accountToolStripMenuItem, complaintsToolStripMenuItem, calendarToolStripMenuItem, itemCatalogToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(33, 24);
            toolStripMenuItem1.Text = "≡";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(178, 26);
            homeToolStripMenuItem.Text = "Home";
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(178, 26);
            accountToolStripMenuItem.Text = "Account";
            // 
            // complaintsToolStripMenuItem
            // 
            complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            complaintsToolStripMenuItem.Size = new Size(178, 26);
            complaintsToolStripMenuItem.Text = "Complaints";
            // 
            // calendarToolStripMenuItem
            // 
            calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            calendarToolStripMenuItem.Size = new Size(178, 26);
            calendarToolStripMenuItem.Text = "Calendar";
            // 
            // itemCatalogToolStripMenuItem
            // 
            itemCatalogToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itemListToolStripMenuItem, myOrderToolStripMenuItem });
            itemCatalogToolStripMenuItem.Name = "itemCatalogToolStripMenuItem";
            itemCatalogToolStripMenuItem.Size = new Size(178, 26);
            itemCatalogToolStripMenuItem.Text = "Item Catalog";
            // 
            // itemListToolStripMenuItem
            // 
            itemListToolStripMenuItem.Name = "itemListToolStripMenuItem";
            itemListToolStripMenuItem.Size = new Size(154, 26);
            itemListToolStripMenuItem.Text = "Item List";
            // 
            // myOrderToolStripMenuItem
            // 
            myOrderToolStripMenuItem.Name = "myOrderToolStripMenuItem";
            myOrderToolStripMenuItem.Size = new Size(154, 26);
            myOrderToolStripMenuItem.Text = "My Order";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1876, 37);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 1019);
            vScrollBar1.TabIndex = 132;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1055);
            Controls.Add(vScrollBar1);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ListView listView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem complaintsToolStripMenuItem;
        private ToolStripMenuItem calendarToolStripMenuItem;
        private ToolStripMenuItem itemCatalogToolStripMenuItem;
        private ToolStripMenuItem itemListToolStripMenuItem;
        private ToolStripMenuItem myOrderToolStripMenuItem;
        private VScrollBar vScrollBar1;
    }
}