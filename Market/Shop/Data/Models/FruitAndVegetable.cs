namespace Shop.Data.Models
{
    /// <summary>
    /// The structure of fruits and vegetable table in database.
    /// </summary>
    public class FruitAndVegetable
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        public FruitAndVegetable(string category, string name, decimal price, int quantity)
        {
            Category = category;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        /// <summary>
        /// 
        /// </summary>
        public FruitAndVegetable()
        {

        }
    }
}