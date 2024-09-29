using Tyuiu.ZhukovaYA.Sprint1.Task3.V13.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task3.V13; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #1 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #1                                                            *"); 
        Console.WriteLine("* Тема: Операторы состовного присваивания                              *"); 
        Console.WriteLine("* Задание #3                                                           *"); 
        Console.WriteLine("* Вариант #13                                                          *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                                                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: Написать программу, которая позволяет найти произведение    *"); 
        Console.WriteLine("* цифр заданного трехзначного числа. Ответ округлите до 3 знаков       *");
        Console.WriteLine("* после запятой.                                                       *");
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите трехзначное число:"); 
        int x = int.Parse(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 

        DataService ds = new DataService();
        double res = ds.MultiplyOfDigits(x);
 
        Console.WriteLine($"Ответ = {res}"); 
        Console.ReadKey();
    } 
} 
