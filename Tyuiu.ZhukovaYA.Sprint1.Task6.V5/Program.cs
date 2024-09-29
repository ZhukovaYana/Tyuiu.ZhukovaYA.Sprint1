using Tyuiu.ZhukovaYA.Sprint1.Task6.V5.Lib; 
 
namespace Tyuiu.BarbashinAV.Sprint1.Task6.V5; 
 
class Program 
{ 
    static void Main(string[] args) 
    { 
        Console.Title = "Спринт #1 | Выполнил: Жукова Я.А. | ИИПб-24-1"; 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* Спринт #1                                                            *"); 
        Console.WriteLine("* Тема: Работа со строками класс String                                *"); 
        Console.WriteLine("* Задание #6                                                           *"); 
        Console.WriteLine("* Вариант #5                                                           *"); 
        Console.WriteLine("* Выполнил: Жукова Яна Андреевна | ИИПб-24-1                           *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* УСЛОВИЕ: пользователь вводит текст. Напечатать те слова, которые     *"); 
        Console.WriteLine("* являются симметричными (например: казак, шалаш).                     *"); 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *"); 
        Console.WriteLine("************************************************************************"); 
 
        Console.WriteLine("Введите текст:"); 
        string vaule = Convert.ToString(Console.ReadLine()!); 
 
        Console.WriteLine("************************************************************************"); 
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *"); 
        Console.WriteLine("************************************************************************"); 
 
        DataService ds = new DataService();
        string res = ds.CheckSymmetricalWords(vaule);
        
        Console.WriteLine($"Ответ = {res}"); 
        Console.ReadKey();
    } 
} 
