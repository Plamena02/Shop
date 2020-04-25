using System;
using System.Drawing;
using System.Linq;
using Microsoft.SqlServer;
using System.Windows.Forms;
using ShopVisual.Controllers;

namespace ShopVisual
{
    public partial class Form1 : Form
    {
        private DrinkController drinkController = new DrinkController();
        private NutController nutController = new NutController();
        private FruitAndVegetableController fruitAndVegetableController = new FruitAndVegetableController();
        private PastryController pastryController = new PastryController();
        private int SectionNumber = 0;
        private int ReturnNumber = 0;

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
            label2.Text = "Kolakak\nKolakak\nKolakak\nKolakak";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "Pastry";
            label1.Location = new Point(175, 75);
            label1.ForeColor = Color.Gold;
            label2.BackColor = Color.Gold;
            label2.ForeColor = Color.Gold;
            SectionNumber = 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "Nuts";
            label1.Location = new Point(190, 75);
            label1.ForeColor = Color.MediumOrchid;
            label2.BackColor = Color.MediumOrchid;
            label2.ForeColor = Color.MediumOrchid;
            SectionNumber = 3;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "FruitsAndVegetables";
            label1.Location = new Point(56, 75);
            label1.ForeColor = Color.LimeGreen;
            label2.BackColor = Color.LimeGreen;
            label2.ForeColor = Color.LimeGreen;
            SectionNumber = 2;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            ShowSubMenu();
            label1.Text = "Drinks";
            label1.Location = new Point(175, 71);
            label1.ForeColor = Color.DeepSkyBlue;
            label2.BackColor = Color.DeepSkyBlue;
            label2.ForeColor = Color.DeepSkyBlue;
            SectionNumber = 4;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
            ReturnNumber = 2;
            ListAll(SectionNumber);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clear();
            ReturnNumber = 2;
            ReturnPosition();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
            ReturnNumber = 2;
            ReturnPosition();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clear();
            ReturnNumber = 2;
            ReturnPosition();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clear();
            ReturnNumber = 2;
            ReturnPosition();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Clear();
            if (ReturnNumber == 1)
            {
                ShowMainMenu();
            }
            if (ReturnNumber == 2)
            {
                ShowSubMenu();
            }
        }

        private void ShowMainMenu()
        {
            button1.Enabled = true;
            button1.Visible = true;
            button2.Enabled = true;
            button2.Visible = true;
            button3.Enabled = true;
            button3.Visible = true;
            button4.Enabled = true;
            button4.Visible = true;
            this.Size = new System.Drawing.Size(494, 442);
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
            button10.Location = new Point(245,301);
            this.Size = new System.Drawing.Size(494, 442);
            ReturnNumber = 1;
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

        private void ListAll(int num)
        {
            ReturnPosition();
            label3.Text = "";
            if (num == 1)
            {
                var pastries = pastryController.GetAllPastries();
                label1.Location = new Point(180, 75);
                label3.BackColor = Color.Gold;
                foreach (var item in pastries)
                {
                    label3.Text += ($"  {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/pcs {item.Quantity}pcs.\n\n");
                }
            }
            if (num == 2)
            {
                var frutsAndVegetables = fruitAndVegetableController.GetAllFruitsAndVegetables();
                foreach (var item in frutsAndVegetables)
                {
                    label3.BackColor = Color.LimeGreen;
                    label3.Text += ($"    {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/kg {item.Quantity}kg.\n\n");
                }
            }
            if (num == 3)
            {
                var nuts = nutController.GetAllNuts();
                foreach (var item in nuts)
                {
                    label3.BackColor = Color.MediumOrchid;
                    label3.Text += ($"  {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/kg {item.Quantity}kg.\n\n");
                }
            }
            if (num == 4)
            {
                var drinks = drinkController.GetAllDrinks();
                foreach (var item in drinks)
                {
                    label3.BackColor = Color.DeepSkyBlue;
                    label3.Text += ($"  {item.Id} {item.Category} {item.Name} " +
                        $"{item.Price}lv/pcs {item.Quantity}pcs.\n\n");
                }
            }
        }

        private void ReturnPosition()
        {
            label2.Text = "Kolakak.\nKolakak.\nKolakak.\nKolakak.\nKolakak.\nKolakak.";
            label2.Visible = true;
            label1.Visible = true;
            this.Size = new System.Drawing.Size(515, 660);
            button10.Visible = true;
            button10.Enabled = true;
            button10.Location = new Point(180, 570);
            label3.Visible = true;
        }

    }
}
