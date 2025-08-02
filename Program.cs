

namespace MultiFunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Multi-Function Application ===");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GradeCalculator();
                        break;
                    case "2":
                        TicketPriceCalculator();
                        break;
                    case "3":
                        TriangleTypeIdentifier();
                        break;
                    case "4":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // 1. Grade Calculator
        static void GradeCalculator()
        {
            Console.Clear();
            Console.WriteLine("=== Grade Calculator ===");
            Console.Write("Enter numerical grade (0-100): ");
            if (int.TryParse(Console.ReadLine(), out int grade))
            {
                string letterGrade;
                if (grade >= 90)
                    letterGrade = "A";
                else if (grade >= 80)
                    letterGrade = "B";
                else if (grade >= 70)
                    letterGrade = "C";
                else if (grade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                Console.WriteLine($"Letter Grade: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }

        // 2. Ticket Price Calculator
        static void TicketPriceCalculator()
        {
            Console.Clear();
            Console.WriteLine("=== Ticket Price Calculator ===");
            Console.Write("Enter your age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                double price = (age <= 12 || age >= 65) ? 7.0 : 10.0;
                Console.WriteLine($"Your ticket price is GHC{price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }

        // 3. Triangle Type Identifier
        static void TriangleTypeIdentifier()
        {
            Console.Clear();
            Console.WriteLine("=== Triangle Type Identifier ===");

            Console.Write("Enter side A: ");
            bool validA = double.TryParse(Console.ReadLine(), out double a);

            Console.Write("Enter side B: ");
            bool validB = double.TryParse(Console.ReadLine(), out double b);

            Console.Write("Enter side C: ");
            bool validC = double.TryParse(Console.ReadLine(), out double c);

            if (!validA || !validB || !validC)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            else if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Triangle Type: Equilateral");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Triangle Type: Isosceles");
                else
                    Console.WriteLine("Triangle Type: Scalene");
            }
            else
            {
                Console.WriteLine("The sides do not form a valid triangle.");
            }

            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }
    }
}
 