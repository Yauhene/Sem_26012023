if(int.TryParse(Console.ReadLine(), out int i)) // проверка того, что пользователь вводит именно число, TryParse проверит число ли введено
                                                // out int i - присвоит переменной i значение результата перевода строки в число
{
    int sum = (int)Math.Pow(i, 2); //Math.Pow возведет наше i во вторую степень, (int) заставит вернуть целое, а не double
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Вы ввели не целое число");
}