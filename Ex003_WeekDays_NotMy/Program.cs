// Задача про дни недели, не моя версия
Console.Write("Введите номер дня недели :");
if(int.TryParse(Console.ReadLine(), out int i))
{
    if(i==1) Console.Write("Понедельник");
        else if(i==2) Console.Write("Понедельник");
        else if(i==3) Console.Write("Среда");
        else if(i==4) Console.Write("Четверг");
        else if(i==5) Console.Write("Пятница");
        else if(i==6) Console.Write("Суббота");
        else if(i==7) Console.Write("Воскресенье");
            else
            {
                 Console.Write("Некорректный номер дня недели");
            }

    
}

else
{
    Console.Write("Вы ввели некорректный номер :");    
}