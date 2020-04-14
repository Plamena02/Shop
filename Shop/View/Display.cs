using System;
using Shop.Controllers;
using Shop.Data;

namespace Shop.View
{
    public class Display
    {

        private DrinkController drinkController;
        private NutController nutController;
        private FruitAndVegetableController fruitAndVegetableController;
        private PastryController pastryController;
        private const int closeOperationId = 5;
        private const int rertunOperationId = 7;
        public Display(ShopContext context)
        {
            drinkController = new DrinkController();
            nutController = new NutController();
            fruitAndVegetableController = new FruitAndVegetableController();
            pastryController = new PastryController();
            HandleInput();
        }

        private void ShowMainMenu()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(new string(' ', 18) + "MAIN MENU");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("1. Go to pastries");
            Console.WriteLine("2. Go to fruits and vegetables");
            Console.WriteLine("3. Go to nuts");
            Console.WriteLine("4. Go to drinks");
            Console.WriteLine("5. Exit");
            Console.WriteLine(new string('*', 40));
        }

        private void HandleInput()
        {
            var operation = -1;
            do
            {
                ShowMainMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        PastryInput();
                        break;
                    case 2:
                        FruitAndVegetableInput();
                        break;
                    case 3:
                        NutInput();
                        break;
                    case 4:
                        DrinkInput();
                        break;
                    default:
                        break;
                }

            } while (operation != closeOperationId);
        }

        private void PastryInput()
        {
            var operation = -1;
            do
            {
                ShowPastryMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllPastries();
                        break;
                    case 2:
                        GetPastryByName();
                        break;
                    case 3:
                        AddPastry();
                        break;
                    case 4:
                        RemovePastry();
                        break;
                    case 5:
                        UpdatePastry();
                        break;
                    case 6:
                        SellPastry();
                    default:
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (operation != rertunOperationId);

        }

        private void ListAllPastries()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(new string(' ', 18) + "PASTRIES");
            Console.WriteLine(new string('*', 40));
            var pastries = pastryController.GetAllPastries();
            foreach (var item in pastries)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Price}lv. {item.Quantity}p.");
            }
        }

        private void GetPastryByName()
        {
            throw new NotImplementedException();
        }

        private void AddPastry()
        {
            throw new NotImplementedException();
        }

        private void RemovePastry()
        {
            throw new NotImplementedException();
        }

        private void ListAllPastries()
        {
            throw new UpdatePastry();
        }

        private void ListAllPastries()
        {
            throw new SellPastry();
        }

        private void FruitAndVegetableInput()
        {
            var operation = -1;
            do
            {
                ShowFruitAndVegetableMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAllFruitsAndVegetables();
                        break;
                    case 2:
                        GetFruitOrVegetableByName();
                        break;
                    case 3:
                        AddFruitOrVegetable();
                        break;
                    case 4:
                        RemoveFruitOrVegetable();
                        break;
                    case 5:
                        UpdateFruitOrVegetable();
                        break;
                    case 6:
                        SellFruitOrVegetable();
                    default:
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (operation != rertunOperationId);

        }

        private void NutInput()
        {
            throw new NotImplementedException();
        }

        private void DrinkInput()
        {
            var operation = -1;
            do
            {
                ShowDrinkMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    default:
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            } while (operation != rertunOperationId);

        }

        private void ShowPastryMenu()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(new string(' ', 18) + "PASTRY MENU");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("1. List all pastries.");
            Console.WriteLine("2. Get pastry by name.");
            Console.WriteLine("3. Add pastry.");
            Console.WriteLine("4. Remove pastry.");
            Console.WriteLine("5. Update pastry.");
            Console.WriteLine("6. Sell pastry.");
            Console.WriteLine("7. Return to main menu");
            Console.WriteLine(new string('*', 40));
        }

        private void ShowFruitAndVegetableMenu()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(new string(' ', 18) + "FRUIT AND VEGETABLE MENU");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("1. List all fruts and vegetables.");
            Console.WriteLine("2. Get fruit or vegetable by name.");
            Console.WriteLine("3. Add fruit or vegetable.");
            Console.WriteLine("4. Remove fruit or vegetable.");
            Console.WriteLine("5. Update fruit or vegetable.");
            Console.WriteLine("6. Sell fruit or vegetable.");
            Console.WriteLine("7. Return to main menu");
            Console.WriteLine(new string('*', 40));
        }

        private void ShowNutMenu()
        {
            throw new NotImplementedException();
        }

        private void ShowDrinkMenu()
        {
            Console.WriteLine(new string('*', 40));
            Console.WriteLine(new string(' ', 18) + "DRINK MENU");
            Console.WriteLine(new string('*', 40));
            Console.WriteLine("1. List all drinks.");
            Console.WriteLine("2. Get drink by name.");
            Console.WriteLine("3. Add drink.");
            Console.WriteLine("4. Remove drink.");
            Console.WriteLine("5. Update drink.");
            Console.WriteLine("6. Sell drink.");
            Console.WriteLine("7. Return to main menu");
            Console.WriteLine(new string('*', 40));
        }
    }
}
