using Tyuiu.ZhukovaYA.Sprint1.Task1.V21.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task1.V21; 
 
class Program 
{ 
    static void Main(string[] args) 
    {
        Console.Title = "Спринт #1 | Выполнила: Жукова Я. А. | ИИПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Жукова Я. А. | ИИПб-24-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ :                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле (x*y)/(3+y) и печатает его на экране.    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
        Console.WriteLine("***************************************************************************");

        double x, y;
        Console.WriteLine("Введите значение X");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    } 
} 
