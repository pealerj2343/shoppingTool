using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingTool
{
    public partial class Form1 : Form
    {
        List<Item> items = new List<Item>();
        double totalCost = 0;
        int numOfItems = 0;

        List<String> files = new List<string>();

        NumberFormatInfo currency = new NumberFormatInfo();

        public Form1()
        {
            InitializeComponent();
            currency.CurrencySymbol = "$";
            totalCost_lbl.Text = String.Format("Total Cost: {0}", totalCost.ToString("C2", currency));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void addItem()
        {
            String name = name_txtBox.Text;
            double price = 0;
            double.TryParse(price_txtbx.Text, out price);
            int quantity = 0;
            int.TryParse(quantity_txtbx.Text, out quantity);
            if (name.Length != 0 && price > 0 && quantity > 0)
            {
                inavlid_lbl.Visible = false;
                Item temp = new Item(quantity, price, name);
                temp.changeSymbol(currency.CurrencySymbol);
                items.Add(temp);
                listBox1.Items.Add(items[numOfItems].ToString());
                totalCost += quantity * price;
                totalCost_lbl.Text = String.Format("Total Cost: {0}", totalCost.ToString("C2", currency));
                numOfItems++;
            }
            else
            {
                inavlid_lbl.Visible = true;
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            addItem();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            remove();
        }
        private void remove()
        {
            if (listBox1.SelectedIndex != -1)
            {
                totalCost -= items[listBox1.SelectedIndex].getTotalPrice();
                items.RemoveAt(listBox1.SelectedIndex);
                totalCost_lbl.Text = String.Format("Total Cost: {0}", totalCost.ToString("C2", currency));
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                numOfItems--;
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            confirmClear_btn.Visible = true;
        }

        private void confirmClear_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            items.Clear();
            totalCost = 0;
            totalCost_lbl.Text = String.Format("Total Cost: {0}", totalCost.ToString("C2", currency));
            confirmClear_btn.Visible = false;
            numOfItems = 0;
        }
        public void changeCurrency(String s)
        {
            if (currency.CurrencySymbol == s)
                return;
            double exchangeRate = 1;
            if (s == "$")
            {
                if(currency.CurrencySymbol == "€")
                {
                    exchangeRate = 1.08;
                }
                else
                {
                    exchangeRate = 1.25;
                }
            }
            else if(s == "€")
            {
                if (currency.CurrencySymbol == "$")
                {
                    exchangeRate = 0.93;
                }
                else
                {
                    exchangeRate = 1.16;
                }
            }
            else
            {
                if (currency.CurrencySymbol == "$")
                {
                    exchangeRate = 0.8;
                }
                else
                {
                    exchangeRate = 0.86;
                }
            }
            currency.CurrencySymbol = s;
            totalCost = 0;
            for (int i = 0; i < numOfItems; i++)
            {
                try
                {
                    items[i].changeSymbol(s);
                    items[i].UnitPrice = items[i].UnitPrice * exchangeRate;
                    items[i].updateTotal();
                    totalCost += items[i].getTotalPrice();
                }
                catch (Exception)
                {

                }
            }
            reloadList();
            totalCost_lbl.Text = String.Format("Total Cost: {0}", totalCost.ToString("C2", currency));
        }
        private void reloadList()
        {
            listBox1.Items.Clear();
            foreach(Item item in items)
            {
                listBox1.Items.Add(item);
            }
        }
        private void uSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeCurrency("$");
        }

        private void eURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeCurrency("€");
        }

        private void pOUNDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeCurrency("£");
        }
        private void removeOne()
        {
            if(listBox1.SelectedIndex != -1)
            {
                items[listBox1.SelectedIndex].removeOne();
                reloadList();
            }
        }
        private void addOne()
        {
            if (listBox1.SelectedIndex != -1)
            {
                items[listBox1.SelectedIndex].addOne();
                reloadList();
            }
        }
        private void removeOne_btn_Click(object sender, EventArgs e)
        {
            removeOne();
        }

        private void edit()
        {
            if(listBox1.SelectedIndex != -1)
            {
                name_txtBox.Text = items[listBox1.SelectedIndex].Name;
                price_txtbx.Text = (items[listBox1.SelectedIndex].UnitPrice).ToString();
                quantity_txtbx.Text = (items[listBox1.SelectedIndex].Quantity).ToString();
            }
            remove();
        }

        private void addOne_btn_Click(object sender, EventArgs e)
        {
            addOne();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            if (fileLocation_txtbx.Text != "")
            {
                String line;
                items.Clear();
                files.Clear();
                files_listbox.Items.Clear();
                try
                {
                    StreamReader sr = new StreamReader(fileLocation_txtbx.Text);
                    numOfItems = 0;
                    line = sr.ReadLine();
                    files.Add(line);
                    files_listbox.Items.Add(files[numOfItems]);
                    while (line != null)
                    {
                        line = sr.ReadLine();
                        numOfItems++;
                        files.Add(line);
                        files_listbox.Items.Add(files[numOfItems]);
                        String temp = line;
                        String name = temp.Substring(0, temp.IndexOf(" "));
                        temp = temp.Substring(temp.IndexOf(" ") + 1);
                        int count = int.Parse(temp.Substring(0, temp.IndexOf(" ") + 1));
                        temp = temp.Substring(temp.IndexOf(" ") + 1);
                        double price = double.Parse(temp);
                        Item item = new Item(count, price, name);
                        item.changeSymbol(currency.CurrencySymbol);
                        items.Add(item);
                    }
                    sr.Close();
                }
                catch (Exception)
                {

                }
                
            }
            numOfItems--;
        }

        private void loadList_btn_Click(object sender, EventArgs e)
        {
            reloadList();
            panel4.Visible = false;
            panel2.Visible = true;
            menuStrip1.Visible = true;
        }

        private void newList_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            items.Clear();
            panel4.Visible = false;
            panel2.Visible = true;
            menuStrip1.Visible = true;
        }

        private void files_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Item
    {
        private int quantity;
        private double unitPrice;
        private double totalPrice;
        private String name;
        private NumberFormatInfo currency = new NumberFormatInfo();


        public int Quantity {
            get
            {
                return quantity;
            }
            set
            {
                if(value > 0)
                    quantity = value;
            }
        }
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0)
                    unitPrice = value;
            }
        }
        public void removeOne()
        {
            quantity--;
            updateTotal();
        }
        public void addOne()
        {
            quantity++;
            updateTotal();
        }
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!value.Equals(""))
                {
                    name = value;
                }
            }
        }
        public void changeSymbol(String s)
        {
            currency.CurrencySymbol = s;
        }
        public double getTotalPrice()
        {
            return totalPrice;
        }
        public void updateTotal()
        {
            totalPrice = quantity * unitPrice;
        }
        public Item()
        {

        }
        public Item(int quan, double unitpr, String nme)
        {
            quantity = quan;
            unitPrice = unitpr;
            name = nme;
            totalPrice = quan * unitpr;
            currency.CurrencySymbol = "$";
        }
        override
        public String ToString()
        {
            if(quantity > 1)
                return String.Format("{0} {1}'s at {2} for a total of {3}", quantity, name, unitPrice.ToString("C2", currency), totalPrice.ToString("C2", currency));
            else
                return String.Format("{0} for {1}", name, unitPrice.ToString("C2", currency));
        }
    }
}
