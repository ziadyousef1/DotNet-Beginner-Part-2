namespace DotNet_Beginner_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productBuilder = new ProductBuilder();
            Product product = productBuilder.SetName("Laptop").SetDescription("Gamming laptop").SetPrice(15000).SetManufacturer("Dell").Build();

        }
    }
}