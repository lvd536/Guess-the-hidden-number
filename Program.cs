//Условие:
//Программа, которая:

//    Загадывает случайное число от 1 до 100.
//    Просит пользователя угадать это число.
//    Сообщает, больше или меньше загаданного числа попытка пользователя.
//    Продолжает до тех пор, пока пользователь не угадает число.

Random random = new Random();
bool success = false;
int BotNumber = random.Next(1, 101);
Console.WriteLine("Я загадал число от 1 до 100. Попробуй его угадать!");

do
{
    int userinput = Convert.ToInt32(Console.ReadLine());
    if (userinput == BotNumber)
    {
        Console.WriteLine($"Поздравляем! Вы угадали число {BotNumber}");
        success = true;
    }
    else
    {
        if (BotNumber > userinput)
        {
            Console.WriteLine("Вы не угадали число. Загаданное число больше");
        }
        else
        {
            Console.WriteLine("Вы не угадали число. Загаданное число меньше");
        }
        success = false;
    }

} while ( success == false);

Console.ReadKey();