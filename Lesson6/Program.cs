using Lesson2;
using System.Drawing;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            BankAccount bankAccount = new BankAccount(1000, AccountType.Card);
            BankAccount sameAccount = bankAccount;
            BankAccount newAccount = new BankAccount(100, AccountType.Deposit);

            Console.WriteLine(bankAccount == sameAccount); // true
            Console.WriteLine(sameAccount != bankAccount); // false
            Console.WriteLine(bankAccount == newAccount); // false
            Console.WriteLine(bankAccount);

            // задание 2
            Point point = new Point(true, Color.Black);
            Console.WriteLine(point);

            Circle circle = new Circle(false, Color.AliceBlue, 11m, 5m, 13.6d);
            Console.WriteLine(circle);

            Rectangle rectangle = new Rectangle(true, Color.Red, 15m, 31m, 10d, 10d);
            Console.WriteLine(rectangle);
        }
    }
}