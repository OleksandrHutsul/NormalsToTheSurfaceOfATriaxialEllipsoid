namespace NormalsToTheSurfaceOfATriaxialEllipsoid
{
    internal class Derivative: Elipse
    {
        public void Сalculation()
        {
            #region
            do
            {
                Console.Write("Введіть кут Ксі: ");
                ksi = double.Parse(Console.ReadLine());
                if (ksi < -90 || ksi > 90)
                {
                    Console.WriteLine("Повторіть спробу!" + " Введіть кут в межах -90 до 90!");
                }
                else
                    break;
            } while (true);
            Console.WriteLine();
            do
            {
                Console.Write("Fi: ");
                fi = double.Parse(Console.ReadLine());
                if (fi < 0 || fi > 360)
                {
                    Console.WriteLine("Повторіть спробу!" + " Введіть кут в межах 0 до 360!");
                }
                else
                    break;
            } while (true);
            Console.WriteLine();
            int k;
            do
            {
                Console.Write("Введіть к-сть точок: ");
                k = int.Parse(Console.ReadLine());
                if (k < 0)
                {
                    Console.WriteLine("Повторіть спробу! Введіть K більше нуля!");
                }
                else
                    break;
            } while (true);
            Console.WriteLine();
            #endregion
            double dtksi = 1;
            double dtfi = 2;

            for (int i = 1; i <= k; i++)
            {
                x = 4 * Math.Cos(ksi * Math.PI / 180) * Math.Cos(fi * Math.PI / 180);
                y = 2 * Math.Cos(ksi * Math.PI / 180) * Math.Sin(fi * Math.PI / 180);
                z = Math.Sin(ksi * Math.PI / 180);

                dxksi = 4 * Math.Sin(ksi * Math.PI / 180) * Math.Cos(fi * Math.PI / 180);
                dxfi = 4 * Math.Cos(ksi * Math.PI / 180) * Math.Sin(fi * Math.PI / 180);

                dyksi = 2 * Math.Sin(ksi * Math.PI / 180) * Math.Sin(fi * Math.PI / 180);
                dyfi = -2 * Math.Cos(ksi * Math.PI / 180) * Math.Cos(fi * Math.PI / 180);

                dzksi = -Math.Cos(ksi * Math.PI / 180);
                dzfi = Math.Sin(ksi * Math.PI / 180) * (fi * Math.PI / 180);

                n = (dyksi * dzfi - dzksi * dyfi) + (dzksi * dxfi - dxksi * dzfi) + (dxksi * dyfi - dyksi * dxfi);

                Console.WriteLine("Точка " + i + ". X = " + Math.Round(x, 4) + " Y = " + Math.Round(y, 4) + " Z = " + Math.Round(z, 4) + " Normal = " + Math.Round(n, 4));

                ksi += dtksi;
                fi += dtfi;
            }
        }
    }
}
