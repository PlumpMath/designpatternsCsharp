namespace Decorator_Pattern
{
    using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            //Basic Vehicle
            HondeCity car = new HondeCity();
            WriteLine($"Honda city base price are: {car.Price}");

            //Special Offer
            SpecialOffer offer = new SpecialOffer(car);
            offer.DiscountPercentage = 25;
            offer.Offer = "25% Discount";

            WriteLine($"{offer.Offer} @ Diwali Special Offer and price are: {offer.Price}");
            ReadKey();

        }
    }
}
