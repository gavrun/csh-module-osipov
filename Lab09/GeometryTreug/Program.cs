namespace GeometryTreug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are going to be calculating areas of geometric shapes, and more. Input required.\n");

            // CIRCLE
            Console.WriteLine("Circle:");

            TableBuilder tableBuilderC = new TableBuilder();

            double testRadiusC = 5;
            Circle testCircle = new Circle(testRadiusC);
            Console.WriteLine($"DEBUG Perimeter: {testCircle.GetShapePerimeter():F2}, Area: {testCircle.GetShapeArea():F2}");
            Console.WriteLine();

            Console.WriteLine("What radius to calculate the area of a circle?");
            double radiusC = Int32.Parse(Console.ReadLine());
            Circle circle = new Circle(radiusC);

            Console.WriteLine("DEBUG table style 1 has no empty cells");
            // table header
            tableBuilderC.AddHeader("Radius", "Perimeter", "Area");
            // table row
            tableBuilderC.AddRow(circle.GetShapeAll());
            // print table
            tableBuilderC.PrintTable();

            Console.WriteLine();
            circle.ShowRadius();
            Console.WriteLine();

            // SQUARE 
            Console.WriteLine("Square:");

            TableBuilder tableBuilderS = new TableBuilder();

            Console.WriteLine("What side to calculate the area of a square?");
            double sideS = Int32.Parse(Console.ReadLine());
            Square square = new Square(sideS);
            Console.WriteLine();

            Console.WriteLine("DEBUG table style 1 has no empty cells");
            // table header
            tableBuilderS.AddHeader("Side", "Perimeter", "Area");
            // table row
            tableBuilderS.AddRow(square.GetShapeAll());
            // print table
            tableBuilderS.PrintTable();
            
            Console.WriteLine();
            square.ShowSide();
            square.RotateShape();
            Console.WriteLine();

            // TRIANGLE old and new
            Console.WriteLine("Triangle: ");
            Console.WriteLine("Do you want to calculate the area of an equilateral triangle? (y/n)");
            string isEq = Console.ReadLine();

            TableBuilder tableBuilderT = new TableBuilder();
            TableBuilder tableBuilderTN = new TableBuilder();

            Console.WriteLine("Well.. \nDEBUG test ctor message will appear");
            double testSideT = 5;
            Triangle testTriangle = new Triangle(testSideT);
            Console.WriteLine($"DEBUG Perimeter: {testTriangle.CalcPerimeter()}, Area: {testTriangle.CalcArea()}");
            Console.WriteLine();

            if (isEq.ToLower() == "y")
            {
                Console.WriteLine("Enter the length of the triangle side:");
                double side = double.Parse(Console.ReadLine());

                // create object of class
                Triangle equilateralTriangle = new Triangle(side, side, side); // viola, ctor will be waiting

                Console.WriteLine("DEBUG table style 1 has no empty cells");
                // table header
                tableBuilderT.AddHeader("Side A", "Side B", "Side C", "Area", "Perimeter");
                // table row
                tableBuilderT.AddRow(equilateralTriangle.GetAll());
                // print table
                tableBuilderT.PrintTable();
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
                    tableBuilderT.AddHeader("Side A", "Side B", "Side C", "Area", "Perimeter");
                    // table row
                    tableBuilderT.AddRow(triangle.GetAll());
                    // print table
                    tableBuilderT.PrintTable();

                    Console.WriteLine("DEBUG table style 2 with empty cells");
                    // table header
                    tableBuilderTN.AddHeader("Sides", "Perimeter", "Area");
                    // table rows
                    string[] row1 = (string[])(triangle.GetSideA()).Concat(triangle.GetPerimeter()).Concat(triangle.GetArea()).ToArray();
                    string[] row2 = (string[])(triangle.GetSideB()).ToArray();
                    string[] row3 = (string[])(triangle.GetSideC()).ToArray();
                    tableBuilderTN.AddRow(row1);
                    tableBuilderTN.AddRow(row2);
                    tableBuilderTN.AddRow(row3);
                    // print table
                    tableBuilderTN.PrintTable();
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
