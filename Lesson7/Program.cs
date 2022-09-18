namespace Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ACoder aCoder = new ACoder();
            string encodedA = aCoder.Encode("Аа, Бб, Вв, Яя, Ff, Hh, Xx"); // Бб, Вв, Гг, Аа, Gg, Ii, Yy
            string decodedA = aCoder.Decode(encodedA); // Аа, Бб, Вв, Яя, Ff, Hh, Xx
            string encodedA2 = aCoder.Encode("Привет, World!");
            string decodedA2 = aCoder.Decode(encodedA2);

            Console.WriteLine($"Входная строка \"Аа, Бб, Вв, Яя, Ff, Hh, Xx\". Кодируем в \"{encodedA}\"");
            Console.WriteLine($"Декодируем в \"{decodedA}\"\n");
            Console.WriteLine($"Входная строка \"Привет, World!\". Кодируем в \"{encodedA2}\"");
            Console.WriteLine($"Декодируем в \"{decodedA2}\"\n");

            BCoder bCoder = new BCoder();
            string encodedB = bCoder.Encode("Аа, Бб, Вв, Aa, Gg");
            string decodedB = bCoder.Decode(encodedB);

            Console.WriteLine($"Входная строка - \"Аа, Бб, Вв, Aa, Gg\". Кодируем в \"{encodedB}\"");
            Console.WriteLine($"Декодируем в \"{decodedB}\"");
        }
    }
}