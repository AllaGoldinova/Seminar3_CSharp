// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).


int numberQuarter = ReadInt("Введите номер четверти: ");

switch (numberQuarter)
{
    case 1:
        Console.WriteLine("x > 0, y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0, y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0, y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0, y < 0");
        break;
    default:
        Console.WriteLine("Четвертей всего четыре");

}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}