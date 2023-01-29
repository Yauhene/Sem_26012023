// Интересная версия дня недели по номеру дня от соседней комнаты

string[] days = new String[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Номер дня недели :");
int day = int.Parse(Console.ReadLine());
Console.WriteLine(days[day-1]);
