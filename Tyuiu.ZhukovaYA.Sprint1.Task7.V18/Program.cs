using Tyuiu.ZhukovaYA.Sprint1.Task7.V18.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task7.V18; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #1 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #1                                                            *"); 
        Console.WriteLine("* Тема: Добавления к решению итоговых проектов по спринту              *"); 
        Console.WriteLine("* Задание #7                                                           *"); 
        Console.WriteLine("* Вариант #18                                                          *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ:                                                             *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по    *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем.                   *"); 
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
