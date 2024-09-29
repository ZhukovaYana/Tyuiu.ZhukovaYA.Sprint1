using Tyuiu.ZhukovaYA.Sprint1.Task4.V4.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task4.V4; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #1 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #1                                                            *"); 
        Console.WriteLine("* Тема: Class Math                                                     *"); 
        Console.WriteLine("* Задание #4                                                           *"); 
        Console.WriteLine("* Вариант #4                                                           *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные      *");
        Console.WriteLine("* данные, вычисляет результат по формуле и печатает его на экране.     *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                           *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите переменную X:"); 
        int x = int.Parse(Console.ReadLine()!); 
        Console.WriteLine("Введите переменную Y:"); 
        int y = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        double res = ds.Calculate(x, y);

        Console.WriteLine($"Ответ = {res}");
        Console.ReadKey();
    } 
} 
