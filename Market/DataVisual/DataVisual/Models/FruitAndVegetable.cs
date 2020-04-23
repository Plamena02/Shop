using System.ComponentModel.DataAnnotations;

namespace DataVisual
{
    /// <summary>
    /// The structure of fruits and vegetable table in database.
    /// </summary>
    public class FruitAndVegetable
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public FruitAndVegetable(string category, string name, decimal price, int quantity)
        {
            Category = category;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public FruitAndVegetable()
        {

        }
    }
}