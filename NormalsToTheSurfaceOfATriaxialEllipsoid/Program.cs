namespace NormalsToTheSurfaceOfATriaxialEllipsoid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default; //український вивід символів

            Derivative derivative = new Derivative();

            derivative.Сalculation();
        }
    }
}
