namespace Flyweight_Pattern
{
    using static System.Console;

    public class Circle : IShape
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            WriteLine("Printing Circle");
        }
    }
}
