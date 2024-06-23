namespace PaddingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Bartek";

            string leftText = text.PadLeft(10);
            Console.WriteLine(leftText);
            
            string rightText = text.PadRight(10, '-');
            Console.WriteLine(rightText);

            Console.WriteLine("0123456789");
        }
    }
}
