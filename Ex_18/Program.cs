// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

 int numberQuarter = ReadInt("Введите номер четверти: ");

 if(numberQuarter == 1)
 {
    Console.WriteLine("x > 0, y > 0");
 }

 else if(numberQuarter == 2)
 {
    Console.WriteLine("x < 0, y > 0");
 }

 else if(numberQuarter == 3)
 {
    Console.WriteLine("x < 0, y < 0");
 }

 else if(numberQuarter == 4)
 {
    Console.WriteLine("x > 0, y < 0");
 }
    
 else
 {
    Console.WriteLine("Четвертей всего четыре");
 }


