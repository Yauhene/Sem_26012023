// Задача: Написать программу, которая принимает два числа и выясняет, является ли первое квадратом второго
//

Console.Write("Введите первое число: ");
if(int.TryParse(Console.ReadLine(), out int i1))
{

}
else
{
    Console.WriteLine("Вы ввели не целое число");
}

Console.Write("Введите второе число: ");
if(int.TryParse(Console.ReadLine(), out int i2))
{

}
else
{
    Console.WriteLine("Вы ввели не целое число");
}

Console.Write("Число ");
Console.Write(i1);
if((i1 / i2) == i2)
{   
    Console.Write(" является квадратом числа ");
}    
else
{
    Console.Write(" Не является квадратом числа ");
}
Console.Write(i2);