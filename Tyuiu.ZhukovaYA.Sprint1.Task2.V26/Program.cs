using Tyuiu.ZhukovaYA.Sprint1.Task2.V26.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task2.V26; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        Console.Title = "Спринт #1 | Выполнила: Жукова Я. А. | ИИПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы                                          *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнила: Жукова Я. А. | ИИПб-24-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ : Задано текущее время в часах и минутах. Вычислить, сколько    *");
        Console.WriteLine("* минут прошло с начала суток.                                            *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите кол-во часов:");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Введите кол-во минут:");
        int y = int.Parse(Console.ReadLine()!);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        int res = ds.Calculate(x, y);
        Console.WriteLine($"{res} минут прошло с начала суток");
        Console.ReadKey();
    } 
} 
