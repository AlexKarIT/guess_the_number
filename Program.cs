// Угадай число

Console.Write("До какого значения загадать число? ");
int number = Convert.ToInt32(Console.ReadLine());

//double X = (Math.Round (Math.Pow(number, 1.0/2), 0));
double X = (Math.Round(Math.Log(number, 2), 0));
int numberX = new Random().Next(1, (number + 1));
int min = 1;
int max = number + 1;
int probe = 0;
int U = 0;
while (X > 0)
{
    X = X - 1;
    Console.WriteLine("Попробуй угадать моё число от " + (min) + " до " + (max - 1));
    Console.WriteLine("Количество оставшихся попыток: " + (X + 1));
    String Y = Console.ReadLine();

    if (double.TryParse(Y, out double result))

    {

        int numberA = Convert.ToInt32(Y);

        if (numberA > (max - 1))
        {
            Console.WriteLine("Вы ввели число вне диапазона, будьте внимательны!!");
            Console.WriteLine("Количество оставшихся попыток сохранено ;-) ");
            numberA = max;
            X++;
        }

        if (numberA < (min))
        {
            Console.WriteLine("Вы ввели число вне диапазона, будьте внимательны!!");
            Console.WriteLine("Количество оставшихся попыток сохранено ;-) ");
            numberA = min - 1;
            X++;
        }

        if (numberA == numberX)
        {
            Console.WriteLine("Да, это оно... Молодец!!!");
            X = 0;
            U = 1;
        }

        if (numberA > numberX)
        {
            Console.WriteLine("Нет, моё меньше!!!");
            max = numberA;
        }
        if (numberA < numberX)
        {
            Console.WriteLine("Нет, моё больше!!!");
            min = numberA + 1;
        }
        probe++;

    }
    else
    {
        Console.WriteLine("Вы ввели не число, будьте внимательны!!");
        Console.WriteLine("Количество оставшихся попыток сохранено ;-) ");
        X++;
    }


}

Console.WriteLine("Загаданное число: " + numberX);
if (U == 0)
{
    Console.WriteLine("Повезёт в следующий раз!");
}
else
{
    Console.WriteLine("Вы угадали число с " + probe + " попытки");
}