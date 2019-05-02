using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter your fullname: ");
            var fullName = Console.ReadLine();

            Console.Write("Please enter your location: ");
            var location = Console.ReadLine();

            Console.WriteLine($"Your name is: { fullName }");
            Console.WriteLine($"You are from: { location }");

            Console.Write("Please enter a number: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter a number: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            var today = DateTime.Now;
            var christmas = new DateTime(today.Year, 12, 25);
            var startDate = today;
            var endDate = christmas;
            var result = Math.Ceiling((endDate - startDate).TotalDays);

            Console.WriteLine("To find the number of days til Christmas press enter ");
            Console.ReadKey();
            Console.WriteLine($"The number of days til Christmas is: { result }");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
