// Напишите программу которая будет выдавать название дня недели по заданному номеру
// 3-> Среда
// 5-> Пятница

Console.WriteLine("Input number (Введите номер)");
int a = Convert.ToInt32(Console.ReadLine());
int c = 5;
switch (a)
{
    case 1:
        Console.WriteLine("Monday (Понедельник)");
        break;
    case 2:
        Console.WriteLine("Tuesday (Вторник)");
        break;
    case 3:
        Console.WriteLine("Wednesday (среда)");
        break;
    case 4:
        Console.WriteLine("Thursday (Четверг)");
        break;
    case 5:
        Console.WriteLine("Friday (Пятница)");
        break;
    case 6:
        Console.WriteLine("Saturday (Суббота)");
        break;
    case 7:
        Console.WriteLine("Sunday (Воскресение)");
        break;
    default:
        Console.WriteLine("There is no such a weekday (Нет такого дня недели)");
        break;
}