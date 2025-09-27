namespace CircleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle(5);
            Circle secondCircle = new Circle(6);

            var areaOfFirstCircle = firstCircle.GetArea();
            var areaOfSecondCircle = secondCircle.GetArea();

            Console.WriteLine($"Arean av första cirkeln: {areaOfFirstCircle}");
            Console.WriteLine($"Arean av andra cirkeln: {areaOfSecondCircle}");

        }
    }
}
