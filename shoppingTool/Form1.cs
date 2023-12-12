using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                items[i].changeSymbol(s);
                items[i].UnitPrice = items[i].UnitPrice * exchangeRate;
                items[i].updateTotal();
                totalCost += items[i].getTotalPrice();
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
