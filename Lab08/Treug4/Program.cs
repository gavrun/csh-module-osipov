namespace Treug4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to calculate the area of an equilateral triangle? (y/n)");
            string isEq = Console.ReadLine();

            TableBuilder tableBuilder = new TableBuilder();
            TableBuilder tableBuilderN = new TableBuilder();

            Console.WriteLine("Well.. before we go, test ctor message will appear");
            double testSide = 5;
            Triangle testTriangle = new Triangle(testSide);
            Console.WriteLine($"Perimeter: {testTriangle.CalcPerimeter()}, Area: {testTriangle.CalcArea()}");
            Console.WriteLine();

            if (isEq.ToLower() == "y")
            {
                Console.WriteLine("Enter the length of the triangle side:");
                double side = double.Parse(Console.ReadLine());

                // create object of class
                Triangle equilateralTriangle = new Triangle(side, side, side); // viola, ctor will be waiting

                Console.WriteLine("DEBUG table style 1 has no empty cells");
                // table header
                tableBuilder.AddHeader("Side A", "Side B", "Side C", "Area", "Perimeter");
                // table row
                tableBuilder.AddRow(equilateralTriangle.GetAll());
                // print table
                tableBuilder.PrintTable();
            }
            else
            {
                Console.WriteLine("Enter the length of the First side:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Second side:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the length of the Third side:");
                double c = double.Parse(Console.ReadLine());

                try
                {
                    // create object of class
                    Triangle triangle = new Triangle(a, b, c);

                    Console.WriteLine("DEBUG table style 1 has no empty cells");
                    // table header
                    tableBuilder.AddHeader("Side A", "Side B", "Side C", "Area", "Perimeter");
                    // table row
                    tableBuilder.AddRow(triangle.GetAll());
                    // print table
                    tableBuilder.PrintTable();

                    Console.WriteLine("DEBUG table style 2 with empty cells");
                    // table header
                    tableBuilderN.AddHeader("Sides", "Perimeter", "Area");
                    // table rows
                    string[] row1 = (string[])(triangle.GetSideA()).Concat(triangle.GetPerimeter()).Concat(triangle.GetArea()).ToArray();
                    string[] row2 = (string[])(triangle.GetSideB()).ToArray();
                    string[] row3 = (string[])(triangle.GetSideC()).ToArray();
                    tableBuilderN.AddRow(row1);
                    tableBuilderN.AddRow(row2);
                    tableBuilderN.AddRow(row3);
                    // print table
                    tableBuilderN.PrintTable();
                }
                catch (Exception ex)
                {
                    // if triangle cannot be made, suggest correct examples
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Examples of valid triangles:\n" +
                                        "Equilateral: 3, 3, 3\n" +
                                        "Isosceles: 5, 5, 8\n" +
                                        "Right-angled: 3, 4, 5\n" +
                                        "Scalene: 6, 7, 8");
                    Console.ResetColor();
                    throw;
                }
            }
        }
    }
}
