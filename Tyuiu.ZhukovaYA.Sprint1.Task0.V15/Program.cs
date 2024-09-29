using Tyuiu.ZhukovaYA.Sprint1.Task0.V15.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task0.V15; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        Console.Title = "Спринт #1 | Выполнила: Жукова Я. А. | ИИПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Жукова Я. А. | ИИПб-24-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Написать программу, которая вычисляет выражение 20 - (2*2-8) и печатает *");
        Console.WriteLine("* результат на экране.                                                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 20 - (2*2-8)                                                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    } 
} 
