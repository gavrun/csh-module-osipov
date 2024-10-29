// пример нарушения принципа единсвенной обязанности
namespace areaOfTriangle
{
    internal class Program
    {
        public static double calculateOfArea()
        {
            Console.WriteLine("Введите периметр треугольника в сантиметрах");
            int p = int.Parse(Console.ReadLine());
            int pp = p / 2; //полупериметр
            int a = p / 3; //сторона треугольника
            double S = Math.Round(Math.Sqrt(pp * (pp - a) * 3), 2);
            return S;
        }
        public static void AreaOutPut()
        {
            double S = calculateOfArea();
            Console.WriteLine($"Площадь треугольника = {S} см2.");
        }
        static void Main(string[] args)
        {
            AreaOutPut();
            
        }
    }
}
            
        
