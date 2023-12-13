
namespace shoppingTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_btn = new System.Windows.Forms.Button();
            this.confirmClear_btn = new System.Windows.Forms.Button();
            this.inavlid_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.quantity_txtbx = new System.Windows.Forms.TextBox();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.price_txtbx = new System.Windows.Forms.TextBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.name_txtBox = new System.Windows.Forms.TextBox();
            this.itemName_lbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.remove_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOUNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalCost_lbl = new System.Windows.Forms.Label();
            this.removeOne_btn = new System.Windows.Forms.Button();
            this.addOne_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.newList_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loadList_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.files_listbox = new System.Windows.Forms.ListBox();
            this.load_btn = new System.Windows.Forms.Button();
            this.fileLocation_txtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.totalCost_lbl);
            this.panel1.Controls.Add(this.confirmClear_btn);
            this.panel1.Controls.Add(this.inavlid_lbl);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.quantity_txtbx);
            this.panel1.Controls.Add(this.quantity_lbl);
            this.panel1.Controls.Add(this.price_txtbx);
            this.panel1.Controls.Add(this.price_lbl);
            this.panel1.Controls.Add(this.name_txtBox);
            this.panel1.Controls.Add(this.itemName_lbl);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 110);
            this.panel1.TabIndex = 1;
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(536, 18);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "Clear List";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // confirmClear_btn
            // 
            this.confirmClear_btn.Location = new System.Drawing.Point(536, 47);
            this.confirmClear_btn.Name = "confirmClear_btn";
            this.confirmClear_btn.Size = new System.Drawing.Size(75, 23);
            this.confirmClear_btn.TabIndex = 9;
            this.confirmClear_btn.Text = "Confirm?";
            this.confirmClear_btn.UseVisualStyleBackColor = true;
            this.confirmClear_btn.Visible = false;
            this.confirmClear_btn.Click += new System.EventHandler(this.confirmClear_btn_Click);
            // 
            // inavlid_lbl
            // 
            this.inavlid_lbl.AutoSize = true;
            this.inavlid_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inavlid_lbl.Location = new System.Drawing.Point(248, 70);
            this.inavlid_lbl.Name = "inavlid_lbl";
            this.inavlid_lbl.Size = new System.Drawing.Size(65, 15);
            this.inavlid_lbl.TabIndex = 3;
            this.inavlid_lbl.Text = "Invalid Item";
            this.inavlid_lbl.Visible = false;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(434, 34);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Tag = "add";
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // quantity_txtbx
            // 
            this.quantity_txtbx.Location = new System.Drawing.Point(296, 34);
            this.quantity_txtbx.Name = "quantity_txtbx";
            this.quantity_txtbx.Size = new System.Drawing.Size(100, 21);
            this.quantity_txtbx.TabIndex = 5;
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Location = new System.Drawing.Point(293, 18);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(54, 15);
            this.quantity_lbl.TabIndex = 4;
            this.quantity_lbl.Text = "Quantity:";
            // 
            // price_txtbx
            // 
            this.price_txtbx.Location = new System.Drawing.Point(170, 34);
            this.price_txtbx.Name = "price_txtbx";
            this.price_txtbx.Size = new System.Drawing.Size(100, 21);
            this.price_txtbx.TabIndex = 3;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Location = new System.Drawing.Point(167, 18);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(34, 15);
            this.price_lbl.TabIndex = 2;
            this.price_lbl.Text = "Price:";
            // 
            // name_txtBox
            // 
            this.name_txtBox.Location = new System.Drawing.Point(32, 34);
            this.name_txtBox.Name = "name_txtBox";
            this.name_txtBox.Size = new System.Drawing.Size(100, 21);
            this.name_txtBox.TabIndex = 1;
            // 
            // itemName_lbl
            // 
            this.itemName_lbl.AutoSize = true;
            this.itemName_lbl.Location = new System.Drawing.Point(29, 18);
            this.itemName_lbl.Name = "itemName_lbl";
            this.itemName_lbl.Size = new System.Drawing.Size(38, 15);
            this.itemName_lbl.TabIndex = 0;
            this.itemName_lbl.Text = "Name:";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(0, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 289);
            this.listBox1.TabIndex = 2;
            // 
            // remove_btn
            // 
            this.remove_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_btn.Location = new System.Drawing.Point(606, 43);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 21);
            this.remove_btn.TabIndex = 6;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSDToolStripMenuItem,
            this.eURToolStripMenuItem,
            this.pOUNDToolStripMenuItem});
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.currencyToolStripMenuItem.Text = "Currency";
            // 
            // uSDToolStripMenuItem
            // 
            this.uSDToolStripMenuItem.Name = "uSDToolStripMenuItem";
            this.uSDToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.uSDToolStripMenuItem.Text = "USD";
            this.uSDToolStripMenuItem.Click += new System.EventHandler(this.uSDToolStripMenuItem_Click);
            // 
            // eURToolStripMenuItem
            // 
            this.eURToolStripMenuItem.Name = "eURToolStripMenuItem";
            this.eURToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.eURToolStripMenuItem.Text = "EUR";
            this.eURToolStripMenuItem.Click += new System.EventHandler(this.eURToolStripMenuItem_Click);
            // 
            // pOUNDToolStripMenuItem
            // 
            this.pOUNDToolStripMenuItem.Name = "pOUNDToolStripMenuItem";
            this.pOUNDToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pOUNDToolStripMenuItem.Text = "POUND";
            this.pOUNDToolStripMenuItem.Click += new System.EventHandler(this.pOUNDToolStripMenuItem_Click);
            // 
            // totalCost_lbl
            // 
            this.totalCost_lbl.AutoSize = true;
            this.totalCost_lbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost_lbl.Location = new System.Drawing.Point(12, 83);
            this.totalCost_lbl.Name = "totalCost_lbl";
            this.totalCost_lbl.Size = new System.Drawing.Size(64, 15);
            this.totalCost_lbl.TabIndex = 10;
            this.totalCost_lbl.Text = "Total Cost: ";
            // 
            // removeOne_btn
            // 
            this.removeOne_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeOne_btn.Location = new System.Drawing.Point(601, 70);
            this.removeOne_btn.Name = "removeOne_btn";
            this.removeOne_btn.Size = new System.Drawing.Size(88, 21);
            this.removeOne_btn.TabIndex = 11;
            this.removeOne_btn.Text = "Remove One";
            this.removeOne_btn.UseVisualStyleBackColor = true;
            this.removeOne_btn.Click += new System.EventHandler(this.removeOne_btn_Click);
            // 
            // addOne_btn
            // 
            this.addOne_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addOne_btn.Location = new System.Drawing.Point(601, 97);
            this.addOne_btn.Name = "addOne_btn";
            this.addOne_btn.Size = new System.Drawing.Size(88, 21);
            this.addOne_btn.TabIndex = 12;
            this.addOne_btn.Text = "Add One";
            this.addOne_btn.UseVisualStyleBackColor = true;
            this.addOne_btn.Click += new System.EventHandler(this.addOne_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Location = new System.Drawing.Point(601, 124);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(88, 21);
            this.edit_btn.TabIndex = 13;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(744, 541);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.Controls.Add(this.remove_btn);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.removeOne_btn);
            this.panel3.Controls.Add(this.addOne_btn);
            this.panel3.Controls.Add(this.edit_btn);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(26, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 336);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 541);
            this.panel4.TabIndex = 16;
            // 
            // newList_btn
            // 
            this.newList_btn.Location = new System.Drawing.Point(473, 294);
            this.newList_btn.Name = "newList_btn";
            this.newList_btn.Size = new System.Drawing.Size(75, 23);
            this.newList_btn.TabIndex = 7;
            this.newList_btn.Text = "New List";
            this.newList_btn.UseVisualStyleBackColor = true;
            this.newList_btn.Click += new System.EventHandler(this.newList_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 14);
            this.label3.TabIndex = 6;
            // 
            // loadList_btn
            // 
            this.loadList_btn.Location = new System.Drawing.Point(377, 294);
            this.loadList_btn.Name = "loadList_btn";
            this.loadList_btn.Size = new System.Drawing.Size(75, 23);
            this.loadList_btn.TabIndex = 5;
            this.loadList_btn.Text = "Load List";
            this.loadList_btn.UseVisualStyleBackColor = true;
            this.loadList_btn.Click += new System.EventHandler(this.loadList_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "List Preview";
            // 
            // files_listbox
            // 
            this.files_listbox.FormattingEnabled = true;
            this.files_listbox.ItemHeight = 14;
            this.files_listbox.Location = new System.Drawing.Point(81, 43);
            this.files_listbox.Name = "files_listbox";
            this.files_listbox.Size = new System.Drawing.Size(267, 256);
            this.files_listbox.TabIndex = 3;
            this.files_listbox.SelectedIndexChanged += new System.EventHandler(this.files_listbox_SelectedIndexChanged);
            // 
            // load_btn
            // 
            this.load_btn.Location = new System.Drawing.Point(411, 8);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 2;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // fileLocation_txtbx
            // 
            this.fileLocation_txtbx.Location = new System.Drawing.Point(151, 9);
            this.fileLocation_txtbx.Name = "fileLocation_txtbx";
            this.fileLocation_txtbx.Size = new System.Drawing.Size(234, 22);
            this.fileLocation_txtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shopping List Location:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.newList_btn);
            this.panel5.Controls.Add(this.fileLocation_txtbx);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.load_btn);
            this.panel5.Controls.Add(this.loadList_btn);
            this.panel5.Controls.Add(this.files_listbox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(12, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(576, 348);
            this.panel5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 541);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(760, 580);
            this.Name = "Form1";
            this.Text = "Grocery List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name_txtBox;
        private System.Windows.Forms.Label itemName_lbl;
        private System.Windows.Forms.Label inavlid_lbl;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox quantity_txtbx;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.TextBox price_txtbx;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button confirmClear_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label totalCost_lbl;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOUNDToolStripMenuItem;
        private System.Windows.Forms.Button removeOne_btn;
        private System.Windows.Forms.Button addOne_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox files_listbox;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.TextBox fileLocation_txtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadList_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newList_btn;
        private System.Windows.Forms.Panel panel5;
    }
}

