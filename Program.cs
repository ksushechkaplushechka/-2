


int chislo = 1;

while (chislo != 4)
{
    Console.WriteLine("что хотите запустить? ");
    Console.WriteLine("1 - угадай число");
    Console.WriteLine("2 - таблица умножения");
    Console.WriteLine("3 - вывод делителей числа");
    Console.WriteLine("4 - выход из программы");

    int z = Convert.ToInt32(Console.ReadLine());

    if (z == 1)
    {
        random();
    }

    if (z == 2)
    {
        tablisa();
    }

    if (z == 3)
    {
        Del();
    }

    if (z == 4)
    {
        Environment.Exit(0);
    }
}



static void random()
{
    Random rnd = new Random();
    int ra = rnd.Next(0, 100);
    Console.WriteLine("введите число от 0 до 100");
    int ch = 0;

    while (ra != ch)
    {
        ch = Convert.ToInt32(Console.ReadLine());

        if (ra == ch)
        { Console.WriteLine("вы угадали"); }

        else if (ra > ch)
        {
            Console.WriteLine("большее");
        }
        else if (ra < ch)
        { Console.WriteLine("меньшее"); }
    }
}


static void tablisa()
{

    int[,] t = new int[10, 10];

    for (int ch = 1; ch < 10; ch++)
    {
        for (int ch1 = 1; ch1 < 10; ch1++)
        {
            Console.Write(t[ch, ch1] + ch * ch1 + "\t");
        }
        Console.WriteLine();
    }
}


static void Del()
{

    int ch = 0;
    do
    {
        Console.WriteLine("выход - 0");
        Console.WriteLine("введите число: ");
        ch = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("делители ");
        for (int d = 1; d <= ch; d++)
        {
            if (ch % d == 0)
            {
                Console.WriteLine(d);
            }
        }
    } while (ch != 0);
}

