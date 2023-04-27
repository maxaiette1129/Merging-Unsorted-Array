namespace charpbeginner3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

           string merge = string.Join(" : ", cars);
           Console.WriteLine($"The soring of inside the arary is {merge}");








        }
    }
}