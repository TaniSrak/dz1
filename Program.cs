namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1
            Console.WriteLine("Введите длину прямоугольника A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину стороны квадрата C:");
            int C = Convert.ToInt32(Console.ReadLine());

            if (C > A || C > B)
            {
                Console.WriteLine("Нельзя разместить ни одного квадрата со стороной С на прямоугольнике.");
                return;
            }

            int squaresCount = (A / C) * (B / C);
            int unusedArea = A * B - squaresCount * C * C;

            Console.WriteLine($"Количество квадратов, размещенных на прямоугольнике: {squaresCount}");
            Console.WriteLine($"Площадь незанятой части прямоугольника: {unusedArea}");
            Console.WriteLine();

            //Task2
            Console.WriteLine("Введите процентную ставку P (0 < P < 25):");
            double P = double.Parse(Console.ReadLine());

            if (P <= 0 || P >= 25)
            {
                Console.WriteLine("Ошибка: процентная ставка должна быть в диапазоне от 0 до 25.");
                return;
            }

            double initialDeposit = 10000;
            double targetAmount = 11000;
            int months = 0;

            while (initialDeposit < targetAmount)
            {
                initialDeposit += initialDeposit * (P / 100);
                months++;
            }

            Console.WriteLine($"Через {months} месяцев размер вклада превысит {targetAmount} грн.");
            Console.WriteLine($"Итоговый размер вклада: {initialDeposit} грн.");
            Console.WriteLine();

            //Task3
            int Aa, Bb;
            Console.WriteLine("Введите два целых числа A и B (A < B): ");
            if (!int.TryParse(Console.ReadLine(), out Aa) || //у меня вопрос, почему здесь интовая конвертация не работает?
                !int.TryParse(Console.ReadLine(), out Bb) || 
                Aa >= Bb)
            {
                Console.WriteLine("Ошибка ввода.");
                return;
            }

            for (int i = Aa; i <= Bb; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //task4
            // Ввод числа
            Console.Write("Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine());

            // Преобразование числа и вывод результата
            Console.WriteLine("Развернутое число: " + ReverseNumber(N));
        }

        // Функция для разворота числа
        static int ReverseNumber(int number)
        {
            string numberAsString = number.ToString();
            char[] charArray = numberAsString.ToCharArray();
            Array.Reverse(charArray); //перевернули
            string reversedString = new string(charArray);
            return Convert.ToInt32(reversedString);
        }
    }
}
