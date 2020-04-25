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
            textBox1.Visible = false;
            textBox1.Enabled = false;
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
            label4.Text = "Enter ID:";
            ReturnPosition();
            BackgroundDesing();
            button11.Visible = true;
            button11.Enabled = true;
            button11.Location = new Point(100, 350);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clear();
            ReturnNumber = 2;
            ReturnPosition();
            button12.Enabled = true;
            button12.Visible = true;
            button12.Location = new Point(104, 351);
            BackgroundDesing();
            label4.Text = "Enter category:";
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            textBox3.Visible = true;
            textBox3.Enabled = true;
            textBox4.Visible = true;
            textBox4.Enabled = true;
            label4.Location = new Point(103,165);
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
            label2.Text = "Kolakak\nKolakak\nKolakak\nKolakak";
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
            foreach (TextBox b in this.Controls.OfType<TextBox>())
            {
                b.Enabled = false;
                b.Visible = false;
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
                    label1.Location = new Point(60, 75);
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
                label2.Text = "Kolakak..\nKolakak..\nKolakak..\nKolakak..\nKolakak..\nKolakak..";
                var drinks = drinkController.GetAllDrinks(); 
                label1.Location = new Point(190, 75);
                this.Size = new System.Drawing.Size(540, 660);
                button10.Location = new Point(190, 570);
                label3.BackColor = Color.DeepSkyBlue;
                foreach (var item in drinks)
                {
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

        private void button11_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            
            if (SectionNumber == 1)
            {
                var id = int.Parse(textBox1.Text);
                var pastry = pastryController.GetPastryById(id);
                if (pastry != null)
                {

                    label3.Text += ("\n\n\n             ID: " + pastry.Id);
                    label3.Text += ("\n             Category: " + pastry.Category);
                    label3.Text += ("\n             Name: " + pastry.Name);
                    label3.Text += ("\n             Price: " + pastry.Price + "lv/pcs");
                    label3.Text += ("\n             Quantity: " + pastry.Quantity + "pcs.");

                }
                else
                {
                    MessageBox.Show("The product was not found!");
                }
            }
            if (SectionNumber == 2)
            {
                var id = int.Parse(textBox1.Text);
                var fruitAndVegetable = fruitAndVegetableController.GetFruitOrVegetableById(id);
                if (fruitAndVegetable != null)
                {

                    label3.Text += ("\n\n\n             ID: " + fruitAndVegetable.Id);
                    label3.Text += ("\n             Category: " + fruitAndVegetable.Category);
                    label3.Text += ("\n             Name: " + fruitAndVegetable.Name);
                    label3.Text += ("\n             Price: " + fruitAndVegetable.Price + "lv/pcs");
                    label3.Text += ("\n             Quantity: " + fruitAndVegetable.Quantity + "pcs.");

                }
                else
                {
                    MessageBox.Show("The product was not found!");
                }
            }
            if (SectionNumber == 3)
            {
                
                var id = int.Parse(textBox1.Text);
                var nut = nutController.GetNutById(id);
                if (nut != null)
                {

                    label3.Text += ("\n\n\n             ID: " + nut.Id);
                    label3.Text += ("\n             Category: " + nut.Category);
                    label3.Text += ("\n             Name: " + nut.Name);
                    label3.Text += ("\n             Price: " + nut.Price + "lv/pcs");
                    label3.Text += ("\n             Quantity: " + nut.Quantity + "pcs.");

                }
                else
                {
                    MessageBox.Show("The product was not found!");
                }
            }
            if (SectionNumber == 4)
            {

                var id = int.Parse(textBox1.Text);
                var drink = drinkController.GetDrinkById(id);
                if (drink != null)
                {

                    label3.Text += ("\n\n\n             ID: " + drink.Id);
                    label3.Text += ("\n             Category: " + drink.Category);
                    label3.Text += ("\n             Name: " + drink.Name);
                    label3.Text += ("\n             Price: " + drink.Price + "lv/pcs");
                    label3.Text += ("\n             Quantity: " + drink.Quantity + "pcs.");

                }
                else
                {
                    MessageBox.Show("The product was not found!");
                }
            }
        }

        private void BackgroundDesing()
        {
            label3.Text = "";
            label4.Visible = true;
            this.Size = new System.Drawing.Size(494, 460);
            button10.Location = new Point(250, 350);
            textBox1.Visible = true;
            textBox1.Enabled = true;
            label2.Text = "Kolakak\nKolakak\nKolakak\nKolakak";
            textBox1.Text = "";
            if (SectionNumber == 1)
            {
                label4.BackColor = Color.Gold;
                label3.BackColor = Color.Gold;
                label5.BackColor = Color.Gold;
                label6.BackColor = Color.Gold;
                label7.BackColor = Color.Gold;
                textBox1.BackColor = Color.Gold;
                textBox2.BackColor = Color.Gold;
                textBox3.BackColor = Color.Gold;
                textBox4.BackColor = Color.Gold;
            }
            if (SectionNumber == 2)
            {
                label4.BackColor = Color.LimeGreen;
                label3.BackColor = Color.LimeGreen;
                textBox1.BackColor = Color.LimeGreen;
                label5.BackColor = Color.LimeGreen;
                label6.BackColor = Color.LimeGreen;
                label7.BackColor = Color.LimeGreen;
                textBox2.BackColor = Color.LimeGreen;
                textBox3.BackColor = Color.LimeGreen;
                textBox4.BackColor = Color.LimeGreen;
            }
            if (SectionNumber == 3)
            {
                label4.BackColor = Color.MediumOrchid;
                label3.BackColor = Color.MediumOrchid;
                textBox1.BackColor = Color.MediumOrchid;
                label5.BackColor = Color.MediumOrchid;
                label6.BackColor = Color.MediumOrchid;
                label7.BackColor = Color.MediumOrchid;
                textBox2.BackColor = Color.MediumOrchid;
                textBox3.BackColor = Color.MediumOrchid;
                textBox4.BackColor = Color.MediumOrchid;
            }
            if (SectionNumber == 4)
            {
                label4.BackColor = Color.DeepSkyBlue;
                label3.BackColor = Color.DeepSkyBlue;
                textBox1.BackColor = Color.DeepSkyBlue;
                label5.BackColor = Color.DeepSkyBlue;
                label6.BackColor = Color.DeepSkyBlue;
                label7.BackColor = Color.DeepSkyBlue;
                textBox2.BackColor = Color.DeepSkyBlue;
                textBox3.BackColor = Color.DeepSkyBlue;
                textBox4.BackColor = Color.DeepSkyBlue;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (SectionNumber==1)
            {
                Pastry pastry = new Pastry();
                pastry.Category = textBox1.Text;
                pastry.Name = textBox2.Text;
                pastry.Price = decimal.Parse(textBox3.Text);
                pastry.Quantity = int.Parse(textBox4.Text);
                pastryController.Add(pastry);
            }
            if (SectionNumber == 2)
            {
                FruitsAndVegetable fruitsAndVegetable = new FruitsAndVegetable();
                fruitsAndVegetable.Category = textBox1.Text;
                fruitsAndVegetable.Name = textBox2.Text;
                fruitsAndVegetable.Price = decimal.Parse(textBox3.Text);
                fruitsAndVegetable.Quantity = int.Parse(textBox4.Text);
                fruitAndVegetableController.Add(fruitsAndVegetable);
            }
            if (SectionNumber == 3)
            {
                Nut nut = new Nut();
                nut.Category = textBox1.Text;
                nut.Name = textBox2.Text;
                nut.Price = decimal.Parse(textBox3.Text);
                nut.Quantity = int.Parse(textBox4.Text);
                nutController.Add(nut);
            }
            if (SectionNumber == 4)
            {
                Drink drink = new Drink();
                drink.Category = textBox1.Text;
                drink.Name = textBox2.Text;
                drink.Price = decimal.Parse(textBox3.Text);
                drink.Quantity = int.Parse(textBox4.Text);
                drinkController.Add(drink);
            }
            MessageBox.Show("The product was successfully added!");
        }
    }
}
