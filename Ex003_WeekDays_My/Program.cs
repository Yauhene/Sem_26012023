// Задача. Написать программу, выводящую название дня недели по его номеру
//

Console.WriteLine("Введите номер дня недели : ");
if(int.TryParse(Console.ReadLine(), out int i))
{
    switch (i)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    
    case 2:
        Console.WriteLine("Вторник");
        break;

    case 3:
        Console.WriteLine("Среда");
        break;

    case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
        Console.WriteLine("Пятница");
        break;

    case 6:
        Console.WriteLine("Суббота");
        break;

    case 7:
        Console.WriteLine("Воскресенье");
        break;
    
    default:
        Console.WriteLine("Вы ввели некорректный номер дня недели");
        break;
}
}
else
{
    Console.WriteLine("Вы ввели не целое число");
}
