class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int p = 2;  // Начинаем с p = 2
        int count = 0;  // Количество найденных чисел
        while (count < n)
        {
            int m = (int)Math.Pow(2, p) - 1;  // Число Мерсенна Mp = 2^p - 1

            if (IsPrime(p) && IsPrime(m))
            {
                Console.WriteLine(m);
                count++;
            }

            p++;
        }
    }
}
// уже скучно стало в 5 утра сижу коменчу xddd