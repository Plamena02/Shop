using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllersVisual;
using Shop;
using Shop.Controllers;
using Shop.Data;



namespace Shop.Visual
{
    public partial class Form1 : Form
    {
        private DrinkController drinkController = new DrinkController(new ShopContext());
        private NutController nutController = new NutController(new ShopContext());
        private FruitAndVegetableController fruitAndVegetableController = new FruitAndVegetableController(new ShopContext());
        private PastryController pastryController = new PastryController(new ShopContext());
        private int Number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            ShowMainMenu();
            label1.BringToFront();
            label2.SendToBack();
            label2.Text = "Kolakak\nKolakak\nKolakak";
        }
    }

        private void PastryButton_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "Pastry";
            label1.Location = new Point(158, 71);
            label1.ForeColor = Color.Gold;
            label2.BackColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            Number = 1;
        }

        private void FruitsAndVegetablesButton_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "FruitsAndVegetables";
            label1.Location = new Point(32,71);
            label1.ForeColor = Color.LimeGreen;
            label2.BackColor = Color.LimeGreen;
            label2.ForeColor = Color.LimeGreen;
            Number = 2;
        }

        private void NutsButton_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "Nuts";
            label1.Location = new Point(170, 71);
            label1.ForeColor = Color.MediumOrchid;
            label2.BackColor = Color.MediumOrchid;
            label2.ForeColor = Color.MediumOrchid;
            Number = 3;
        }

        private void DrinksButton_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "Drinks";
            label1.Location = new Point(158, 71);
            label1.ForeColor = Color.DeepSkyBlue;
            label2.BackColor = Color.DeepSkyBlue;
            label2.ForeColor = Color.DeepSkyBlue;
            Number = 4;
        }


        private void ListAll_Click(object sender, EventArgs e)
        {
            Clear();
            ListAll(Number);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clear();
        }
        
        private void ShowMainMenu ()
        {
            button1.Enabled = true;
            button1.Visible = true;
            button2.Enabled = true;
            button2.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
            button4.Enabled = true;
            button4.Visible = true;
        }

        private void ShowSubMenu()
        {
            button5.Enabled = true;
            button5.Visible = true;
            button6.Enabled = true;
            button6.Visible = true;
            button7.Enabled = true;
            button7.Visible = true;
            button8.Enabled = true;
            button8.Visible = true;
            button9.Enabled = true;
            button9.Visible = true;
            button10.Enabled = true;
            button10.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void Clear()
        {
            foreach (Button b in this.Controls.OfType<Button>())
            {
                b.Enabled = false;
                b.Visible = false;
            }
            foreach (Label d in this.Controls.OfType<Label>())
            {
                d.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clear();
            ShowMainMenu();
        }

        private void ListAll(int num)
        {
            var pastries = pastryController.GetAllPastries();
            var frutsAndVegetables = fruitAndVegetableController.GetAllFruitsAndVegetables();
            var nuts = nutController.GetAllNuts();
            var drinks = drinkController.GetAllDrinks();
            if (num==1)
            {
                foreach (var item in pastries)
                {  
                    label2.Text = ($"    {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/pcs {item.Quantity}pcs.");
                }
            }
            if (num==2)
            {
                foreach (var item in frutsAndVegetables)
                {
                    label2.Text = ($"    {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/kg {item.Quantity}kg.");
                }
            }
            if (num==3)
            {
                foreach (var item in nuts)
                {
                    label2.Text = ($"    {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/kg {item.Quantity}kg.");
                }
            }
            if (num==4)
            {
                foreach (var item in drinks)
                {
                    label2.Text = ($"    {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/pcs {item.Quantity}pcs.");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
